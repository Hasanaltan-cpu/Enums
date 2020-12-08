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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        enum Cities:byte
        {
            İstanbul = 34,İzmir = 35, Ankara = 06,Adana = 01,Antalya = 07
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(Cities)));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print screen what the value selected on the listbox.
            //ATTENTION=Value of Enums should use selected type when u wanna cast.
            
            byte selectedIndex = (byte)Enum.Parse(typeof(Cities), listBox1.Text);
            MessageBox.Show($"Selected City Number:{selectedIndex}");

        }
    }
}
