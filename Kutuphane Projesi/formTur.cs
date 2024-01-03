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
    public partial class formTur : Form
    {
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutSatiri;
        public formTur()
        {
            InitializeComponent();
        }
        private void formTur_Load(object sender, EventArgs e)
        {

            TurleriListele();
        }


        public void TurleriListele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM kitapturleri";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                turGrid.DataSource = dataTable;
                turGrid.Columns["tur_id"].HeaderText = "ID";
                turGrid.Columns["tur_id"].Width = 100;
                turGrid.Columns["tur_adi"].HeaderText = "Tür Adı";
                turGrid.Columns["tur_adi"].Width = 300;


            }
            catch (Exception ex) 
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
                komutSatiri = "INSERT INTO kitapturleri (tur_adi) VALUES(@tur_adi)";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void turGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTurAdi.Text = turGrid.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komutSatiri = "DELETE FROM kitapturleri WHERE tur_id = @tur_id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@tur_id", turGrid.CurrentRow.Cells["tur_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();

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
                komutSatiri = "UPDATE ogrenciler SET tur_adi=@tur_adi where tur_id=@tur_id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@tur_id", int.Parse(turGrid.CurrentRow.Cells["tur_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
