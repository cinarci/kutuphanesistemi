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
    public partial class formOduncKitap : Form
    {
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;
        public formOduncKitap()
        {
            InitializeComponent();
        }

        private void formOduncKitap_Load(object sender, EventArgs e)
        {
            Listele();
            KitapYukle();
        }

        public void KitapYukle()
        {
            try
            {
                komutSatiri = "SELECT * FROM kitaplar WHERE kitap_id not in (SELECT kitap_id FROM odunc_kitaplar WHERE teslim_tarihi IS NULL)";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapAdi.DataSource = dataTable;
                comboKitapAdi.ValueMember = "kitap_id";
                comboKitapAdi.DisplayMember = "kitap_adi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama From kitaplar, ogrenciler, odunc_kitaplar " +
            "where ogr_no=ogrenci_no and kitaplar. kitap_id=odunc_kitaplar.kitap_id";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOdunc.DataSource = dataTable;
                gridOdunc.Columns["id"].HeaderText = "ID";
                gridOdunc.Columns["id"].Width = 30;
                gridOdunc.Columns["ogrenci_no"].HeaderText = "Öğrenci No";
                gridOdunc.Columns["ogrenci_no"].Width = 40;
                gridOdunc.Columns["ad"].HeaderText = "Ad";
                gridOdunc.Columns["ad"].Width = 70;
                gridOdunc.Columns["soyad"].HeaderText = "Soyad";
                gridOdunc.Columns["soyad"].Width = 70;
                gridOdunc.Columns["kitap_adi"].HeaderText = "Kitap Ad1";
                gridOdunc.Columns["kitap_adi"].Width = 100;
                gridOdunc.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
                gridOdunc.Columns["verilis_tarihi"].Width = 70;
                gridOdunc.Columns["teslim tarihi"].HeaderText = "Teslim Tarihi";
                gridOdunc.Columns["teslim tarihi"].Width = 70;
                gridOdunc.Columns["aciklama"].HeaderText = "Açıklama";
                gridOdunc.Columns["aciklama"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;

                komut.CommandText = "INSERT INTO odunc_kitaplar (ogr_no, kitap_id, verilis_tarihi, aciklama) " + "VALUES(@ogr_no, @kitap_id, @verilis_tarihi, @aciklama)";
                komut.Parameters.AddWithValue("@ogr_no", int.Parse(txtOgrenciNo.Text));
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(comboKitapAdi.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@verilis_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle(); ;
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle()
        {
            txtOgrenciNo.Clear();
            txtAciklama.Clear();
        }

        private void gridOdunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAciklama.Text = gridOdunc.CurrentRow.Cells["aciklama"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "DELETE FROM odunc_kitaplar WHERE odunc_kitaplar = @id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", gridOdunc.CurrentRow.Cells["id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridOdunc.CurrentRow.Cells["teslim_tarihi"].Value.ToString() != String.Empty)
                {
                    MessageBox.Show("Bu kitap teslim alınmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                komutSatiri = "UPDATE odunc_kitaplar SET teslim_tarihi=@teslim tarihi, aciklama=@aciklama where id=@id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", int.Parse(gridOdunc.CurrentRow.Cells["id"].Value.ToString()));
                komut.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now.ToString("yyyy/MM/dd"));
                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                KitapYukle();
                Listele();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void OdunckitapOgrenciArama(string aranacakkelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                komutSatiri = "Select id, ogrenci_no, ad, soyad, kitap_adi, verilis_tarihi, teslim_tarihi, aciklama " +
                "From kitaplar, ogrenciler, odunc_kitaplar " +
                "where ogr_no=ogrenci_no and kitaplar.kitap_id=odunc_kitaplar.kitap_id and ad LIKE'" + aranacakkelime + "%'"; 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOdunc.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOduncArama_TextChanged(object sender, EventArgs e)
        {
            OdunckitapOgrenciArama(txtOduncArama.Text);
        }

        
    } 
}
            
        
   
