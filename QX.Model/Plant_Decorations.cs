using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 植物摆放位置
   /// </summary>
   [Serializable]
   public partial class Plant_Decorations
   {
      /// <summary>
      /// 植物摆饰序号
      /// </summary>
      private decimal pD_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_ID_IsChanged=false;
      /// <summary>
      /// 植物摆饰序号
      /// </summary>
      public decimal PD_ID
      {
         get{ return pD_ID; }
         set{ pD_ID = value; pD_ID_IsChanged=true; }
      }
      /// <summary>
      /// 植物摆饰序号
      /// </summary>
      public bool PD_ID_IsChanged
      {
         get{ return pD_ID_IsChanged; }
         set{ pD_ID_IsChanged = value; }
      }
      /// <summary>
      /// 植物摆饰编码
      /// </summary>
      private string pD_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_Code_IsChanged=false;
      /// <summary>
      /// 植物摆饰编码
      /// </summary>
      public string PD_Code
      {
         get{ return pD_Code; }
         set{ pD_Code = value; pD_Code_IsChanged=true; }
      }
      /// <summary>
      /// 植物摆饰编码
      /// </summary>
      public bool PD_Code_IsChanged
      {
         get{ return pD_Code_IsChanged; }
         set{ pD_Code_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string pD_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string PD_Company
      {
         get{ return pD_Company; }
         set{ pD_Company = value; pD_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool PD_Company_IsChanged
      {
         get{ return pD_Company_IsChanged; }
         set{ pD_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string pD_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string PD_Dept
      {
         get{ return pD_Dept; }
         set{ pD_Dept = value; pD_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool PD_Dept_IsChanged
      {
         get{ return pD_Dept_IsChanged; }
         set{ pD_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 摆放楼层
      /// </summary>
      private string pD_Floor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_Floor_IsChanged=false;
      /// <summary>
      /// 摆放楼层
      /// </summary>
      public string PD_Floor
      {
         get{ return pD_Floor; }
         set{ pD_Floor = value; pD_Floor_IsChanged=true; }
      }
      /// <summary>
      /// 摆放楼层
      /// </summary>
      public bool PD_Floor_IsChanged
      {
         get{ return pD_Floor_IsChanged; }
         set{ pD_Floor_IsChanged = value; }
      }
      /// <summary>
      /// 摆放位置
      /// </summary>
      private string pD_Position;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_Position_IsChanged=false;
      /// <summary>
      /// 摆放位置
      /// </summary>
      public string PD_Position
      {
         get{ return pD_Position; }
         set{ pD_Position = value; pD_Position_IsChanged=true; }
      }
      /// <summary>
      /// 摆放位置
      /// </summary>
      public bool PD_Position_IsChanged
      {
         get{ return pD_Position_IsChanged; }
         set{ pD_Position_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pD_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pD_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PD_Remark
      {
         get{ return pD_Remark; }
         set{ pD_Remark = value; pD_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PD_Remark_IsChanged
      {
         get{ return pD_Remark_IsChanged; }
         set{ pD_Remark_IsChanged = value; }
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
   }
}
