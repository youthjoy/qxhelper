using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.Model;

namespace QX.BLL
{
    public class Bll_Ref_Config
    {




        /// <summary>
        /// 转换实体
        /// </summary>
        /// <param name="whIOMain"></param>
        /// <returns></returns>
        public static RefData ChangePUMainToRefData(PU_Main p)
        {
            return new RefData
            {
                PUM_TypeDescription = "采购相关单据",
                PUM_TechType = "PU",
                PUM_Type = p.PUM_RType,
                PUM_BOwner = p.PUM_BOwner,
                PUM_Discount = p.PUM_Discount
                           ,
                PUM_DisSum = p.PUM_DisSum,
                PUM_IDate = p.PUM_IDate
                           ,
                PUM_Owner = p.PUM_Owner,
                PUM_Payable = p.PUM_Payable
                           ,
                PUM_PDate = p.PUM_PDate,
                PUM_Code = p.PUM_RCode
                           ,
                PUM_RDate = p.PUM_RDate
                           ,
                PUM_SCode = p.PUM_SCode,
                PUM_SContact = p.PUM_SContact
                           ,
                PUM_SName = p.PUM_SName,
                PUM_STel = p.PUM_STel
                           ,
                PUM_Tax = p.PUM_Tax,
                PUM_Tranfee = p.PUM_Tranfee,
                PUM_RefCode = p.PUM_RefCode,
                PUM_RefType = p.PUM_RefType,
                PUM_Title=p.PUM_Title,
                PUM_UDEF1=p.PUM_UDEF1,
                PUM_UDEF2 = p.PUM_UDEF2,
                PUM_UDEF3 = p.PUM_UDEF3,
                PUM_UDEF4 = p.PUM_UDEF4,
            };
        }


        public static PU_Detail ChangeIODataToPUDetail(WH_IOItem items)
        {
            return new PU_Detail
            {
                PUD_MCode = items.WHIOI_MCode,
                PUD_MName = items.WHIOI_MName,
                PUD_Num = items.WHIOI_MNum,
                PUD_Spec = items.WHIOI_MSpec,
                PUD_Unit = items.WHIOI_MUnit,
                PUD_Price = items.WHIOI_MPrice,
            };
        }


        public static WH_IOItem ChangePUDetailDataToIODetail(PU_Detail items)
        {
            return new WH_IOItem
            {
                WHIOI_MCode = items.PUD_MCode,
                WHIOI_MName = items.PUD_MName,
                WHIOI_MNum = items.PUD_Num,
                WHIOI_MSpec = items.PUD_Spec,
                WHIOI_MUnit = items.PUD_Unit,
                WHIOI_MPrice = items.PUD_Price,
            };
        }
        public static List<WH_IOItem> ChangePUDetailToIOData(List<PU_Detail> list)
        {
            var re = from items in list
                     select new WH_IOItem
                     {
                         WHIOI_Code = items.PUD_Code,
                         WHIOI_MCode = items.PUD_MCode,
                         WHIOI_MName = items.PUD_MName,
                         WHIOI_MNum = items.PUD_Num,
                         WHIOI_MSpec = items.PUD_Spec,
                         WHIOI_MUnit = items.PUD_Unit,
                         WHIOI_MPrice = items.PUD_Price
                     };
            return re.ToList();
        }

        public static List<PU_Detail> ChangeIODataToPUDetail(List<WH_IOItem> list)
        {
            var re = from items in list
                     select new PU_Detail
                     {
                         PUD_Code = items.WHIOI_Code,
                         PUD_MCode = items.WHIOI_MCode,
                         PUD_MName = items.WHIOI_MName,
                         PUD_Num = items.WHIOI_MNum,
                         PUD_Spec = items.WHIOI_MSpec,
                         PUD_Unit = items.WHIOI_MUnit,
                         PUD_Price = items.WHIOI_MPrice,
                     };
            return re.ToList();
        }

