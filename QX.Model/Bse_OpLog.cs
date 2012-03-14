using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_OpLog
   {
      private decimal bOL_ID;
      private bool bOL_ID_IsChanged=false;
      public decimal BOL_ID
      {
         get{ return bOL_ID; }
         set{ bOL_ID = value; bOL_ID_IsChanged=true; }
      }
      public bool BOL_ID_IsChanged
      {
         get{ return bOL_ID_IsChanged; }
         set{ bOL_ID_IsChanged = value; }
      }
      /// <summary>
      /// 操作日志编码
      /// </summary>
      private string bOL_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Code_IsChanged=false;
      /// <summary>
      /// 操作日志编码
      /// </summary>
      public string BOL_Code
      {
         get{ return bOL_Code; }
         set{ bOL_Code = value; bOL_Code_IsChanged=true; }
      }
      /// <summary>
      /// 操作日志编码
      /// </summary>
      public bool BOL_Code_IsChanged
      {
         get{ return bOL_Code_IsChanged; }
         set{ bOL_Code_IsChanged = value; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      private string bOL_Module;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Module_IsChanged=false;
      /// <summary>
      /// 模块编码
      /// </summary>
      public string BOL_Module
      {
         get{ return bOL_Module; }
         set{ bOL_Module = value; bOL_Module_IsChanged=true; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      public bool BOL_Module_IsChanged
      {
         get{ return bOL_Module_IsChanged; }
         set{ bOL_Module_IsChanged = value; }
      }
      /// <summary>
      /// 操作类型
      /// </summary>
      private string bOL_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Type_IsChanged=false;
      /// <summary>
      /// 操作类型
      /// </summary>
      public string BOL_Type
      {
         get{ return bOL_Type; }
         set{ bOL_Type = value; bOL_Type_IsChanged=true; }
      }
      /// <summary>
      /// 操作类型
      /// </summary>
      public bool BOL_Type_IsChanged
      {
         get{ return bOL_Type_IsChanged; }
         set{ bOL_Type_IsChanged = value; }
      }
      /// <summary>
      /// 操作行为
      /// </summary>
      private string bOL_Operation;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Operation_IsChanged=false;
      /// <summary>
      /// 操作行为
      /// </summary>
      public string BOL_Operation
      {
         get{ return bOL_Operation; }
         set{ bOL_Operation = value; bOL_Operation_IsChanged=true; }
      }
      /// <summary>
      /// 操作行为
      /// </summary>
      public bool BOL_Operation_IsChanged
      {
         get{ return bOL_Operation_IsChanged; }
         set{ bOL_Operation_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string bOL_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Operator_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string BOL_Operator
      {
         get{ return bOL_Operator; }
         set{ bOL_Operator = value; bOL_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool BOL_Operator_IsChanged
      {
         get{ return bOL_Operator_IsChanged; }
         set{ bOL_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      private DateTime bOL_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_OpDate_IsChanged=false;
      /// <summary>
      /// 操作时间
      /// </summary>
      public DateTime BOL_OpDate
      {
         get{ return bOL_OpDate; }
         set{ bOL_OpDate = value; bOL_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      public bool BOL_OpDate_IsChanged
      {
         get{ return bOL_OpDate_IsChanged; }
         set{ bOL_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项1
      /// </summary>
      private string bOL_Udef1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Udef1_IsChanged=false;
      /// <summary>
      /// 自定义项1
      /// </summary>
      public string BOL_Udef1
      {
         get{ return bOL_Udef1; }
         set{ bOL_Udef1 = value; bOL_Udef1_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项1
      /// </summary>
      public bool BOL_Udef1_IsChanged
      {
         get{ return bOL_Udef1_IsChanged; }
         set{ bOL_Udef1_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项2
      /// </summary>
      private string bOL_Udef2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Udef2_IsChanged=false;
      /// <summary>
      /// 自定义项2
      /// </summary>
      public string BOL_Udef2
      {
         get{ return bOL_Udef2; }
         set{ bOL_Udef2 = value; bOL_Udef2_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项2
      /// </summary>
      public bool BOL_Udef2_IsChanged
      {
         get{ return bOL_Udef2_IsChanged; }
         set{ bOL_Udef2_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项3
      /// </summary>
      private string bOL_Udef3;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Udef3_IsChanged=false;
      /// <summary>
      /// 自定义项3
      /// </summary>
      public string BOL_Udef3
      {
         get{ return bOL_Udef3; }
         set{ bOL_Udef3 = value; bOL_Udef3_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项3
      /// </summary>
      public bool BOL_Udef3_IsChanged
      {
         get{ return bOL_Udef3_IsChanged; }
         set{ bOL_Udef3_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项4
      /// </summary>
      private string bOL_Udef4;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Udef4_IsChanged=false;
      /// <summary>
      /// 自定义项4
      /// </summary>
      public string BOL_Udef4
      {
         get{ return bOL_Udef4; }
         set{ bOL_Udef4 = value; bOL_Udef4_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项4
      /// </summary>
      public bool BOL_Udef4_IsChanged
      {
         get{ return bOL_Udef4_IsChanged; }
         set{ bOL_Udef4_IsChanged = value; }
      }
      /// <summary>
      /// 自定义项5
      /// </summary>
      private string bOL_Udef5;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bOL_Udef5_IsChanged=false;
      /// <summary>
      /// 自定义项5
      /// </summary>
      public string BOL_Udef5
      {
         get{ return bOL_Udef5; }
         set{ bOL_Udef5 = value; bOL_Udef5_IsChanged=true; }
      }
      /// <summary>
      /// 自定义项5
      /// </summary>
      public bool BOL_Udef5_IsChanged
      {
         get{ return bOL_Udef5_IsChanged; }
         set{ bOL_Udef5_IsChanged = value; }
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
