using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 地磅计量信息
   /// </summary>
   [Serializable]
   public partial class Loadometer_Usage
   {
      /// <summary>
      /// 地磅信息序号
      /// </summary>
      private decimal loadometer_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_ID_IsChanged=false;
      /// <summary>
      /// 地磅信息序号
      /// </summary>
      public decimal Loadometer_ID
      {
         get{ return loadometer_ID; }
         set{ loadometer_ID = value; loadometer_ID_IsChanged=true; }
      }
      /// <summary>
      /// 地磅信息序号
      /// </summary>
      public bool Loadometer_ID_IsChanged
      {
         get{ return loadometer_ID_IsChanged; }
         set{ loadometer_ID_IsChanged = value; }
      }
      /// <summary>
      /// 地磅信息编码
      /// </summary>
      private string loadometer_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Code_IsChanged=false;
      /// <summary>
      /// 地磅信息编码
      /// </summary>
      public string Loadometer_Code
      {
         get{ return loadometer_Code; }
         set{ loadometer_Code = value; loadometer_Code_IsChanged=true; }
      }
      /// <summary>
      /// 地磅信息编码
      /// </summary>
      public bool Loadometer_Code_IsChanged
      {
         get{ return loadometer_Code_IsChanged; }
         set{ loadometer_Code_IsChanged = value; }
      }
      /// <summary>
      /// 计量单位
      /// </summary>
      private string loadometer_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Unit_IsChanged=false;
      /// <summary>
      /// 计量单位
      /// </summary>
      public string Loadometer_Unit
      {
         get{ return loadometer_Unit; }
         set{ loadometer_Unit = value; loadometer_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 计量单位
      /// </summary>
      public bool Loadometer_Unit_IsChanged
      {
         get{ return loadometer_Unit_IsChanged; }
         set{ loadometer_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 计量误差
      /// </summary>
      private float loadometer_Error;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Error_IsChanged=false;
      /// <summary>
      /// 计量误差
      /// </summary>
      public float Loadometer_Error
      {
         get{ return loadometer_Error; }
         set{ loadometer_Error = value; loadometer_Error_IsChanged=true; }
      }
      /// <summary>
      /// 计量误差
      /// </summary>
      public bool Loadometer_Error_IsChanged
      {
         get{ return loadometer_Error_IsChanged; }
         set{ loadometer_Error_IsChanged = value; }
      }
      /// <summary>
      /// 计量车牌号
      /// </summary>
      private string loadometer_No;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_No_IsChanged=false;
      /// <summary>
      /// 计量车牌号
      /// </summary>
      public string Loadometer_No
      {
         get{ return loadometer_No; }
         set{ loadometer_No = value; loadometer_No_IsChanged=true; }
      }
      /// <summary>
      /// 计量车牌号
      /// </summary>
      public bool Loadometer_No_IsChanged
      {
         get{ return loadometer_No_IsChanged; }
         set{ loadometer_No_IsChanged = value; }
      }
      /// <summary>
      /// 计量时间
      /// </summary>
      private DateTime loadometer_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Date_IsChanged=false;
      /// <summary>
      /// 计量时间
      /// </summary>
      public DateTime Loadometer_Date
      {
         get{ return loadometer_Date; }
         set{ loadometer_Date = value; loadometer_Date_IsChanged=true; }
      }
      /// <summary>
      /// 计量时间
      /// </summary>
      public bool Loadometer_Date_IsChanged
      {
         get{ return loadometer_Date_IsChanged; }
         set{ loadometer_Date_IsChanged = value; }
      }
      /// <summary>
      /// 发货单位编码
      /// </summary>
      private string loadometer_Delivery;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Delivery_IsChanged=false;
      /// <summary>
      /// 发货单位编码
      /// </summary>
      public string Loadometer_Delivery
      {
         get{ return loadometer_Delivery; }
         set{ loadometer_Delivery = value; loadometer_Delivery_IsChanged=true; }
      }
      /// <summary>
      /// 发货单位编码
      /// </summary>
      public bool Loadometer_Delivery_IsChanged
      {
         get{ return loadometer_Delivery_IsChanged; }
         set{ loadometer_Delivery_IsChanged = value; }
      }
      /// <summary>
      /// 收货单位编码
      /// </summary>
      private string loadometer_Receive;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Receive_IsChanged=false;
      /// <summary>
      /// 收货单位编码
      /// </summary>
      public string Loadometer_Receive
      {
         get{ return loadometer_Receive; }
         set{ loadometer_Receive = value; loadometer_Receive_IsChanged=true; }
      }
      /// <summary>
      /// 收货单位编码
      /// </summary>
      public bool Loadometer_Receive_IsChanged
      {
         get{ return loadometer_Receive_IsChanged; }
         set{ loadometer_Receive_IsChanged = value; }
      }
      /// <summary>
      /// 过磅类别
      /// </summary>
      private string loadometer_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Type_IsChanged=false;
      /// <summary>
      /// 过磅类别
      /// </summary>
      public string Loadometer_Type
      {
         get{ return loadometer_Type; }
         set{ loadometer_Type = value; loadometer_Type_IsChanged=true; }
      }
      /// <summary>
      /// 过磅类别
      /// </summary>
      public bool Loadometer_Type_IsChanged
      {
         get{ return loadometer_Type_IsChanged; }
         set{ loadometer_Type_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string loadometer_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string Loadometer_iType
      {
         get{ return loadometer_iType; }
         set{ loadometer_iType = value; loadometer_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool Loadometer_iType_IsChanged
      {
         get{ return loadometer_iType_IsChanged; }
         set{ loadometer_iType_IsChanged = value; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      private decimal loadometer_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Price_IsChanged=false;
      /// <summary>
      /// 单价
      /// </summary>
      public decimal Loadometer_Price
      {
         get{ return loadometer_Price; }
         set{ loadometer_Price = value; loadometer_Price_IsChanged=true; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      public bool Loadometer_Price_IsChanged
      {
         get{ return loadometer_Price_IsChanged; }
         set{ loadometer_Price_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal loadometer_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Amount_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal Loadometer_Amount
      {
         get{ return loadometer_Amount; }
         set{ loadometer_Amount = value; loadometer_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool Loadometer_Amount_IsChanged
      {
         get{ return loadometer_Amount_IsChanged; }
         set{ loadometer_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 司磅员名称
      /// </summary>
      private string loadometer_PounderName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_PounderName_IsChanged=false;
      /// <summary>
      /// 司磅员名称
      /// </summary>
      public string Loadometer_PounderName
      {
         get{ return loadometer_PounderName; }
         set{ loadometer_PounderName = value; loadometer_PounderName_IsChanged=true; }
      }
      /// <summary>
      /// 司磅员名称
      /// </summary>
      public bool Loadometer_PounderName_IsChanged
      {
         get{ return loadometer_PounderName_IsChanged; }
         set{ loadometer_PounderName_IsChanged = value; }
      }
      /// <summary>
      /// 司磅员
      /// </summary>
      private string loadometer_Pounder;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Pounder_IsChanged=false;
      /// <summary>
      /// 司磅员
      /// </summary>
      public string Loadometer_Pounder
      {
         get{ return loadometer_Pounder; }
         set{ loadometer_Pounder = value; loadometer_Pounder_IsChanged=true; }
      }
      /// <summary>
      /// 司磅员
      /// </summary>
      public bool Loadometer_Pounder_IsChanged
      {
         get{ return loadometer_Pounder_IsChanged; }
         set{ loadometer_Pounder_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string loadometer_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string Loadometer_MName
      {
         get{ return loadometer_MName; }
         set{ loadometer_MName = value; loadometer_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool Loadometer_MName_IsChanged
      {
         get{ return loadometer_MName_IsChanged; }
         set{ loadometer_MName_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string loadometer_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string Loadometer_MCode
      {
         get{ return loadometer_MCode; }
         set{ loadometer_MCode = value; loadometer_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool Loadometer_MCode_IsChanged
      {
         get{ return loadometer_MCode_IsChanged; }
         set{ loadometer_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 承运单位编码
      /// </summary>
      private string loadometer_Transport;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Transport_IsChanged=false;
      /// <summary>
      /// 承运单位编码
      /// </summary>
      public string Loadometer_Transport
      {
         get{ return loadometer_Transport; }
         set{ loadometer_Transport = value; loadometer_Transport_IsChanged=true; }
      }
      /// <summary>
      /// 承运单位编码
      /// </summary>
      public bool Loadometer_Transport_IsChanged
      {
         get{ return loadometer_Transport_IsChanged; }
         set{ loadometer_Transport_IsChanged = value; }
      }
      /// <summary>
      /// 承运单位名称
      /// </summary>
      private string loadometer_TransportName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_TransportName_IsChanged=false;
      /// <summary>
      /// 承运单位名称
      /// </summary>
      public string Loadometer_TransportName
      {
         get{ return loadometer_TransportName; }
         set{ loadometer_TransportName = value; loadometer_TransportName_IsChanged=true; }
      }
      /// <summary>
      /// 承运单位名称
      /// </summary>
      public bool Loadometer_TransportName_IsChanged
      {
         get{ return loadometer_TransportName_IsChanged; }
         set{ loadometer_TransportName_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶员编码
      /// </summary>
      private string loadometer_Pilot;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Pilot_IsChanged=false;
      /// <summary>
      /// 驾驶员编码
      /// </summary>
      public string Loadometer_Pilot
      {
         get{ return loadometer_Pilot; }
         set{ loadometer_Pilot = value; loadometer_Pilot_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶员编码
      /// </summary>
      public bool Loadometer_Pilot_IsChanged
      {
         get{ return loadometer_Pilot_IsChanged; }
         set{ loadometer_Pilot_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      private string loadometer_PilotName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_PilotName_IsChanged=false;
      /// <summary>
      /// 驾驶员
      /// </summary>
      public string Loadometer_PilotName
      {
         get{ return loadometer_PilotName; }
         set{ loadometer_PilotName = value; loadometer_PilotName_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      public bool Loadometer_PilotName_IsChanged
      {
         get{ return loadometer_PilotName_IsChanged; }
         set{ loadometer_PilotName_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string loadometer_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool loadometer_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Loadometer_Remark
      {
         get{ return loadometer_Remark; }
         set{ loadometer_Remark = value; loadometer_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Loadometer_Remark_IsChanged
      {
         get{ return loadometer_Remark_IsChanged; }
         set{ loadometer_Remark_IsChanged = value; }
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
   }
}
