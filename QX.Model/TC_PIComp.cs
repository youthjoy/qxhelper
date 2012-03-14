using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产配合比信息
   /// </summary>
   [Serializable]
   public partial class TC_PIComp
   {
      private decimal tCPI_ID;
      private bool tCPI_ID_IsChanged=false;
      public decimal TCPI_ID
      {
         get{ return tCPI_ID; }
         set{ tCPI_ID = value; tCPI_ID_IsChanged=true; }
      }
      public bool TCPI_ID_IsChanged
      {
         get{ return tCPI_ID_IsChanged; }
         set{ tCPI_ID_IsChanged = value; }
      }
      private string tCPI_Code;
      private bool tCPI_Code_IsChanged=false;
      public string TCPI_Code
      {
         get{ return tCPI_Code; }
         set{ tCPI_Code = value; tCPI_Code_IsChanged=true; }
      }
      public bool TCPI_Code_IsChanged
      {
         get{ return tCPI_Code_IsChanged; }
         set{ tCPI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 配合比编码
      /// </summary>
      private string tCPI_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_PCode_IsChanged=false;
      /// <summary>
      /// 配合比编码
      /// </summary>
      public string TCPI_PCode
      {
         get{ return tCPI_PCode; }
         set{ tCPI_PCode = value; tCPI_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 配合比编码
      /// </summary>
      public bool TCPI_PCode_IsChanged
      {
         get{ return tCPI_PCode_IsChanged; }
         set{ tCPI_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓库编码
      /// </summary>
      private string tCPI_WCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_WCode_IsChanged=false;
      /// <summary>
      /// 仓库编码
      /// </summary>
      public string TCPI_WCode
      {
         get{ return tCPI_WCode; }
         set{ tCPI_WCode = value; tCPI_WCode_IsChanged=true; }
      }
      /// <summary>
      /// 仓库编码
      /// </summary>
      public bool TCPI_WCode_IsChanged
      {
         get{ return tCPI_WCode_IsChanged; }
         set{ tCPI_WCode_IsChanged = value; }
      }
      /// <summary>
      /// 仓号
      /// </summary>
      private string tCPI_WNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_WNo_IsChanged=false;
      /// <summary>
      /// 仓号
      /// </summary>
      public string TCPI_WNo
      {
         get{ return tCPI_WNo; }
         set{ tCPI_WNo = value; tCPI_WNo_IsChanged=true; }
      }
      /// <summary>
      /// 仓号
      /// </summary>
      public bool TCPI_WNo_IsChanged
      {
         get{ return tCPI_WNo_IsChanged; }
         set{ tCPI_WNo_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string tCPI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string TCPI_MCode
      {
         get{ return tCPI_MCode; }
         set{ tCPI_MCode = value; tCPI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool TCPI_MCode_IsChanged
      {
         get{ return tCPI_MCode_IsChanged; }
         set{ tCPI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string tCPI_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string TCPI_MName
      {
         get{ return tCPI_MName; }
         set{ tCPI_MName = value; tCPI_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool TCPI_MName_IsChanged
      {
         get{ return tCPI_MName_IsChanged; }
         set{ tCPI_MName_IsChanged = value; }
      }
      /// <summary>
      /// 基准配比
      /// </summary>
      private decimal tCPI_STNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_STNum_IsChanged=false;
      /// <summary>
      /// 基准配比
      /// </summary>
      public decimal TCPI_STNum
      {
         get{ return tCPI_STNum; }
         set{ tCPI_STNum = value; tCPI_STNum_IsChanged=true; }
      }
      /// <summary>
      /// 基准配比
      /// </summary>
      public bool TCPI_STNum_IsChanged
      {
         get{ return tCPI_STNum_IsChanged; }
         set{ tCPI_STNum_IsChanged = value; }
      }
      /// <summary>
      /// 单方配比
      /// </summary>
      private decimal tCPI_PCNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_PCNum_IsChanged=false;
      /// <summary>
      /// 单方配比
      /// </summary>
      public decimal TCPI_PCNum
      {
         get{ return tCPI_PCNum; }
         set{ tCPI_PCNum = value; tCPI_PCNum_IsChanged=true; }
      }
      /// <summary>
      /// 单方配比
      /// </summary>
      public bool TCPI_PCNum_IsChanged
      {
         get{ return tCPI_PCNum_IsChanged; }
         set{ tCPI_PCNum_IsChanged = value; }
      }
      /// <summary>
      /// 含水率
      /// </summary>
      private decimal tCPI_WatNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_WatNum_IsChanged=false;
      /// <summary>
      /// 含水率
      /// </summary>
      public decimal TCPI_WatNum
      {
         get{ return tCPI_WatNum; }
         set{ tCPI_WatNum = value; tCPI_WatNum_IsChanged=true; }
      }
      /// <summary>
      /// 含水率
      /// </summary>
      public bool TCPI_WatNum_IsChanged
      {
         get{ return tCPI_WatNum_IsChanged; }
         set{ tCPI_WatNum_IsChanged = value; }
      }
      /// <summary>
      /// 单方设定
      /// </summary>
      private decimal tCPI_OneNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_OneNum_IsChanged=false;
      /// <summary>
      /// 单方设定
      /// </summary>
      public decimal TCPI_OneNum
      {
         get{ return tCPI_OneNum; }
         set{ tCPI_OneNum = value; tCPI_OneNum_IsChanged=true; }
      }
      /// <summary>
      /// 单方设定
      /// </summary>
      public bool TCPI_OneNum_IsChanged
      {
         get{ return tCPI_OneNum_IsChanged; }
         set{ tCPI_OneNum_IsChanged = value; }
      }
      /// <summary>
      /// 物料类别编码
      /// </summary>
      private string tCPI_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCPI_CCode_IsChanged=false;
      /// <summary>
      /// 物料类别编码
      /// </summary>
      public string TCPI_CCode
      {
         get{ return tCPI_CCode; }
         set{ tCPI_CCode = value; tCPI_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料类别编码
      /// </summary>
      public bool TCPI_CCode_IsChanged
      {
         get{ return tCPI_CCode_IsChanged; }
         set{ tCPI_CCode_IsChanged = value; }
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
