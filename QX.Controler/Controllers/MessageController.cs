using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.Model;
using QX.Comm;

using QX.HtmlHelperLib;
using QX.HtmlHelperLib.JqGrid;

namespace QX.Controllers.Controllers
{
    public class MessageController : Controller
    {

        private BLL.Bll_Message mInstance = new QX.BLL.Bll_Message();
        private BindModelHelper bmHelper = new BindModelHelper();
        private BLL.Bll_Audit auditInstance = new QX.BLL.Bll_Audit();
        //
        // GET: /Message/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMessageList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_MessageModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_Message> list = new List<Bse_Message>();
            if (string.IsNullOrEmpty(filterSql))
            {
                list = mInstance.GetMsgList("1=1");
            }
            else
            {
                list = mInstance.GetMsgList(filterSql);
            }

            var model = list.AsQueryable<Bse_Message>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }



        public ActionResult Add()
        {
            Bse_Message info = new Bse_Message();
            info.Msg_Code = mInstance.GenerateMsgCode();
            GetbackUrl();
            return View(info);
        }

        public ActionResult Edit(string id, string rtype)
        {
            var model = mInstance.GetModel(string.Format("AND Msg_Code='{0}'", id));
            string isView = string.Empty;
            GetbackUrl();
            return View(model);
        }



        [ValidateInput(false)]
        public JsonResult FileOperation(FormCollection formCollect)
        {
            var flag = false;
            Bse_Message doc = new Bse_Message();
            bmHelper.BindFormToModel<Bse_Message>(doc, formCollect);
            string type = formCollect["optype"];

            if (formCollect["formOper"] == "edit")
            {

                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.Msg_Stat = "Draft";
                }
                else
                {
                    doc.Msg_Stat = "Normal";
                    ////进入审核流程
                    //doc.AuditStat = "Auditing";
                    //var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.ComFileAudit.ToString());
                    //if (model != null)
                    //{
                    //    doc.AuditCurAudit = model.VT_VerifyNode_Code;
                    //}
                }

                flag = mInstance.Update(doc);
            }
            else
            {


                doc.CreateTime = DateTime.Now;
                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.Msg_Stat = "Draft";
                }
                else
                {
                    doc.Msg_Stat = "Normal";
                    ////进入审核流程
                    //doc.AuditStat = "Auditing";
                    //var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.DocumentAudit.ToString());
                    //if (model != null)
                    //{
                    //    doc.AuditCurAudit = model.VT_VerifyNode_Code;
                    //}
                }

                flag = mInstance.Add(doc);
                //日志记录
                //this.OpLog(this.GetControllerName(), "添加:单据类型" + puMain.PUM_RType + ",编码:" + puMain.PUM_RCode, addResult.ToString());

            }
            if (flag)
            {
                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            else
            {
                return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
            }
        }


        public void GetbackUrl()
        {
            if (string.IsNullOrEmpty(Request["backUrl"]))
            {
                ViewData["backUrl"] = "";
            }
            else
            {
                ViewData["backUrl"] = Request["backUrl"];
            }
        }


    }
}
