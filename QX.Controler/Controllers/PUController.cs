using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.Model;
using QX.BLL;
using QX.HtmlHelperLib;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QX.Comm;
using QX.Config;
using System.Collections;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using QX.AOP;

namespace QX.Controllers.Controllers
{
    /// <summary>
    /// 采购管理
    /// </summary>
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    public class PUController : Controller
    {

        public static List<WH_IOItem> whItem = new List<WH_IOItem>();
        private List<PU_Detail> _PUDetailList;

        private List<PU_Detail> PUDetailList
        {
            get
            {
                if (HttpContext.Session["PUDetailList"] != null)
                {
                    _PUDetailList = HttpContext.Session["PUDetailList"] as List<PU_Detail>;
                }
                else
                {
                    _PUDetailList = new List<PU_Detail>();

                }
                return _PUDetailList;
            }
            set
            {
                _PUDetailList = value;

                HttpContext.Session["PUDetailList"] = _PUDetailList;
            }
        }


        private Bll_PU_Detail pudInstance = new Bll_PU_Detail();

        private Bll_PU_Main puInstance = new Bll_PU_Main();

        private Bll_WH_Supplier supInstance = new Bll_WH_Supplier();

        private Bll_WH_IOMain ioInstance = new Bll_WH_IOMain();
        private Bll_WH_IOItem iodInstance = new Bll_WH_IOItem();

        private BindModelHelper bmHelper = new BindModelHelper();
        private Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();

        private Bll_Asset_MApply maInstance = new Bll_Asset_MApply();

        public ActionResult Index(string id)
        {
            string rtype = id;
            if (string.IsNullOrEmpty(rtype))
            {
                ViewData["RType"] = "PO";
            }
            else
            {
                ViewData["RType"] = rtype;
            }
            return View();
        }

        #region 添加编辑操作

        /// <summary>
        /// 外修外加工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CreateWithWO(string id)
        {
            PUDetailList = new List<PU_Detail>();

            this.ViewData = this.GetRefdenped(true);
            return View();
            //string main = string.Empty;
            //string other = string.Empty;
            //string showName = string.Empty;
            //string refType = string.Empty;
            //string module = string.Empty;

            ////默认为PO
            //if (string.IsNullOrEmpty(id))
            //{
            //    ViewData["PType"] = PUTypeEnum.PO.ToString();

            //    main = "PU_Main_TOP";
            //    other = "PU_Main_Button";
            //    showName = "采购订单";
            //}
            //else
            //{
            //    ViewData["PType"] = id;
            //    Dictionary<string, string> dicList = puInstance.GetPUMainShowData(id);
            //    main = dicList["ShowMain"];
            //    other = dicList["ShowOther"];
            //    //refType = dicList["RefType"];
            //    showName = dicList["ShowName"];
            //    module = dicList["Module"];
            //}

            ////ViewData["RefType"] = refType;
            //ViewData["ShowName"] = showName;
            //ViewData["Main"] = main;
            //ViewData["Other"] = other;
            //ViewData["Module"] = module;
            //return View();
        }

        public ActionResult EditWithWO(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            PU_Main puMain = new PU_Main();
            if (!string.IsNullOrEmpty(code))
            {
                puMain = puInstance.GetModelByCode(code);
            }
            this.ViewData = this.GetRefdenped(true);
            //string main = string.Empty;
            //string other = string.Empty;
            //string showName = string.Empty;
            //string refType = string.Empty;
            //string module = string.Empty;


            ////默认为PO
            //if (string.IsNullOrEmpty(rtype))
            //{
            //    ViewData["PType"] = PUTypeEnum.PO.ToString();
            //    main = "PU_Main";
            //    other = "PU_MainOther";
            //    showName = "采购订单";
            //}
            //else
            //{
            //    ViewData["PType"] = rtype;
            //    Dictionary<string, string> dicList = puInstance.GetPUMainShowData(rtype);
            //    main = dicList["ShowMain"];
            //    other = dicList["ShowOther"];
            //    showName = dicList["ShowName"];
            //    module = dicList["Module"];

            //}

            //ViewData["Main"] = main;
            //ViewData["Other"] = other;
            //ViewData["ShowName"] = showName;
            //ViewData["Module"] = module;
            return View(puMain);
        }

        //
        // GET: /PU/

        public ActionResult Create(string id)
        {
            if (Request["MRTOPO"] != "1")
            {
                PUDetailList = new List<PU_Detail>();
            }         
            this.ViewData = this.GetRefdenped(true);
            return View();

        }

        public ActionResult PUReturn(string id)
        {
            PUDetailList = new List<PU_Detail>();

            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        public ActionResult SpecCreate(string id)
        {
            PUDetailList = new List<PU_Detail>();

            this.ViewData = this.GetRefdenped(true);
            return View();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">供应商编码</param>
        /// <param name="rtype">当前单据类型</param>
        /// <returns></returns>
        public ActionResult CreateWithSup(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            this.ViewData = this.GetRefdenped(true);
            //string supCode = code;

            //ViewData["SupCode"] = supCode;

            //string main = string.Empty;
            //string other = string.Empty;
            //string showName = string.Empty;
            //string refType = string.Empty;
            //string module = "";

            //ViewData["PType"] = rtype;
            //Dictionary<string, string> dicList = puInstance.GetPUMainShowData(rtype);
            //main = dicList["ShowMain"];
            //other = dicList["ShowOther"];
            ////refType = dicList["RefType"];
            //showName = dicList["ShowName"];
            //module = dicList["Module"];

            //ViewData["ShowName"] = showName;
            //ViewData["Main"] = main;
            //ViewData["Other"] = other;
            //ViewData["Module"] = module;
            return View();

        }

        public ActionResult Edit(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            ViewData["view"] = Request["view"] != null ? Request["view"] : "";
            string tab = "#tabs-" + Request["tab"];

            PU_Main puMain = new PU_Main();
            if (!string.IsNullOrEmpty(code))
            {
                puMain = puInstance.GetModelByCode(code);
                //DateTime newDate = new DateTime();
                //puMain.PUM_RDate = DateTime.ParseExact(puMain.PUM_RDate.ToString(), "yyyy-MM-dd",new DateFormat());
                //puMain.PUM_RDate = DateTime.TryParse(puMain.PUM_RDate.ToString(), out newDate);
            }

            this.ViewData = this.GetRefdenped(true);
            this.ViewData.Add("tab", tab);
            return View(puMain);

        }

        public ActionResult SpecEdit(string code, string rtype)
        {
            var Tab = string.Empty;
            PUDetailList = new List<PU_Detail>();
            PU_Main puMain = new PU_Main();
            if (Request["tab"] != "")
            {
                Tab = "#tabs-" + Request["tab"];
            }
            if (!string.IsNullOrEmpty(code))
            {
                puMain = puInstance.GetModelByCode(code);
            }

            this.ViewData = this.GetRefdenped(true);
            this.ViewData.Add("tab", Tab);
            return View(puMain);

        }


        [HttpPost]
        public ActionResult GetRefTypeList(string ownType)
        {
            var dic = puInstance.GetRefDictionary(ownType);
            var re = from d in dic select new { Key = d.Key, Value = d.Value };
            JsonResult jresult = new JsonResult { Data = re, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            return jresult;
        }


        /// <summary>
        /// 主表数据(参考单据)
        /// </summary>
        /// <param name="id">参考类型</param>
        /// <param name="ownType">单据本身类型</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult RefPUMainList(string id, string ownType, int page, int rows, string search, string sidx, string sord)
        {
            string filters = Request["serachKey"] == null ? "" : Request["serachKey"].ToString();

            string filtersSql = "";
            if (!string.IsNullOrEmpty(filters))
            {
                //设备外修查询单独处理

                if (!string.IsNullOrEmpty(ownType) && ownType.ToLower() == "baseser" 
                     && !string.IsNullOrEmpty(id) && id.ToLower()=="base")
                {
                    filtersSql = " AND (AMA_name like  '%" + filters + "%' or AMA_Company like '%" + filters + "%' or AMA_Code like '%" + filters + "%' )";
                }
                else
                {
                    filtersSql = " AND (PUM_Title like  '%" + filters + "%' or PUM_Company like '%" + filters + "%' or PUM_RCode like '%" + filters + "%' )";
                }
                
            }

            if (string.IsNullOrEmpty(ownType))
            {
                return JavaScript("");
            }
            else
            {
                //当前单据参考类型
                string refType = id;
                //string jsonResult = string.Empty;

                //List<RefData> refMainData = new List<RefData>();

                //refMainData = puInstance.GetRefGridDataList(rtype, ownType);
                //var model = refMainData.AsQueryable<RefData>();
                //var result = model.ToJqGridData(page, rows, null, search, null);
                //jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
                //return JavaScript(jsonResult);

                //调用存储过程
                SqlParameter x1 = new SqlParameter("@refType", SqlDbType.VarChar, 20);
                x1.Value = refType;
                SqlParameter x2 = new SqlParameter("@rType", SqlDbType.VarChar, 20);
                x2.Value = ownType;
                SqlParameter x3 = new SqlParameter("@uCompanyCode", SqlDbType.VarChar, 20);
                x3.Value = SessionConfig.CompanyCode();
                SqlParameter x4 = new SqlParameter("@uDepartmentCode", SqlDbType.VarChar, 20);
                x4.Value = SessionConfig.DeptCode();
                SqlParameter x5 = new SqlParameter("@uUserCode", SqlDbType.VarChar, 40);
                x5.Value = SessionConfig.UserId();
                SqlParameter x6 = new SqlParameter("@Search", SqlDbType.VarChar, 500);
                x6.Value = filtersSql;
                SqlParameter[] param = new SqlParameter[] { x1, x2, x3, x4, x5 ,x6};
                IDbDataParameter[] parames = param as IDbDataParameter[];
                DataTable dt = Bll_Comm.RunProc("qx_sp_record_reflist", parames);
                DataTable newDt = DataTablePage.GetPagedTable(dt, page, rows);
                var json = DataTablePage.JsonForJqgrid(newDt, page, rows, dt.Rows.Count);
                return JavaScript(json);
            }



        }

        /// <summary>
        /// 采购明细
        /// </summary>
        /// <param name="id">单据编码</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public JsonResult DetailsList(string id, int page, int rows, string search, string sidx, string sord)
        {
            var result = new JqGridData();

            //操作类型
            string Oper = Request["Oper"] != null ? Request["Oper"] : "view";

            List<PU_Detail> list = new List<PU_Detail>();            

            if (!string.IsNullOrEmpty(id))
            {
                if (PUDetailList != null && PUDetailList.Count != 0)
                {
                    list = PUDetailList;
                }
                else
                {
                    //list = pudInstance.GetPUDetailByPOCode(id);
                    
                    //物料数据更新
                    list = pudInstance.GetPUDetailByPOCode(id);
                    PUDetailList = list;
                }
            }
            else
            {
                list = PUDetailList;
            }         

            var model = list.AsQueryable<PU_Detail>();
            result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 采购明细
        /// </summary>
        /// <param name="id">单据编码</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public JsonResult DetailsListForRef(string code,string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var result = new JqGridData();
            //var rtype = Request["ownType"] !=null? Request["ownType"] : "";
            //操作类型
            //string Oper = Request["Oper"] != null ? Request["Oper"] : "view";

            List<PU_Detail> list = new List<PU_Detail>();

            if (!string.IsNullOrEmpty(code))
            {
                if (PUDetailList != null && PUDetailList.Count != 0)
                {
                    list = PUDetailList;
                }
                else
                {
                    //list = pudInstance.GetPUDetailByPOCode(id);

                    //物料数据更新
                    var DetailList = pudInstance.GetPUDetailByPOCode(code);
                    List<PU_Detail> DList = new List<PU_Detail>();
                    //如果是收货参考  则判断可收货数量
                    if (rtype.Contains("PI"))
                    {  //入库时更新未收货数量
                        foreach (var item in DetailList)
                        {
                            if (item.PUD_Num > 0)
                            {
                                var pNum = item.PUD_Num - item.PUD_DNum;
                                item.PUD_Num = pNum;
                                if (pNum > 0)
                                {
                                    DList.Add(item);
                                }
                            }
                        }
                    }
                    else
                    {
                        DList = DetailList;
                    }
                    PUDetailList = DList;
                }
            }
            else
            {
                list = PUDetailList;
            }

            var model = list.AsQueryable<PU_Detail>();
            result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult DetailsCURDListForMR(string id, int page, int rows, string search, string sidx, string sord)
        {
            var result = new JqGridData();


            List<PU_Detail> list = new List<PU_Detail>();

            list = PUDetailList;

            //if (!string.IsNullOrEmpty(id))
            //{
            //    if (PUDetailList != null && PUDetailList.Count != 0)
            //    {
            //        list = PUDetailList;
            //    }
            //    else
            //    {
            //        list = pudInstance.GetPUDetailByPOCode(id);
            //        PUDetailList = list;
            //    }
            //}

            var model = list.AsQueryable<PU_Detail>();
            result = model.ToJqGridData(page, rows, null, search, null);
            return JavaScript(JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd")));
        }


        

        /// <summary>
        /// 获取MR主表信息，并加载明细
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public ActionResult GetPUMainMR(string id)
        {
            // Modify BY QB 
            // Modify:增加单据类型
            // Modify Date:2011-3-22
            PUDetailList = new List<PU_Detail>();
            string RType = Request["rType"];
            RType = string.IsNullOrEmpty(RType) ? "MMMR" : RType;
            var model = puInstance.GetModel(" AND PUM_RCode='" + id + "' AND PUM_RType='" + RType + "'");
            PUDetailList = pudInstance.GetListByCode(" AND PUD_RCode='" + id + "' AND PUD_RType='" + RType + "'");
            var result = JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(result);
        }


        /// <summary>
        /// 采购明细
        /// </summary>
        /// <param name="id">单据编码</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public JsonResult DetailListForMR(string id, int page, int rows, string search, string sidx, string sord)
        {
            var result = new JqGridData();

            List<PU_Detail> list = new List<PU_Detail>();

            if (!string.IsNullOrEmpty(id))
            {

                list = pudInstance.GetPUDetailByPOCode(id);
                //PUDetailList = list; 
                var model = list.AsQueryable<PU_Detail>();
                result = model.ToJqGridData(page, rows, null, search, null);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("");
            }

        }


        public ContentResult GeneratePUMainCode()
        {
            return Content(puInstance.GenerateCode());
        }

        /// <summary>
        /// 获取参考单据实体相关数据
        /// </summary>
        /// <param name="id">参考的单据编码</param>
        /// <returns></returns>
        public ActionResult GetPUMain(string id, string rtype)
        {
            string result = string.Empty;
            RefData resultData = new RefData();
            var owntype = Request["ownType"] !=null? Request["ownType"] : "";
            switch (rtype)
            {
                case "PU":
                    //参考单据实体
                    var re = puInstance.GetModelByCode(id);
                    PU_Main puMain = new PU_Main();

                    puMain = re;
                    //参考单据本身的类型即为实体的参考单据类型
                    puMain.PUM_RefType = re.PUM_RType;
                    puMain.PUM_RefCode = re.PUM_RCode;

                    resultData = Bll_Ref_Config.ChangePUMainToRefData(puMain);

                    result = JsonConvert.SerializeObject(resultData, new JsonDateConverter("yyyy-MM-dd"));

                    //物料数据更新
                    var DetailList = pudInstance.GetPUDetailByPOCode(id);
                    List<PU_Detail> DList = new List<PU_Detail>();
                    //入库时更新未收货数量

                    if (owntype.Contains("PI"))
                    {  //入库时更新未收货数量
                        foreach (var item in DetailList)
                        {
                            if (item.PUD_Num > 0)
                            {
                                var pNum = item.PUD_Num - item.PUD_DNum;
                                item.PUD_Num = pNum;
                                if (pNum > 0)
                                {
                                    DList.Add(item);
                                }
                            }
                        }
                    }
                    else
                    {
                        DList = DetailList;
                    }


                    PUDetailList = DList;
                    
                    break;
                case "IA":
                    //参考订单
                    var reIA = ioInstance.GetModelByCode(id);
                    WH_IOMain ioMain = new WH_IOMain();

                    ioMain = reIA;

                    ioMain.WHIOM_RefCode = reIA.WHIOM_Code;
                    ioMain.WHIOM_RefType = reIA.WHIOM_Type;

                    resultData = Bll_Ref_Config.ChangeIOMainToRefData(ioMain);

                    result = JsonConvert.SerializeObject(resultData, new JsonDateConverter("yyyy-MM-dd"));

                    //物料数据更新
                    var list = iodInstance.GetIOItemByIOMainCode(id);
                    PUDetailList = Bll_Ref_Config.ChangeIODataToPUDetail(list);
                    //PUDetailList=Bll_Ref_Config.ChangeIOMainToRefData
                    //var list = ioInstance.GetAll();
                    //var temp = list.Union(PUDetailList);
                    //PUDetailList = temp.ToList();
                    break;

                    ///参考维修 Asset_MApply
                case "MA":

                    var reMA = maInstance.GetModel(" AND AMA_Code='"+id+"'");
                    PU_Main puMA = new PU_Main();
                    //转换主表 Asset_MAppy->PU_Main                    

                    resultData = Bll_Ref_Config.ChangeMAToRefData(reMA);

                    result = JsonConvert.SerializeObject(resultData, new JsonDateConverter("yyyy-MM-dd"));

                    //物料数据更新
                    //var list = iodInstance.GetIOItemByIOMainCode(id);
                    //PUDetailList = Bll_Ref_Config.ChangeIODataToPUDetail(list);

                    break;
            }

            return JavaScript(result);
        }

        /// <summary>
        /// 获取某单据明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetPUDetail(string id)
        {
            //临时解决
            var re = PUDetailList.FirstOrDefault(o => o.PUD_Code == id);
            if (re==null)
            {
                re = pudInstance.GetModelByCode(id);
            }
            //var re = pudInstance.GetModelByCode(id);
            
            //JsonResult result = new JsonResult { Data = re };
            //return result;
            var result = JsonConvert.SerializeObject(re, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(result);
        }



        public ActionResult PUOperation(FormCollection formCollect)
        {
            string Module = formCollect["Module"];
            string PUM_RType = formCollect["PUM_RType"];
            bool Flag_MRTOPO =!string.IsNullOrEmpty(formCollect["MRTOPO"])?true:false;  //订单从采购汇总生成标志

            PU_Main puMain = new PU_Main();
            bmHelper.BindFormToModel<PU_Main>(puMain, formCollect);


            //获取单据业务配置相关信息
            var configDependenceModel = Bll_Comm.CommRefDepend(PUM_RType);

            if (PUDetailList==null || PUDetailList.Count<=0)
            {
                var result1 = new JsonResult { Data = new { result = "fail", Msg = "明细数据不能为空！" } };
                return result1;
            }

            //检查明细中的仓库号不能为空
            if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF8))
            {
                PU_Detail pd = Bll_PU_Main.CheckPUDetailValidation(PUDetailList);
                if (pd != null)
                {
                    var result1 = new JsonResult { Data = new { result = "fail", Msg = "请为物料:" + pd.PUD_MName + "(" + pd.PUD_MCode + ")选择仓库号" } };
                    return result1;
                }
            }

            //对页面DetailList中的必填项进行检查，初步只检查是否有值，不作类型判断（容错处理）
            //获取DetailList模块配置
            if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF10))
            {
                Dictionary<string, string> errorList = new Dictionary<string, string>();
                if (PUDetailList.Count>0)
                {
                    errorList = Bll_PU_Main.ValidateList(configDependenceModel.RefDepend_UDEF10, PUDetailList);
                    if (errorList.Count > 0)
                    {
                        StringBuilder ShowMsg = new StringBuilder();
                        foreach (var item in errorList)
                        {
                            ShowMsg.AppendLine("数据:" + item.Key + "不能为空！<br>");
                        }
                        var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg.ToString() } };
                        return result1;
                    }
                }
                else
                {
                    var result1 = new JsonResult { Data = new { result = "fail", Msg = "单据明细为空，不能添加单据！" } };
                    return result1;
                }                
            }
            //检查明细中数量是否大于库存数量
            if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF14))
            {
                var errorList = Bll_PU_Main.CheckPUDetailStroage(PUDetailList,puMain.PUM_CompanyCode);
                if (errorList.Count>0)
                {
                    StringBuilder ShowMsg = new StringBuilder();
                    foreach (var item in errorList)
                    {
                        ShowMsg.AppendLine("物料:"+item.Key+"库存数量不足！");
                    }
                    var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg .ToString() } };
                    return result1;
                }
            }

            //自定义验证PUD_Num与参考数量的比较
            if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF15))
            {
                #region 旧方法,新方法改用存储过程调用
                //var errorList = Bll_PU_Main.CheckPUDetailRefNum(configDependenceModel.RefDepend_UDEF15, PUDetailList, formCollect["PUM_RefCode"]);
                //if (errorList.Count > 0)
                //{
                //    StringBuilder ShowMsg = new StringBuilder();
                //    foreach (var item in errorList)
                //    {
                //        ShowMsg.AppendLine("物料:( " + item.Key+" ) "+ configDependenceModel.RefDepend_UDEF16);
                //    }
                //    var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg.ToString() } };
                //    return result1;
                //}
                #endregion

                var errorList = Bll_PU_Main.CheckPUDetailRefNums(PUDetailList, puMain);
                if (errorList.Count > 0)
                {
                    StringBuilder ShowMsg = new StringBuilder();
                    foreach (var item in errorList)
                    {
                        ShowMsg.AppendLine("物料:( " + item.Key + " ) " + configDependenceModel.RefDepend_UDEF15);
                    }
                    var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg.ToString() } };
                    return result1;
                }
                
            }

            if (formCollect["PUM_Formoper"] == "edit")
            {
                //PU_Main puMain = new PU_Main();
                //bmHelper.BindFormToModel<PU_Main>(puMain, formCollect);

                var re = puInstance.UpdatePuMainAndDetails(puMain, PUDetailList);

                //日志记录
                this.OpLog(this.GetControllerName(), "修改:单据类型" + puMain.PUM_RType + ",编码:" + puMain.PUM_RCode, re.ToString());
            }
            else
            {                
                //创建人
                puMain.PUM_Operator = SessionConfig.UserName();
                //创建人编码
                puMain.PUM_OCode = SessionConfig.UserId();
                puMain.PUM_OpDate = DateTime.Now;
                puMain.PUM_RCode = Bll_Comm.GetTableKeyForPU(puMain.PUM_CompanyCode, puMain.PUM_RType);

                var addResult =  puInstance.AddPuMainAndDetails(puMain, PUDetailList, configDependenceModel, Flag_MRTOPO);

                //日志记录
                this.OpLog(this.GetControllerName(), "添加:单据类型" + puMain.PUM_RType + ",编码:" + puMain.PUM_RCode, addResult.ToString());

            }

            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }

        /// <summary>
        /// 资产数据维护(收货)
        /// </summary>
        /// <param name="formCollect"></param>
        /// <returns></returns>
        public ActionResult SpecOperation(FormCollection formCollect)
        {
            string Module = formCollect["Module"];
            string PUM_RType = formCollect["PUM_RType"];
            bool Flag_MRTOPO = !string.IsNullOrEmpty(formCollect["MRTOPO"]) ? true : false;  //订单从采购汇总生成标志

            PU_Main puMain = new PU_Main();
            bmHelper.BindFormToModel<PU_Main>(puMain, formCollect);

            bool Re=false;

            //获取单据业务配置相关信息
            var configDependenceModel = Bll_Comm.CommRefDepend(PUM_RType);

            if (PUDetailList == null || PUDetailList.Count <= 0)
            {
                var result1 = new JsonResult { Data = new { result = "fail", Msg = "明细数据不能为空！" } };
                return result1;
            }

            //检查明细中的仓库号不能为空
            //if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF8))
            //{
            //    PU_Detail pd = Bll_PU_Main.CheckPUDetailValidation(PUDetailList);
            //    if (pd != null)
            //    {
            //        var result1 = new JsonResult { Data = new { result = "fail", Msg = "请为物料:" + pd.PUD_MName + "(" + pd.PUD_MCode + ")选择仓库号" } };
            //        return result1;
            //    }
            //}

            //对页面DetailList中的必填项进行检查，初步只检查是否有值，不作类型判断（容错处理）
            //获取DetailList模块配置
            if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF10))
            {
                Dictionary<string, string> errorList = new Dictionary<string, string>();
                if (PUDetailList.Count > 0)
                {
                    errorList = Bll_PU_Main.ValidateList(configDependenceModel.RefDepend_UDEF10, PUDetailList);
                    if (errorList.Count > 0)
                    {
                        StringBuilder ShowMsg = new StringBuilder();
                        foreach (var item in errorList)
                        {
                            ShowMsg.AppendLine("数据:" + item.Key + "不能为空！<br>");
                        }
                        var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg.ToString() } };
                        return result1;
                    }
                }
                else
                {
                    var result1 = new JsonResult { Data = new { result = "fail", Msg = "单据明细为空，不能添加单据！" } };
                    return result1;
                }
            }
            //检查明细中数量是否大于库存数量
            //if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF14))
            //{
            //    var errorList = Bll_PU_Main.CheckPUDetailStroage(PUDetailList, puMain.PUM_CompanyCode);
            //    if (errorList.Count > 0)
            //    {
            //        StringBuilder ShowMsg = new StringBuilder();
            //        foreach (var item in errorList)
            //        {
            //            ShowMsg.AppendLine("物料:" + item.Key + "库存数量不足！");
            //        }
            //        var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg.ToString() } };
            //        return result1;
            //    }
            //}

            //自定义验证PUD_Num与参考数量的比较
            //if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF15))
            //{
            //    #region 旧方法,新方法改用存储过程调用

            //    #endregion

            //    var errorList = Bll_PU_Main.CheckPUDetailRefNums(PUDetailList, puMain);
            //    if (errorList.Count > 0)
            //    {
            //        StringBuilder ShowMsg = new StringBuilder();
            //        foreach (var item in errorList)
            //        {
            //            ShowMsg.AppendLine("物料:( " + item.Key + " ) " + configDependenceModel.RefDepend_UDEF15);
            //        }
            //        var result1 = new JsonResult { Data = new { result = "fail", Msg = ShowMsg.ToString() } };
            //        return result1;
            //    }

            //}

            if (formCollect["PUM_Formoper"] == "edit")
            {
                puInstance.UpdatePuMainAndDetails(puMain, PUDetailList);
            }
            else
            {
                //创建人
                puMain.PUM_Operator = SessionConfig.UserName();
                //创建人编码
                puMain.PUM_OCode = SessionConfig.UserId();
                puMain.PUM_OpDate = DateTime.Now;

                Re=puInstance.AddPuMainAndDetails(puMain, PUDetailList, configDependenceModel, Flag_MRTOPO);
                //如果入库成功则添加一条资产信息
                if (Re)
                { 
                    
                }
            }

            //日志记录
            this.OpLog(this.GetControllerName(), "收货:固定资产,编码:" + puMain.PUM_RCode, Re.ToString());

            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }

        public ActionResult DeletePUDetail(string id)
        {
            var val = PUDetailList.FirstOrDefault(o => o.PUD_Code == id);
            PUDetailList.Remove(val);

            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }

        /// <summary>
        /// 单据废弃
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult TrashRecord(string code)
        {
            string strResult = "";

            var model = puInstance.GetModel(string.Format(" and PUM_RCode='{0}'", code));
            if (model!=null)
            {
                if (model.AuditStat== AudtiOperaTypeEnum.Auditing.ToString())
                {
                    if (model.PUM_OCode==SessionConfig.UserId())
                    {
                        model.AuditStat = AudtiOperaTypeEnum.Litter.ToString();
                        var re = puInstance.Update(model);
                        if (re)
                        {
                            strResult = "";
                        }
                        else
                        {
                            strResult = "废弃失败";
                        }
                    }
                    else
                    {
                        strResult = "您没有废弃当前单据的权限！";
                    }
                }
                else if (model.AuditStat== AudtiOperaTypeEnum.OnAudit.ToString())
                {
                    strResult = "单据已进入审核，不能废弃！";

                }else if (model.AuditStat== AudtiOperaTypeEnum.LastAudit.ToString())
                {
                    strResult = "单据已终审通过，不能废弃";
                }else if (model.AuditStat== AudtiOperaTypeEnum.Litter.ToString())
                {
                    strResult = "单据已经废弃，不能重复操作";
                }
            }
            else
            {
                strResult = "获取单据数据失败";
            }
            //日志记录
            this.OpLog(this.GetControllerName(), "废弃:单据编码" + code, strResult);

            return Content(strResult);            
        }


        /// <summary>
        /// 明细更新（不操作数据库）
        /// </summary>
        /// <param name="formCollect"></param>
        /// <returns></returns>
        public ActionResult PUDOperation(FormCollection formCollect)
        {
            if (formCollect["PUDetailsFormoper"] == "edit")
            {
                string puDCode = formCollect["PUD_Code"];
                PU_Detail puDetail = PUDetailList.FirstOrDefault(o => o.PUD_Code == puDCode);
                bmHelper.BindFormToModel<PU_Detail>(puDetail, formCollect);
            }
            else
            {
                PU_Detail puDetail = new PU_Detail();
                bmHelper.BindFormToModel<PU_Detail>(puDetail, formCollect);

                //采购明细标识--不是数据库标识(临时标识)
                decimal maxid = 1;
                if (PUDetailList.Count != 0)
                {
                    maxid = PUDetailList.Max(o => o.PUD_ID) + 1;
                }

                puDetail.PUD_ID = maxid;
                puDetail.PUD_Code = "PUD" + maxid.ToString();

                PUDetailList.Add(puDetail);
            }
            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }

        #endregion


        #region PU 列表

        /// <summary>
        /// 通用订单
        /// </summary>
        /// <param name="code">收货对应单据类型</param>
        /// <param name="rtype">当前单据类型</param>
        /// <returns></returns>
        public ActionResult ComPOList(string code, string rtype)
        {
            //收货对应的类型
            //string rrtype = code;

            //ViewData["RType"] = rtype;

            //ViewData["RRType"] = rrtype;

            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        /// <summary>
        /// 特殊采购订单
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <returns></returns>
        public ActionResult SpecPOList(string code, string rtype)
        {
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        /// <summary>
        /// 通用收货
        /// </summary>
        /// <param name="code">参考订单类型(0 则表示不参考单据)</param>
        /// <param name="rtype">当前单据类型</param>
        /// <returns></returns>
        public ActionResult ComPIList(string code, string rtype)
        {

            //当前单据类型
            //ViewData["RType"] = rtype;
            //if (code == "0")
            //{
            //    //参考单据类型
            //    ViewData["RRType"] = "";
            //}
            //else
            //{
            //    //参考单据类型
            //    ViewData["RRType"] = code;
            //}
            //this.ViewData.Add(this.SetPUView());
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        /// <summary>
        /// 资产收货
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <returns></returns>
        public ActionResult SpecPIList(string code, string rtype)
        {
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        /// <summary>
        /// 通用换货
        /// </summary>
        /// <param name="code">换货出库单据类型</param>
        /// <param name="rtype">换货入库单据类型</param>
        /// <returns></returns>
        public ActionResult ComPROIList(string code, string rtype)
        {
            //string rrtype = code;
            //ViewData["RType"] = rtype;
            //ViewData["RRType"] = rrtype;
            //this.ViewData.Add(this.SetPUView());
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        /// <summary>
        /// 外修回厂
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <returns></returns>
        public ActionResult ComWOIList(string code, string rtype)
        {
            this.ViewData = this.GetRefdenped(true);
            return View();
        }


        public ActionResult ComPRList(string code, string rtype)
        {
            //string rtype = id;
            //ViewData["RType"] = rtype;
            //this.ViewData.Add(this.SetPUView());
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        public ActionResult ComWOList(string id)
        {
            //string rtype = id;
            //ViewData["RType"] = rtype;
            //this.ViewData.Add(this.SetPUView());
            this.ViewData = this.GetRefdenped(true);
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">当前单据状态</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult PUMainList(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var Config = Bll_Comm.CommRefDepend(rtype);
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch(Config.RefDepend_UDEF1);
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            string stat = code;

            List<PU_Main> list = new List<PU_Main>();
            list = puInstance.GetPUMainListByType(stat, rtype, filterSql);

            //字典数据转换
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.AuditStat + "'");
                    if (dictModel != null)
                    {
                        item.AuditStatName = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.OrderByDescending(o=>o.PUM_RDate).AsQueryable<PU_Main>();
            var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(re);
        }

        /// <summary>
        /// 收货与未收货订单数据
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult PUMainListForPOReceive(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var Config = Bll_Comm.CommRefDepend(rtype);
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
                filterSql = filter.BuildSearch(Config.RefDepend_UDEF1);
            }
            string stat = code;

            List<PU_Main> list = new List<PU_Main>();
            list = puInstance.GetPOListForReceive(stat, rtype, filterSql);

            //字典数据转换
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.AuditStat + "'");
                    if (dictModel != null)
                    {
                        item.AuditStatName = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.OrderByDescending(o => o.PUM_RDate).AsQueryable<PU_Main>();
            var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(re);
        }


    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">当前单据状态</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult AuditingPUMainList(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var Config = Bll_Comm.CommRefDepend(rtype);
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                //filterSql = " AND  "+ BulidJqGridSearch.BuildSearch(filter);
                filterSql = " AND " + filter.BuildSearch(Config.RefDepend_UDEF1);
            }

            string stat = code;
            string ucode = QX.Config.SessionConfig.UserId();

            List<PU_Main> list = new List<PU_Main>();
            list = puInstance.GetAuditingPUMainListByType(ucode, stat, rtype, ucode,filterSql);

            //字典数据转换
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.AuditStat + "'");
                    if (dictModel != null)
                    {
                        item.AuditStatName = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.OrderByDescending(o => o.PUM_RDate).AsQueryable<PU_Main>();
            var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(re);
        }


        /// <summary>
        /// 采购订单
        /// </summary>
        /// <returns></returns>
        public ActionResult POList()
        {
            this.ViewData.Add(this.SetPUView());
            return View();
        }




        /// <summary>
        /// 采购订单收货||采购换货
        /// </summary>
        /// <param name="code">参考订单编码</param>
        /// <param name="rtype">当前单据类型</param>
        /// <returns></returns>
        public ActionResult PUReceive(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            PU_Main puMain = new PU_Main();

            this.ViewData = this.GetRefdenped(true);
            return View(puMain);
        }

        /// <summary>
        /// 资产入库
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <returns></returns>
        public ActionResult SpecReceive(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            PU_Main puMain = new PU_Main();

            this.ViewData = this.GetRefdenped(true);
            return View(puMain);
        }

        /// <summary>
        /// 外修回厂确认
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <returns></returns>
        public ActionResult WOReceive(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            PU_Main puMain = new PU_Main();

            this.ViewData = this.GetRefdenped(true);
            return View(puMain);
        }

        /// <summary>
        /// 采购收货
        /// </summary>
        /// <returns></returns>
        public ActionResult PRRList()
        {
            this.ViewData.Add(this.SetPUView());
            return View();
        }

        /// <summary>
        /// 采购退货
        /// </summary>
        /// <returns></returns>
        public ActionResult PRList()
        {
            this.ViewData.Add(this.SetPUView());
            return View();
        }

        /// <summary>
        /// 采购换货
        /// </summary>
        /// <returns></returns>
        public ActionResult PROIList()
        {
            this.ViewData.Add(this.SetPUView());
            return View();
        }



        #endregion

        /// <summary>
        /// 调用存储过程更新单据相关数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdatePU(string rtype, string rcode)
        {
            puInstance.UpdatePU(rtype, rcode);

            return Content("");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult GetAuditingList()
        {
            return View();
        }

        /// <summary>
        /// 删除订单主表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oper"></param>
        /// <returns></returns>
        public ActionResult DeletePUMain(string id, string oper)
        {
            string result = "fial";
            if (!string.IsNullOrEmpty(id) && oper == "del")
            {
                bool flag = puInstance.Delete(" and PUM_RCode='" + id + "' ");
                result = flag ? "success" : "fail";
            }
            return Content(result);
        }




        #region 物料需求汇总


        /// <summary>
        /// 通用订单
        /// </summary>
        /// <param name="code">收货对应单据类型</param>
        /// <param name="rtype">当前单据类型</param>
        /// <returns></returns>
        public ActionResult ComMRList(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            //获取类型数据
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        /// <summary>
        /// 大宗采购汇总
        /// </summary>
        /// <param name="code"></param>
        /// <param name="rtype"></param>
        /// <returns></returns>
        public ActionResult MPMRList(string code, string rtype)
        {
            PUDetailList = new List<PU_Detail>();
            //获取类型数据
            this.ViewData = this.GetRefdenped(true);
            return View();
        }

        public ActionResult CreateRemand(string id)
        {
            string RRtype = Request["rrtype"] != null ? Request["rrtype"] : "";
            puInstance.CreateNewMRList(id, RRtype);

            return Content("success");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">当前单据状态</param>
        /// <param name="rtype">类型</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult MRMainList(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {

            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            ///状态
            string stat = code;

            List<PU_Main> list = new List<PU_Main>();

            list = puInstance.GetMRList(stat, rtype, filterSql);

            //字典数据转换
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.AuditStat + "'");
                    if (dictModel != null)
                    {
                        item.AuditStatName = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.AsQueryable<PU_Main>();
            var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(re);
        }


        public ActionResult MRMainListForHis(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var Config = Bll_Comm.CommRefDepend(rtype);
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
                filterSql = filter.BuildSearch(Config.RefDepend_UDEF1);
            }
            ///状态
            string stat = code;

            List<PU_Main> list = new List<PU_Main>();

            list = puInstance.GetMRListForHis(stat, rtype, filterSql);

            //字典数据转换
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.AuditStat + "'");
                    if (dictModel != null)
                    {
                        item.AuditStatName = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.AsQueryable<PU_Main>();
            var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(re);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">当前单据状态</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult AuditingMRMainList(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            string stat = code;
            string ucode = QX.Config.SessionConfig.UserId();

            List<PU_Main> list = new List<PU_Main>();
            list = puInstance.GetAuditingMRMainListByType(ucode, stat, rtype, ucode);

            //字典数据转换
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.AuditStat + "'");
                    if (dictModel != null)
                    {
                        item.AuditStatName = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.AsQueryable<PU_Main>();
            var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(re);
        }


        public ActionResult MROperation(FormCollection formCollect)
        {
            string Module = formCollect["Module"];
            string PUM_RType = formCollect["PUM_RType"];
            //获取单据业务配置相关信息
            var configDependenceModel = Bll_Comm.CommRefDepend(PUM_RType);

            //检查明细中的仓库号不能为空
            //if (!string.IsNullOrEmpty(configDependenceModel.RefDepend_UDEF8))
            //{
            //    PU_Detail pd = Bll_PU_Main.CheckPUDetailValidation(PUDetailList);
            //    if (pd != null)
            //    {
            //        var result1 = new JsonResult { Data = new { result = "fail", Msg = "请为物料:" + pd.PUD_MName + "(" + pd.PUD_MCode + ")选择仓库号" } };
            //        return result1;
            //    }
            //}


            //if (formCollect["PUM_Formoper"] == "edit")
            //{
            //    PU_Main puMain = new PU_Main();
            //    bmHelper.BindFormToModel<PU_Main>(puMain, formCollect);

            //    puInstance.UpdatePuMRMainAndDetails(puMain, PUDetailList, "");
            //}//提交数据
            //else
            //{
            //    PU_Main puMain = new PU_Main();

            //    bmHelper.BindFormToModel<PU_Main>(puMain, formCollect);

            //    puInstance.UpdatePuMRMainAndDetails(puMain, PUDetailList, configDependenceModel.RefDepend_UDEF2);

            //}

            //Modify by QB 2011-3-15

            PU_Main puMain = new PU_Main();
            bmHelper.BindFormToModel<PU_Main>(puMain, formCollect);
            puInstance.UpdatePuMRMainAndDetails(puMain, PUDetailList, configDependenceModel.RefDepend_UDEF2);

            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }

        #endregion

        //筛选--按公司分组，显示数据
        public ActionResult PU_DetailGetDatalist(string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var result = new JqGridData();
            string CCode = Request["companycode"];
            IList<PU_Detail> list;
            string searchKey = Request["searchKey"];
            string filterSql = !string.IsNullOrEmpty(searchKey) ? " and (PUD_MCode like '%" + searchKey + "%' or PUD_MName like '%" + searchKey + "%' or PUD_Spec like '%" + searchKey + "%') "
                : "";
            if (!string.IsNullOrEmpty(CCode))
            {
                list = new BLL.Bll_PU_Detail().GetListByCode(filterSql + " AND pud_rcode in (select pum_rcode from pu_main where pum_companycode='" + CCode 
                    + "' and pum_rtype='" + rtype + "' and isnull(stat,0)=0 and AuditStat='LastAudit') and pud_num>isnull(pud_num1,0) and isnull(pud_dstatus,'')='' and isnull(stat,0)=0  and PUD_Num>isnull(PUD_Num1,0) ");
            }
            else
            {
                list = new BLL.Bll_PU_Detail().GetListByCode("and pud_id=0");
            }
            var model = list.AsQueryable<PU_Detail>();
            result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        // Modify BY QB 
        // Modify:筛选--按公司分组，显示数据--大宗
        // Modify Date:2011-3-22
        public ActionResult PU_DetailGetDatalistForMP(string rtype, int page, int rows, string search, string sidx, string sord)
        {
            var result = new JqGridData();
            string CCode = Request["companycode"];
            string searchKey = Request["searchKey"];
            string filterSql = !string.IsNullOrEmpty(searchKey) ? " and (PUD_MCode like '%" + searchKey + "%' or PUD_MName like '%" + searchKey + "%' or PUD_Spec like '%"+searchKey+"%') " 
                : "";
            List<PU_Detail> list;
            if (!string.IsNullOrEmpty(CCode))
            {
                list = new BLL.Bll_PU_Detail().GetListByCode( filterSql + " AND pud_rcode in (select pum_rcode from pu_main where pum_companycode='" + CCode 
                    + "' and pum_rtype='" + rtype + "' and isnull(stat,0)=0 and AuditStat='LastAudit') and pud_num>isnull(pud_num1,0) and isnull(pud_dstatus,'')='' and isnull(stat,0)=0  and PUD_Num>isnull(PUD_Num1,0) ");
            }
            else
            {
                list = new BLL.Bll_PU_Detail().GetListByCode("and pud_id=0");
            }
            
            var model = list.AsQueryable<PU_Detail>();
            result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///将汇总转换化订单
        /// </summary>
        /// <returns></returns>
        public ActionResult MRCreateToPO()
        {
            PUDetailList = new List<PU_Detail>();

            string SelectList = Request["SelectList"] != null ? Request["SelectList"] : "";
            List<PU_Detail> DBSelectList = JsonConvert.DeserializeObject<List<PU_Detail>>(SelectList);
            if (DBSelectList.Count > 0)
            {

                List<PU_Detail> TempList = new List<PU_Detail>();
                foreach (var item in DBSelectList)
                {
                    PU_Detail puDetail = new PU_Detail();
                    //采购明细标识--(临时标识)
                    decimal maxid = 1;
                    if (TempList.Count != 0)
                    {
                        maxid = TempList.Max(o => o.PUD_ID) + 1;
                    }

                    puDetail = pudInstance.GetModel(" AND PUD_RCode='" + item.PUD_RCode + "' AND PUD_MCode='" + item.PUD_MCode + "' ");
                    puDetail.PUD_ID = maxid;
                    puDetail.PUD_Code = "PUD" + maxid.ToString();
                    puDetail.PUD_RDate = DateTime.Now;
                    //PUD_Udef1  记录参考需求计划的数量
                    puDetail.PUD_Udef1 = puDetail.PUD_RCode;
                    //puDetail.PUD_Udef2 = "";
                    //puDetail.PUD_Udef3 = "";
                    //puDetail.PUD_Udef4 = "";
                    //puDetail.PUD_Udef5 = "";
                    TempList.Add(puDetail);
                }

                //对重复物料进行筛选
                IEnumerable<PU_Detail> unQieeList = TempList.Distinct<PU_Detail>(new PU_DetailDistinct());
                //如果过滤后数据小于原数据则表示需要合并计划
                if (unQieeList.Count() < TempList.Count)
                {
                    foreach (var item in unQieeList)
                    {
                        var MCodeList = TempList.Where(o => o.PUD_MCode == item.PUD_MCode);
                        if (MCodeList.Count() > 1)
                        {
                            //存在重复物料,合并物料，并将物料的RCode存入UDEF1中
                            PU_Detail tmpModel = new PU_Detail();
                            string strRcode = "";
                            decimal sumNum = 0;
                            decimal sumTranfee = 0;
                            foreach (var MCodeItem in MCodeList)
                            {
                                strRcode += MCodeItem.PUD_RCode + ",";
                                sumNum += MCodeItem.PUD_Num;
                                sumTranfee += MCodeItem.PUD_Tranfee;
                            }
                            tmpModel = MCodeList.First();
                            tmpModel.PUD_Num = sumNum;
                            tmpModel.PUD_Tranfee = sumTranfee;
                            tmpModel.PUD_Udef1 = strRcode.TrimEnd(',');
                            PUDetailList.Add(tmpModel);
                        }
                        else
                        {
                            PUDetailList.Add(item);
                        }
                    }
                }
                else
                {
                    PUDetailList = TempList;
                }

            }
            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }


        /// <summary>
        ///将汇总转换化订单--大宗
        /// </summary>
        /// <returns></returns>
        public ActionResult MRCreateToMPPO()
        {
            PUDetailList = new List<PU_Detail>();

            string SelectList = Request["SelectList"] != null ? Request["SelectList"] : "";
            List<PU_Detail> DBSelectList = JsonConvert.DeserializeObject<List<PU_Detail>>(SelectList);
            if (DBSelectList.Count > 0)
            {

                List<PU_Detail> TempList = new List<PU_Detail>();
                foreach (var item in DBSelectList)
                {
                    PU_Detail puDetail = new PU_Detail();
                    //采购明细标识--(临时标识)
                    decimal maxid = 1;
                    if (TempList.Count != 0)
                    {
                        maxid = TempList.Max(o => o.PUD_ID) + 1;
                    }

                    puDetail = pudInstance.GetModel(" AND PUD_RCode='" + item.PUD_RCode + "' AND PUD_MCode='" + item.PUD_MCode + "' ");
                    puDetail.PUD_ID = maxid;
                    puDetail.PUD_Code = "PUD" + maxid.ToString();
                    puDetail.PUD_RDate = DateTime.Now;
                    //PUD_Udef1  记录参考需求计划的数量
                    puDetail.PUD_Udef1 = puDetail.PUD_RCode;
                    //puDetail.PUD_Udef2 = "";
                    //puDetail.PUD_Udef3 = puDetail.ude
                    //puDetail.PUD_Udef4 = "";
                    //puDetail.PUD_Udef5 = "";
                    TempList.Add(puDetail);
                }

                //对重复物料进行筛选
                IEnumerable<PU_Detail> unQieeList = TempList.Distinct<PU_Detail>(new PU_DetailDistinct());
                //如果过滤后数据小于原数据则表示需要合并计划
                if (unQieeList.Count() < TempList.Count)
                {
                    foreach (var item in unQieeList)
                    {
                        var MCodeList = TempList.Where(o => o.PUD_MCode == item.PUD_MCode);
                        if (MCodeList.Count() > 1)
                        {
                            //存在重复物料,合并物料，并将物料的RCode存入UDEF1中
                            PU_Detail tmpModel = new PU_Detail();
                            string strRcode = "";
                            decimal sumNum = 0;
                            decimal sumTranfee = 0;
                            foreach (var MCodeItem in MCodeList)
                            {
                                strRcode += MCodeItem.PUD_RCode + ",";
                                sumNum += MCodeItem.PUD_Num;
                                sumTranfee += MCodeItem.PUD_Tranfee;
                            }
                            tmpModel = MCodeList.First();
                            tmpModel.PUD_Num = sumNum;
                            tmpModel.PUD_Tranfee = sumTranfee;
                            tmpModel.PUD_Udef1 = strRcode.TrimEnd(',');
                            PUDetailList.Add(tmpModel);
                        }
                        else
                        {
                            PUDetailList.Add(item);
                        }
                    }
                }
                else
                {
                    PUDetailList = TempList;
                }

            }
            var result = new JsonResult { Data = new { result = "success" } };
            return result;
        }

        /// <summary>
        /// 财务帐期
        /// </summary>
        /// <returns></returns>
        public ActionResult Zygote()
        {
            return View();
        }
        public ActionResult ZygoteServerEidt(Bse_Period bp)
        {
            return new BLL.objInfomation().AddUpdateObject(bp, Request["Bse_Period_Formoper"]) ? Content("success") : Content("false");
        }
    }

    public class DateFormat : IFormatProvider
    {

        #region IFormatProvider 成员

        public object GetFormat(Type formatType)
        {
            return null;

        }

        #endregion
    }

    public class PU_DetailDistinct : IEqualityComparer<PU_Detail>
    {


        #region IEqualityComparer<PU_Detail> 成员

        public bool Equals(PU_Detail x, PU_Detail y)
        {
            if (x.PUD_MCode == y.PUD_MCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(PU_Detail obj)
        {
            return obj.PUD_MCode.GetHashCode();
        }

        #endregion
    }

}
