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
using System.Text;
using QX.AOP;

namespace QX.Controllers.Controllers
{
    public class DocController : Controller
    {
        #region 操作句柄

        private BLL.Bll_Doc_Info diInstance = new QX.BLL.Bll_Doc_Info();
        private BLL.Bll_Audit auditInstance = new QX.BLL.Bll_Audit();
        private BLL.Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
        private Bll_Sys_UserPermission pInstance = new Bll_Sys_UserPermission();

        private BindModelHelper bmHelper = new BindModelHelper();
        #endregion

        //
        // GET: /Doc/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            Doc_Info info = new Doc_Info();
            info.Doc_Code = diInstance.GenerateDocCode();
            info.Doc_Creator = SessionConfig.UserId();
            info.Doc_CreatorName = SessionConfig.UserName();
            info.Doc_DpCode = SessionConfig.DeptCode();
            info.Doc_DpName = SessionConfig.DeptName();
            info.Doc_Date = DateTime.Now;
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

        /// <summary>
        /// 文档上传
        /// </summary>
        /// <param name="qqfile"></param>
        /// <returns></returns>
        public ActionResult Upload(string qqfile)
        {
            var fileType = Request["typeParam"];
            string cate = Request["Cate"];
            string key = Request["DictKey"];

            var path = string.Empty;
            string catepath = string.Empty;
            string finalPath = string.Empty;

            if (string.IsNullOrEmpty(fileType))
            {
                fileType = "Doc";
            }

            if (!string.IsNullOrEmpty(cate))
            {
                catepath = GetPath(cate, key);
            }

            switch (fileType)
            {
                case "File":
                    path = System.Configuration.ConfigurationSettings.AppSettings["File"];

                    break;
                case "Comp":
                    path = System.Configuration.ConfigurationSettings.AppSettings["Comp"];
                    break;
                case "Doc":
                default:
                    path = System.Configuration.ConfigurationSettings.AppSettings["Doc"];
                    break;
            }

            finalPath = path + catepath;

            string file = Comm.FileUpload.UploadFile(qqfile, finalPath, System.Web.HttpContext.Current);

            if (string.IsNullOrEmpty(file))
            {
                return Json(new { result = "fail", message = "上传失败!" }, "text/html");
            }

            return Json(new { result = "success", path = file, message = "成功" }, "text/html");

        }

        public ActionResult Delete(string id)
        {
            Doc_Info doc = diInstance.GetModel(string.Format("AND Doc_Code='{0}'", id));
            doc.Stat = 1;
            diInstance.UpdateObject(doc);

            BLL.Bll_Comm.OpLog("CListDoc_Info", "Doc_Info", string.Format("删除公文:{0}", id));

            return Json(new { result = "success", message = "成功" }, "text/json");
        }

        public ActionResult AllotDelete(string id)
        {
            Doc_Allot doc = diInstance.GetAllotModel(string.Format("AND DA_Code='{0}'", id));
            doc.Stat = 1;
            diInstance.UpdateAllot(doc);

            BLL.Bll_Comm.OpLog("CListDoc_Info", "AllotDelete", string.Format("删除分发人员:{0}", id));

            return Json(new { result = "success", message = "成功" }, "text/json");
        }

        /// <summary>
        /// 群组相关人员删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult AllotGroupDelete(string id)
        {
            Doc_Allot doc = diInstance.GetAllotModel(string.Format("AND DA_Code='{0}'", id));
            doc.Stat = 1;
            diInstance.UpdateAllot(doc);

            BLL.Bll_Comm.OpLog("CListDoc_Info", "AllotDelete", string.Format("删除分发人员:{0}", id));

            return Json(new { result = "success", message = "成功" }, "text/json");
        }

        public ActionResult AttachmentDelete(string id)
        {
            Doc_Attachment doc = diInstance.GetAttachModel(id);
            doc.Stat = 1;
            diInstance.UpdateAttachment(doc);

            BLL.Bll_Comm.OpLog("Attachment", "AttachmentDelete", string.Format("删除附件:附件编号:{0},附件所属文件编号:{1}", id, doc.Dat_RefCode));

            return Json(new { result = "success", message = "成功" }, "text/json");
        }

