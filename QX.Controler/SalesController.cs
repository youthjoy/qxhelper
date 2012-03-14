using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.Model;
using QX.BLL;
using QX.Comm;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections;
using System.Data;
using System.Text;
using QX.Config;
using QX.AOP;


namespace QX.Controllers.Controllers
{
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    public class SalesController : Controller
    {

        private Bll_WH_Supplier wsInstance = new Bll_WH_Supplier();

        private BindModelHelper bmHelper = new BindModelHelper();

        private Bll_SD_Customer custInstance = new Bll_SD_Customer();
        private Bll_SD_Project projInstance = new Bll_SD_Project();
        private Bll_SD_Contract conInstance = new Bll_SD_Contract();
        private Bll_SD_CTrans transInstance = new Bll_SD_CTrans();
        private Bll_SD_ProjectParts partsInstance = new Bll_SD_ProjectParts();
        private Bll_SD_CPrice priceInstance = new Bll_SD_CPrice();
        private Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
        private Bll_Bse_Period periodInstance = new Bll_Bse_Period();
        private Bll_SD_Banlance banlanceInstance = new Bll_SD_Banlance();
        private Bll_SD_BItem bitemInstance = new Bll_SD_BItem();
        private Bll_SD_Receivable receiveableInstance = new Bll_SD_Receivable();
        private Bll_SD_Receive recevieInstance = new Bll_SD_Receive();
        private Bll_SD_Invoice invoiceInstance = new Bll_SD_Invoice();
        private Bll_Sys_Rec_RefDepend RefInstance = new Bll_Sys_Rec_RefDepend();

        //
        // GET: /Sales/
        #region 客户管理相关方法
        public ActionResult GenerateCustomerCode()
        {
            return Content(custInstance.GenerateCode());
        }


        /// <summary>
        /// 添加、编辑
        /// </summary>
        /// <param name="formCollect"></param>
        /// <returns></returns>

        public ActionResult CustomerOperation(FormCollection formCollect)
        {
            var flag = false;

            if (formCollect["CustomerFormoper"] == "edit")
            {
                WH_Supplier supMain = new WH_Supplier();
                bmHelper.BindFormToModel<WH_Supplier>(supMain, formCollect);
                var item = wsInstance.GetModelByCode(supMain.WHS_CustCode);
                if (item != null)
                {
                    supMain.WHS_IDS = item.WHS_IDS;
                }
                
                supMain.UpdateDate = DateTime.Now;
                if (wsInstance.Update(supMain))
                {
                    flag = true;
                }
                //日志记录
                this.OpLog(this.GetControllerName(), "修改:客户信息,编码:" + supMain.WHS_CustCode, flag.ToString());
            }
            else
            {
                WH_Supplier supMain = new WH_Supplier();

                bmHelper.BindFormToModel<WH_Supplier>(supMain, formCollect);
                supMain.WHS_iType = DataITypeEnum.Cust.ToString();
                supMain.Stat = 0;
                supMain.CreateDate = DateTime.Now;
                supMain.UpdateDate = DateTime.Now;
                if (wsInstance.Insert(supMain))
                {
                    flag = true;
                }
                //日志记录
                this.OpLog(this.GetControllerName(), "添加:客户信息,编码:" + supMain.WHS_CustCode, flag.ToString());
            }
            if (flag)
            {
                return new JsonResult { Data = new { result = "success" } };
            }
            else
            {
                return new JsonResult { Data = new { result = "fail" } };
            }
        }


        public ActionResult CustomerList()
        {
            return View();
        }


        /// <summary>
        /// 获取所有供应商列表（通用列表）
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetCustomerList(int page, int rows, string search, string sidx, string sord)
        {
            //string rtype = id;

            List<WH_Supplier> list = new List<WH_Supplier>();

            list = custInstance.GetCustomerList();

            var model = list.AsQueryable<WH_Supplier>();

            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }

        public ActionResult EditCustomer(string id)
        {
            ViewData["view"] = Request["view"] != null ? Request["view"] : "";
            ViewData["itype"] = Request["itype"] != null ? Request["itype"] : "Settle";
            var model = wsInstance.GetModelByCode(id);
            return View(model);

        }

        ///// <summary>
        ///// 获取供应商往来明细
        ///// </summary>
        ///// <returns></returns>
        //public ActionResult PUList(string id, int page, int rows, string search, string sidx, string sord)
        //{
        //    var list = wsInstance.GetSupplyPUList(id);
        //    var model = list.AsQueryable<RefData>();
        //    var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
        //    return JavaScript(re);
        //}

        /// <summary>
        /// 获取某个供应商具体信息
        /// </summary>
        /// <param name="supCode"></param>
        /// <returns></returns>
        public ActionResult GetCustomer(string supCode)
        {
            WH_Supplier re = new WH_Supplier();
            if (!string.IsNullOrEmpty(supCode))
            {
                re = wsInstance.GetModel(string.Format(" AND WHS_CustCode='{0}'", supCode));
            }
            JsonResult result = new JsonResult { Data = re };
            return result;
        }

        ///// <summary>
        ///// 供应商结算情况列表
        ///// </summary>
        ///// <param name="id">供应商编码</param>
        ///// <param name="page"></param>
        ///// <param name="rows"></param>
        ///// <param name="search"></param>
        ///// <param name="sidx"></param>
        ///// <param name="sord"></param>
        ///// <returns></returns>
        //public ActionResult SupBanlanceList(string id, int page, int rows, string search, string sidx, string sord)
        //{
        //    var list = wsInstance.GetSupBanlanceList(id);
        //    var model = list.AsQueryable<WH_Banlance>();
        //    var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
        //    return JavaScript(re);
        //}

        ///// <summary>
        ///// 付款情况
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="page"></param>
        ///// <param name="rows"></param>
        ///// <param name="search"></param>
        ///// <param name="sidx"></param>
        ///// <param name="sord"></param>
        ///// <returns></returns>
        //public ActionResult SupPayList(string id, int page, int rows, string search, string sidx, string sord)
        //{
        //    var list = wsInstance.GetSupPayList(id);
        //    var model = list.AsQueryable<WH_Pay>();
        //    var re = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
        //    return JavaScript(re);
        //}
        /// <summary>
        /// 获取供应商列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        //public ActionResult GetCustomerList(string id, int page, int rows, string search, string sidx, string sord)
        //{
        //    string jsonResult = string.Empty;

        //    List<WH_Supplier> supList = new List<WH_Supplier>();

        //    supList = wsInstance.GetAll();
        //    var model = supList.AsQueryable<WH_Supplier>();
        //    var result = model.ToJqGridData(page, rows, null, search, null);
        //    jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
        //    return JavaScript(jsonResult);
        //}

        public ActionResult DeleteCustomer(string code)
        {

            if (wsInstance.Delete(string.Format(" AND WHS_CustCode='{0}'", code)))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }
        #endregion


        #region 合同管理相关方法
        public ActionResult GenerateContractCode()
        {
            return Content(conInstance.GenerateCode());
        }


        /// <summary>
        /// 添加、编辑
        /// </summary>
        /// <param name="formCollect"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ContractOperation(FormCollection formCollect)
        {
            var flag = false;

            SD_Contract conMain = new SD_Contract();
            bmHelper.BindFormToModel<SD_Contract>(conMain, formCollect);

            if (formCollect["ContractFormoper"] == "edit")
            {
                //点击提交
                if (formCollect["ContractEditType"] == "valid")
                {
                    ///提交时改变状态，进入审核状态
                    if (formCollect["ContractType"] == "Audit")
                    {
                        conMain.AuditStat = AudtiOperaTypeEnum.Auditing.ToString();
                        conMain.AuditCurAudit = new Bll_Audit().GetVerifyTemplateFirstNode(AuditModuleEnum.ContractAudit.ToString()).VT_VerifyNode_Code;
                        conMain.SDC_Stat = ContractTypeEnum.Valid.ToString();
                    }
                    conMain.SDC_ID = conInstance.GetModel(" and SDC_Code='" + conMain.SDC_Code + "' ").SDC_ID;
                    if (conInstance.Update(conMain))
                    {
                        flag = true;
                    }
                }//点击草稿
                else
                {
                    conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();
                    conMain.SDC_ID = conInstance.GetModel(" and SDC_Code='" + conMain.SDC_Code + "' ").SDC_ID;
                    if (conInstance.Update(conMain))
                    {
                        flag = true;
                    }
                }

            }
            else //添加时使得合同直接保存为草稿
            {
                var temp = conInstance.GetModelByCode(conMain.SDC_Code);
                if (temp != null)
                {
                    var id = temp.SDC_ID;
                    conMain.SDC_ID = id;
                    conMain.SDC_iType = DataITypeEnum.Cust.ToString();
                    conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();//草稿状态
                    if (conInstance.Update(conMain))
                    {
                        flag = true;
                    }
                }
                else
                {
                    conMain.SDC_iType = DataITypeEnum.Cust.ToString();
                    conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();//草稿状态
                    if (conInstance.Insert(conMain))
                    {
                        flag = true;
                    }
                }


            }
            if (flag)
            {
                return new JsonResult { Data = new { result = "success" } };
            }
            else
            {
                return new JsonResult { Data = new { result = "fail" } };
            }
        }


        /// <summary>
        /// 添加、编辑--预审合同
        /// </summary>
        /// <param name="formCollect"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ContractPreOperation(FormCollection formCollect)
        {
            var flag = false;

            SD_Contract conMain = new SD_Contract();
            bmHelper.BindFormToModel<SD_Contract>(conMain, formCollect);

            if (formCollect["ContractFormoper"] == "edit")
            {
                //点击提交
                if (formCollect["ContractEditType"] == "valid")
                {
                    ///提交时改变状态，进入审核状态
                    if (formCollect["ContractType"] == "Audit")
                    {
                        conMain.AuditStat = AudtiOperaTypeEnum.Auditing.ToString();
                        conMain.AuditCurAudit = new Bll_Audit().GetVerifyTemplateFirstNode(AuditModuleEnum.ContractAudit.ToString()).VT_VerifyNode_Code;
                        conMain.SDC_Stat = ContractTypeEnum.Valid.ToString();
                    }
                    conMain.SDC_iType = DataITypeEnum.PreCust.ToString();
                    conMain.SDC_ID = conInstance.GetModel(" and SDC_Code='" + conMain.SDC_Code + "' and SDC_iType='PreCust' ").SDC_ID;
                    if (conInstance.Update(conMain))
                    {
                        flag = true;
                    }
                }//点击草稿
                else
                {
                    conMain.SDC_ID = conInstance.GetModel(" and SDC_Code='" + conMain.SDC_Code + "' and SDC_iType='PreCust' ").SDC_ID;
                    conMain.SDC_iType = DataITypeEnum.PreCust.ToString();
                    conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();
                    if (conInstance.Update(conMain))
                    {
                        flag = true;
                    }
                }

                //日志记录
                this.OpLog(this.GetControllerName(), "修改:预审合同,编码:" + conMain.SDC_Code, flag.ToString());

            }
            else //添加预审合同
            {

                var temp = conInstance.GetModelByCode(conMain.SDC_Code);
                if (temp != null)
                {
                    var id = temp.SDC_ID;
                    conMain.SDC_ID = id;
                    conMain.SDC_iType = formCollect["ContractEditType"];
                    conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();//草稿状态
                    if (conInstance.Update(conMain))
                    {
                        flag = true;
                    }
                }
                else
                {
                    conMain.SDC_iType = formCollect["ContractEditType"];
                    conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();//草稿状态
                    if (conInstance.Insert(conMain))
                    {
                        flag = true;
                    }
                }

                //日志记录
                this.OpLog(this.GetControllerName(), "添加:预审合同,编码:" + conMain.SDC_Code, flag.ToString());

                //conMain.SDC_iType = DataITypeEnum.PreCust.ToString();
                //conMain.SDC_Stat = ContractTypeEnum.Draft.ToString();
                //if (conInstance.Insert(conMain))
                //{
                //    flag = true;
                //}

            }
            if (flag)
            {
                return new JsonResult { Data = new { result = "success" } };
            }
            else
            {
                return new JsonResult { Data = new { result = "fail" } };
            }
        }

        /// <summary>
        /// 终审通过后，将预审后同转化为合同
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult PreContractToContract(string id)
        {
            JsonResult JResult = new JsonResult();

            var Premodel = conInstance.GetModel(" AND SDC_Code='" + id + "' AND SDC_iType='PreCust'");
            var model = conInstance.GetModel(" AND SDC_Code='" + id + "' AND SDC_iType='Cust'");

            if (Premodel != null)
            {
                if (model == null)
                {
                    Premodel.SDC_iType = "Cust";
                    Premodel.SDC_Stat = ContractTypeEnum.Draft.ToString();
                    conInstance.Insert(Premodel);
                    JResult = new JsonResult { Data = new { result = "success", msg = "" } };
                }
                else
                {
                    JResult = new JsonResult { Data = new { result = "fail", msg = "合同已经存在,生成合同失败" } };
                }
            }
            return JResult;
        }

        /// <summary>
        /// 检查合同是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CheckContractIsExist(string id)
        {
            string result = "";
            var model = conInstance.GetModel(" AND SDC_Code='" + id + "' AND SDC_iType='Cust'");
            if (model == null)
            {
                result = "false";
            }
            else
            {
                result = "true";
            }

            return Content(result);
        }


        public ActionResult ContractList()
        {
            return View();
        }


        /// <summary>
        /// 获取所有供应商列表（通用列表）
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetContractList(string code, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            List<SD_Contract> list = new List<SD_Contract>();

            list = conInstance.GetContractList(code, rtype, SessionConfig.UserId());

            var model = list.AsQueryable<SD_Contract>();

            //var result = model.ToJqGridData(page, rows, null, search, null);
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));

