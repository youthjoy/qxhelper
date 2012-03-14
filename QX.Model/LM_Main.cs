using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 地磅计量信息
   /// </summary>
   [Serializable]
   public partial class LM_Main
   {
      /// <summary>
      /// 地磅信息序号
      /// </summary>
      private decimal lM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_ID_IsChanged=false;
      /// <summary>
      /// 地磅信息序号
      /// </summary>
      public decimal LM_ID
      {
         get{ return lM_ID; }
         set{ lM_ID = value; lM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 地磅信息序号
      /// </summary>
      public bool LM_ID_IsChanged
      {
         get{ return lM_ID_IsChanged; }
         set{ lM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 地磅信息编码
      /// </summary>
      private string lM_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Code_IsChanged=false;
      /// <summary>
      /// 地磅信息编码
      /// </summary>
      public string LM_Code
      {
         get{ return lM_Code; }
         set{ lM_Code = value; lM_Code_IsChanged=true; }
      }
      /// <summary>
      /// 地磅信息编码
      /// </summary>
      public bool LM_Code_IsChanged
      {
         get{ return lM_Code_IsChanged; }
         set{ lM_Code_IsChanged = value; }
      }
      /// <summary>
      /// 计量单位
      /// </summary>
      private string lM_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Unit_IsChanged=false;
      /// <summary>
      /// 计量单位
      /// </summary>
      public string LM_Unit
      {
         get{ return lM_Unit; }
         set{ lM_Unit = value; lM_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 计量单位
      /// </summary>
      public bool LM_Unit_IsChanged
      {
         get{ return lM_Unit_IsChanged; }
         set{ lM_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 计量误差
      /// </summary>
      private decimal lM_Error;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Error_IsChanged=false;
      /// <summary>
      /// 计量误差
      /// </summary>
      public decimal LM_Error
      {
         get{ return lM_Error; }
         set{ lM_Error = value; lM_Error_IsChanged=true; }
      }
      /// <summary>
      /// 计量误差
      /// </summary>
      public bool LM_Error_IsChanged
      {
         get{ return lM_Error_IsChanged; }
         set{ lM_Error_IsChanged = value; }
      }
      /// <summary>
      /// 计量车牌号
      /// </summary>
      private string lM_No;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_No_IsChanged=false;
      /// <summary>
      /// 计量车牌号
      /// </summary>
      public string LM_No
      {
         get{ return lM_No; }
         set{ lM_No = value; lM_No_IsChanged=true; }
      }
      /// <summary>
      /// 计量车牌号
      /// </summary>
      public bool LM_No_IsChanged
      {
         get{ return lM_No_IsChanged; }
         set{ lM_No_IsChanged = value; }
      }
      /// <summary>
      /// 计量时间
      /// </summary>
      private DateTime lM_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Date_IsChanged=false;
      /// <summary>
      /// 计量时间
      /// </summary>
      public DateTime LM_Date
      {
         get{ return lM_Date; }
         set{ lM_Date = value; lM_Date_IsChanged=true; }
      }
      /// <summary>
      /// 计量时间
      /// </summary>
      public bool LM_Date_IsChanged
      {
         get{ return lM_Date_IsChanged; }
         set{ lM_Date_IsChanged = value; }
      }
      /// <summary>
      /// 毛重
      /// </summary>
      private decimal lM_GW;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_GW_IsChanged=false;
      /// <summary>
      /// 毛重
      /// </summary>
      public decimal LM_GW
      {
         get{ return lM_GW; }
         set{ lM_GW = value; lM_GW_IsChanged=true; }
      }
      /// <summary>
      /// 毛重
      /// </summary>
      public bool LM_GW_IsChanged
      {
         get{ return lM_GW_IsChanged; }
         set{ lM_GW_IsChanged = value; }
      }
      /// <summary>
      /// 净重
      /// </summary>
      private decimal lM_NWeight;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_NWeight_IsChanged=false;
      /// <summary>
      /// 净重
      /// </summary>
      public decimal LM_NWeight
      {
         get{ return lM_NWeight; }
         set{ lM_NWeight = value; lM_NWeight_IsChanged=true; }
      }
      /// <summary>
      /// 净重
      /// </summary>
      public bool LM_NWeight_IsChanged
      {
         get{ return lM_NWeight_IsChanged; }
         set{ lM_NWeight_IsChanged = value; }
      }
      /// <summary>
      /// 皮重
      /// </summary>
      private decimal lM_TareWeight;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_TareWeight_IsChanged=false;
      /// <summary>
      /// 皮重
      /// </summary>
      public decimal LM_TareWeight
      {
         get{ return lM_TareWeight; }
         set{ lM_TareWeight = value; lM_TareWeight_IsChanged=true; }
      }
      /// <summary>
      /// 皮重
      /// </summary>
      public bool LM_TareWeight_IsChanged
      {
         get{ return lM_TareWeight_IsChanged; }
         set{ lM_TareWeight_IsChanged = value; }
      }
      /// <summary>
      /// 结算重量
      /// </summary>
      private decimal lM_LastWeight;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_LastWeight_IsChanged=false;
      /// <summary>
      /// 结算重量
      /// </summary>
      public decimal LM_LastWeight
      {
         get{ return lM_LastWeight; }
         set{ lM_LastWeight = value; lM_LastWeight_IsChanged=true; }
      }
      /// <summary>
      /// 结算重量
      /// </summary>
      public bool LM_LastWeight_IsChanged
      {
         get{ return lM_LastWeight_IsChanged; }
         set{ lM_LastWeight_IsChanged = value; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      private string lM_RType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_RType_IsChanged=false;
      /// <summary>
      /// 单据类型
      /// </summary>
      public string LM_RType
      {
         get{ return lM_RType; }
         set{ lM_RType = value; lM_RType_IsChanged=true; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      public bool LM_RType_IsChanged
      {
         get{ return lM_RType_IsChanged; }
         set{ lM_RType_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string lM_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_RCode_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string LM_RCode
      {
         get{ return lM_RCode; }
         set{ lM_RCode = value; lM_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool LM_RCode_IsChanged
      {
         get{ return lM_RCode_IsChanged; }
         set{ lM_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 发货单位编码
      /// </summary>
      private string lM_Delivery;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Delivery_IsChanged=false;
      /// <summary>
      /// 发货单位编码
      /// </summary>
      public string LM_Delivery
      {
         get{ return lM_Delivery; }
         set{ lM_Delivery = value; lM_Delivery_IsChanged=true; }
      }
      /// <summary>
      /// 发货单位编码
      /// </summary>
      public bool LM_Delivery_IsChanged
      {
         get{ return lM_Delivery_IsChanged; }
         set{ lM_Delivery_IsChanged = value; }
      }
      /// <summary>
      /// 收货单位编码
      /// </summary>
      private string lM_Receive;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Receive_IsChanged=false;
      /// <summary>
      /// 收货单位编码
      /// </summary>
      public string LM_Receive
      {
         get{ return lM_Receive; }
         set{ lM_Receive = value; lM_Receive_IsChanged=true; }
      }
      /// <summary>
      /// 收货单位编码
      /// </summary>
      public bool LM_Receive_IsChanged
      {
         get{ return lM_Receive_IsChanged; }
         set{ lM_Receive_IsChanged = value; }
      }
      /// <summary>
      /// 过磅类别
      /// </summary>
      private string lM_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Type_IsChanged=false;
      /// <summary>
      /// 过磅类别
      /// </summary>
      public string LM_Type
      {
         get{ return lM_Type; }
         set{ lM_Type = value; lM_Type_IsChanged=true; }
      }
      /// <summary>
      /// 过磅类别
      /// </summary>
      public bool LM_Type_IsChanged
      {
         get{ return lM_Type_IsChanged; }
         set{ lM_Type_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string lM_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string LM_iType
      {
         get{ return lM_iType; }
         set{ lM_iType = value; lM_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool LM_iType_IsChanged
      {
         get{ return lM_iType_IsChanged; }
         set{ lM_iType_IsChanged = value; }
      }
      private string lM_Stat;
      private bool lM_Stat_IsChanged=false;
      public string LM_Stat
      {
         get{ return lM_Stat; }
         set{ lM_Stat = value; lM_Stat_IsChanged=true; }
      }
      public bool LM_Stat_IsChanged
      {
         get{ return lM_Stat_IsChanged; }
         set{ lM_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      private decimal lM_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Price_IsChanged=false;
      /// <summary>
      /// 单价
      /// </summary>
      public decimal LM_Price
      {
         get{ return lM_Price; }
         set{ lM_Price = value; lM_Price_IsChanged=true; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      public bool LM_Price_IsChanged
      {
         get{ return lM_Price_IsChanged; }
         set{ lM_Price_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal lM_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Amount_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal LM_Amount
      {
         get{ return lM_Amount; }
         set{ lM_Amount = value; lM_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool LM_Amount_IsChanged
      {
         get{ return lM_Amount_IsChanged; }
         set{ lM_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 司磅员名称
      /// </summary>
      private string lM_PounderName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_PounderName_IsChanged=false;
      /// <summary>
      /// 司磅员名称
      /// </summary>
      public string LM_PounderName
      {
         get{ return lM_PounderName; }
         set{ lM_PounderName = value; lM_PounderName_IsChanged=true; }
      }
      /// <summary>
      /// 司磅员名称
      /// </summary>
      public bool LM_PounderName_IsChanged
      {
         get{ return lM_PounderName_IsChanged; }
         set{ lM_PounderName_IsChanged = value; }
      }
      /// <summary>
      /// 司磅员
      /// </summary>
      private string lM_Pounder;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Pounder_IsChanged=false;
      /// <summary>
      /// 司磅员
      /// </summary>
      public string LM_Pounder
      {
         get{ return lM_Pounder; }
         set{ lM_Pounder = value; lM_Pounder_IsChanged=true; }
      }
      /// <summary>
      /// 司磅员
      /// </summary>
      public bool LM_Pounder_IsChanged
      {
         get{ return lM_Pounder_IsChanged; }
         set{ lM_Pounder_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string lM_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string LM_MName
      {
         get{ return lM_MName; }
         set{ lM_MName = value; lM_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool LM_MName_IsChanged
      {
         get{ return lM_MName_IsChanged; }
         set{ lM_MName_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string lM_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string LM_MCode
      {
         get{ return lM_MCode; }
         set{ lM_MCode = value; lM_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool LM_MCode_IsChanged
      {
         get{ return lM_MCode_IsChanged; }
         set{ lM_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 承运单位编码
      /// </summary>
      private string lM_Transport;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Transport_IsChanged=false;
      /// <summary>
      /// 承运单位编码
      /// </summary>
      public string LM_Transport
      {
         get{ return lM_Transport; }
         set{ lM_Transport = value; lM_Transport_IsChanged=true; }
      }
      /// <summary>
      /// 承运单位编码
      /// </summary>
      public bool LM_Transport_IsChanged
      {
         get{ return lM_Transport_IsChanged; }
         set{ lM_Transport_IsChanged = value; }
      }
      /// <summary>
      /// 承运单位名称
      /// </summary>
      private string lM_TransportName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_TransportName_IsChanged=false;
      /// <summary>
      /// 承运单位名称
      /// </summary>
      public string LM_TransportName
      {
         get{ return lM_TransportName; }
         set{ lM_TransportName = value; lM_TransportName_IsChanged=true; }
      }
      /// <summary>
      /// 承运单位名称
      /// </summary>
      public bool LM_TransportName_IsChanged
      {
         get{ return lM_TransportName_IsChanged; }
         set{ lM_TransportName_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶员编码
      /// </summary>
      private string lM_Pilot;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Pilot_IsChanged=false;
      /// <summary>
      /// 驾驶员编码
      /// </summary>
      public string LM_Pilot
      {
         get{ return lM_Pilot; }
         set{ lM_Pilot = value; lM_Pilot_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶员编码
      /// </summary>
      public bool LM_Pilot_IsChanged
      {
         get{ return lM_Pilot_IsChanged; }
         set{ lM_Pilot_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      private string lM_PilotName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_PilotName_IsChanged=false;
      /// <summary>
      /// 驾驶员
      /// </summary>
      public string LM_PilotName
      {
         get{ return lM_PilotName; }
         set{ lM_PilotName = value; lM_PilotName_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      public bool LM_PilotName_IsChanged
      {
         get{ return lM_PilotName_IsChanged; }
         set{ lM_PilotName_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string lM_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lM_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string LM_Remark
      {
         get{ return lM_Remark; }
         set{ lM_Remark = value; lM_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool LM_Remark_IsChanged
      {
         get{ return lM_Remark_IsChanged; }
         set{ lM_Remark_IsChanged = value; }
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