        public string GetPath(string code, string key)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (!"RoadNode".Equals(key))
                {
                    var list = dictInstance.GetDictListByKeyCode(key);
                    var model = list.FirstOrDefault(o => o.Dict_Code == code);
                    GeneratePath(model, list, sb);
                    sb.AppendFormat("\\{0}", model.Dict_Name);
                }
                else
                {
                    var list=dictInstance.GetDictByKeyByErp(key);
                    //var list = dictInstance.GetDictListByKeyCode(key);
                    var model = list.FirstOrDefault(o => o.Dict_Code == code);
                    GeneratePath(model, list, sb);
                    sb.AppendFormat("\\{0}", model.Dict_Name);
                }
            }
            catch (Exception ex)
            {

            }
            return sb.ToString();
        }

        public void GeneratePath(Bse_Dict current, List<Bse_Dict> allData, StringBuilder sb)
        {
            var temp = allData.FirstOrDefault(o => o.Dict_Code == current.Dict_PCode);
            if (temp != null)
            {
                GeneratePath(temp, allData, sb);
                sb.AppendFormat("\\{0}", temp.Dict_Name);
            }
            else
            {
                return;
            }
        }

    

        public ActionResult GetDownload(string id)
        {
            var flag = false;

            string ftype = Request["ftype"];

            if (string.IsNullOrEmpty(ftype))
            {
                ftype = "Doc_AttachmentModule";
            }

            string filepath = string.Empty;
            string filename = string.Empty;
            switch (ftype)
            {
                case "Bse_ComponentsModule":
                    {
                        flag = IsHaveDownloadPermission("400700", AuditModuleEnum.CompAudit.ToString());
                        Doc_Attachment attach = diInstance.GetAttachModel(id);
                        var path = attach.Dat_Path;
                        filepath = path;
                        filename = attach.Dat_Name;
                        break;
                    }
                case "Bse_FileModule":
                    {
                        flag = IsHaveDownloadPermission("300700", AuditModuleEnum.ComFileAudit.ToString());
                        Doc_Attachment attach = diInstance.GetAttachModel(id);
                        var path = attach.Dat_Path;
                        filepath = path;
                        filename = attach.Dat_Name;
                        break;
                    }
                case "Doc_AttachmentModule":
                default:
                    {

                        flag = IsHaveDownloadPermission("200700", AuditModuleEnum.DocumentAudit.ToString());

                        Doc_Attachment attach = diInstance.GetAttachModel(id);
                        var path = attach.Dat_Path;
                        filepath = path;
                        filename = attach.Dat_Name;

                        if (attach.Dat_Creator == SessionConfig.UserId())
                        {
                            flag = true;
                        }

                        break;
                    }
            }

            if (flag)
            {

                switch (ftype)
                {
                    case "Comp":
                        {
                            BLL.Bll_Comm.OpLog("Bse_ComponentsModule", "GetDownload", string.Format("下载图纸:{0}", id));
                            break;
                        }
                    case "File":
                        {
                            BLL.Bll_Comm.OpLog("Bse_FileModule", "GetDownload", string.Format("下载文档:{0}", id));
                            break;
                        }
                    case "Doc":
                    default:
                        {
                            BLL.Bll_Comm.OpLog("CListDoc_Info", "GetDownload", string.Format("下载公文:{0}", id));

                            break;
                        }
                }
                return File(new FileStream(filepath, FileMode.Open), "text/plain", filename);
            }
            else
            {
                return Content("您没有下载当前文件的权限!");
            }
        }

        public bool IsHaveDownloadPermission(string funCode, string module)
        {
            //分发的人、权限功能表、审核的人均由下载权限

            //通用的下载权限
            var flag = pInstance.IsHavePermission(SessionConfig.UserId(), funCode);
            var flag1 = false;
            var flag2 = false;
            //分发 
            flag1 = diInstance.IsHaveAllot(SessionConfig.UserId(), module);
            //审核权限
            flag2 = diInstance.IsHaveAudit(SessionConfig.UserId(), module);
            //有下载权限的前提下如果是并且是分发或者有审核权限的才能下载
            return flag && (flag1 || flag2);
        }

        public ActionResult Edit(string id, string rtype)
        {
            var model = diInstance.GetModel(string.Format("AND Doc_Code='{0}'", id));
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
            var model = diInstance.GetModel(string.Format("AND Doc_Code='{0}'", id));

            string isView = string.Empty;

            //是否本人修正(两种不同的显示方式)
            if (SessionConfig.UserId() == model.Doc_Creator)
            {
                ViewData["IsSelf"] = true;
            }
            else
            {
                ViewData["IsSelf"] = true;
            }

            GetbackUrl();

            return View(model);
        }

        public ActionResult Show(string id, string rtype)
        {
            var model = diInstance.GetModel(string.Format("AND Doc_Code='{0}'", id));
            string isView = string.Empty;
            if (!string.IsNullOrEmpty(rtype))
            {
                isView = "view";
                ViewData["IsView"] = "display:none";
            }

            GetbackUrl();

            return View(model);
        }

        public ActionResult DraftList()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult FinList()
        {
            return View();
        }




        /// <summary>
        /// 获取草稿列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetDraftList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("CList_DocInfo");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Doc_Info> list = new List<Doc_Info>();

            string orderby = Bll_Comm.GetOrderString(sidx, sord);

            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetDraftDocList("1=1" + orderby);
            }
            else
            {
                list = diInstance.GetDraftDocList(filterSql + orderby);
            }

            var model = list.AsQueryable<Doc_Info>();
            var result = model.ToJqGridData(page, rows, null, search, null);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public void Handle(string code)
        {
            string condition = string.Format("AND DA_DocCode='{0}' And DA_Allot='{1}'", code, SessionConfig.UserId());
            Doc_Allot allot = diInstance.GetAllotModel(condition);
            if (allot != null && (allot.DA_IsHandle == "NoHandle" || string.IsNullOrEmpty(allot.DA_IsHandle)))
            {
                allot.DA_IsHandle = "Handle";
                allot.DA_IsHandleName = "处理";
                var flag = diInstance.UpdateAllot(allot);
            }
        }


        public ActionResult GetMySubmitList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("CListDoc_Info");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Doc_Info> list = new List<Doc_Info>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);
            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetMyDocList("1=1" + orderby);
            }
            else
            {
                list = diInstance.GetMyDocList(filterSql + orderby);
            }

            var model = list.AsQueryable<Doc_Info>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        /// <summary>
        /// 获取待办公文
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
                filterSql = filter.BuildSearch("CList_DocInfo");
            }
            List<Doc_Info> list = new List<Doc_Info>();

            string orderby = Bll_Comm.GetOrderString(sidx, sord);

            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetNormalDocList("1=1" + orderby);
            }
            else
            {
                list = diInstance.GetNormalDocList(filterSql + orderby);
            }

            var model = list.AsQueryable<Doc_Info>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取抄送
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetCCDoingList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("CList_DocInfo");
            }
            List<Doc_Info> list = new List<Doc_Info>();
            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetNormalCCDocList("1=1");
            }
            else
            {
                list = diInstance.GetNormalCCDocList(filterSql);
            }

            var model = list.AsQueryable<Doc_Info>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取待审
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
                filterSql = filter.BuildSearch("CList_DocInfo");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Doc_Info> list = new List<Doc_Info>();

            string orderby = Bll_Comm.GetOrderString(sidx, sord);

            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetAuditDocList("1=1" + orderby);
            }
            else
            {
                list = diInstance.GetAuditDocList(filterSql + orderby);
            }

            var model = list.AsQueryable<Doc_Info>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 获取已办(与登录整相关的分发和审核过的文档列表)
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetInDoList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("CList_DocInfo");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Doc_Info> list = new List<Doc_Info>();

            string orderby = Bll_Comm.GetOrderString(sidx, sord);

            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetAllDocList("1=1" + orderby);
            }
            else
            {
                list = diInstance.GetAllDocList(filterSql + orderby);
            }

            var model = list.AsQueryable<Doc_Info>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        /// <summary>
        /// 获取归档列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetFinList(int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("CList_DocInfo");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Doc_Info> list = new List<Doc_Info>();
            string orderby = Bll_Comm.GetOrderString(sidx, sord);

            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetFinDocList("1=1" + orderby);
            }
            else
            {
                list = diInstance.GetFinDocList(filterSql + orderby);
            }

            var model = list.AsQueryable<Doc_Info>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            //return Json(result, JsonRequestBehavior.AllowGet);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        public ActionResult DoingDoc()
        {
            return View();
        }


        [ValidateInput(false)]
        public JsonResult DocOperation(FormCollection formCollect)
        {
            var flag = false;
            Doc_Info doc = new Doc_Info();
            bmHelper.BindFormToModel<Doc_Info>(doc, formCollect);
            string type = formCollect["optype"];
            int isback = 0;
            if (formCollect["formOper"] == "edit")
            {

                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.Doc_Stat = "Draft";
                }
                else if (type == "submit")
                {
                    doc.Doc_Stat = "Normal";
                    //进入审核流程
                    doc.AuditStat = "Auditing";
                    var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.DocumentAudit.ToString());
                    if (model != null)
                    {
                        doc.AuditCurAudit = model.VT_VerifyNode_Code;
                    }
                }

                flag = diInstance.Update(doc);

                BLL.Bll_Comm.OpLog("CList_DocInfo", "DocOperation", string.Format("编辑公文:{0}", doc.Doc_Code));
            }
            else
            {
                isback = 1;
                //doc.Doc_Code = diInstance.GenerateDocCode();
                doc.Doc_Date = DateTime.Now;
                doc.CreateTime = DateTime.Now;
                doc.UpdateTime = DateTime.Now;
                if (type == "nor")
                {
                    doc.Doc_Stat = "Draft";
                }
                else
                {
                    doc.Doc_Stat = "Normal";
                    //进入审核流程
                    doc.AuditStat = "Auditing";
                    var model = auditInstance.GetVerifyTemplateFirstNode(AuditModuleEnum.DocumentAudit.ToString());
                    if (model != null)
                    {
                        doc.AuditCurAudit = model.VT_VerifyNode_Code;
                    }
                }

                flag = diInstance.AddObject(doc);

                BLL.Bll_Comm.OpLog("CList_DocInfo", "DocOperation", string.Format("添加公文:{0}", doc.Doc_Code));
                //日志记录
                //this.OpLog(this.GetControllerName(), "添加:单据类型" + puMain.PUM_RType + ",编码:" + puMain.PUM_RCode, addResult.ToString());

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

        #region 分发

        /// <summary>
        /// 获取文档分发列表（文档维护时候）
        /// </summary>
        /// <param name="id">文档编码</param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetAllot(string id, int page, int rows, string search, string sidx, string sord)
        {

            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Doc_AllotModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }

            List<Doc_Allot> list = new List<Doc_Allot>();
            if (!string.IsNullOrEmpty(id))
            {
                if (string.IsNullOrEmpty(filterSql))
                {
                    list = diInstance.GetAllotList(id, " 1=1");
                }
                else
                {
                    list = diInstance.GetAllotList(id, filterSql);
                }
            }

            var model = list.AsQueryable<Doc_Allot>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        public ActionResult GetCC(string id, int page, int rows, string search, string sidx, string sord)
        {

            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Doc_AllotModule");
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }

            List<Doc_Allot> list = new List<Doc_Allot>();
            if (!string.IsNullOrEmpty(id))
            {
                if (string.IsNullOrEmpty(filterSql))
                {
                    list = diInstance.GetCCList(id, " 1=1");
                }
                else
                {
                    list = diInstance.GetCCList(id, filterSql);
                }
            }

            var model = list.AsQueryable<Doc_Allot>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }


        public ActionResult GetAllotModel(string code)
        {
            var m = diInstance.GetAllotModel(string.Format("And DA_DocCode='{0}' AND DA_Allot='{1}'", code, SessionConfig.UserId()));
            return JavaScript(JsonConvert.SerializeObject(m));
        }

        [ValidateInput(false)]
        public JsonResult AllotOperation(FormCollection formCollect)
        {

            Doc_Allot doc = new Doc_Allot();
            string id = formCollect["DA_Code"];
            doc = diInstance.GetAllotModel(string.Format("AND DA_Code='{0}'", id));
            doc.DA_Opinion = formCollect["DA_Opinion"];
            doc.DA_IsHandle = "Handle";
            doc.DA_IsHandleName = "处理";

            diInstance.UpdateAllot(doc);
            return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };

        }

        /// <summary>
        /// 分发
        /// </summary>
        /// <param name="code"></param>
        /// <param name="doc"></param>
        /// <returns></returns>
        public ActionResult DocAllot(string code, string name, string doc, string module)
        {
            if (!string.IsNullOrEmpty(code))
            {
                string[] codeArray = code.Split(',');
                string[] nameArray = name.Split(',');
                for (int i = 0; i < codeArray.Length; i++)
                {
                    var c = codeArray[i];
                    var na = nameArray[i];
                    Doc_Allot allot = new Doc_Allot();
                    allot.DA_Code = diInstance.GenerateAllotCode();

                    allot.DA_Module = module;
                    //未处理
                    allot.DA_IsHandle = "NoHandle";
                    allot.DA_IsHandleName = "未处理";
                    //分发人编码
                    allot.DA_Allot = c;
                    //分法人名字
                    allot.DA_Account = na;
                    allot.DA_DocCode = doc;
                    allot.DA_iType = AllotType.Distribution.ToString();
                    allot.DA_Date = DateTime.Now;
                    diInstance.AddAllot(allot);

                    BLL.Bll_Comm.OpLog("Allot", "Allot", string.Format("分发:{0}", allot.DA_DocCode));
                }

                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
        }

        /// <summary>
        /// 群组授权
        /// </summary>
        /// <param name="code"></param>
        /// <param name="group"></param>
        /// <param name="module"></param>
        /// <returns></returns>
        public ActionResult GroupAllot(string code, string group, string module)
        {
            if (!string.IsNullOrEmpty(code))
            {
                List<Doc_Allot> list = new List<Doc_Allot>();

                list = diInstance.GetAllotList(group, "1=1");

                foreach (var allot in list)
                {
                    allot.DA_RefCode = allot.DA_DocCode;
                    allot.DA_DocCode = code;
                    //itype 分发或抄送    Type-->下载或查看
                    allot.DA_Type = "View";
                    allot.DA_TypeName = "查看权限";
                    diInstance.AddAllot(allot);
                }

                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
        }


        public ActionResult GroupDownloadAllot(string code, string group, string module)
        {
            if (!string.IsNullOrEmpty(code))
            {
                List<Doc_Allot> list = new List<Doc_Allot>();

                list = diInstance.GetAllotList(group, "1=1");

                foreach (var allot in list)
                {
                    //表明从群组参考而来
                    allot.DA_RefCode = allot.DA_DocCode;
                    allot.DA_DocCode = code;
                    //itype 分发或抄送    Type-->下载或查看
                    allot.DA_Type = "Download";
                    allot.DA_TypeName = "下载权限";
                    diInstance.AddAllot(allot);
                }

                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
        }


        public ActionResult DocCC(string code, string name, string doc, string module)
        {
            if (!string.IsNullOrEmpty(code))
            {
                string[] codeArray = code.Split(',');
                string[] nameArray = name.Split(',');
                for (int i = 0; i < codeArray.Length; i++)
                {
                    var c = codeArray[i];
                    var na = nameArray[i];
                    Doc_Allot allot = new Doc_Allot();
                    allot.DA_Code = diInstance.GenerateAllotCode();

                    allot.DA_Module = module;
                    //未处理
                    allot.DA_IsHandle = "NoHandle";
                    allot.DA_IsHandleName = "未处理";
                    //分发人编码
                    allot.DA_Allot = c;
                    //分法人名字
                    allot.DA_Account = na;
                    allot.DA_DocCode = doc;
                    allot.DA_iType = AllotType.CC.ToString();
                    allot.DA_Date = DateTime.Now;
                    diInstance.AddAllot(allot);

                    BLL.Bll_Comm.OpLog("Allot", "Allot", string.Format("抄送:{0}", allot.DA_DocCode));
                }

                return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
            }
            return new JsonResult { Data = new { result = "fail", Msg = "数据更新失败！" } };
        }

        #endregion

        #region 附件

        public ActionResult GetAttachmentList(string id, int page, int rows, string search, string sidx, string sord)
        {
            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            string rtype = string.Empty;

            string[] temp = id.Split('-');
            if (temp == null || temp.Length == 0)
            {
                var list1 = new List<Doc_Attachment>();
                var model1 = list1.AsQueryable<Doc_Attachment>();
                //var result = model.ToJqGridData(page, rows, null, search, null);

                var jsonResult1 = JsonConvert.SerializeObject(model1.ToJqGridData(page, rows, null, search, null));
                return JavaScript(jsonResult1);

            }

            id = temp[0];
            rtype = temp[1];

            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch(rtype);
                //filterSql = BulidJqGridSearch.BuildSearch(filter);
            }
            List<Doc_Attachment> list = new List<Doc_Attachment>();
            if (string.IsNullOrEmpty(filterSql))
            {
                list = diInstance.GetAttachmentList(rtype, id, "1=1");
            }
            else
            {
                list = diInstance.GetAttachmentList(rtype, id, filterSql);
            }

            var model = list.AsQueryable<Doc_Attachment>();
            //var result = model.ToJqGridData(page, rows, null, search, null);

            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null));
            return JavaScript(jsonResult);
            //return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UploadDoc(string code, string path, string module)
        {
            string fileName = Path.GetFileName(path);
            Doc_Attachment attachment = new Doc_Attachment();
            attachment.Dat_Name = fileName;
            attachment.Dat_Path = path;
            attachment.Dat_Module = module;
            attachment.Dat_RefCode = code;
            attachment.Dat_Date = DateTime.Now;
            attachment.Dat_Creator = SessionConfig.UserId();
            attachment.Dat_CreatorName = SessionConfig.UserName();
            attachment.Dat_Code = diInstance.GenerateAttachmentCode();
            diInstance.AddAttachment(attachment);

            BLL.Bll_Comm.OpLog("Upload", "Upload", string.Format("上传附件:{0}", attachment.Dat_RefCode));

            return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
        }

        /// <summary>
        /// 图纸文件上传后回调函数
        /// </summary>
        /// <param name="code"></param>
        /// <param name="path"></param>
        /// <param name="module"></param>
        /// <returns></returns>
        public ActionResult UploadDocComp(string code, string path, string module)
        {
            string fileName = Path.GetFileName(path);
            Doc_Attachment attachment = new Doc_Attachment();
            attachment.Dat_Name = fileName;
            attachment.Dat_Path = path;
            attachment.Dat_Module = module;
            attachment.Dat_RefCode = code;
            //文件类型(不同的类型不同的处理方式)
            attachment.Dat_Type = Path.GetExtension(path).Trim('.');
            attachment.Dat_Date = DateTime.Now;
            attachment.Dat_Creator = SessionConfig.UserId();
            attachment.Dat_CreatorName = SessionConfig.UserName();
            attachment.Dat_Code = diInstance.GenerateAttachmentCode();
            diInstance.AddAttachment(attachment);

            BLL.Bll_Comm.OpLog("Upload", "Upload", string.Format("上传附件:{0}", attachment.Dat_RefCode));

            return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };
        }

        #endregion

    }
}
