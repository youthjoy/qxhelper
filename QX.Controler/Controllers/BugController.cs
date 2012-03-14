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
using QX.HtmlHelperLib;
using QX.Config;

namespace QX.Controllers.Controllers
{
    public class BugController : Controller
    {

        private BLL.Bll_Sys_Bug bugInstance = new BLL.Bll_Sys_Bug();
        private BLL.Bll_Sys_BugLog buglogInstance = new BLL.Bll_Sys_BugLog();
        private Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();

        //
        // GET: /Bug/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Bug操作
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult GetList(string id,int page, int rows, string search, string sidx, string sord)
        {
            //获取当前用户BUG组别
            var UserName=SessionConfig.UserName();
            var RoleSql = "";
            EnumBugUserGroup Role = CurrentUserRole();
            switch (Role)
            {
                case EnumBugUserGroup.GDev:
                    RoleSql = " AND (Sys_UserName='" + UserName + "' or Sys_Owner='" + UserName + "' )  ";
                    break;
                case EnumBugUserGroup.GTest:
                    RoleSql = " AND (Sys_UserName='" + UserName + "' or Sys_Owner='" + UserName + "') ";
                    break;
                case EnumBugUserGroup.GAdmin:                   
                    break;
                default:
                    break;
            }

            List<Sys_Bug> list = new List<Sys_Bug>();            
            string filters = Request["filters"];
            string filtersSql = string.Empty;
            if (!string.IsNullOrEmpty(filters))
            {

                filtersSql = " AND  " + filters.BuildSearch("Sys_BugModule");
            }
            if (!string.IsNullOrEmpty(id))
            {
                filtersSql += "and Sys_Project='" + id + "'";
            }
            if (!string.IsNullOrEmpty(RoleSql))
            {
                filtersSql += RoleSql;
            }

            if (!string.IsNullOrEmpty(filtersSql))
            {
                list = bugInstance.GetListByCode(filtersSql);
            }
            else
            {
                list = bugInstance.GetAll();
            }

            //字典
            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.Sys_Status + "'");
                    if (dictModel != null)
                    {
                        item.Sys_Status = dictModel.Dict_Name;
                    }
                }
            }

            var model = list.AsQueryable<Sys_Bug>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd HH:mm"));
            return JavaScript(result);
        }


        /// <summary>
        /// Bug日记
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        public ActionResult LogGetList(int page, int rows, string search, string sidx, string sord)
        {
            List<Sys_BugLog> list = new List<Sys_BugLog>();
            string filters = Request["filters"];
            string filtersSql = string.Empty;

            if (!string.IsNullOrEmpty(Request["Code"]))
            {
                filtersSql = "and SL_Code='" + Request["Code"] + "'";
            }
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = " AND  " + BulidJqGridSearch.BuildSearch(filters);
            }

            if (!string.IsNullOrEmpty(filtersSql))
            {
                list = buglogInstance.GetListByCode(filtersSql);
            }
            else
            {
                list = buglogInstance.GetAll();
            }

            if (list.Count() > 0)
            {
                foreach (var item in list)
                {
                    var dictModel = dictInstance.GetModel(" AND Dict_Code='" + item.SL_Status + "'");
                    if (dictModel != null)
                    {
                        item.SL_Status = dictModel.Dict_Name;
                    }
                }
            }


            var model = list.OrderByDescending(o=>o.SL_ID).AsQueryable<Sys_BugLog>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd HH:mm"));
            return JavaScript(result);
        }

        /// <summary>
        /// 获取系统Bug列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Get(string oper, string id)
        {
            string Form = Request["form"];
            Sys_Bug model = new Sys_Bug();
            Sys_BugLog Logmodel= new Sys_BugLog();
            if (!string.IsNullOrEmpty(Form))
            {
                model = JsonConvert.DeserializeObject<Sys_Bug>(Form);
            }
             Logmodel.SL_Code= model.Sys_Code;
             Logmodel.SL_OpUser = SessionConfig.UserName();
             Logmodel.SL_Date = DateTime.Now;
             Logmodel.SL_Status= model.Sys_Status;
             Logmodel.SL_Owner = model.Sys_Owner;
            if (oper == JqGridEnum.view.ToString())
            {
                List<Sys_Bug> list = bugInstance.GetListByCode(" AND Sys_Code='" + id + "'");
                model = new Sys_Bug();
                if (list.Count > 0)
                {
                    model = list[0];
                }
                return JavaScript(JsonConvert.SerializeObject(model, new JsonDateConverter("yyyy-MM-dd HH:mm")));
            }
            else if (oper == JqGridEnum.edit.ToString())
            {
                model.Sys_ID = bugInstance.GetModel(" AND Sys_Code='" + model.Sys_Code + "'  ").Sys_ID;
                bool result = bugInstance.Update(model);
                result = buglogInstance.Insert(Logmodel);
                string strResult = result ? "success" : "fail";
               
                return Content(strResult);
            }
            else if (oper == JqGridEnum.del.ToString())
            {
                bool result = bugInstance.Delete(" AND WHBM_Code='" + id + "'");
                string strResult = result ? "success" : "fail";

                return Content(strResult);
            }
            else if (oper == JqGridEnum.add.ToString())
            {
                string form = Request["form"];
                model.Sys_Date = DateTime.Now;
                bool result = bugInstance.Insert(model);
                result = buglogInstance.Insert(Logmodel);
                string strResult = result ? "success" : "fail";

                return Content(strResult);
            }
            else
            {
                return new EmptyResult();
            }

        }


        /// <summary>
        /// 获取当前用户所在的BUG组
        /// </summary>
        /// <returns></returns>
        private EnumBugUserGroup CurrentUserRole()
        {
            EnumBugUserGroup result = new EnumBugUserGroup();
            try
            {
                var UserName = SessionConfig.UserName();
                var CurRole = BugUserGroup().Where(o => o.Dict_Code == UserName).First();
                if (CurRole != null)
                {
                    result = (EnumBugUserGroup)Enum.Parse(typeof(EnumBugUserGroup), CurRole.Dict_UDef1);
                }
            }
            catch (System.Exception ex)
            {
                result = EnumBugUserGroup.GDev;
            }
            
            return result;
        }

        private List<Bse_Dict> BugUserGroup()
        {
            var list = dictInstance.GetListByCode(" AND Dict_Key='BUGUSER' AND Dict_Key!=Dict_Code");
            return list;
        }
    }

    /// <summary>
    /// BUG管理用户组
    /// </summary>
    public enum EnumBugUserGroup
    {
        /// <summary>
        /// 开发组
        /// </summary>
        GDev,
        /// <summary>
        /// 测试组
        /// </summary>
        GTest,
        /// <summary>
        /// 管理组
        /// </summary>
        GAdmin
    }
}
