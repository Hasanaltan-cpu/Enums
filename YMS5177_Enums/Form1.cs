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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Enum
        //We use enum type provide to user for static option.In addition to that this is managed this controlly by us.Thus in our application there is no chance to suprise and ultra-secured structe we had.

        //For using enum we should use Enum.GetNames() method.Enum includes numeric values on the background.These valuese are index values of default and types are "ınt".This type "int" can change if u need.For instance, firstly it will 5 then the others are created by enum.As you see ,enums work with key-value .

        //An enum that is written,can change with Enum.Parse.UI(User Interface) user sees enums values that we created.Actually user chose an integer value and enum manage this in itself method and it writes value of this integer on the database.

        //On the below ,we mentioned about enums get numeric values.Enum.Parse process return us as a object type in terms of Background value.
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal()
            {
                FLName = txtPersonalName.Text,
                Departman = (Departmans)Enum.Parse(typeof(Departmans), cmbDepartmans.Text)
            };
            MessageBox.Show($"Employee Information:\n FullName:{personal.FLName}\nDepartmans:{personal.Departman}");
            //If you wanna you have option for selected index value.I mean we can reach index value of relation departmans.
            int selectedIndex = (int)Enum.Parse(typeof(Departmans), cmbDepartmans.Text);
            MessageBox.Show($"Employee Information :\nFull Name:{personal.FLName}\nDepartmans:{personal.Departman}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //While form loads,departmans loads in the combobox.For this ,we use addrange method and GetNames() method belongs to Enum class.
            cmbDepartmans.Items.AddRange(Enum.GetNames(typeof(Departmans)));
            //KeyWord is an oparetor that when the process is begun for getting an object.
            //For first member of departman be selected;
            cmbDepartmans.SelectedIndex = 0;

            //These two arguments work similarly and their job is same.
            //typeof()=>Get type on the Compile Time;
            //gettype)=>Get type on the RunTime;
        }
    }
}
