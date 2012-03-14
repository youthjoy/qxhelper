using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class WH_Price
   {
      private Int64 wP_ID;
      private bool wP_ID_IsChanged=false;
      public Int64 WP_ID
      {
         get{ return wP_ID; }
         set{ wP_ID = value; wP_ID_IsChanged=true; }
      }
      public bool WP_ID_IsChanged
      {
         get{ return wP_ID_IsChanged; }
         set{ wP_ID_IsChanged = value; }
      }
      private string wP_CCode;
      private bool wP_CCode_IsChanged=false;
      public string WP_CCode
      {
         get{ return wP_CCode; }
         set{ wP_CCode = value; wP_CCode_IsChanged=true; }
      }
      public bool WP_CCode_IsChanged
      {
         get{ return wP_CCode_IsChanged; }
         set{ wP_CCode_IsChanged = value; }
      }
      private string wP_CName;
      private bool wP_CName_IsChanged=false;
      public string WP_CName
      {
         get{ return wP_CName; }
         set{ wP_CName = value; wP_CName_IsChanged=true; }
      }
      public bool WP_CName_IsChanged
      {
         get{ return wP_CName_IsChanged; }
         set{ wP_CName_IsChanged = value; }
      }
      private string wP_MCode;
      private bool wP_MCode_IsChanged=false;
      public string WP_MCode
      {
         get{ return wP_MCode; }
         set{ wP_MCode = value; wP_MCode_IsChanged=true; }
      }
      public bool WP_MCode_IsChanged
      {
         get{ return wP_MCode_IsChanged; }
         set{ wP_MCode_IsChanged = value; }
      }
      private string wP_MName;
      private bool wP_MName_IsChanged=false;
      public string WP_MName
      {
         get{ return wP_MName; }
         set{ wP_MName = value; wP_MName_IsChanged=true; }
      }
      public bool WP_MName_IsChanged
      {
         get{ return wP_MName_IsChanged; }
         set{ wP_MName_IsChanged = value; }
      }
      private string wP_Spec;
      private bool wP_Spec_IsChanged=false;
      public string WP_Spec
      {
         get{ return wP_Spec; }
         set{ wP_Spec = value; wP_Spec_IsChanged=true; }
      }
      public bool WP_Spec_IsChanged
      {
         get{ return wP_Spec_IsChanged; }
         set{ wP_Spec_IsChanged = value; }
      }
      private string wP_Unit;
      private bool wP_Unit_IsChanged=false;
      public string WP_Unit
      {
         get{ return wP_Unit; }
         set{ wP_Unit = value; wP_Unit_IsChanged=true; }
      }
      public bool WP_Unit_IsChanged
      {
         get{ return wP_Unit_IsChanged; }
         set{ wP_Unit_IsChanged = value; }
      }
      private decimal wP_Price;
      private bool wP_Price_IsChanged=false;
      public decimal WP_Price
      {
         get{ return wP_Price; }
         set{ wP_Price = value; wP_Price_IsChanged=true; }
      }
      public bool WP_Price_IsChanged
      {
         get{ return wP_Price_IsChanged; }
         set{ wP_Price_IsChanged = value; }
      }
      private decimal wP_Num;
      private bool wP_Num_IsChanged=false;
      public decimal WP_Num
      {
         get{ return wP_Num; }
         set{ wP_Num = value; wP_Num_IsChanged=true; }
      }
      public bool WP_Num_IsChanged
      {
         get{ return wP_Num_IsChanged; }
         set{ wP_Num_IsChanged = value; }
      }
      private decimal wP_ONum;
      private bool wP_ONum_IsChanged=false;
      public decimal WP_ONum
      {
         get{ return wP_ONum; }
         set{ wP_ONum = value; wP_ONum_IsChanged=true; }
      }
      public bool WP_ONum_IsChanged
      {
         get{ return wP_ONum_IsChanged; }
         set{ wP_ONum_IsChanged = value; }
      }
      private decimal wP_PNum;
      private bool wP_PNum_IsChanged=false;
      public decimal WP_PNum
      {
         get{ return wP_PNum; }
         set{ wP_PNum = value; wP_PNum_IsChanged=true; }
      }
      public bool WP_PNum_IsChanged
      {
         get{ return wP_PNum_IsChanged; }
         set{ wP_PNum_IsChanged = value; }
      }
      private decimal wP_RNum;
      private bool wP_RNum_IsChanged=false;
      public decimal WP_RNum
      {
         get{ return wP_RNum; }
         set{ wP_RNum = value; wP_RNum_IsChanged=true; }
      }
      public bool WP_RNum_IsChanged
      {
         get{ return wP_RNum_IsChanged; }
         set{ wP_RNum_IsChanged = value; }
      }
      private decimal wP_RONum;
      private bool wP_RONum_IsChanged=false;
      public decimal WP_RONum
      {
         get{ return wP_RONum; }
         set{ wP_RONum = value; wP_RONum_IsChanged=true; }
      }
      public bool WP_RONum_IsChanged
      {
         get{ return wP_RONum_IsChanged; }
         set{ wP_RONum_IsChanged = value; }
      }
      private decimal wP_INum;
      private bool wP_INum_IsChanged=false;
      public decimal WP_INum
      {
         get{ return wP_INum; }
         set{ wP_INum = value; wP_INum_IsChanged=true; }
      }
      public bool WP_INum_IsChanged
      {
         get{ return wP_INum_IsChanged; }
         set{ wP_INum_IsChanged = value; }
      }
      private decimal wP_PRONum;
      private bool wP_PRONum_IsChanged=false;
      public decimal WP_PRONum
      {
         get{ return wP_PRONum; }
         set{ wP_PRONum = value; wP_PRONum_IsChanged=true; }
      }
      public bool WP_PRONum_IsChanged
      {
         get{ return wP_PRONum_IsChanged; }
         set{ wP_PRONum_IsChanged = value; }
      }
      private decimal wP_PRINum;
      private bool wP_PRINum_IsChanged=false;
      public decimal WP_PRINum
      {
         get{ return wP_PRINum; }
         set{ wP_PRINum = value; wP_PRINum_IsChanged=true; }
      }
      public bool WP_PRINum_IsChanged
      {
         get{ return wP_PRINum_IsChanged; }
         set{ wP_PRINum_IsChanged = value; }
      }
      private string wP_Udef1;
      private bool wP_Udef1_IsChanged=false;
      public string WP_Udef1
      {
         get{ return wP_Udef1; }
         set{ wP_Udef1 = value; wP_Udef1_IsChanged=true; }
      }
      public bool WP_Udef1_IsChanged
      {
         get{ return wP_Udef1_IsChanged; }
         set{ wP_Udef1_IsChanged = value; }
      }
      private string wP_Udef2;
      private bool wP_Udef2_IsChanged=false;
      public string WP_Udef2
      {
         get{ return wP_Udef2; }
         set{ wP_Udef2 = value; wP_Udef2_IsChanged=true; }
      }
      public bool WP_Udef2_IsChanged
      {
         get{ return wP_Udef2_IsChanged; }
         set{ wP_Udef2_IsChanged = value; }
      }
      private string wP_Udef3;
      private bool wP_Udef3_IsChanged=false;
      public string WP_Udef3
      {
         get{ return wP_Udef3; }
         set{ wP_Udef3 = value; wP_Udef3_IsChanged=true; }
      }
      public bool WP_Udef3_IsChanged
      {
         get{ return wP_Udef3_IsChanged; }
         set{ wP_Udef3_IsChanged = value; }
      }
      private string wP_Udef4;
      private bool wP_Udef4_IsChanged=false;
      public string WP_Udef4
      {
         get{ return wP_Udef4; }
         set{ wP_Udef4 = value; wP_Udef4_IsChanged=true; }
      }
      public bool WP_Udef4_IsChanged
      {
         get{ return wP_Udef4_IsChanged; }
         set{ wP_Udef4_IsChanged = value; }
      }
      private string wP_Udef5;
      private bool wP_Udef5_IsChanged=false;
      public string WP_Udef5
      {
         get{ return wP_Udef5; }
         set{ wP_Udef5 = value; wP_Udef5_IsChanged=true; }
      }
      public bool WP_Udef5_IsChanged
      {
         get{ return wP_Udef5_IsChanged; }
         set{ wP_Udef5_IsChanged = value; }
      }
      private string wP_Udef6;
      private bool wP_Udef6_IsChanged=false;
      public string WP_Udef6
      {
         get{ return wP_Udef6; }
         set{ wP_Udef6 = value; wP_Udef6_IsChanged=true; }
      }
      public bool WP_Udef6_IsChanged
      {
         get{ return wP_Udef6_IsChanged; }
         set{ wP_Udef6_IsChanged = value; }
      }
      private string wP_Udef7;
      private bool wP_Udef7_IsChanged=false;
      public string WP_Udef7
      {
         get{ return wP_Udef7; }
         set{ wP_Udef7 = value; wP_Udef7_IsChanged=true; }
      }
      public bool WP_Udef7_IsChanged
      {
         get{ return wP_Udef7_IsChanged; }
         set{ wP_Udef7_IsChanged = value; }
      }
      private string wP_Udef8;
      private bool wP_Udef8_IsChanged=false;
      public string WP_Udef8
      {
         get{ return wP_Udef8; }
         set{ wP_Udef8 = value; wP_Udef8_IsChanged=true; }
      }
      public bool WP_Udef8_IsChanged
      {
         get{ return wP_Udef8_IsChanged; }
         set{ wP_Udef8_IsChanged = value; }
      }
      private string wP_Udef9;
      private bool wP_Udef9_IsChanged=false;
      public string WP_Udef9
      {
         get{ return wP_Udef9; }
         set{ wP_Udef9 = value; wP_Udef9_IsChanged=true; }
      }
      public bool WP_Udef9_IsChanged
      {
         get{ return wP_Udef9_IsChanged; }
         set{ wP_Udef9_IsChanged = value; }
      }
      private string wP_Udef10;
      private bool wP_Udef10_IsChanged=false;
      public string WP_Udef10
      {
         get{ return wP_Udef10; }
         set{ wP_Udef10 = value; wP_Udef10_IsChanged=true; }
      }
      public bool WP_Udef10_IsChanged
      {
         get{ return wP_Udef10_IsChanged; }
         set{ wP_Udef10_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private DateTime wP_LastPPDate;
      private bool wP_LastPPDate_IsChanged=false;
      public DateTime WP_LastPPDate
      {
         get{ return wP_LastPPDate; }
         set{ wP_LastPPDate = value; wP_LastPPDate_IsChanged=true; }
      }
      public bool WP_LastPPDate_IsChanged
      {
         get{ return wP_LastPPDate_IsChanged; }
         set{ wP_LastPPDate_IsChanged = value; }
      }
      private DateTime wP_LastPPCollectDate;
      private bool wP_LastPPCollectDate_IsChanged=false;
      public DateTime WP_LastPPCollectDate
      {
         get{ return wP_LastPPCollectDate; }
         set{ wP_LastPPCollectDate = value; wP_LastPPCollectDate_IsChanged=true; }
      }
      public bool WP_LastPPCollectDate_IsChanged
      {
         get{ return wP_LastPPCollectDate_IsChanged; }
         set{ wP_LastPPCollectDate_IsChanged = value; }
      }
      private DateTime wP_LastPODate;
      private bool wP_LastPODate_IsChanged=false;
      public DateTime WP_LastPODate
      {
         get{ return wP_LastPODate; }
         set{ wP_LastPODate = value; wP_LastPODate_IsChanged=true; }
      }
      public bool WP_LastPODate_IsChanged
      {
         get{ return wP_LastPODate_IsChanged; }
         set{ wP_LastPODate_IsChanged = value; }
      }
      private string wP_LastPOSupCode;
      private bool wP_LastPOSupCode_IsChanged=false;
      public string WP_LastPOSupCode
      {
         get{ return wP_LastPOSupCode; }
         set{ wP_LastPOSupCode = value; wP_LastPOSupCode_IsChanged=true; }
      }
      public bool WP_LastPOSupCode_IsChanged
      {
         get{ return wP_LastPOSupCode_IsChanged; }
         set{ wP_LastPOSupCode_IsChanged = value; }
      }
      private string wP_LastPOSupName;
      private bool wP_LastPOSupName_IsChanged=false;
      public string WP_LastPOSupName
      {
         get{ return wP_LastPOSupName; }
         set{ wP_LastPOSupName = value; wP_LastPOSupName_IsChanged=true; }
      }
      public bool WP_LastPOSupName_IsChanged
      {
         get{ return wP_LastPOSupName_IsChanged; }
         set{ wP_LastPOSupName_IsChanged = value; }
      }
      private DateTime wP_LastPIDate;
      private bool wP_LastPIDate_IsChanged=false;
      public DateTime WP_LastPIDate
      {
         get{ return wP_LastPIDate; }
         set{ wP_LastPIDate = value; wP_LastPIDate_IsChanged=true; }
      }
      public bool WP_LastPIDate_IsChanged
      {
         get{ return wP_LastPIDate_IsChanged; }
         set{ wP_LastPIDate_IsChanged = value; }
      }
      private string wP_LastPISupCode;
      private bool wP_LastPISupCode_IsChanged=false;
      public string WP_LastPISupCode
      {
         get{ return wP_LastPISupCode; }
         set{ wP_LastPISupCode = value; wP_LastPISupCode_IsChanged=true; }
      }
      public bool WP_LastPISupCode_IsChanged
      {
         get{ return wP_LastPISupCode_IsChanged; }
         set{ wP_LastPISupCode_IsChanged = value; }
      }
      private string wP_LastPISupName;
      private bool wP_LastPISupName_IsChanged=false;
      public string WP_LastPISupName
      {
         get{ return wP_LastPISupName; }
         set{ wP_LastPISupName = value; wP_LastPISupName_IsChanged=true; }
      }
      public bool WP_LastPISupName_IsChanged
      {
         get{ return wP_LastPISupName_IsChanged; }
         set{ wP_LastPISupName_IsChanged = value; }
      }
      private DateTime wP_LastPRDate;
      private bool wP_LastPRDate_IsChanged=false;
      public DateTime WP_LastPRDate
      {
         get{ return wP_LastPRDate; }
         set{ wP_LastPRDate = value; wP_LastPRDate_IsChanged=true; }
      }
      public bool WP_LastPRDate_IsChanged
      {
         get{ return wP_LastPRDate_IsChanged; }
         set{ wP_LastPRDate_IsChanged = value; }
      }
      private string wP_LastPRSupCode;
      private bool wP_LastPRSupCode_IsChanged=false;
      public string WP_LastPRSupCode
      {
         get{ return wP_LastPRSupCode; }
         set{ wP_LastPRSupCode = value; wP_LastPRSupCode_IsChanged=true; }
      }
      public bool WP_LastPRSupCode_IsChanged
      {
         get{ return wP_LastPRSupCode_IsChanged; }
         set{ wP_LastPRSupCode_IsChanged = value; }
      }
      private string wP_LastPRSupName;
      private bool wP_LastPRSupName_IsChanged=false;
      public string WP_LastPRSupName
      {
         get{ return wP_LastPRSupName; }
         set{ wP_LastPRSupName = value; wP_LastPRSupName_IsChanged=true; }
      }
      public bool WP_LastPRSupName_IsChanged
      {
         get{ return wP_LastPRSupName_IsChanged; }
         set{ wP_LastPRSupName_IsChanged = value; }
      }
      private DateTime wP_LastRODate;
      private bool wP_LastRODate_IsChanged=false;
      public DateTime WP_LastRODate
      {
         get{ return wP_LastRODate; }
         set{ wP_LastRODate = value; wP_LastRODate_IsChanged=true; }
      }
      public bool WP_LastRODate_IsChanged
      {
         get{ return wP_LastRODate_IsChanged; }
         set{ wP_LastRODate_IsChanged = value; }
      }
      private string wP_LastRODeptCode;
      private bool wP_LastRODeptCode_IsChanged=false;
      public string WP_LastRODeptCode
      {
         get{ return wP_LastRODeptCode; }
         set{ wP_LastRODeptCode = value; wP_LastRODeptCode_IsChanged=true; }
      }
      public bool WP_LastRODeptCode_IsChanged
      {
         get{ return wP_LastRODeptCode_IsChanged; }
         set{ wP_LastRODeptCode_IsChanged = value; }
      }
      private string wP_LastRODeptName;
      private bool wP_LastRODeptName_IsChanged=false;
      public string WP_LastRODeptName
      {
         get{ return wP_LastRODeptName; }
         set{ wP_LastRODeptName = value; wP_LastRODeptName_IsChanged=true; }
      }
      public bool WP_LastRODeptName_IsChanged
      {
         get{ return wP_LastRODeptName_IsChanged; }
         set{ wP_LastRODeptName_IsChanged = value; }
      }
      private string wP_LastROUseType;
      private bool wP_LastROUseType_IsChanged=false;
      public string WP_LastROUseType
      {
         get{ return wP_LastROUseType; }
         set{ wP_LastROUseType = value; wP_LastROUseType_IsChanged=true; }
      }
      public bool WP_LastROUseType_IsChanged
      {
         get{ return wP_LastROUseType_IsChanged; }
         set{ wP_LastROUseType_IsChanged = value; }
      }
      private string wP_LastROEmpCode;
      private bool wP_LastROEmpCode_IsChanged=false;
      public string WP_LastROEmpCode
      {
         get{ return wP_LastROEmpCode; }
         set{ wP_LastROEmpCode = value; wP_LastROEmpCode_IsChanged=true; }
      }
      public bool WP_LastROEmpCode_IsChanged
      {
         get{ return wP_LastROEmpCode_IsChanged; }
         set{ wP_LastROEmpCode_IsChanged = value; }
      }
      private string wP_LastROEmpName;
      private bool wP_LastROEmpName_IsChanged=false;
      public string WP_LastROEmpName
      {
         get{ return wP_LastROEmpName; }
         set{ wP_LastROEmpName = value; wP_LastROEmpName_IsChanged=true; }
      }
      public bool WP_LastROEmpName_IsChanged
      {
         get{ return wP_LastROEmpName_IsChanged; }
         set{ wP_LastROEmpName_IsChanged = value; }
      }
      private DateTime wP_LastPRODate;
      private bool wP_LastPRODate_IsChanged=false;
      public DateTime WP_LastPRODate
      {
         get{ return wP_LastPRODate; }
         set{ wP_LastPRODate = value; wP_LastPRODate_IsChanged=true; }
      }
      public bool WP_LastPRODate_IsChanged
      {
         get{ return wP_LastPRODate_IsChanged; }
         set{ wP_LastPRODate_IsChanged = value; }
      }
      private DateTime wP_LastPRIDate;
      private bool wP_LastPRIDate_IsChanged=false;
      public DateTime WP_LastPRIDate
      {
         get{ return wP_LastPRIDate; }
         set{ wP_LastPRIDate = value; wP_LastPRIDate_IsChanged=true; }
      }
      public bool WP_LastPRIDate_IsChanged
      {
         get{ return wP_LastPRIDate_IsChanged; }
         set{ wP_LastPRIDate_IsChanged = value; }
      }
      private string wP_LastPRISupCode;
      private bool wP_LastPRISupCode_IsChanged=false;
      public string WP_LastPRISupCode
      {
         get{ return wP_LastPRISupCode; }
         set{ wP_LastPRISupCode = value; wP_LastPRISupCode_IsChanged=true; }
      }
      public bool WP_LastPRISupCode_IsChanged
      {
         get{ return wP_LastPRISupCode_IsChanged; }
         set{ wP_LastPRISupCode_IsChanged = value; }
      }
      private string wP_LastPRISupName;
      private bool wP_LastPRISupName_IsChanged=false;
      public string WP_LastPRISupName
      {
         get{ return wP_LastPRISupName; }
         set{ wP_LastPRISupName = value; wP_LastPRISupName_IsChanged=true; }
      }
      public bool WP_LastPRISupName_IsChanged
      {
         get{ return wP_LastPRISupName_IsChanged; }
         set{ wP_LastPRISupName_IsChanged = value; }
      }
      private string wP_LastPROSupCode;
      private bool wP_LastPROSupCode_IsChanged=false;
      public string WP_LastPROSupCode
      {
         get{ return wP_LastPROSupCode; }
         set{ wP_LastPROSupCode = value; wP_LastPROSupCode_IsChanged=true; }
      }
      public bool WP_LastPROSupCode_IsChanged
      {
         get{ return wP_LastPROSupCode_IsChanged; }
         set{ wP_LastPROSupCode_IsChanged = value; }
      }
      private string wP_LastPROSupName;
      private bool wP_LastPROSupName_IsChanged=false;
      public string WP_LastPROSupName
      {
         get{ return wP_LastPROSupName; }
         set{ wP_LastPROSupName = value; wP_LastPROSupName_IsChanged=true; }
      }
      public bool WP_LastPROSupName_IsChanged
      {
         get{ return wP_LastPROSupName_IsChanged; }
         set{ wP_LastPROSupName_IsChanged = value; }
      }
      private int wP_CountPP;
      private bool wP_CountPP_IsChanged=false;
      public int WP_CountPP
      {
         get{ return wP_CountPP; }
         set{ wP_CountPP = value; wP_CountPP_IsChanged=true; }
      }
      public bool WP_CountPP_IsChanged
      {
         get{ return wP_CountPP_IsChanged; }
         set{ wP_CountPP_IsChanged = value; }
      }
      private int wP_CountPO;
      private bool wP_CountPO_IsChanged=false;
      public int WP_CountPO
      {
         get{ return wP_CountPO; }
         set{ wP_CountPO = value; wP_CountPO_IsChanged=true; }
      }
      public bool WP_CountPO_IsChanged
      {
         get{ return wP_CountPO_IsChanged; }
         set{ wP_CountPO_IsChanged = value; }
      }
      private int wP_CountPI;
      private bool wP_CountPI_IsChanged=false;
      public int WP_CountPI
      {
         get{ return wP_CountPI; }
         set{ wP_CountPI = value; wP_CountPI_IsChanged=true; }
      }
      public bool WP_CountPI_IsChanged
      {
         get{ return wP_CountPI_IsChanged; }
         set{ wP_CountPI_IsChanged = value; }
      }
      private int wP_CountPR;
      private bool wP_CountPR_IsChanged=false;
      public int WP_CountPR
      {
         get{ return wP_CountPR; }
         set{ wP_CountPR = value; wP_CountPR_IsChanged=true; }
      }
      public bool WP_CountPR_IsChanged
      {
         get{ return wP_CountPR_IsChanged; }
         set{ wP_CountPR_IsChanged = value; }
      }
      private int wP_CountRO;
      private bool wP_CountRO_IsChanged=false;
      public int WP_CountRO
      {
         get{ return wP_CountRO; }
         set{ wP_CountRO = value; wP_CountRO_IsChanged=true; }
      }
      public bool WP_CountRO_IsChanged
      {
         get{ return wP_CountRO_IsChanged; }
         set{ wP_CountRO_IsChanged = value; }
      }
      private decimal wP_CountPRO;
      private bool wP_CountPRO_IsChanged=false;
      public decimal WP_CountPRO
      {
         get{ return wP_CountPRO; }
         set{ wP_CountPRO = value; wP_CountPRO_IsChanged=true; }
      }
      public bool WP_CountPRO_IsChanged
      {
         get{ return wP_CountPRO_IsChanged; }
         set{ wP_CountPRO_IsChanged = value; }
      }
      private decimal wP_CountRR;
      private bool wP_CountRR_IsChanged=false;
      public decimal WP_CountRR
      {
         get{ return wP_CountRR; }
         set{ wP_CountRR = value; wP_CountRR_IsChanged=true; }
      }
      public bool WP_CountRR_IsChanged
      {
         get{ return wP_CountRR_IsChanged; }
         set{ wP_CountRR_IsChanged = value; }
      }
      private decimal wP_LeftPO;
      private bool wP_LeftPO_IsChanged=false;
      public decimal WP_LeftPO
      {
         get{ return wP_LeftPO; }
         set{ wP_LeftPO = value; wP_LeftPO_IsChanged=true; }
      }
      public bool WP_LeftPO_IsChanged
      {
         get{ return wP_LeftPO_IsChanged; }
         set{ wP_LeftPO_IsChanged = value; }
      }
      private decimal wP_LeftPP;
      private bool wP_LeftPP_IsChanged=false;
      public decimal WP_LeftPP
      {
         get{ return wP_LeftPP; }
         set{ wP_LeftPP = value; wP_LeftPP_IsChanged=true; }
      }
      public bool WP_LeftPP_IsChanged
      {
         get{ return wP_LeftPP_IsChanged; }
         set{ wP_LeftPP_IsChanged = value; }
      }
      private DateTime wP_LastRRDate;
      private bool wP_LastRRDate_IsChanged=false;
      public DateTime WP_LastRRDate
      {
         get{ return wP_LastRRDate; }
         set{ wP_LastRRDate = value; wP_LastRRDate_IsChanged=true; }
      }
      public bool WP_LastRRDate_IsChanged
      {
         get{ return wP_LastRRDate_IsChanged; }
         set{ wP_LastRRDate_IsChanged = value; }
      }
      private string wP_LastRRDeptCode;
      private bool wP_LastRRDeptCode_IsChanged=false;
      public string WP_LastRRDeptCode
      {
         get{ return wP_LastRRDeptCode; }
         set{ wP_LastRRDeptCode = value; wP_LastRRDeptCode_IsChanged=true; }
      }
      public bool WP_LastRRDeptCode_IsChanged
      {
         get{ return wP_LastRRDeptCode_IsChanged; }
         set{ wP_LastRRDeptCode_IsChanged = value; }
      }
      private string wP_LastRRDeptName;
      private bool wP_LastRRDeptName_IsChanged=false;
      public string WP_LastRRDeptName
      {
         get{ return wP_LastRRDeptName; }
         set{ wP_LastRRDeptName = value; wP_LastRRDeptName_IsChanged=true; }
      }
      public bool WP_LastRRDeptName_IsChanged
      {
         get{ return wP_LastRRDeptName_IsChanged; }
         set{ wP_LastRRDeptName_IsChanged = value; }
      }
      private string wP_LastRRUseType;
      private bool wP_LastRRUseType_IsChanged=false;
      public string WP_LastRRUseType
      {
         get{ return wP_LastRRUseType; }
         set{ wP_LastRRUseType = value; wP_LastRRUseType_IsChanged=true; }
      }
      public bool WP_LastRRUseType_IsChanged
      {
         get{ return wP_LastRRUseType_IsChanged; }
         set{ wP_LastRRUseType_IsChanged = value; }
      }
      private string wP_LastRREmpCode;
      private bool wP_LastRREmpCode_IsChanged=false;
      public string WP_LastRREmpCode
      {
         get{ return wP_LastRREmpCode; }
         set{ wP_LastRREmpCode = value; wP_LastRREmpCode_IsChanged=true; }
      }
      public bool WP_LastRREmpCode_IsChanged
      {
         get{ return wP_LastRREmpCode_IsChanged; }
         set{ wP_LastRREmpCode_IsChanged = value; }
      }
      private string wP_LastRREmpName;
      private bool wP_LastRREmpName_IsChanged=false;
      public string WP_LastRREmpName
      {
         get{ return wP_LastRREmpName; }
         set{ wP_LastRREmpName = value; wP_LastRREmpName_IsChanged=true; }
      }
      public bool WP_LastRREmpName_IsChanged
      {
         get{ return wP_LastRREmpName_IsChanged; }
         set{ wP_LastRREmpName_IsChanged = value; }
      }
   }
}
