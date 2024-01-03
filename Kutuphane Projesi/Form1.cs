using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            formKitap kitap = new formKitap();
            kitap.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            formOgrenci ogrenci = new formOgrenci();
            ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            formTur oduncKitap = new formTur();
            oduncKitap.ShowDialog();
        }

        private void bntOduncKitap_Click(object sender, EventArgs e)
        {
            formOduncKitap tur = new formOduncKitap();
            tur.ShowDialog();
        }
    }
}
