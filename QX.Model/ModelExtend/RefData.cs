using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    public class RefData
    {
        /// <summary>
        /// 单据技术类型（PU,IA）
        /// </summary>
        public string PUM_TechType
        {
            get;
            set;
        }

        private string pUM_RType;
        /// <summary>
        /// 单据类型（记录是出库单还是采购相关单据）
        /// </summary>
        public string PUM_TypeDescription
        {
            get { return pUM_RType; }
            set { pUM_RType = value; }
        }

        public string PUM_Type
        {
            get;
            set;
        }

        private string pUM_RCode;
        private bool pUM_RCode_IsChanged = false;
        public string PUM_Code
        {
            get { return pUM_RCode; }
            set { pUM_RCode = value; pUM_RCode_IsChanged = true; }
        }
 
        private string pUM_SCode;
        private bool pUM_SCode_IsChanged = false;
        public string PUM_SCode
        {
            get { return pUM_SCode; }
            set { pUM_SCode = value; pUM_SCode_IsChanged = true; }
        }
 
        private string pUM_SName;
        private bool pUM_SName_IsChanged = false;
        public string PUM_SName
        {
            get { return pUM_SName; }
            set { pUM_SName = value; pUM_SName_IsChanged = true; }
        }
 
        private string pUM_SContact;
        private bool pUM_SContact_IsChanged = false;
        public string PUM_SContact
        {
            get { return pUM_SContact; }
            set { pUM_SContact = value; pUM_SContact_IsChanged = true; }
        }

        private string pUM_STel;
        private bool pUM_STel_IsChanged = false;
        public string PUM_STel
        {
            get { return pUM_STel; }
            set { pUM_STel = value; pUM_STel_IsChanged = true; }
        }


        private DateTime pUM_PDate;
        private bool pUM_PDate_IsChanged = false;
        public DateTime PUM_PDate
        {
            get { return pUM_PDate; }
            set { pUM_PDate = value; pUM_PDate_IsChanged = true; }
        }

        private DateTime pUM_IDate;
        private bool pUM_IDate_IsChanged = false;
        public DateTime PUM_IDate
        {
            get { return pUM_IDate; }
            set { pUM_IDate = value; pUM_IDate_IsChanged = true; }
        }
 
        private DateTime pUM_RDate;
        private bool pUM_RDate_IsChanged = false;
        public DateTime PUM_RDate
        {
            get { return pUM_RDate; }
            set { pUM_RDate = value; pUM_RDate_IsChanged = true; }
        }

        private string pUM_Owner;
        private bool pUM_Owner_IsChanged = false;
        public string PUM_Owner
        {
            get { return pUM_Owner; }
            set { pUM_Owner = value; pUM_Owner_IsChanged = true; }
        }
 
        private decimal pUM_Tranfee;
        private bool pUM_Tranfee_IsChanged = false;
        public decimal PUM_Tranfee
        {
            get { return pUM_Tranfee; }
            set { pUM_Tranfee = value; pUM_Tranfee_IsChanged = true; }
        }
  
        private decimal pUM_Discount;
        private bool pUM_Discount_IsChanged = false;
        public decimal PUM_Discount
        {
            get { return pUM_Discount; }
            set { pUM_Discount = value; pUM_Discount_IsChanged = true; }
        }

        private decimal pUM_DisSum;
        private bool pUM_DisSum_IsChanged = false;
        public decimal PUM_DisSum
        {
            get { return pUM_DisSum; }
            set { pUM_DisSum = value; pUM_DisSum_IsChanged = true; }
        }

        private decimal pUM_Tax;
        private bool pUM_Tax_IsChanged = false;
        public decimal PUM_Tax
        {
            get { return pUM_Tax; }
            set { pUM_Tax = value; pUM_Tax_IsChanged = true; }
        }

        private decimal pUM_Payable;
        private bool pUM_Payable_IsChanged = false;
        public decimal PUM_Payable
        {
            get { return pUM_Payable; }
            set { pUM_Payable = value; pUM_Payable_IsChanged = true; }
        }

        private string pUM_BOwner;
        private bool pUM_BOwner_IsChanged = false;
   
        public string PUM_BOwner
        {
            get { return pUM_BOwner; }
            set { pUM_BOwner = value; pUM_BOwner_IsChanged = true; }
        }

        public string PUM_RefCode
        {
            get;
            set;
        }

        public string PUM_RefType
        {
            get;
            set;
        }

        public string PUM_Title
        {
            get;
            set;
        }

        public string PUM_UDEF1
        {
            get;
            set;
        }
        public string PUM_UDEF2
        {
            get;
            set;
        }
        public string PUM_UDEF3
        {
            get;
            set;
        }
        public string PUM_UDEF4
        {
            get;
            set;
        }
        

       
    }
}
