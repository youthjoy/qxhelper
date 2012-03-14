using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 付款条款
   /// </summary>
   [Serializable]
   public partial class Pay_Clause
   {
      /// <summary>
      /// Cluase_ID
      /// </summary>
      private decimal cluase_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cluase_ID_IsChanged=false;
      /// <summary>
      /// Cluase_ID
      /// </summary>
      public decimal Cluase_ID
      {
         get{ return cluase_ID; }
         set{ cluase_ID = value; cluase_ID_IsChanged=true; }
      }
      /// <summary>
      /// Cluase_ID
      /// </summary>
      public bool Cluase_ID_IsChanged
      {
         get{ return cluase_ID_IsChanged; }
         set{ cluase_ID_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string contract_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Code_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string Contract_Code
      {
         get{ return contract_Code; }
         set{ contract_Code = value; contract_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool Contract_Code_IsChanged
      {
         get{ return contract_Code_IsChanged; }
         set{ contract_Code_IsChanged = value; }
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
   }
}
