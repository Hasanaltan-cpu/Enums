using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5177_Enums
{
    public enum Departmans
    {
        SoftwareDeveloper,SystemNetworkExpert,GraphicOrientation,English,Accounting
    }
    public class Personal
    {
        private string _FLName;
        public string FLName { get=> _FLName; set => _FLName=value; }

        private Departmans _departmans;
        public  Departmans Departman { get => _departmans; set => _departmans=value; }

    }
}
