using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using QX.Model;
using QX.BLL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QX.Comm;
using QX.Config;
using System.IO;
using System.Text;
using QX.HtmlHelperLib.JqGrid;
using QX.HtmlHelperLib;

namespace QX.Controllers.Controllers
{
    public class CompController : Controller
    {

        #region 操作句柄

        private Bll_RoadComponents rcInstance = new Bll_RoadComponents();
        private Bll_Comp cInstance = new Bll_Comp();
        //  private Bll_Doc diInstance = new Bll_Doc();
        //  private Bll_Doc_Info dinfoInstance = new Bll_Doc_Info();
        //  private BLL.Bll_Audit auditInstance = new QX.BLL.Bll_Audit();
        private BindModelHelper bmHelper = new BindModelHelper();


        #endregion
        //
        // GET: /Comp/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Test()
        {
            return View();
        }
        public ActionResult List()
        {
            ViewData["DeptList"] = cInstance.GenerateCompTree();
            return View();
        }


        public ActionResult Add()
        {
            Bse_Components info = new Bse_Components();
            info.Comp_Code = cInstance.GenerateCompCode();
            info.Comp_Creator = SessionConfig.UserId();
            info.Comp_CreatorName = SessionConfig.UserName();
            info.Comp_Date = DateTime.Now;

            GetbackUrl();

            return View(info);
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


        public ActionResult Correct(string id, string rtype)
        {
            var model = cInstance.GetModel(string.Format("AND Comp_Code='{0}'", id));
            string isView = string.Empty;

            GetbackUrl();
            return View(model);
        }

        public ActionResult Delete(string id)
        {

            Bse_Components doc = cInstance.GetModel(string.Format("AND Comp_Code='{0}'", id));
            cInstance.DeleteComp(doc);

            BLL.Bll_Comm.OpLog("Bse_ComponentsModule", "Delete", string.Format("删除图纸:{0}", id));

            return Json(new { result = "success", message = "成功" }, "text/json");
        }



        public ActionResult Show(string id, string rtype)
        {
            var model = cInstance.GetModel(string.Format("AND Comp_Code='{0}'", id));
            string isView = string.Empty;
            if (!string.IsNullOrEmpty(rtype))
            {
                isView = "view";
                ViewData["IsView"] = "view";
            }
            GetbackUrl();
            return View(model);
        }

        [ValidateInput(false)]
        public JsonResult CompOperation(FormCollection formCollect)
        {
            var flag = false;
            Bse_Components doc = new Bse_Components();
            bmHelper.BindFormToModel<Bse_Components>(doc, formCollect);
            string type = formCollect["optype"];
            int isback = 0;

            //var chlist = cInstance.GetCompHisList(string.Format("AND CH_CompCode='{0}'", doc.Comp_Code));
            //if (chlist.Count == 0)
            //{
            //    return Json(new { result = "fail", Msg = "请上传图纸图片附件！" }, "application/json");
            //}

            if (formCollect["formOper"] == "edit")
            {

                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.Comp_Stat = "Draft";
                }
                else if (type == "submit")
                {
                    doc.Comp_Stat = "Normal";
                    //进入审核流程
                    doc.AuditStat = "Auditing";
                    //  var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.CompAudit.ToString());

                }

                flag = cInstance.UpdateComp(doc);

                BLL.Bll_Comm.OpLog("Bse_ComponentsModule", "CompOperation", string.Format("更新图纸:{0}", doc.Comp_Code));
            }
            else
            {

                //doc.Doc_Code = diInstance.GenerateDocCode();
                isback = 1;
                doc.CreateTime = DateTime.Now;
                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.Comp_Stat = "Draft";
                }
                else
                {
                    //var list = cInstance.GetCompHisList(string.Format("AND CH_CompCode='{0}' AND CH_iType='File'", doc.Comp_Code));

                    //if (list.Count == 0)
                    //{
                    //    return Json(new { result = "success", isBack = isback, Msg = "请上传图纸附件！" }, "application/json");
                    //}


                    doc.Comp_Stat = "Normal";
                    //进入审核流程
                    doc.AuditStat = "Auditing";

                }

                flag = cInstance.AddComp(doc);
                //日志记录
                BLL.Bll_Comm.OpLog("Bse_ComponentsModule", "CompOperation", string.Format("添加图纸:{0}", doc.Comp_Code));

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

        public ActionResult GetCompDraftList(string id, string rtype, int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            //if (!string.IsNullOrEmpty(filter))
            //{
            //    filterSql = filter.BuildSearch("Bse_ComponentsModule");
            //    //filterSql = BulidJqGridSearch.BuildSearch(filter);
            //}
            List<Bse_Components> list = new List<Bse_Components>();
            if (string.IsNullOrEmpty(filterSql))
            {
                list = cInstance.GetCompDraftList("1=1");
            }
            else
            {
                list = cInstance.GetCompDraftList(filterSql);
            }

            var model = list.AsQueryable<Bse_Components>();
            //var result = model.ToJqGridData(page, rows, null, search, null);

            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
            //return Json(result, JsonRequestBehavior.AllowGet);
        }



        /// <summary>
        /// 零件图纸上传(图片上传)
        /// </summary>
        /// <param name="qqfile"></param>
        /// <returns></returns>
        public ActionResult Upload(string qqfile)
        {
            var path = Server.MapPath("~/Upload");
            var dpath = Server.MapPath("~/Upload/Temp");
            string file = Comm.FileUpload.UploadFile(qqfile, path, System.Web.HttpContext.Current);
            string dfile = Path.Combine(dpath, Path.GetFileName(file));

            //业务处理 已审人数*50作为高度

            if (string.IsNullOrEmpty(file))
            {
                return Json(new { result = "fail", message = "上传失败!" }, "application/json");
            }

            ThumNail.AddWaterWord(SessionConfig.UserName(), file, dfile, 100, 100);

            return Json(new { result = "success", path = "/Upload/" + Path.GetFileName(file), message = "成功" }, "application/json");
        }


        public ActionResult DoingComp()
        {
            return View();
        }

        /// <summary>
        /// 获取零件图号
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetComponentsList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_ComponentsModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Road_Components> list = new List<Road_Components>();
            if (string.IsNullOrEmpty(filterSql))
            {
                list = rcInstance.GetCompList("1=1");
            }
            else
            {
                list = rcInstance.GetCompList(filterSql);
            }

            var model = list.AsQueryable<Road_Components>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取客户列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetCustomerList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = BulidJqGridSearch.BuildSearch(filter);
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<SD_Customer> list = new List<SD_Customer>();
            if (string.IsNullOrEmpty(filterSql))
            {
                list = cInstance.GetCustomerList("1=1");
            }
            else
            {
                list = cInstance.GetCustomerList(filterSql);
            }

            var model = list.AsQueryable<SD_Customer>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取所有图纸（非草稿  与本人相关）
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>

        /// <summary>
        /// 根据客户获取对应图号的相关图纸
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>







        /// <summary>
        /// 获取待办图纸
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>













    }
}