        public static IEnumerable<RefData> ChangePUMainToRefData(List<PU_Main> list)
        {
            var temp = from p in list
                       select new RefData
                       {
                           PUM_TypeDescription = "采购相关单据",
                           PUM_TechType = "PU",
                           PUM_Type = p.PUM_RType,
                           PUM_BOwner = p.PUM_BOwner,
                           PUM_Discount = p.PUM_Discount
                           ,
                           PUM_DisSum = p.PUM_DisSum,
                           PUM_IDate = p.PUM_IDate
                           ,
                           PUM_Owner = p.PUM_Owner,
                           PUM_Payable = p.PUM_Payable
                           ,
                           PUM_PDate = p.PUM_PDate,
                           PUM_Code = p.PUM_RCode
                           ,
                           PUM_RDate = p.PUM_RDate
                           ,
                           PUM_SCode = p.PUM_SCode,
                           PUM_SContact = p.PUM_SContact
                           ,
                           PUM_SName = p.PUM_SName,
                           PUM_STel = p.PUM_STel
                           ,
                           PUM_Tax = p.PUM_Tax,
                           PUM_Tranfee = p.PUM_Tranfee,
                           PUM_Title=p.PUM_Title
                       };

            return temp;
        }


        public static RefData ChangeMAToRefData(Asset_MApply p)
        {
            return new RefData
            {
                PUM_TypeDescription = "维修单",
                PUM_TechType = "MA",
                PUM_Type = p.AMA_Type, //维修类别
                PUM_Code = p.AMA_Code, //单据编码
                PUM_RDate = p.AMA_ReceiveDate //接收时间      
                ,
                PUM_PDate = p.AMA_OpDate //故障发生时间
                ,
                PUM_BOwner = p.AMA_Owner //报修人
                
                ,PUM_UDEF1 = p.AMA_OwnerCode //报修人编码               
                ,PUM_UDEF2 = p.AMA_FCode //资产编码
                ,PUM_UDEF3 = p.AMA_FName //资产名称 
            };
        }


        /// <summary>
        /// 转换实体
        /// </summary>
        /// <param name="whIOMain"></param>
        /// <returns></returns>
        public static RefData ChangeIOMainToRefData(WH_IOMain p)
        {
            return new RefData
            {
                PUM_TypeDescription = "出库相关单据",
                PUM_TechType = "IA",
                PUM_Type = p.WHIOM_Type,
                PUM_Code = p.WHIOM_Code,
                PUM_RDate = p.WHIOM_RDate
                ,
                PUM_IDate = p.WHIOM_IDate
                ,
                PUM_PDate = p.WHIOM_PDate
                ,
                PUM_BOwner = p.WHIOM_BOwner
                ,
                PUM_Owner = p.WHIOM_Owner
                ,
                PUM_Tranfee = p.WHIOM_TranFee,
                PUM_Tax = p.WHIOM_Tax,
                PUM_Discount = p.WHIOM_DisCount,
                PUM_DisSum = p.WHIOM_DisSum,
                PUM_RefType = p.WHIOM_RefType,
                PUM_RefCode = p.WHIOM_RefCode,
                PUM_Title=p.WHIOM_Title
            };
        }

        /// <summary>
        /// 转换列表
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IEnumerable<RefData> ChangeIOMainToRefData(List<WH_IOMain> list)
        {
            var temp = from p in list
                       select new RefData
                       {

                           PUM_TypeDescription = "出库相关单据",
                           PUM_TechType = "IA",
                           PUM_Type = p.WHIOM_Type,
                           PUM_Code = p.WHIOM_Code,
                           PUM_RDate = p.WHIOM_RDate
                           ,
                           PUM_IDate = p.WHIOM_IDate
                           ,
                           PUM_PDate = p.WHIOM_PDate
                           ,
                           PUM_BOwner = p.WHIOM_BOwner
                           ,
                           PUM_Owner = p.WHIOM_Owner
                           ,
                           PUM_Tranfee = p.WHIOM_TranFee,
                           PUM_Tax = p.WHIOM_Tax,
                           PUM_Discount = p.WHIOM_DisCount,
                           PUM_DisSum = p.WHIOM_DisSum,
                           PUM_Title=p.WHIOM_Title
                       };
            return temp;
        }
    }
}
