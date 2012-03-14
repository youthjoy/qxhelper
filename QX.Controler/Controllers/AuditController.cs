using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.BLL;
using QX.Model;
using QX.HtmlHelperLib.JqGrid;
using QX.Comm;
using QX.Config;
using Newtonsoft.Json;
using QX.AOP;
using QX.Common;

using QX.HtmlHelperLib;
using Newtonsoft.Json.Converters;


namespace QX.Controllers.Controllers
{
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters]
    [QX.Cache.CompressFilter]
    [QX.Cache.CacheFilter(Duration = 120)]

    public class AuditController : Controller
    {

        private BindModelHelper bmHelper = new BindModelHelper();
        Bll_Audit atInstance = new Bll_Audit();
        Bll_Bse_Employee stuffInstance = new Bll_Bse_Employee();
        Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
        //
        // GET: /Audit/

        public ActionResult Index()
        {
            ViewData["DictList"] = atInstance.GetTemplateList().AsEnumerable();
            return View();
        }

        public ActionResult GetVerifyNodeList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Verify_TemplateConfigModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Verify_Nodes> list = new List<Verify_Nodes>();


            if (!string.IsNullOrEmpty(filterSql))
            {
                list = atInstance.GetVerifyNodes(filterSql);
            }
            else
            {
                list = atInstance.GetVerifyNodes("1=1");
            }


            var model = list.AsQueryable<Verify_Nodes>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        public ActionResult ConfirmSel(string data, string module)
        {
            if (string.IsNullOrEmpty(data))
            {
                return Json(new { result = "fail", Msg = "数据更新失败！" }, "application/json");
            }

            atInstance.Config(data, module);

            return Json(new { result = "success", Msg = "数据更新失败！" }, "application/json");
        }

        public ActionResult VerifyNode()
        {
            return View();
        }

        public ActionResult AddUser(string code, string name, string Node)
        {
            if (!string.IsNullOrEmpty(code))
            {
                string[] codeArray = code.Split(',');
                string[] nameArray = name.Split(',');
                for (int i = 0; i < codeArray.Length; i++)
                {
                    var c = codeArray[i];
                    var na = nameArray[i];
                    Verify_Users user = new Verify_Users();
                    user.VU_User = c;
                    user.VU_UserName = na;
                    user.VU_VerifyNode_Code = Node;
                    atInstance.AddUser(user);
                }

                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
        }

        public ActionResult DelUser(string code,string NodeCode)
        {
            if (!string.IsNullOrEmpty(code))
            {
                string[] codeArray = code.Split(',');
                for (int i = 0; i < codeArray.Length; i++)
                {
                    var c = codeArray[i];
                    var user = atInstance.GetUserModel(string.Format("AND VU_VerifyNode_Code='{0}' AND VU_User={1}",NodeCode, c));
                    user.Stat = 1;
                    atInstance.UpdateUser(user);
                }

                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
        }

        public ActionResult VerifyNodeOperation(FormCollection formCollect)
        {
            var flag = true;
            Verify_Nodes doc = new Verify_Nodes();
            bmHelper.BindFormToModel<Verify_Nodes>(doc, formCollect);
            string type = formCollect["optype"];
            int isback = 0;
            if (formCollect["formOper"] == "edit")
            {
                flag = atInstance.UpdateNode(doc);
            }
            else
            {
                isback = 1;
                flag = atInstance.AddNode(doc);
            }

            if (flag)
            {
                return Json(new { result = "success", isBack = isback, Msg = "数据更新成功！" }, "application/json");
            }
            else
            {
                return Json(new { result = "fail", Msg = "数据更新失败！" }, "application/json");
            }
        }

        public ActionResult DelConfig(string data, string module)
        {
            if (string.IsNullOrEmpty(data))
            {
                return Json(new { result = "fail", Msg = "数据更新失败！" }, "application/json");
            }

            atInstance.DelConfig(data, module);

            return Json(new { result = "success", Msg = "数据更新失败！" }, "application/json");
        }

        public ActionResult GetVerifyUsers(string id, int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Verify_UsersModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Verify_Users> list = new List<Verify_Users>();
            if (!string.IsNullOrEmpty(id))
            {

                if (string.IsNullOrEmpty(filterSql))
                {
                    list = atInstance.GetVerifyUsersByNode(id,"AND 1=1");
                }
                else
                {
                    list = atInstance.GetVerifyUsersByNode(id,"AND "+filterSql);
                }
            }

            var model = list.AsQueryable<Verify_Users>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        public ActionResult GetTemplateConfigList(string id, int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Verify_TemplateConfigModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Verify_TemplateConfig> list = new List<Verify_TemplateConfig>();
            if (!string.IsNullOrEmpty(id))
            {

                if (string.IsNullOrEmpty(filterSql))
                {
                    list = atInstance.GetTemplateConfig(id);
                }
                else
                {
                    list = atInstance.GetTemplateConfig(id);
                }
            }

            var model = list.AsQueryable<Verify_TemplateConfig>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        public ActionResult Template()
        {
            return View();
        }

        /// <summary>
        /// 审核结点
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Audit()
        {
            //SessionConfig.UserId();
            string VerfiyKey = Request["verfiykey"];
            string RecordId = Request["recordid"];
            string AuditSuggest = Request["suggest"];
            string UserId = this.GetSession<string>("UserId");
            string Agree = Request["agree"] == "true" ? AudtiRecordsDataTypeEnum.Audited.ToString() : AudtiRecordsDataTypeEnum.Reject.ToString();
            string VerfiyNodeCode = Request["NodeCode"];
            //单据类型
            string Itype = Request["type"];
            string ProResult = "";

            var result = atInstance.Audit(VerfiyKey, RecordId, AuditSuggest, UserId, Agree, VerfiyNodeCode, out ProResult);

            this.OpLog(this.GetControllerName(), "审核:单据类型" + Itype + ",编码:" + RecordId, result.ToString());

            return Content(ProResult);
        }

        public ActionResult AuditUser(int page, int rows, string search, string sidx, string sord)
        {
            string VerfiyKey = Request["verfiykey"];
            string VerfiyNodeCode = Request["NodeCode"];
            if (string.IsNullOrEmpty(VerfiyKey) || string.IsNullOrEmpty(VerfiyNodeCode))
            {
                List<Verify_Users> list = new List<Verify_Users>();
                var model = list.AsQueryable<Verify_Users>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                List<Verify_Users> list = atInstance.GetVerifyUserList(VerfiyKey, VerfiyNodeCode);
                var model = list.AsQueryable<Verify_Users>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public void SendMsg(string codes, string module)
        {
            try
            {
                Bll_Sys_Map mapInst = new Bll_Sys_Map();
                var Map = mapInst.GetModel(string.Format(" AND Map_Module='{0}' AND Map_Source='{0}'", "SmsTemplate"));

                Bll_Audit auditInst = new Bll_Audit();
                var TemlateKey = auditInst.GetTemplateModel(module);



                string[] code = codes.TrimEnd(',').Split(',');
                foreach (var c in code)
                {
                    string content = string.Format(Map.Map_Object, TemlateKey.Template_Name, SessionConfig.UserName());

                    var model = stuffInstance.GetModelByCode(c);
                    GSMHelper.SendMessage(model.Emp_Mobile, content);
                }
            }
            catch (Exception ex)
            {
                QX.Log.PlateLog.WriteError(SessionConfig.UserName(), "", "", "", "发送短信失败!", QX.Log.PlateLog.LogMessageType.Error, ex);
            }

        }

        /// <summary>
        /// 下一审核人，所在部门
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult NextAuditUser()
        {
            string VerfiyKey = Request["verfiykey"];
            string VerfiyNodeCode = Request["NodeCode"];
            Verify_Users model = atInstance.GetVerifyUser(VerfiyKey, VerfiyNodeCode);
            if (model != null)
            {
                var stuffModel = new Bll_Bse_Employee().GetModel(" AND Emp_Code='" + model.VU_User + "' ");
                //var departModel = new Bll_HR_Department().GetModel(" AND Dept_Code='" + model.VU_Dept + "' ");

                model.VU_User = stuffModel != null ? stuffModel.Emp_Name : "";
                model.VU_Dept = stuffModel != null ? stuffModel.Emp_Dept_Name : "";

                return Json(model);
            }
            else
            {
                return Content("fail");
            }
        }

        /// <summary>
        /// 获取审核历史
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult AuditHistroy(string id, int page, int rows, string search, string sidx, string sord)
        {
            string VerfiyKey = Request["verfiykey"];
            string DataCode = Request["DataCode"];
            if (!string.IsNullOrEmpty(VerfiyKey) || !string.IsNullOrEmpty(DataCode))
            {
                var list = atInstance.VerfiyProcessRecords(VerfiyKey, DataCode).ToList();

                //审核人名称替换                
                //审核结果字典替换
                foreach (var item in list)
                {
                    var stuffModel = stuffInstance.GetModel(" AND Emp_Code='" + item.VRecord_Owner + "' ");
                    var dictModel = dictInstance.GetModel(" AND Dict_Key='AuditFlag' AND Dict_Code='" + item.VRecord_Flag + "'");
                    item.VRecord_Owner = stuffModel != null ? stuffModel.Emp_Name : item.VRecord_Owner;
                    item.VRecord_Flag = dictModel != null ? dictModel.Dict_Name : item.VRecord_Flag;
                    item.DeptName = stuffModel != null ? stuffModel.Emp_Dept_Name : "";
                }

                var model = list.AsQueryable<VerifyProcess_Records>();
                var result = model.ToJqGridData(page, rows, null, search, null);
                return JavaScript(JsonConvert.SerializeObject(result, new JsonDateConverter("yyyy-MM-dd HH:mm")));
            }
            else
            {
                return JavaScript("");
            }
        }

    }
}
