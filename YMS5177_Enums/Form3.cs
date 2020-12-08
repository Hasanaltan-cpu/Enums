using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5177_Enums
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        enum Cities : int
        {
            İstanbul = 34, İzmir = 35, Ankara = 06, Adana = 01, Antalya = 07
        }


        //Şehirler Enum'ı 
        //Sehirismi=Plaka Kodu
        //Form3 yüklendiğinde döngü kurularak Listbox'a şehirleri bas.
        //
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(Cities)))
            {
                listBox1.Items.Add(item + "--->" + Convert.ToInt32(Enum.Parse(typeof(Cities),item)));
            }
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            //TextBox'dan gelen değeri plaka No'suna göre şehrin ismini bas.

            int plaka = int.Parse(txtPlakaKod.Text);

            Cities secilenDeger = (Cities)plaka;

            MessageBox.Show($"Plaka Numarası ==>{plaka}");

        }
       
        private void btnEnumCntrl_Click(object sender, EventArgs e)
        {

            int plaka = int.Parse(txtPlakaKod.Text);
            if (Enum.IsDefined(typeof(Cities), plaka)) //IsDefined aksi taktirde vereceği  hatayı kontrol etmemizi sağlayan enum 'ın kendi gömülü methodlarından biridir.

            {
                Cities selectedcity = (Cities)plaka;
                MessageBox.Show($"Aradığınız şehir :{selectedcity}");

            }
            else
            {
                MessageBox.Show("Girdiğiniz plaka numarasına ait bir şehir bulunmamaktadır.");

            }
            
    }
}
