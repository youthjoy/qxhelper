using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 印章基本信息
   /// </summary>
   [Serializable]
   public partial class GM_Seal
   {
      /// <summary>
      /// 印章编号
      /// </summary>
      private decimal gMSE_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_ID_IsChanged=false;
      /// <summary>
      /// 印章编号
      /// </summary>
      public decimal GMSE_ID
      {
         get{ return gMSE_ID; }
         set{ gMSE_ID = value; gMSE_ID_IsChanged=true; }
      }
      /// <summary>
      /// 印章编号
      /// </summary>
      public bool GMSE_ID_IsChanged
      {
         get{ return gMSE_ID_IsChanged; }
         set{ gMSE_ID_IsChanged = value; }
      }
      /// <summary>
      /// 印章编码
      /// </summary>
      private string gMSE_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Code_IsChanged=false;
      /// <summary>
      /// 印章编码
      /// </summary>
      public string GMSE_Code
      {
         get{ return gMSE_Code; }
         set{ gMSE_Code = value; gMSE_Code_IsChanged=true; }
      }
      /// <summary>
      /// 印章编码
      /// </summary>
      public bool GMSE_Code_IsChanged
      {
         get{ return gMSE_Code_IsChanged; }
         set{ gMSE_Code_IsChanged = value; }
      }
      /// <summary>
      /// 印章名称
      /// </summary>
      private string gMSE_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Name_IsChanged=false;
      /// <summary>
      /// 印章名称
      /// </summary>
      public string GMSE_Name
      {
         get{ return gMSE_Name; }
         set{ gMSE_Name = value; gMSE_Name_IsChanged=true; }
      }
      /// <summary>
      /// 印章名称
      /// </summary>
      public bool GMSE_Name_IsChanged
      {
         get{ return gMSE_Name_IsChanged; }
         set{ gMSE_Name_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string gMSE_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_CompanyCode_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string GMSE_CompanyCode
      {
         get{ return gMSE_CompanyCode; }
         set{ gMSE_CompanyCode = value; gMSE_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool GMSE_CompanyCode_IsChanged
      {
         get{ return gMSE_CompanyCode_IsChanged; }
         set{ gMSE_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string gMSE_DeptCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_DeptCode_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string GMSE_DeptCode
      {
         get{ return gMSE_DeptCode; }
         set{ gMSE_DeptCode = value; gMSE_DeptCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool GMSE_DeptCode_IsChanged
      {
         get{ return gMSE_DeptCode_IsChanged; }
         set{ gMSE_DeptCode_IsChanged = value; }
      }
      /// <summary>
      /// 印章使用说明
      /// </summary>
      private string gMSE_Intro;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Intro_IsChanged=false;
      /// <summary>
      /// 印章使用说明
      /// </summary>
      public string GMSE_Intro
      {
         get{ return gMSE_Intro; }
         set{ gMSE_Intro = value; gMSE_Intro_IsChanged=true; }
      }
      /// <summary>
      /// 印章使用说明
      /// </summary>
      public bool GMSE_Intro_IsChanged
      {
         get{ return gMSE_Intro_IsChanged; }
         set{ gMSE_Intro_IsChanged = value; }
      }
      /// <summary>
      /// 内置类型
      /// </summary>
      private string gMSE_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_iType_IsChanged=false;
      /// <summary>
      /// 内置类型
      /// </summary>
      public string GMSE_iType
      {
         get{ return gMSE_iType; }
         set{ gMSE_iType = value; gMSE_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内置类型
      /// </summary>
      public bool GMSE_iType_IsChanged
      {
         get{ return gMSE_iType_IsChanged; }
         set{ gMSE_iType_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string gMSE_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string GMSE_Bak
      {
         get{ return gMSE_Bak; }
         set{ gMSE_Bak = value; gMSE_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool GMSE_Bak_IsChanged
      {
         get{ return gMSE_Bak_IsChanged; }
         set{ gMSE_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      private string gMSE_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Owner_IsChanged=false;
      /// <summary>
      /// 责任人
      /// </summary>
      public string GMSE_Owner
      {
         get{ return gMSE_Owner; }
         set{ gMSE_Owner = value; gMSE_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      public bool GMSE_Owner_IsChanged
      {
         get{ return gMSE_Owner_IsChanged; }
         set{ gMSE_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 责任联系电话
      /// </summary>
      private string gMSE_Tel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Tel_IsChanged=false;
      /// <summary>
      /// 责任联系电话
      /// </summary>
      public string GMSE_Tel
      {
         get{ return gMSE_Tel; }
         set{ gMSE_Tel = value; gMSE_Tel_IsChanged=true; }
      }
      /// <summary>
      /// 责任联系电话
      /// </summary>
      public bool GMSE_Tel_IsChanged
      {
         get{ return gMSE_Tel_IsChanged; }
         set{ gMSE_Tel_IsChanged = value; }
      }
      /// <summary>
      /// 印章类型
      /// </summary>
      private string gMSE_Cat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool gMSE_Cat_IsChanged=false;
      /// <summary>
      /// 印章类型
      /// </summary>
      public string GMSE_Cat
      {
         get{ return gMSE_Cat; }
         set{ gMSE_Cat = value; gMSE_Cat_IsChanged=true; }
      }
      /// <summary>
      /// 印章类型
      /// </summary>
      public bool GMSE_Cat_IsChanged
      {
         get{ return gMSE_Cat_IsChanged; }
         set{ gMSE_Cat_IsChanged = value; }
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
