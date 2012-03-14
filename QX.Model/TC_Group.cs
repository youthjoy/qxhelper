using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 试组信息
   /// </summary>
   [Serializable]
   public partial class TC_Group
   {
      private decimal tCG_ID;
      private bool tCG_ID_IsChanged=false;
      public decimal TCG_ID
      {
         get{ return tCG_ID; }
         set{ tCG_ID = value; tCG_ID_IsChanged=true; }
      }
      public bool TCG_ID_IsChanged
      {
         get{ return tCG_ID_IsChanged; }
         set{ tCG_ID_IsChanged = value; }
      }
      /// <summary>
      /// 试组编码
      /// </summary>
      private string tCG_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_Code_IsChanged=false;
      /// <summary>
      /// 试组编码
      /// </summary>
      public string TCG_Code
      {
         get{ return tCG_Code; }
         set{ tCG_Code = value; tCG_Code_IsChanged=true; }
      }
      /// <summary>
      /// 试组编码
      /// </summary>
      public bool TCG_Code_IsChanged
      {
         get{ return tCG_Code_IsChanged; }
         set{ tCG_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string tCG_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string TCG_CCode
      {
         get{ return tCG_CCode; }
         set{ tCG_CCode = value; tCG_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool TCG_CCode_IsChanged
      {
         get{ return tCG_CCode_IsChanged; }
         set{ tCG_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      private string tCG_PRCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_PRCode_IsChanged=false;
      /// <summary>
      /// 工程编码
      /// </summary>
      public string TCG_PRCode
      {
         get{ return tCG_PRCode; }
         set{ tCG_PRCode = value; tCG_PRCode_IsChanged=true; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      public bool TCG_PRCode_IsChanged
      {
         get{ return tCG_PRCode_IsChanged; }
         set{ tCG_PRCode_IsChanged = value; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      private string tCG_PPCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_PPCode_IsChanged=false;
      /// <summary>
      /// 计划编码
      /// </summary>
      public string TCG_PPCode
      {
         get{ return tCG_PPCode; }
         set{ tCG_PPCode = value; tCG_PPCode_IsChanged=true; }
      }
      /// <summary>
      /// 计划编码
      /// </summary>
      public bool TCG_PPCode_IsChanged
      {
         get{ return tCG_PPCode_IsChanged; }
         set{ tCG_PPCode_IsChanged = value; }
      }
      /// <summary>
      /// 发货单号
      /// </summary>
      private string tCG_PDCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_PDCode_IsChanged=false;
      /// <summary>
      /// 发货单号
      /// </summary>
      public string TCG_PDCode
      {
         get{ return tCG_PDCode; }
         set{ tCG_PDCode = value; tCG_PDCode_IsChanged=true; }
      }
      /// <summary>
      /// 发货单号
      /// </summary>
      public bool TCG_PDCode_IsChanged
      {
         get{ return tCG_PDCode_IsChanged; }
         set{ tCG_PDCode_IsChanged = value; }
      }
      /// <summary>
      /// 试验者
      /// </summary>
      private string tCG_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_Owner_IsChanged=false;
      /// <summary>
      /// 试验者
      /// </summary>
      public string TCG_Owner
      {
         get{ return tCG_Owner; }
         set{ tCG_Owner = value; tCG_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 试验者
      /// </summary>
      public bool TCG_Owner_IsChanged
      {
         get{ return tCG_Owner_IsChanged; }
         set{ tCG_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 试验时间
      /// </summary>
      private DateTime tCG_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_Date_IsChanged=false;
      /// <summary>
      /// 试验时间
      /// </summary>
      public DateTime TCG_Date
      {
         get{ return tCG_Date; }
         set{ tCG_Date = value; tCG_Date_IsChanged=true; }
      }
      /// <summary>
      /// 试验时间
      /// </summary>
      public bool TCG_Date_IsChanged
      {
         get{ return tCG_Date_IsChanged; }
         set{ tCG_Date_IsChanged = value; }
      }
      /// <summary>
      /// 试块类型
      /// </summary>
      private string tCG_GType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_GType_IsChanged=false;
      /// <summary>
      /// 试块类型
      /// </summary>
      public string TCG_GType
      {
         get{ return tCG_GType; }
         set{ tCG_GType = value; tCG_GType_IsChanged=true; }
      }
      /// <summary>
      /// 试块类型
      /// </summary>
      public bool TCG_GType_IsChanged
      {
         get{ return tCG_GType_IsChanged; }
         set{ tCG_GType_IsChanged = value; }
      }
      /// <summary>
      /// 检验类型
      /// </summary>
      private string tCG_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_iType_IsChanged=false;
      /// <summary>
      /// 检验类型
      /// </summary>
      public string TCG_iType
      {
         get{ return tCG_iType; }
         set{ tCG_iType = value; tCG_iType_IsChanged=true; }
      }
      /// <summary>
      /// 检验类型
      /// </summary>
      public bool TCG_iType_IsChanged
      {
         get{ return tCG_iType_IsChanged; }
         set{ tCG_iType_IsChanged = value; }
      }
      /// <summary>
      /// 粘聚性
      /// </summary>
      private int tCG_iNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_iNum_IsChanged=false;
      /// <summary>
      /// 粘聚性
      /// </summary>
      public int TCG_iNum
      {
         get{ return tCG_iNum; }
         set{ tCG_iNum = value; tCG_iNum_IsChanged=true; }
      }
      /// <summary>
      /// 粘聚性
      /// </summary>
      public bool TCG_iNum_IsChanged
      {
         get{ return tCG_iNum_IsChanged; }
         set{ tCG_iNum_IsChanged = value; }
      }
      /// <summary>
      /// 保水性
      /// </summary>
      private string tCG_KWater;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_KWater_IsChanged=false;
      /// <summary>
      /// 保水性
      /// </summary>
      public string TCG_KWater
      {
         get{ return tCG_KWater; }
         set{ tCG_KWater = value; tCG_KWater_IsChanged=true; }
      }
      /// <summary>
      /// 保水性
      /// </summary>
      public bool TCG_KWater_IsChanged
      {
         get{ return tCG_KWater_IsChanged; }
         set{ tCG_KWater_IsChanged = value; }
      }
      /// <summary>
      /// 拌合及捣实方式
      /// </summary>
      private string tCG_BType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_BType_IsChanged=false;
      /// <summary>
      /// 拌合及捣实方式
      /// </summary>
      public string TCG_BType
      {
         get{ return tCG_BType; }
         set{ tCG_BType = value; tCG_BType_IsChanged=true; }
      }
      /// <summary>
      /// 拌合及捣实方式
      /// </summary>
      public bool TCG_BType_IsChanged
      {
         get{ return tCG_BType_IsChanged; }
         set{ tCG_BType_IsChanged = value; }
      }
      /// <summary>
      /// 养护方式
      /// </summary>
      private string tCG_YType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_YType_IsChanged=false;
      /// <summary>
      /// 养护方式
      /// </summary>
      public string TCG_YType
      {
         get{ return tCG_YType; }
         set{ tCG_YType = value; tCG_YType_IsChanged=true; }
      }
      /// <summary>
      /// 养护方式
      /// </summary>
      public bool TCG_YType_IsChanged
      {
         get{ return tCG_YType_IsChanged; }
         set{ tCG_YType_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板编码
      /// </summary>
      private string tCG_TCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCG_TCode_IsChanged=false;
      /// <summary>
      /// 检测模板编码
      /// </summary>
      public string TCG_TCode
      {
         get{ return tCG_TCode; }
         set{ tCG_TCode = value; tCG_TCode_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板编码
      /// </summary>
      public bool TCG_TCode_IsChanged
      {
         get{ return tCG_TCode_IsChanged; }
         set{ tCG_TCode_IsChanged = value; }
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
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
   }
}
