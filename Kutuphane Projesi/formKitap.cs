using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class formKitap : Form
    {
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;
        public formKitap()
        {
            InitializeComponent();
        }

        private void formKitap_Load(object sender, EventArgs e)
        {
            KitapListele();
            KitapTurYukle();
        }

        public void KitapListele()
        {
            try 
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi" +
                    " FROM kitaplar INNER JOIN kitapturleri ON kitaplar.tur_id=kitapturleri.tur_id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitap.DataSource = dataTable;

                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "Tür";
                gridKitap.Columns["tur_adi"].Width = 50;
                gridKitap.Columns["kitap_adi"].HeaderText = "Adı";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "Yazar";
                gridKitap.Columns["yazar"].Width = 100;
                gridKitap.Columns["yayinevi"].HeaderText = "Yayınevi";
                gridKitap.Columns["yayinevi"].Width = 80;
                gridKitap.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                gridKitap.Columns["sayfa_sayisi"].Width = 50;

            }

            catch (Exception e)
            {
                MessageBox.Show (e.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

        }

        public void KitapTurYukle() 
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM kitapturleri";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboTur.DataSource = dataTable;
                comboTur.ValueMember = "tur_id";
                comboTur.DisplayMember = "tur_adi";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                try
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    komutSatiri = "INSERT INTO kitaplar (tur_id, kitap_adi, yazar, yayinevi, sayfa_sayisi) VALUES(@tur_id, @kitap_adi, @yazar, @yayinevi, @sayfa_sayisi)";
                    komut = new SqlCommand(komutSatiri, baglanti);
                    komut.Parameters.AddWithValue("@tur_id", int.Parse(comboTur.SelectedValue.ToString()));
                    komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                    komut.Parameters.AddWithValue("@yazar", txtYazarAdi.Text);
                    komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                    komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfa.Text));
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Temizle();
                    MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    KitapListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        public void Temizle()
        {
            txtKitapAdi.Clear();
            txtSayfa.Clear();
            txtYayinevi.Clear();
            txtYazarAdi.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "DELETE FROM kitaplar WHERE kitap_id = @kitap_id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@kitap_id", gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtSayfa.Text = gridKitap.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinevi.Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazarAdi.Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "UPDATE kitaplar SET tur_id@tur_id, kitap_adi=@kitap_adi" +
                    "yazar=@yazar, yayinevi=@yayinevi, sayfa_sayisi=@sayfa_sayisi where kitap_id=@kitap_id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboTur.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazarAdi.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfa.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            KitapArama(txtKitapAra.Text);
        }

        public void KitapArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "SELECT kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi FROM kitaplar,kitapturleri " +
                    "WHERE kitaplar.tur_id=kitapturleri.tur_id and kitap_adi LIKE '" + aranacakKelime + "%'";
                komut = new SqlCommand(komutSatiri, baglanti);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridKitap.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

        
    