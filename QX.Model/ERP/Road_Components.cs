using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 零件图号信息
   /// </summary>
   [Serializable]
   public partial class Road_Components
   {
      /// <summary>
      /// 零件序号
      /// </summary>
      private Int64 comp_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_ID_IsChanged=false;
      /// <summary>
      /// 零件序号
      /// </summary>
      public Int64 Comp_ID
      {
         get{ return comp_ID; }
         set{ comp_ID = value; comp_ID_IsChanged=true; }
      }
      /// <summary>
      /// 零件序号
      /// </summary>
      public bool Comp_ID_IsChanged
      {
         get{ return comp_ID_IsChanged; }
         set{ comp_ID_IsChanged = value; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      private string comp_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_Code_IsChanged=false;
      /// <summary>
      /// 零件图号
      /// </summary>
      public string Comp_Code
      {
         get{ return comp_Code; }
         set{ comp_Code = value; comp_Code_IsChanged=true; }
      }
      /// <summary>
      /// 零件图号
      /// </summary>
      public bool Comp_Code_IsChanged
      {
         get{ return comp_Code_IsChanged; }
         set{ comp_Code_IsChanged = value; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      private string comp_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_Name_IsChanged=false;
      /// <summary>
      /// 零件名称
      /// </summary>
      public string Comp_Name
      {
         get{ return comp_Name; }
         set{ comp_Name = value; comp_Name_IsChanged=true; }
      }
      /// <summary>
      /// 零件名称
      /// </summary>
      public bool Comp_Name_IsChanged
      {
         get{ return comp_Name_IsChanged; }
         set{ comp_Name_IsChanged = value; }
      }
      /// <summary>
      /// 零件图纸
      /// </summary>
      private string comp_Design;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_Design_IsChanged=false;
      /// <summary>
      /// 零件图纸
      /// </summary>
      public string Comp_Design
      {
         get{ return comp_Design; }
         set{ comp_Design = value; comp_Design_IsChanged=true; }
      }
      /// <summary>
      /// 零件图纸
      /// </summary>
      public bool Comp_Design_IsChanged
      {
         get{ return comp_Design_IsChanged; }
         set{ comp_Design_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string comp_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Comp_Bak
      {
         get{ return comp_Bak; }
         set{ comp_Bak = value; comp_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Comp_Bak_IsChanged
      {
         get{ return comp_Bak_IsChanged; }
         set{ comp_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 零件状态
      /// </summary>
      private string comp_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_Stat_IsChanged=false;
      /// <summary>
      /// 零件状态
      /// </summary>
      public string Comp_Stat
      {
         get{ return comp_Stat; }
         set{ comp_Stat = value; comp_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 零件状态
      /// </summary>
      public bool Comp_Stat_IsChanged
      {
         get{ return comp_Stat_IsChanged; }
         set{ comp_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 产品类别编码
      /// </summary>
      private string comp_CatCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_CatCode_IsChanged=false;
      /// <summary>
      /// 产品类别编码
      /// </summary>
      public string Comp_CatCode
      {
         get{ return comp_CatCode; }
         set{ comp_CatCode = value; comp_CatCode_IsChanged=true; }
      }
      /// <summary>
      /// 产品类别编码
      /// </summary>
      public bool Comp_CatCode_IsChanged
      {
         get{ return comp_CatCode_IsChanged; }
         set{ comp_CatCode_IsChanged = value; }
      }
      /// <summary>
      /// 产品类别名称
      /// </summary>
      private string comp_CatName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_CatName_IsChanged=false;
      /// <summary>
      /// 产品类别名称
      /// </summary>
      public string Comp_CatName
      {
         get{ return comp_CatName; }
         set{ comp_CatName = value; comp_CatName_IsChanged=true; }
      }
      /// <summary>
      /// 产品类别名称
      /// </summary>
      public bool Comp_CatName_IsChanged
      {
         get{ return comp_CatName_IsChanged; }
         set{ comp_CatName_IsChanged = value; }
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
      /// 排序
      /// </summary>
      private int comp_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool comp_Order_IsChanged=false;
      /// <summary>
      /// 排序
      /// </summary>
      public int Comp_Order
      {
         get{ return comp_Order; }
         set{ comp_Order = value; comp_Order_IsChanged=true; }
      }
      /// <summary>
      /// 排序
      /// </summary>
      public bool Comp_Order_IsChanged
      {
         get{ return comp_Order_IsChanged; }
         set{ comp_Order_IsChanged = value; }
      }
      private string auditStat;
      private bool auditStat_IsChanged=false;
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private string auditCurAudit;
      private bool auditCurAudit_IsChanged=false;
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
      private string comp_CurNode;
      private bool comp_CurNode_IsChanged=false;
      public string Comp_CurNode
      {
         get{ return comp_CurNode; }
         set{ comp_CurNode = value; comp_CurNode_IsChanged=true; }
      }
      public bool Comp_CurNode_IsChanged
      {
         get{ return comp_CurNode_IsChanged; }
         set{ comp_CurNode_IsChanged = value; }
      }
      private string comp_Creator;
      private bool comp_Creator_IsChanged=false;
      public string Comp_Creator
      {
         get{ return comp_Creator; }
         set{ comp_Creator = value; comp_Creator_IsChanged=true; }
      }
      public bool Comp_Creator_IsChanged
      {
         get{ return comp_Creator_IsChanged; }
         set{ comp_Creator_IsChanged = value; }
      }
      private DateTime comp_CreatTime;
      private bool comp_CreatTime_IsChanged=false;
      public DateTime Comp_CreatTime
      {
         get{ return comp_CreatTime; }
         set{ comp_CreatTime = value; comp_CreatTime_IsChanged=true; }
      }
      public bool Comp_CreatTime_IsChanged
      {
         get{ return comp_CreatTime_IsChanged; }
         set{ comp_CreatTime_IsChanged = value; }
      }
      private int comp_IsBusy;
      private bool comp_IsBusy_IsChanged=false;
      public int Comp_IsBusy
      {
         get{ return comp_IsBusy; }
         set{ comp_IsBusy = value; comp_IsBusy_IsChanged=true; }
      }
      public bool Comp_IsBusy_IsChanged
      {
         get{ return comp_IsBusy_IsChanged; }
         set{ comp_IsBusy_IsChanged = value; }
      }
      private string comp_Udef1;
      private bool comp_Udef1_IsChanged=false;
      public string Comp_Udef1
      {
         get{ return comp_Udef1; }
         set{ comp_Udef1 = value; comp_Udef1_IsChanged=true; }
      }
      public bool Comp_Udef1_IsChanged
      {
         get{ return comp_Udef1_IsChanged; }
         set{ comp_Udef1_IsChanged = value; }
      }
      private string comp_Udef2;
      private bool comp_Udef2_IsChanged=false;
      public string Comp_Udef2
      {
         get{ return comp_Udef2; }
         set{ comp_Udef2 = value; comp_Udef2_IsChanged=true; }
      }
      public bool Comp_Udef2_IsChanged
      {
         get{ return comp_Udef2_IsChanged; }
         set{ comp_Udef2_IsChanged = value; }
      }
   }
}
