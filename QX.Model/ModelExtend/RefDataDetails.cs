using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public class RefDataDetails
    {

        private string pUD_Code;
        private bool pUD_Code_IsChanged = false;
        public string PUD_Code
        {
            get { return pUD_Code; }
            set { pUD_Code = value; pUD_Code_IsChanged = true; }
        }

        private string pUD_MCode;
        private bool pUD_MCode_IsChanged = false;
        public string PUD_MCode
        {
            get { return pUD_MCode; }
            set { pUD_MCode = value; pUD_MCode_IsChanged = true; }
        }
 
        private string pUD_MName;
        private bool pUD_MName_IsChanged = false;
        public string PUD_MName
        {
            get { return pUD_MName; }
            set { pUD_MName = value; pUD_MName_IsChanged = true; }
        }
        private string pUD_Spec;
        private bool pUD_Spec_IsChanged = false;
        public string PUD_Spec
        {
            get { return pUD_Spec; }
            set { pUD_Spec = value; pUD_Spec_IsChanged = true; }
        }

        private string pUD_Unit;
        private bool pUD_Unit_IsChanged = false;
        public string PUD_Unit
        {
            get { return pUD_Unit; }
            set { pUD_Unit = value; pUD_Unit_IsChanged = true; }
        }
        private decimal pUD_Price;
        private bool pUD_Price_IsChanged = false;
        public decimal PUD_Price
        {
            get { return pUD_Price; }
            set { pUD_Price = value; pUD_Price_IsChanged = true; }
        }
        private int pUD_Num;
        private bool pUD_Num_IsChanged = false;
        public int PUD_Num
        {
            get { return pUD_Num; }
            set { pUD_Num = value; pUD_Num_IsChanged = true; }
        }
        private string pUD_Bak;
        private bool pUD_Bak_IsChanged = false;
        public string PUD_Bak
        {
            get { return pUD_Bak; }
            set { pUD_Bak = value; pUD_Bak_IsChanged = true; }
        }



    }
}
