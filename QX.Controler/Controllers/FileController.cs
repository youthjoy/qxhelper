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
using System.IO;

namespace QX.Controllers.Controllers
{
    public class FileController : Controller
    {
        private BLL.Bll_Audit auditInstance = new QX.BLL.Bll_Audit();
        private Bll_Doc_Info diInstance = new Bll_Doc_Info();
        private BindModelHelper bmHelper = new BindModelHelper();
        public Bll_File fInstance = new Bll_File();
        //
        // GET: /Comm/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            Bse_File info = new Bse_File();
            info.CF_Code = fInstance.GenerateComFileCode();
            GetbackUrl();
            return View(info);
        }

        

        [ValidateInput(false)]
        public JsonResult FileOperation(FormCollection formCollect)
        {
            var flag = false;
            Bse_File doc = new Bse_File();
            bmHelper.BindFormToModel<Bse_File>(doc, formCollect);
            string type = formCollect["optype"];
            int isback = 0;
            if (formCollect["formOper"] == "edit")
            {

                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.CF_iType = "Draft";
                }
                else if(type=="submit")
                {
                    doc.CF_iType = "Normal";
                    //进入审核流程
                    doc.AuditStat = "Auditing";
                    var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.ComFileAudit.ToString());
                    if (model != null)
                    {
                        doc.AuditCurAudit = model.VT_VerifyNode_Code;
                    }
                }
             
                flag = fInstance.UpdateModel(doc);

                BLL.Bll_Comm.OpLog("Bse_FileModule", "FileOperation", string.Format("更新文件:{0}", doc.CF_Code));
            }
            else
            {

                isback = 1;
                doc.CreateTime = DateTime.Now;
                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.CF_iType = "Draft";
                }
                else
                {
                    doc.CF_iType = "Normal";
                    //进入审核流程
                    doc.AuditStat = "Auditing";
                    var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.DocumentAudit.ToString());
                    if (model != null)
                    {
                        doc.AuditCurAudit = model.VT_VerifyNode_Code;
                    }
                }
                doc.CF_Creator = SessionConfig.UserId();
                doc.CF_CreatorName = SessionConfig.UserName();
                flag = fInstance.AddModel(doc);
                //日志记录
                BLL.Bll_Comm.OpLog("Bse_FileModule", "FileOperation", string.Format("添加文件:{0}", doc.CF_Code));

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


        public ActionResult Delete(string id)
        {
            
            Bse_File doc = fInstance.GetModel(string.Format("AND CF_Code='{0}'", id));
            doc.Stat = 1;
            fInstance.UpdateModel(doc);

            BLL.Bll_Comm.OpLog("Bse_FileModule", "Delete", string.Format("删除文档:{0}", id));

            return Json(new { result = "success", message = "成功" }, "text/json");
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

        public ActionResult DoingList()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Edit(string id, string rtype)
        {
            var model = fInstance.GetModel(string.Format("AND CF_Code='{0}'", id));
            string isView = string.Empty;
            if (!string.IsNullOrEmpty(rtype))
            {
                isView = "view";
                ViewData["IsView"] = "display:none";
            }

            GetbackUrl();
            return View(model);
        }

        public ActionResult Correct(string id, string rtype)
        {
            var model = fInstance.GetModel(string.Format("AND CF_Code='{0}'", id));
            string isView = string.Empty;
            if (!string.IsNullOrEmpty(rtype))
            {
                isView = "view";
                ViewData["IsView"] = "display:none";
            }

            GetbackUrl();
            return View(model);
        }

        public ActionResult Show(string id)
        {
            var model = fInstance.GetModel(string.Format("AND CF_Code='{0}'", id));
            string isView = string.Empty;
     
            GetbackUrl();
            return View(model);
        }

        /// <summary>
        /// 获取文档列表(草稿）
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetFileList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_FileModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_File> list = new List<Bse_File>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);
            if (string.IsNullOrEmpty(filterSql))
            {
                list = fInstance.GetFileList("1=1"+orderby);
            }
            else
            {
                list = fInstance.GetFileList(filterSql+orderby);
            }

            var model = list.AsQueryable<Bse_File>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        /// <summary>
        /// 获取待审列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetAuditList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_FileModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_File> list = new List<Bse_File>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);
            if (string.IsNullOrEmpty(filterSql))
            {
                list = fInstance.GetAuditList("1=1"+orderby);
            }
            else
            {
                list = fInstance.GetAuditList(filterSql+orderby);
            }

            var model = list.AsQueryable<Bse_File>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取待办文档列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetDoingList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_FileModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_File> list = new List<Bse_File>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);
            if (string.IsNullOrEmpty(filterSql))
            {
                list = fInstance.GetDoingFileList("1=1"+orderby);
            }
            else
            {
                list = fInstance.GetDoingFileList(filterSql+orderby);
            }

            var model = list.AsQueryable<Bse_File>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取文档列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetAllFileList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_FileModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_File> list = new List<Bse_File>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);
            if (string.IsNullOrEmpty(filterSql))
            {
                list = fInstance.GetAllFileList("1=1"+orderby);
            }
            else
            {
                list = fInstance.GetAllFileList(filterSql+orderby);
            }

            var model = list.AsQueryable<Bse_File>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        public ActionResult GetMySubmitList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Bse_FileModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Bse_File> list = new List<Bse_File>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);
            if (string.IsNullOrEmpty(filterSql))
            {
                list =fInstance.GetMyFileList("1=1"+orderby);
            }
            else
            {
                list = fInstance.GetMyFileList(filterSql+orderby);
            }

            var model = list.AsQueryable<Bse_File>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        public ActionResult UploadFile(string code, string path, string module)
        {
            string fileName = Path.GetFileName(path);
            Doc_Attachment attachment = new Doc_Attachment();
            attachment.Dat_Name = fileName;
            attachment.Dat_Path = path;
            attachment.Dat_Module = module;
            attachment.Dat_RefCode = code;
            attachment.Dat_Code = diInstance.GenerateAttachmentCode();
            diInstance.AddAttachment(attachment);
            return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
        }

    }
}
