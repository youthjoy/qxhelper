using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 客户结算单明细
   /// </summary>
   [Serializable]
   public partial class SD_BItem
   {
      /// <summary>
      /// 结算明细序号
      /// </summary>
      private decimal sDBI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_ID_IsChanged=false;
      /// <summary>
      /// 结算明细序号
      /// </summary>
      public decimal SDBI_ID
      {
         get{ return sDBI_ID; }
         set{ sDBI_ID = value; sDBI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 结算明细序号
      /// </summary>
      public bool SDBI_ID_IsChanged
      {
         get{ return sDBI_ID_IsChanged; }
         set{ sDBI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 结算明细编码
      /// </summary>
      private string sDBI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Code_IsChanged=false;
      /// <summary>
      /// 结算明细编码
      /// </summary>
      public string SDBI_Code
      {
         get{ return sDBI_Code; }
         set{ sDBI_Code = value; sDBI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 结算明细编码
      /// </summary>
      public bool SDBI_Code_IsChanged
      {
         get{ return sDBI_Code_IsChanged; }
         set{ sDBI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      private string sDBI_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_SCode_IsChanged=false;
      /// <summary>
      /// 结算单编码
      /// </summary>
      public string SDBI_SCode
      {
         get{ return sDBI_SCode; }
         set{ sDBI_SCode = value; sDBI_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      public bool SDBI_SCode_IsChanged
      {
         get{ return sDBI_SCode_IsChanged; }
         set{ sDBI_SCode_IsChanged = value; }
      }
      private string sDBI_Period;
      private bool sDBI_Period_IsChanged=false;
      public string SDBI_Period
      {
         get{ return sDBI_Period; }
         set{ sDBI_Period = value; sDBI_Period_IsChanged=true; }
      }
      public bool SDBI_Period_IsChanged
      {
         get{ return sDBI_Period_IsChanged; }
         set{ sDBI_Period_IsChanged = value; }
      }
      private string sDBI_CCode;
      private bool sDBI_CCode_IsChanged=false;
      public string SDBI_CCode
      {
         get{ return sDBI_CCode; }
         set{ sDBI_CCode = value; sDBI_CCode_IsChanged=true; }
      }
      public bool SDBI_CCode_IsChanged
      {
         get{ return sDBI_CCode_IsChanged; }
         set{ sDBI_CCode_IsChanged = value; }
      }
      private string sDBI_MType;
      private bool sDBI_MType_IsChanged=false;
      public string SDBI_MType
      {
         get{ return sDBI_MType; }
         set{ sDBI_MType = value; sDBI_MType_IsChanged=true; }
      }
      public bool SDBI_MType_IsChanged
      {
         get{ return sDBI_MType_IsChanged; }
         set{ sDBI_MType_IsChanged = value; }
      }
      private string sDBI_MCode;
      private bool sDBI_MCode_IsChanged=false;
      public string SDBI_MCode
      {
         get{ return sDBI_MCode; }
         set{ sDBI_MCode = value; sDBI_MCode_IsChanged=true; }
      }
      public bool SDBI_MCode_IsChanged
      {
         get{ return sDBI_MCode_IsChanged; }
         set{ sDBI_MCode_IsChanged = value; }
      }
      private string sDBI_Name;
      private bool sDBI_Name_IsChanged=false;
      public string SDBI_Name
      {
         get{ return sDBI_Name; }
         set{ sDBI_Name = value; sDBI_Name_IsChanged=true; }
      }
      public bool SDBI_Name_IsChanged
      {
         get{ return sDBI_Name_IsChanged; }
         set{ sDBI_Name_IsChanged = value; }
      }
      private decimal sDBI_Num;
      private bool sDBI_Num_IsChanged=false;
      public decimal SDBI_Num
      {
         get{ return sDBI_Num; }
         set{ sDBI_Num = value; sDBI_Num_IsChanged=true; }
      }
      public bool SDBI_Num_IsChanged
      {
         get{ return sDBI_Num_IsChanged; }
         set{ sDBI_Num_IsChanged = value; }
      }
      private string sDBI_Unit;
      private bool sDBI_Unit_IsChanged=false;
      public string SDBI_Unit
      {
         get{ return sDBI_Unit; }
         set{ sDBI_Unit = value; sDBI_Unit_IsChanged=true; }
      }
      public bool SDBI_Unit_IsChanged
      {
         get{ return sDBI_Unit_IsChanged; }
         set{ sDBI_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      private decimal sDBI_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Price_IsChanged=false;
      /// <summary>
      /// 单价
      /// </summary>
      public decimal SDBI_Price
      {
         get{ return sDBI_Price; }
         set{ sDBI_Price = value; sDBI_Price_IsChanged=true; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      public bool SDBI_Price_IsChanged
      {
         get{ return sDBI_Price_IsChanged; }
         set{ sDBI_Price_IsChanged = value; }
      }
      /// <summary>
      /// 结算方量
      /// </summary>
      private decimal sDBI_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Sum_IsChanged=false;
      /// <summary>
      /// 结算方量
      /// </summary>
      public decimal SDBI_Sum
      {
         get{ return sDBI_Sum; }
         set{ sDBI_Sum = value; sDBI_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 结算方量
      /// </summary>
      public bool SDBI_Sum_IsChanged
      {
         get{ return sDBI_Sum_IsChanged; }
         set{ sDBI_Sum_IsChanged = value; }
      }
      private DateTime sDBI_Start;
      private bool sDBI_Start_IsChanged=false;
      public DateTime SDBI_Start
      {
         get{ return sDBI_Start; }
         set{ sDBI_Start = value; sDBI_Start_IsChanged=true; }
      }
      public bool SDBI_Start_IsChanged
      {
         get{ return sDBI_Start_IsChanged; }
         set{ sDBI_Start_IsChanged = value; }
      }
      private DateTime sDBI_End;
      private bool sDBI_End_IsChanged=false;
      public DateTime SDBI_End
      {
         get{ return sDBI_End; }
         set{ sDBI_End = value; sDBI_End_IsChanged=true; }
      }
      public bool SDBI_End_IsChanged
      {
         get{ return sDBI_End_IsChanged; }
         set{ sDBI_End_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDBI_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDBI_Bak
      {
         get{ return sDBI_Bak; }
         set{ sDBI_Bak = value; sDBI_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDBI_Bak_IsChanged
      {
         get{ return sDBI_Bak_IsChanged; }
         set{ sDBI_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createDate_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime updateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool updateDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime deleteDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool deleteDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      private string sDBI_Level;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Level_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string SDBI_Level
      {
         get{ return sDBI_Level; }
         set{ sDBI_Level = value; sDBI_Level_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool SDBI_Level_IsChanged
      {
         get{ return sDBI_Level_IsChanged; }
         set{ sDBI_Level_IsChanged = value; }
      }
      /// <summary>
      /// 浇注部位
      /// </summary>
      private string sDBI_Part;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Part_IsChanged=false;
      /// <summary>
      /// 浇注部位
      /// </summary>
      public string SDBI_Part
      {
         get{ return sDBI_Part; }
         set{ sDBI_Part = value; sDBI_Part_IsChanged=true; }
      }
      /// <summary>
      /// 浇注部位
      /// </summary>
      public bool SDBI_Part_IsChanged
      {
         get{ return sDBI_Part_IsChanged; }
         set{ sDBI_Part_IsChanged = value; }
      }
      /// <summary>
      /// 浇注方式
      /// </summary>
      private string sDBI_Method;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Method_IsChanged=false;
      /// <summary>
      /// 浇注方式
      /// </summary>
      public string SDBI_Method
      {
         get{ return sDBI_Method; }
         set{ sDBI_Method = value; sDBI_Method_IsChanged=true; }
      }
      /// <summary>
      /// 浇注方式
      /// </summary>
      public bool SDBI_Method_IsChanged
      {
         get{ return sDBI_Method_IsChanged; }
         set{ sDBI_Method_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private string sDBI_Money;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Money_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public string SDBI_Money
      {
         get{ return sDBI_Money; }
         set{ sDBI_Money = value; sDBI_Money_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool SDBI_Money_IsChanged
      {
         get{ return sDBI_Money_IsChanged; }
         set{ sDBI_Money_IsChanged = value; }
      }
      /// <summary>
      /// 附件张数
      /// </summary>
      private string sDBI_AttachementCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_AttachementCount_IsChanged=false;
      /// <summary>
      /// 附件张数
      /// </summary>
      public string SDBI_AttachementCount
      {
         get{ return sDBI_AttachementCount; }
         set{ sDBI_AttachementCount = value; sDBI_AttachementCount_IsChanged=true; }
      }
      /// <summary>
      /// 附件张数
      /// </summary>
      public bool SDBI_AttachementCount_IsChanged
      {
         get{ return sDBI_AttachementCount_IsChanged; }
         set{ sDBI_AttachementCount_IsChanged = value; }
      }
   }
}
