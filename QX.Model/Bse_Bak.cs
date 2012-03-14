using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 备注信息
   /// </summary>
   [Serializable]
   public partial class Bse_Bak
   {
      /// <summary>
      /// 备注序号
      /// </summary>
      private decimal bak_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bak_ID_IsChanged=false;
      /// <summary>
      /// 备注序号
      /// </summary>
      public decimal Bak_ID
      {
         get{ return bak_ID; }
         set{ bak_ID = value; bak_ID_IsChanged=true; }
      }
      /// <summary>
      /// 备注序号
      /// </summary>
      public bool Bak_ID_IsChanged
      {
         get{ return bak_ID_IsChanged; }
         set{ bak_ID_IsChanged = value; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      private string module_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Code_IsChanged=false;
      /// <summary>
      /// 模块编码
      /// </summary>
      public string Module_Code
      {
         get{ return module_Code; }
         set{ module_Code = value; module_Code_IsChanged=true; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      public bool Module_Code_IsChanged
      {
         get{ return module_Code_IsChanged; }
         set{ module_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string record_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool record_ID_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string Record_ID
      {
         get{ return record_ID; }
         set{ record_ID = value; record_ID_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool Record_ID_IsChanged
      {
         get{ return record_ID_IsChanged; }
         set{ record_ID_IsChanged = value; }
      }
      /// <summary>
      /// 内容
      /// </summary>
      private string bak_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bak_Content_IsChanged=false;
      /// <summary>
      /// 内容
      /// </summary>
      public string Bak_Content
      {
         get{ return bak_Content; }
         set{ bak_Content = value; bak_Content_IsChanged=true; }
      }
      /// <summary>
      /// 内容
      /// </summary>
      public bool Bak_Content_IsChanged
      {
         get{ return bak_Content_IsChanged; }
         set{ bak_Content_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