            return JavaScript(result);
        }

        public ActionResult AddContract()
        {
            return View();
        }

        public ActionResult EditContract(string id)
        {

            var model = conInstance.GetModelByCode(id);
            return View(model);

        }

        /// <summary>
        /// 获取某个工程具体信息
        /// </summary>
        /// <param name="supCode"></param>
        /// <returns></returns>
        public ActionResult GetContract(string conCode)
        {
            SD_Project re = new SD_Project();
            if (!string.IsNullOrEmpty(conCode))
            {
                re = projInstance.GetModel(string.Format(" AND SDC_Code='{0}'", conCode));
            }
            JsonResult result = new JsonResult { Data = re };
            return result;
        }

        ///// <summary>
        ///// 获取工程列表
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="page"></param>
        ///// <param name="rows"></param>
        ///// <param name="search"></param>
        ///// <param name="sidx"></param>
        ///// <param name="sord"></param>
        ///// <returns></returns>
        //public ActionResult GetContractList(string id, int page, int rows, string search, string sidx, string sord)
        //{
        //    string jsonResult = string.Empty;

        //    List<SD_Contract> conList = new List<SD_Contract>();

        //    conList = conInstance.GetAll();
        //    var model = conList.AsQueryable<SD_Contract>();
        //    var result = model.ToJqGridData(page, rows, null, search, null);
        //    jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
        //    return JavaScript(jsonResult);
        //}

        /// <summary>
        /// 删除预审合同
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult DeleteContract(string code)
        {
            var re=conInstance.Delete(string.Format(" AND SDC_Code='{0}' AND  SDC_iType='PreCust'", code));

            //日志记录
            this.OpLog(this.GetControllerName(), "删除:预审合同,编码:" + code, re.ToString());

            if (re)
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }

        /// <summary>
        /// 使合同失效
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public ActionResult InvalidContract(string code)
        {
            string result = "fail";
            string msg = "";

            if (!string.IsNullOrEmpty(code))
            {
                var Model = conInstance.GetModel(" AND SDC_Code='" + code + "' AND  SDC_iType='PreCust' ");
                if (Model!=null)
                {
                    if (Model.AuditStat == AudtiOperaTypeEnum.Auditing.ToString() || Model.AuditStat == AudtiOperaTypeEnum.LastAudit.ToString())
                    {
                        Model.SDC_Stat = ContractTypeEnum.InValid.ToString();
                        var Re = conInstance.Update(Model);
                        if (Re)
                        {
                            result = "success";
                        }
                        else
                        {
                            msg = "更新合同状态失败";
                        }
                        
                    }
                    else
                    {
                        if (Model.AuditStat==AudtiOperaTypeEnum.OnAudit.ToString())
                        {
                            msg = "合同审核中,无法失效";
                        }
                        else if (Model.AuditStat==AudtiOperaTypeEnum.Litter.ToString())
                        {
                            msg = "合同已经废弃,不需要失效";
                        }
                        
                    }                   

                }
                else
                {
                    msg = "获取合同信息失败！";
                }
            }
            else
            {
                msg = "无法获取合同信息,未获取合同编码";
            }

            this.OpLog(this.GetControllerName(), "失效:预审合同,编码:" + code, result + "," + msg);

            return new JsonResult { Data = new { result=result,msg=msg } };
        }


        public ActionResult DeleteContractStat(string code, string statType)
        {
            string statSQL = "";
            if (statType.Trim().ToLower() == "sdc_stat")
            {
                statSQL = " sdc_stat = 'Invalid' ";
            }
            else
            {
                statSQL = " stat = 1 ";
            }
            if (conInstance.Delete(string.Format(" AND SDC_Code='{0}'", code), statSQL))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }
        #endregion


        #region 工程管理相关方法
        public ActionResult GenerateProjectCode()
        {
            return Content(projInstance.GenerateCode());
        }


        /// <summary>
        /// 添加、编辑
        /// </summary>
        /// <param name="formCollect"></param>
        /// <returns></returns>

        public ActionResult ProjectOperation(FormCollection formCollect)
        {
            var flag = false;

            SD_Project proMain = new SD_Project();
            bmHelper.BindFormToModel<SD_Project>(proMain, formCollect);

            if (formCollect["ProjectFormoper"] == "edit")
            {
                if (projInstance.Update(proMain))
                {
                    flag = true;
                }

            }
            else
            {

                if (projInstance.Insert(proMain))
                {
                    flag = true;
                }

            }
            if (flag)
            {
                return new JsonResult { Data = new { result = "success" } };
            }
            else
            {
                return new JsonResult { Data = new { result = "fail" } };
            }
        }


        public ActionResult ProjectList()
        {
            return View();
        }


        /// <summary>
        /// 获取所有供应商列表（通用列表）
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetProjectList(int page, int rows, string search, string sidx, string sord)
        {
            //string rtype = id;

            List<SD_Project> list = new List<SD_Project>();

            list = projInstance.GetProjectList();

            var model = list.AsQueryable<SD_Project>();

            var result = model.ToJqGridData(page, rows, null, search, null);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddProject()
        {
            return View();
        }

        public ActionResult EditProject(string id)
        {

            var model = projInstance.GetModelByCode(id);
            return View(model);

        }

        /// <summary>
        /// 获取某个工程具体信息
        /// </summary>
        /// <param name="supCode"></param>
        /// <returns></returns>
        public ActionResult GetProject(string projCode)
        {
            SD_Project re = new SD_Project();
            if (!string.IsNullOrEmpty(projCode))
            {
                re = projInstance.GetModel(string.Format(" AND SDI_Code='{0}'", projCode));
            }
            JsonResult result = new JsonResult { Data = re };
            return result;
        }

        /// <summary>
        /// 获取工程列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetProjectList(string id, int page, int rows, string search, string sidx, string sord)
        {
            string jsonResult = string.Empty;

            List<SD_Project> projList = new List<SD_Project>();

            projList = projInstance.GetAll();
            var model = projList.AsQueryable<SD_Project>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        public ActionResult DeleteProject(string code)
        {

            if (projInstance.Delete(string.Format(" AND SDI_Code='{0}'", code)))
            {
                return Content("success");
            }
            else
            {
                return Content("fail");
            }
        }
        #endregion

        public ActionResult QContractList(string id)
        {
            ViewData["CType"] = id;
            return View();
        }

        public ActionResult QEditPreContract(string id)
        {
            string code = Request["code"];
            ViewData["CType"] = id;
            string tab = "#tabs-" + Request["tab"];
            string view = Request["view"];
            if (string.IsNullOrEmpty(view))
            {
                ViewData["view"] = "";
            }
            else
            {
                ViewData["view"] = view;
            }
            SD_Contract model = new SD_Contract();
            if (!String.IsNullOrEmpty(code))
            {
                model = conInstance.GetModel(" and SDC_Code='" + code + "' and SDC_iType='" + id + "' ");
            }
            this.ViewData.Add("tab", tab);
            return View(model);
        }

        public ActionResult QPreContractList(string id)
        {
            ViewData["CType"] = id;
            return View();
        }



        public ActionResult QAddContract()
        {
            //读出字典
            List<Bse_Dict> root = dictInstance.GetListByCode(" AND Dict_Key!=Dict_Code AND Dict_Key='PRODUCT'").OrderBy(o => o.Dict_Order).ToList();
            ViewData["Product"] = root;
            return View();
        }

        public ActionResult QAddPreContract()
        {
            //读出字典
            List<Bse_Dict> root = dictInstance.GetListByCode(" AND Dict_Key!=Dict_Code AND Dict_Key='PRODUCT'").OrderBy(o => o.Dict_Order).ToList();
            ViewData["Product"] = root;
            return View();
        }

        /// <summary>
        /// 合同添加
        /// </summary>
        /// <returns></returns>
        public ActionResult QProjectAdd(string code, string rtype)
        {
            //传递合同编码
            ViewData["SDI_Code"] = !string.IsNullOrEmpty(code) ? code : "";

            //客户编码 姚淞文  0204
            ViewData["SDI_CCode"] = !string.IsNullOrEmpty(rtype) ? rtype : "";
            return View();
        }

        /// <summary>
        /// 合同编码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ActionResult QProjectView(string id)
        {
            //传递合同编码
            ViewData["SDI_MCode"] = !string.IsNullOrEmpty(id) ? id : "";
            return View();
        }

        [HttpPost]
        public ActionResult QProjectDel(string id)
        {
            string result = "fail";
            string msg = "";
            SD_Project model = new SD_Project();
            if (!string.IsNullOrEmpty(id))
            {
                model = projInstance.GetModel(" AND SDI_Code='" + id + "' ");
                model.Stat = 1;
                var Re = projInstance.Update(model);
                if (Re)
                {
                    
                    result = "success";
                }
                else
                {
                    msg = "删除失败,请重试";
                }
            }
            else
            {
                msg = "参数传递错误";
            }

            //日志记录
            this.OpLog(this.GetControllerName(), "删除:工程信息,编码" + model.SDI_Code, result.ToString()+","+msg);

            return new JsonResult { Data = new { result=result,msg=msg  } };
        }


        [HttpPost]
        public ActionResult ProjectSave(SD_Project model)
        {
            bool result = false;
            var _model = projInstance.GetModel(" AND SDI_Code='" + model.SDI_Code + "'");
            if (_model != null)
            {
                model.SDI_ID = _model.SDI_ID;
                result = projInstance.Update(model);
                
                //日志记录
                this.OpLog(this.GetControllerName(), "修改:工程信息,编码" + model.SDI_Code, result.ToString());
            }
            else
            {
                result = projInstance.Insert(model);

                //日志记录
                this.OpLog(this.GetControllerName(), "添加:工程信息,编码" + model.SDI_Code, result.ToString());

            }
            string strResult = result ? "success" : "false";
            return Content(strResult);
        }

        [HttpPost]
        public ActionResult ProjectGetModel(string id)
        {
            SD_Project model = new SD_Project();
            if (!string.IsNullOrEmpty(id))
            {
                model = projInstance.GetModel(" AND SDI_Code='" + id + "'");
            }
            var result = JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(result);
        }

        /// <summary>
        /// 工程路线列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetSDCTransList(string id, int page, int rows, string search, string sidx, string sord)
        {
            if (!string.IsNullOrEmpty(id))
            {
                string jsonResult = string.Empty;

                List<SD_CTrans> projList = new List<SD_CTrans>();

                projList = transInstance.GetListByCode(" AND SDT_PCode='" + id + "'");
                foreach (var item in projList)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.SDT_Unit + "' AND Dict_Key='ROUTEUNITS'");
                    if (dictModel != null)
                    {
                        item.SDT_Unit = dictModel.Dict_Name;
                    }
                }
                var model = projList.AsQueryable<SD_CTrans>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd HH:mm:ss"));
                return JavaScript(jsonResult);
            }
            else
            {
                return new EmptyResult();
            }

        }

        private Bll_Sys_Config_ListPage instance = new Bll_Sys_Config_ListPage();
        private Bll_Sys_Config_Fieled filedInstance = new Bll_Sys_Config_Fieled();

        /// <summary>
        /// 工程路线操作
        /// </summary>
        /// <param name="oper"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SDCTransOper(string oper, string id)
        {
            string Form = Request["form"];
            SD_CTrans model = new SD_CTrans();
            if (!string.IsNullOrEmpty(Form))
            {
                model = JsonConvert.DeserializeObject<SD_CTrans>(Form);
            }

            if (oper == JqGridEnum.view.ToString())
            {
                List<SD_CTrans> list = transInstance.GetListByCode(" AND SDT_Code='" + id + "'");
                model = new SD_CTrans();
                if (list.Count > 0)
                {
                    model = list[0];
                }
                return JavaScript(JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd HH:mm:ss")));
            }
            else if (oper == JqGridEnum.edit.ToString())
            {
                model.SDT_ID = transInstance.GetModel(" And SDT_Code='" + model.SDT_Code + "'").SDT_ID;
                bool result = transInstance.Update(model);
                string strResult = result ? "success" : "fail";
                return Content(strResult);
            }
            else if (oper == JqGridEnum.del.ToString())
            {
                bool result = transInstance.Delete(" AND SDT_Code='" + id + "'");
                string strResult = result ? "success" : "fail";
                return Content(strResult);
            }
            else if (oper == JqGridEnum.add.ToString())
            {
                //string form = Request["form"];
                bool result = transInstance.Insert(model);
                string strResult = result ? "success" : "fail";
                return Content(strResult);
            }
            else
            {
                return new EmptyResult();
            }
        }


        /// <summary>
        /// 工程部位List
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetSDProjectPartsList(string id, int page, int rows, string search, string sidx, string sord)
        {
            string jsonResult = string.Empty;

            List<SD_ProjectParts> projList = new List<SD_ProjectParts>();
            //ysw 0204
            if (string.IsNullOrEmpty(id))
            {
                projList = new List<SD_ProjectParts>();
                var model = projList.AsQueryable<SD_ProjectParts>();
                return Json(model.ToJqGridData(page, rows, null, search, null));
                //var result = model.ToJqGridData(page, rows, null, search, null);
                //jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
                //return JavaScript(jsonResult);
            }
            else
            {
                projList = partsInstance.GetListByCode(" AND SDPP_PCode='" + id + "'");
                var model = projList.AsQueryable<SD_ProjectParts>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
                return JavaScript(jsonResult);
            }


        }


        /// <summary>
        /// 工程部位编辑
        /// </summary>
        /// <param name="oper"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ProjectPartsOper(string oper, string id)
        {
            string Form = Request["form"];
            SD_ProjectParts model = new SD_ProjectParts();
            if (!string.IsNullOrEmpty(Form))
            {
                model = JsonConvert.DeserializeObject<SD_ProjectParts>(Form);
            }

            if (oper == JqGridEnum.view.ToString())
            {
                List<SD_ProjectParts> list = partsInstance.GetListByCode(" AND SDPP_Code='" + id + "'");
                model = new SD_ProjectParts();
                if (list.Count > 0)
                {
                    model = list[0];
                }
                return JavaScript(JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd")));
            }
            else if (oper == JqGridEnum.edit.ToString())
            {
                model.SDPP_ID = partsInstance.GetModel(" And SDPP_Code='" + model.SDPP_Code + "'").SDPP_ID;
                bool result = partsInstance.Update(model);
                string strResult = result ? "success" : "fail";
                return Content(strResult);
            }
            else if (oper == JqGridEnum.del.ToString())
            {
                bool result = projInstance.Delete(" AND SDPP_Code='" + id + "'");
                string strResult = result ? "success" : "fail";
                return Content(strResult);
            }
            else if (oper == JqGridEnum.add.ToString())
            {
                //string form = Request["form"];
                bool result = partsInstance.Insert(model);
                string strResult = result ? "success" : "fail";
                return Content(strResult);
            }
            else
            {
                return new EmptyResult();
            }
        }

        /// <summary>
        /// 合同相关的工程信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult ProjectWithContract(string id, int page, int rows, string search, string sidx, string sord)
        {
            string jsonResult = string.Empty;
            if (!string.IsNullOrEmpty(id))
            {
                List<SD_Project> projList = new List<SD_Project>();
                projList = projInstance.GetListByCode(" AND SDI_MCode='" + id + "'");
                var model = projList.AsQueryable<SD_Project>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
                return JavaScript(jsonResult);
            }
            else
            {
                return new EmptyResult();
            }

        }

        public ActionResult GetProjectCode()
        {
            string key = new Bll_Comm().GetTableKeyCode("SD_Project");
            return Json(new { SDI_Code = key });
        }


        public ActionResult QEditContract(string id)
        {
            string code = Request["code"];
            string view = Request["view"];
            string tab ="#tabs-" +Request["tab"];
            //读出字典
            List<Bse_Dict> root = dictInstance.GetListByCode(" AND Dict_Key!=Dict_Code AND Dict_Key='PRODUCT' ").OrderBy(o => o.Dict_Order).ToList();
            ViewData["Product"] = root;

            ViewData["view"] = !string.IsNullOrEmpty(view) ? "view" : "";
            SD_Contract model = new SD_Contract();
            if (!String.IsNullOrEmpty(code))
            {
                model = conInstance.GetModel(" and SDC_Code='" + code + "' ");
            }
            this.ViewData.Add("tab", tab);
            return View(model);
        }

        /// <summary>
        /// 价格列表初始化及筛选
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult PriceFilter(string id, int page, int rows, string search, string sidx, string sord)
        {
            string ContractNo = id;
            string Category = Request["Category"] != null ? Request["Category"] : "";
            List<SD_CPrice> list = new List<SD_CPrice>();

            List<Bse_Dict> dictList = dictInstance.GetListByCode(string.Format(" AND Dict_Key in ('{0}','{1}')", "PRODUCT", "CONCRETECLASS "));

            string filter = " AND SDP_SCode='" + ContractNo + "' ";
            if (!string.IsNullOrEmpty(Category))
            {
                filter += "and SDP_Category='" + Category + "'";
            }
            list = priceInstance.GetListByCode(filter);

            foreach (var item in list)
            {
                item.SDP_Category = !string.IsNullOrEmpty(item.SDP_Category) ? dictList.FirstOrDefault(o=>o.Dict_Code==item.SDP_Category).Dict_Name :"";
            }
            list = list.OrderByDescending(o => o.SDP_ID).ToList();

            foreach (var item in list)
            {
                if (!string.IsNullOrEmpty(item.SDP_Level))
                {
                    var dictModel = dictList.FirstOrDefault(o=>o.Dict_Code==item.SDP_Level);
                    if (dictModel != null)
                    {
                        item.SDP_Level = dictModel.Dict_Name;
                    }

                }

            }

            var model = list.AsQueryable<SD_CPrice>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }
        #region 结算

        /// <summary>
        /// 销售结算
        /// </summary>
        /// <returns></returns>
        public ActionResult Settle()
        {
            ViewData["itype"] = Request["itype"] != null ? Request["itype"] : "";
            ViewData["type"] = Request["type"] != null ? Request["type"] : "";
            //查询当月帐期
            var model = periodInstance.GetModel(string.Format(" and  BP_Year='{0}' and BP_Month='{1}'",
                DateTime.Now.Year.ToString(), DateTime.Now.Month));
            ViewData["startdate"] = model != null ? model.BP_Start.ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");
            ViewData["enddate"] = model != null ? model.BP_End.ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");

            return View();
        }

        /// <summary>
        /// 销售付款
        /// </summary>
        /// <returns></returns>
        public ActionResult Pay()
        {
            ViewData["Type"] = Request["type"] != null ? Request["type"] : "";
            return View();
        }

        /// <summary>
        /// 客户发票
        /// </summary>
        /// <returns></returns>
        public ActionResult Invoic()
        {
            return View();
        }


        /// <summary>
        /// 生成结算单
        /// </summary>
        /// <returns></returns>
        public ActionResult General_Run(int page, int rows, string search, string sidx, string sord)
        {
            string BanType = Request["bantype"] != null ? Request["bantype"].ToString() : "";
            string Vendor = Request["vendor"] != null ? Request["vendor"].ToString() : "";
            string startdate = Request["startdate"] != null ? Request["startdate"].ToString() : "";
            string enddate = Request["enddate"] != null ? Request["enddate"].ToString() : "";
            if (BanType == "all")
            {
                DataTable dt = banlanceInstance.RunPro("daye", BanType.ToUpper(), Vendor, startdate, enddate);
                return Content("");
            }
            else if (BanType == "temp")
            {
                DataTable dt = banlanceInstance.RunPro("daye", BanType.ToUpper(), Vendor, startdate, enddate);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable newDt = GetPagedTable(dt, page, rows);
                    var json = JsonForJqgrid(dt);
                    return JavaScript(json);
                }
                else
                {
                    return new EmptyResult();
                }
            }
            else
            {
                List<SD_Banlance> list = new List<SD_Banlance>();
                string sqlFilter = " and (SDB_CCode like '%" + Vendor + "%' or SDB_CName like '%" + Vendor + "%' )";
                if (!string.IsNullOrEmpty(startdate))
                {
                    sqlFilter += " and SDB_Date>'" + startdate + "' ";
                }
                if (!string.IsNullOrEmpty(enddate))
                {
                    sqlFilter += " and SDB_Date<'" + enddate + "' ";
                }
                list = banlanceInstance.GetListByCode(sqlFilter);
                var model = list.AsQueryable<SD_Banlance>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
                return JavaScript(_result);
            }
        }


        /// <summary>
        /// 所有结算单列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult List(int page, int rows, string search, string sidx, string sord)
        {
            string type = Request["type"] != null ? Request["type"].ToString() : "";  //当月
            string itype = Request["itype"] != null ? Request["itype"].ToString() : "";//内置类型

            List<SD_Banlance> list = new List<SD_Banlance>();
            if (!string.IsNullOrEmpty(type))
            {
                DateTime now = DateTime.Now;
                DateTime d1 = new DateTime(now.Year, now.Month, 1);
                DateTime d2 = d1.AddMonths(1).AddDays(-1);
                list = banlanceInstance.GetListByCode(string.Format(" and SDB_Date>'{0}' and SDB_Date<'{1}' and isnull(SDB_Status,'" + BanlanceTypeEnum.UnSettle.ToString() + "')<>'{2}' ",
                    d1, d2, BanlanceTypeEnum.Settled.ToString()));
            }
            else
            {
                list = banlanceInstance.GetAll();
            }
            if (!string.IsNullOrEmpty(itype))
            {
                list = list.Where(o => o.SDB_iType == itype).ToList();
            }

            var model = list.AsQueryable<SD_Banlance>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(_result);
        }

        string DetailFilter = " and SDBI_CCode='{0}' and SDBI_Period='{1}' ";
        /// <summary>
        /// 结算物料明细
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult DetailList(string id, int page, int rows, string search, string sidx, string sord)
        {
            List<SD_BItem> list = new List<SD_BItem>();
            if (!string.IsNullOrEmpty(id))
            {
                list = bitemInstance.GetListByCode(" and SDBI_SCode='" + id + "' ");
            }
            else
            {
                string scode = Request["scode"];
                string period = Request["period"];
                if (!string.IsNullOrEmpty(scode) && !string.IsNullOrEmpty(period))
                {
                    list = bitemInstance.GetListByCode(string.Format(DetailFilter, scode, period));
                }
            }

            var model = list.AsQueryable<SD_BItem>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(_result);
        }

        string BalanceFilter = " and SDB_CCode='{0}' and SDB_Period='{1}'";

        /// <summary>
        /// 获取结算主表信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MModel()
        {
            string id = Request["id"];
            string scode = Request["scode"];
            string period = Request["period"];
            SD_Banlance model = new SD_Banlance();
            if (!string.IsNullOrEmpty(id))
            {
                model = banlanceInstance.GetModel(" and SDB_Code='" + id + "'");
            }
            else
            {
                model = banlanceInstance.GetModel(string.Format(BalanceFilter, scode, period));
                model.SDB_Code = Bll_Comm.GetTableKey("SD_Banlance");
            }
            //结算状态
            //if (string.IsNullOrEmpty(model.WHB_Status))
            //{
            //    model.WHB_Status = BanlanceTypeEnum.UnSettle.ToString();
            //}
            var result = JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(result);
        }

        public ActionResult Invioce()
        {
            return View();
        }

        /// <summary>
        /// 确定结算
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult BanlanceSave(SD_Banlance model)
        {
            bool flag = false;
            if (model != null)
            {
                //保存主表
                model.SDB_ID = banlanceInstance.GetModel(string.Format(BalanceFilter, model.SDB_CCode, model.SDB_Period)).SDB_ID;
                //model.SDB_Status = BanlanceTypeEnum.Settled.ToString();

                bool result = banlanceInstance.Update(model);
                if (result)
                {
                    //更新明细
                    List<SD_BItem> detailList = bitemInstance.GetListByCode(string.Format(DetailFilter, model.SDB_CCode, model.SDB_Period));
                    foreach (var item in detailList)
                    {
                        item.SDBI_SCode = model.SDB_Code;
                        item.SDBI_Code = Bll_Comm.GetTableKey("SD_BItem");
                        bitemInstance.Update(item);
                    }
                    flag = true;
                }
                //model.SDB_Status

                //确认结算后插入应收款表
                if (model.SDB_Status == BanlanceTypeEnum.Settled.ToString() && flag)
                {
                    //WH_Payable payModel = new WH_Payable();
                    //payModel.WHP_Code = Bll_Comm.GetTableKey("WH_Payable");
                    //payModel.WHP_SCode = model.WHB_SCode;
                    //payModel.WHP_SName = model.WHB_SName;
                    //payModel.WHP_Period = model.WHB_Period;
                    //payModel.WHP_LSum = model.WHB_LastMonth;
                    //payModel.WHP_CSum = model.WHB_CurPay;//本月应付
                    //payModel.WHP_CLeft = model.WHB_NextMonth;
                    //bool _result = payableInstance.Insert(payModel);
                    SD_Receivable receiveModel = new SD_Receivable();
                    receiveModel.SDR_Code = Bll_Comm.GetTableKey("SD_BItem");
                    receiveModel.SDR_CCode = model.SDB_CCode;
                    receiveModel.SDR_CName = model.SDB_CName;
                    receiveModel.SDR_Period = model.SDB_Period;
                    receiveModel.SDR_Last = model.SDB_Last; //上月结余
                    receiveModel.SDR_Left = model.SDB_Left; //本月应收结余
                    receiveModel.SDR_Current = model.SDB_CurRecevie;//本月应收
                    bool _result = receiveableInstance.Insert(receiveModel);
                }
            }
            string strResult = flag ? "success" : "fail";
            return Content(strResult);
        }
        #endregion
        /// <summary>
        /// 返回参考依赖类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult RefType(string id)
        {
            List<Sys_Rec_RefDepend> list = new List<Sys_Rec_RefDepend>();
            if (!string.IsNullOrEmpty(id))
            {
                list = RefInstance.GetListByCode(" and RefDepend_Code='" + id + "' ");
            }
            //var result = JsonConvert.SerializeObject(list);
            return Json(list);
        }

        /// <summary>
        /// 保存应收款信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult PayableSave(SD_Receive model)
        {
            bool flag = false;
            if (model != null)
            {
                bool payResult = false;

                flag = recevieInstance.Insert(model);
                if (flag && model.SDPR_RefCode != "" && model.SDPR_RefType == "PAYABLE")
                {
                    //更新应收款
                    SD_Receivable payableModel = receiveableInstance.GetModel(" and SDR_Code='" + model.SDPR_RefCode + "' ");
                    payableModel.SDR_IsDone = (int)PayMoenyEnum.Payed;
                    payResult = receiveableInstance.Update(payableModel);
                }
                else if (flag && model.SDPR_RefCode != "" && model.SDPR_RefType == "Invoice")
                {
                    //更新发票状态
                    SD_Invoice invoiceModel = invoiceInstance.GetModel(" and SDCI_Code='" + model.SDPR_RefCode + "' ");
                    invoiceModel.SDCI_Status = PayStatEnum.PAYED.ToString();
                    //invoiceModel.WHI_PayCode = model.WHPP_Code;
                    payResult = invoiceInstance.Update(invoiceModel);
                }
                if (!payResult)
                {
                    recevieInstance.Delete(" and SDR_Code='" + model.SDPR_Code + "' ");
                    flag = false;
                }
            }
            string strResult = flag ? "success" : "fail";
            return Content(strResult);
        }

        /// <summary>
        /// 应收款列表
        /// </summary>
        /// <returns></returns>
        public ActionResult PayableList(int page, int rows, string search, string sidx, string sord)
        {
            List<SD_Receivable> list = new List<SD_Receivable>();
            list = receiveableInstance.GetListByCode(" and isnull(SDR_IsDone,0)=0 ").OrderByDescending(o => o.SDR_Date).ToList();
            var model = list.AsQueryable<SD_Receivable>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(_result);
        }

        public ActionResult ReceiveList(int page, int rows, string search, string sidx, string sord)
        {
            List<SD_Receive> list = recevieInstance.GetAll().OrderByDescending(o => o.SDPR_Date).ToList();
            var model = list.AsQueryable<SD_Receive>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(_result);
        }

        /// <summary>
        /// 对DataTabel进行JqGrid的格式转换
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string JsonForJqgrid(DataTable dt)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{\"Page\":1,\"Total\":" + dt.Rows.Count + ",\"Records\":" + dt.Rows.Count + ",\"Rows\":");
            jsonBuilder.Append(JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd")));
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }
        /// <summary>
        /// 对DataTable分页
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0)
                return dt;
            DataTable newdt = dt.Clone();
            //newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;

            if (rowbegin >= dt.Rows.Count)
                return newdt;

            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }

        //小票
        public ActionResult NRecord()
        {
            return View();
        }
        //异常小票
        public ActionResult DRecord()
        {
            return View();
        }

        /// <summary>
        /// 客户计划
        /// </summary>
        /// <returns></returns>
        public ActionResult CPlan()
        {
            return View();
        }
        public ActionResult ReceiveListselect(int page, int rows, string search, string sidx, string sord)
        {
            string id = Request["id"];
            List<SD_Receive> list = recevieInstance.GetListByCode(" and SDPR_CCode='" + id + "'").OrderByDescending(o => o.SDPR_Date).ToList();
            var model = list.AsQueryable<SD_Receive>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(_result);
        }
        public ActionResult NRecordListselect(int page, int rows, string search, string sidx, string sord)
        {
            string id = Request["id"];
            List<PCD_NRecord> list = new BLL.Bll_PCD_NRecord().GetListByCode(" and PCDN_CCode='" + id + "'", "select").OrderByDescending(o => o.PCDN_DDate).ToList();
            var model = list.AsQueryable<PCD_NRecord>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            var _result = JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(_result);
        }
    }
}
