using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 合同工程信息
   /// </summary>
   [Serializable]
   public partial class SD_Project
   {
      /// <summary>
      /// 工程信息序号
      /// </summary>
      private decimal sDI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_ID_IsChanged=false;
      /// <summary>
      /// 工程信息序号
      /// </summary>
      public decimal SDI_ID
      {
         get{ return sDI_ID; }
         set{ sDI_ID = value; sDI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 工程信息序号
      /// </summary>
      public bool SDI_ID_IsChanged
      {
         get{ return sDI_ID_IsChanged; }
         set{ sDI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 工程信息编码
      /// </summary>
      private string sDI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Code_IsChanged=false;
      /// <summary>
      /// 工程信息编码
      /// </summary>
      public string SDI_Code
      {
         get{ return sDI_Code; }
         set{ sDI_Code = value; sDI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 工程信息编码
      /// </summary>
      public bool SDI_Code_IsChanged
      {
         get{ return sDI_Code_IsChanged; }
         set{ sDI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDI_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDI_CCode
      {
         get{ return sDI_CCode; }
         set{ sDI_CCode = value; sDI_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDI_CCode_IsChanged
      {
         get{ return sDI_CCode_IsChanged; }
         set{ sDI_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string sDI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_MCode_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string SDI_MCode
      {
         get{ return sDI_MCode; }
         set{ sDI_MCode = value; sDI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool SDI_MCode_IsChanged
      {
         get{ return sDI_MCode_IsChanged; }
         set{ sDI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程名称
      /// </summary>
      private string sDI_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Name_IsChanged=false;
      /// <summary>
      /// 工程名称
      /// </summary>
      public string SDI_Name
      {
         get{ return sDI_Name; }
         set{ sDI_Name = value; sDI_Name_IsChanged=true; }
      }
      /// <summary>
      /// 工程名称
      /// </summary>
      public bool SDI_Name_IsChanged
      {
         get{ return sDI_Name_IsChanged; }
         set{ sDI_Name_IsChanged = value; }
      }
      /// <summary>
      /// 工程地点
      /// </summary>
      private string sDI_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Addr_IsChanged=false;
      /// <summary>
      /// 工程地点
      /// </summary>
      public string SDI_Addr
      {
         get{ return sDI_Addr; }
         set{ sDI_Addr = value; sDI_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 工程地点
      /// </summary>
      public bool SDI_Addr_IsChanged
      {
         get{ return sDI_Addr_IsChanged; }
         set{ sDI_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 工程概况
      /// </summary>
      private string sDI_Intro;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Intro_IsChanged=false;
      /// <summary>
      /// 工程概况
      /// </summary>
      public string SDI_Intro
      {
         get{ return sDI_Intro; }
         set{ sDI_Intro = value; sDI_Intro_IsChanged=true; }
      }
      /// <summary>
      /// 工程概况
      /// </summary>
      public bool SDI_Intro_IsChanged
      {
         get{ return sDI_Intro_IsChanged; }
         set{ sDI_Intro_IsChanged = value; }
      }
      /// <summary>
      /// 供货开始时间
      /// </summary>
      private DateTime sDI_Begin;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Begin_IsChanged=false;
      /// <summary>
      /// 供货开始时间
      /// </summary>
      public DateTime SDI_Begin
      {
         get{ return sDI_Begin; }
         set{ sDI_Begin = value; sDI_Begin_IsChanged=true; }
      }
      /// <summary>
      /// 供货开始时间
      /// </summary>
      public bool SDI_Begin_IsChanged
      {
         get{ return sDI_Begin_IsChanged; }
         set{ sDI_Begin_IsChanged = value; }
      }
      /// <summary>
      /// 供货结束时间
      /// </summary>
      private DateTime sDI_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_End_IsChanged=false;
      /// <summary>
      /// 供货结束时间
      /// </summary>
      public DateTime SDI_End
      {
         get{ return sDI_End; }
         set{ sDI_End = value; sDI_End_IsChanged=true; }
      }
      /// <summary>
      /// 供货结束时间
      /// </summary>
      public bool SDI_End_IsChanged
      {
         get{ return sDI_End_IsChanged; }
         set{ sDI_End_IsChanged = value; }
      }
      /// <summary>
      /// 项目跟进人
      /// </summary>
      private string sDI_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Owner_IsChanged=false;
      /// <summary>
      /// 项目跟进人
      /// </summary>
      public string SDI_Owner
      {
         get{ return sDI_Owner; }
         set{ sDI_Owner = value; sDI_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 项目跟进人
      /// </summary>
      public bool SDI_Owner_IsChanged
      {
         get{ return sDI_Owner_IsChanged; }
         set{ sDI_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 区域
      /// </summary>
      private string sDI_Area;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Area_IsChanged=false;
      /// <summary>
      /// 区域
      /// </summary>
      public string SDI_Area
      {
         get{ return sDI_Area; }
         set{ sDI_Area = value; sDI_Area_IsChanged=true; }
      }
      /// <summary>
      /// 区域
      /// </summary>
      public bool SDI_Area_IsChanged
      {
         get{ return sDI_Area_IsChanged; }
         set{ sDI_Area_IsChanged = value; }
      }
      /// <summary>
      /// 建设单位
      /// </summary>
      private string sDI_BCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_BCompany_IsChanged=false;
      /// <summary>
      /// 建设单位
      /// </summary>
      public string SDI_BCompany
      {
         get{ return sDI_BCompany; }
         set{ sDI_BCompany = value; sDI_BCompany_IsChanged=true; }
      }
      /// <summary>
      /// 建设单位
      /// </summary>
      public bool SDI_BCompany_IsChanged
      {
         get{ return sDI_BCompany_IsChanged; }
         set{ sDI_BCompany_IsChanged = value; }
      }
      /// <summary>
      /// 建设单位负责人
      /// </summary>
      private string sDI_BOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_BOwner_IsChanged=false;
      /// <summary>
      /// 建设单位负责人
      /// </summary>
      public string SDI_BOwner
      {
         get{ return sDI_BOwner; }
         set{ sDI_BOwner = value; sDI_BOwner_IsChanged=true; }
      }
      /// <summary>
      /// 建设单位负责人
      /// </summary>
      public bool SDI_BOwner_IsChanged
      {
         get{ return sDI_BOwner_IsChanged; }
         set{ sDI_BOwner_IsChanged = value; }
      }
      /// <summary>
      /// 建设单位负责人联系方式
      /// </summary>
      private string sDI_BContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_BContact_IsChanged=false;
      /// <summary>
      /// 建设单位负责人联系方式
      /// </summary>
      public string SDI_BContact
      {
         get{ return sDI_BContact; }
         set{ sDI_BContact = value; sDI_BContact_IsChanged=true; }
      }
      /// <summary>
      /// 建设单位负责人联系方式
      /// </summary>
      public bool SDI_BContact_IsChanged
      {
         get{ return sDI_BContact_IsChanged; }
         set{ sDI_BContact_IsChanged = value; }
      }
      /// <summary>
      /// 监理方
      /// </summary>
      private string sDI_CCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_CCompany_IsChanged=false;
      /// <summary>
      /// 监理方
      /// </summary>
      public string SDI_CCompany
      {
         get{ return sDI_CCompany; }
         set{ sDI_CCompany = value; sDI_CCompany_IsChanged=true; }
      }
      /// <summary>
      /// 监理方
      /// </summary>
      public bool SDI_CCompany_IsChanged
      {
         get{ return sDI_CCompany_IsChanged; }
         set{ sDI_CCompany_IsChanged = value; }
      }
      /// <summary>
      /// 监理方联系电话
      /// </summary>
      private string sDI_CContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_CContact_IsChanged=false;
      /// <summary>
      /// 监理方联系电话
      /// </summary>
      public string SDI_CContact
      {
         get{ return sDI_CContact; }
         set{ sDI_CContact = value; sDI_CContact_IsChanged=true; }
      }
      /// <summary>
      /// 监理方联系电话
      /// </summary>
      public bool SDI_CContact_IsChanged
      {
         get{ return sDI_CContact_IsChanged; }
         set{ sDI_CContact_IsChanged = value; }
      }
      /// <summary>
      /// 施工单位
      /// </summary>
      private string sDI_OCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_OCompany_IsChanged=false;
      /// <summary>
      /// 施工单位
      /// </summary>
      public string SDI_OCompany
      {
         get{ return sDI_OCompany; }
         set{ sDI_OCompany = value; sDI_OCompany_IsChanged=true; }
      }
      /// <summary>
      /// 施工单位
      /// </summary>
      public bool SDI_OCompany_IsChanged
      {
         get{ return sDI_OCompany_IsChanged; }
         set{ sDI_OCompany_IsChanged = value; }
      }
      /// <summary>
      /// 施工单位负责人
      /// </summary>
      private string sDI_OOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_OOwner_IsChanged=false;
      /// <summary>
      /// 施工单位负责人
      /// </summary>
      public string SDI_OOwner
      {
         get{ return sDI_OOwner; }
         set{ sDI_OOwner = value; sDI_OOwner_IsChanged=true; }
      }
      /// <summary>
      /// 施工单位负责人
      /// </summary>
      public bool SDI_OOwner_IsChanged
      {
         get{ return sDI_OOwner_IsChanged; }
         set{ sDI_OOwner_IsChanged = value; }
      }
      /// <summary>
      /// 施工单位负责人联系方式
      /// </summary>
      private string sDI_OContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_OContact_IsChanged=false;
      /// <summary>
      /// 施工单位负责人联系方式
      /// </summary>
      public string SDI_OContact
      {
         get{ return sDI_OContact; }
         set{ sDI_OContact = value; sDI_OContact_IsChanged=true; }
      }
      /// <summary>
      /// 施工单位负责人联系方式
      /// </summary>
      public bool SDI_OContact_IsChanged
      {
         get{ return sDI_OContact_IsChanged; }
         set{ sDI_OContact_IsChanged = value; }
      }
      /// <summary>
      /// 承建周期
      /// </summary>
      private string sDI_PPeriod;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_PPeriod_IsChanged=false;
      /// <summary>
      /// 承建周期
      /// </summary>
      public string SDI_PPeriod
      {
         get{ return sDI_PPeriod; }
         set{ sDI_PPeriod = value; sDI_PPeriod_IsChanged=true; }
      }
      /// <summary>
      /// 承建周期
      /// </summary>
      public bool SDI_PPeriod_IsChanged
      {
         get{ return sDI_PPeriod_IsChanged; }
         set{ sDI_PPeriod_IsChanged = value; }
      }
      /// <summary>
      /// 建筑面积
      /// </summary>
      private string sDI_PArea;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_PArea_IsChanged=false;
      /// <summary>
      /// 建筑面积
      /// </summary>
      public string SDI_PArea
      {
         get{ return sDI_PArea; }
         set{ sDI_PArea = value; sDI_PArea_IsChanged=true; }
      }
      /// <summary>
      /// 建筑面积
      /// </summary>
      public bool SDI_PArea_IsChanged
      {
         get{ return sDI_PArea_IsChanged; }
         set{ sDI_PArea_IsChanged = value; }
      }
      /// <summary>
      /// 工程结构
      /// </summary>
      private string sDI_PStructure;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_PStructure_IsChanged=false;
      /// <summary>
      /// 工程结构
      /// </summary>
      public string SDI_PStructure
      {
         get{ return sDI_PStructure; }
         set{ sDI_PStructure = value; sDI_PStructure_IsChanged=true; }
      }
      /// <summary>
      /// 工程结构
      /// </summary>
      public bool SDI_PStructure_IsChanged
      {
         get{ return sDI_PStructure_IsChanged; }
         set{ sDI_PStructure_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDI_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDI_Bak
      {
         get{ return sDI_Bak; }
         set{ sDI_Bak = value; sDI_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDI_Bak_IsChanged
      {
         get{ return sDI_Bak_IsChanged; }
         set{ sDI_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 参考工程编号
      /// </summary>
      private string sDI_RPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_RPCode_IsChanged=false;
      /// <summary>
      /// 参考工程编号
      /// </summary>
      public string SDI_RPCode
      {
         get{ return sDI_RPCode; }
         set{ sDI_RPCode = value; sDI_RPCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考工程编号
      /// </summary>
      public bool SDI_RPCode_IsChanged
      {
         get{ return sDI_RPCode_IsChanged; }
         set{ sDI_RPCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程状态
      /// </summary>
      private string sDI_PStatus;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_PStatus_IsChanged=false;
      /// <summary>
      /// 工程状态
      /// </summary>
      public string SDI_PStatus
      {
         get{ return sDI_PStatus; }
         set{ sDI_PStatus = value; sDI_PStatus_IsChanged=true; }
      }
      /// <summary>
      /// 工程状态
      /// </summary>
      public bool SDI_PStatus_IsChanged
      {
         get{ return sDI_PStatus_IsChanged; }
         set{ sDI_PStatus_IsChanged = value; }
      }
      /// <summary>
      /// 工程类别(潜在、活动)
      /// </summary>
      private string sDI_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDI_iType_IsChanged=false;
      /// <summary>
      /// 工程类别(潜在、活动)
      /// </summary>
      public string SDI_iType
      {
         get{ return sDI_iType; }
         set{ sDI_iType = value; sDI_iType_IsChanged=true; }
      }
      /// <summary>
      /// 工程类别(潜在、活动)
      /// </summary>
      public bool SDI_iType_IsChanged
      {
         get{ return sDI_iType_IsChanged; }
         set{ sDI_iType_IsChanged = value; }
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
      /// <summary>
      /// 方量
      /// </summary>
      private string sDl_Field;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDl_Field_IsChanged=false;
      /// <summary>
      /// 方量
      /// </summary>
      public string SDl_Field
      {
         get{ return sDl_Field; }
         set{ sDl_Field = value; sDl_Field_IsChanged=true; }
      }
      /// <summary>
      /// 方量
      /// </summary>
      public bool SDl_Field_IsChanged
      {
         get{ return sDl_Field_IsChanged; }
         set{ sDl_Field_IsChanged = value; }
      }
      /// <summary>
      /// 建立公司
      /// </summary>
      private string sDl_Build;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDl_Build_IsChanged=false;
      /// <summary>
      /// 建立公司
      /// </summary>
      public string SDl_Build
      {
         get{ return sDl_Build; }
         set{ sDl_Build = value; sDl_Build_IsChanged=true; }
      }
      /// <summary>
      /// 建立公司
      /// </summary>
      public bool SDl_Build_IsChanged
      {
         get{ return sDl_Build_IsChanged; }
         set{ sDl_Build_IsChanged = value; }
      }
      /// <summary>
      /// 中心实验室
      /// </summary>
      private string sDl_Laboratory;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDl_Laboratory_IsChanged=false;
      /// <summary>
      /// 中心实验室
      /// </summary>
      public string SDl_Laboratory
      {
         get{ return sDl_Laboratory; }
         set{ sDl_Laboratory = value; sDl_Laboratory_IsChanged=true; }
      }
      /// <summary>
      /// 中心实验室
      /// </summary>
      public bool SDl_Laboratory_IsChanged
      {
         get{ return sDl_Laboratory_IsChanged; }
         set{ sDl_Laboratory_IsChanged = value; }
      }
      private string sDI_Company;
      private bool sDI_Company_IsChanged=false;
      public string SDI_Company
      {
         get{ return sDI_Company; }
         set{ sDI_Company = value; sDI_Company_IsChanged=true; }
      }
      public bool SDI_Company_IsChanged
      {
         get{ return sDI_Company_IsChanged; }
         set{ sDI_Company_IsChanged = value; }
      }
      private string sDI_CompanyCode;
      private bool sDI_CompanyCode_IsChanged=false;
      public string SDI_CompanyCode
      {
         get{ return sDI_CompanyCode; }
         set{ sDI_CompanyCode = value; sDI_CompanyCode_IsChanged=true; }
      }
      public bool SDI_CompanyCode_IsChanged
      {
         get{ return sDI_CompanyCode_IsChanged; }
         set{ sDI_CompanyCode_IsChanged = value; }
      }
   }
}
