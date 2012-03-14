using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QX.Config;
using QX.Model;
using QX.Comm;
using QX.BLL;
using QX.HtmlHelperLib;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;

namespace QX.Controllers.Controllers
{
    public class PermissionController : Controller
    {

        BLL.Bll_Sys_Function fInstance = new QX.BLL.Bll_Sys_Function();
        BLL.Bll_Sys_UserPermission upInstance = new QX.BLL.Bll_Sys_UserPermission();
        Bll_Bse_Employee hrInstance = new Bll_Bse_Employee();
        Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
        Bll_Bse_Department deptInstance = new Bll_Bse_Department();
        BLL.Bll_Sys_Role rInstance = new QX.BLL.Bll_Sys_Role();


        // GET: /Permission/

        public ActionResult Index()
        {
            string id = Request.QueryString["id"];

            ViewData["DeptList"] = deptInstance.GetChildListDept().ToList();


            return View();
        }

        public ActionResult PerAllot(string id)
        {
            ViewData["UserId"] = id;
            //所有的权限列表
            ViewData["FunList"] = fInstance.GetFunctionLevelByKey();

            return View();
        }

        public ActionResult Log()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult GetLogList(int page, int rows, string search, string sidx, string sord)
        {

            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filtersSql = "";
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }

            //string 
            List<Sys_OpLog> list = new List<Sys_OpLog>();

            if (!string.IsNullOrEmpty(filtersSql))
            {

                list = upInstance.GetLogList(" And " + filtersSql);
            }
            else
            {
                list = upInstance.GetLogList(" And 1=1");
            }





            var model = list.AsQueryable<Sys_OpLog>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));


            return JavaScript(result);
        }


        public ActionResult GetUserPermission(string id)
        {
            string usercode =id;
            List<Sys_UserPermission> uPer = new List<Sys_UserPermission>();
            uPer = upInstance.GetListByCode(string.Format(" AND PU_UserCode='{0}'", usercode));
            //return Json(uPer.Where(o => o.PU_IsCheck == "1").ToList());
            return Json(uPer);
        }

        public ActionResult UpdatePermission(string id)
        {
            string ids = Request["data"];
            List<Sys_UserPermission> list = new List<Sys_UserPermission>();
            if (!string.IsNullOrEmpty(ids))
            {
                var array = ids.TrimEnd(',').Split(',');
                foreach (var p in array)
                {
                    Sys_UserPermission s = new Sys_UserPermission();
                    s.PU_FunCode = p;
                    list.Add(s);
                }

                var flag = upInstance.UpdatePermission(id, list);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }
            else
            {
                List<Sys_UserPermission> list1 = new List<Sys_UserPermission>();
                var flag = upInstance.UpdatePermission(id, list1);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }

            //return new JsonResult { Data = new { result = "Fail", Msg = "数据更新失败！" } };
        }

        public ActionResult Role()
        {
            return View();
        }

        /// <summary>
        /// 角色权限分配
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult RoleAllot(string id)
        {
            ViewData["RoleCode"] = id;
            //所有的权限列表
            ViewData["FunList"] = fInstance.GetFunctionLevelByKey();
            return View();
        }

        public ActionResult Group()
        {
            return View();
        }


        public ActionResult GetGroupList(int page, int rows, string search, string sidx, string sord)
        {
            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filtersSql = "";
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }

            //string 
            List<Bse_Group> list = new List<Bse_Group>();

            if (!string.IsNullOrEmpty(filtersSql))
            {
                
                list = upInstance.GetGroupList(filtersSql);
            }
            else
            {
                list = upInstance.GetGroupList(" 1=1");
            }


            var model = list.AsQueryable<Bse_Group>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));

            return JavaScript(result);
        }

        /// <summary>
        /// 角色分配
        /// </summary>
        /// <param name="UCode"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public ActionResult AllotRole(string UCode, string role)
        {
            Bse_Employee stuff = hrInstance.GetModelByCode(UCode);
            Sys_Role rl = rInstance.GetModel(string.Format("AND SRole_Code='{0}'", role));
            //stuff. = rl.SRole_Code;
            //stuff.Stuff_RoleName = rl.SRole_Name;
            hrInstance.Update(stuff);
            return new JsonResult { Data = new { result = "success", Msg = "数据更新成功！" } };


        }

        public ActionResult GetRole(int page, int rows, string search, string sidx, string sord)
        {

            string filter = Request["filters"] != null ? Request["filters"] : "";
            string filterSql = "";
            if (!string.IsNullOrEmpty(filter))
            {
                filterSql = filter.BuildSearch("Doc_AllotModule");
            }

            List<Sys_Role> list = new List<Sys_Role>();

            if (string.IsNullOrEmpty(filterSql))
            {
                list = rInstance.GetListByCode("AND 1=1");
            }
            else
            {
                list = rInstance.GetListByCode(string.Format("AND {0}", filterSql));
            }


            var model = list.AsQueryable<Sys_Role>();
            //var result = model.ToJqGridData(page, rows, null, search, null);
            var jsonResult = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));
            return JavaScript(jsonResult);
        }

        /// <summary>
        /// 更新角色权限
        /// </summary>
        /// <param name="code">角色编码</param>
        /// <returns></returns>
        public ActionResult UpdateRolePermission(string code)
        {
            ///权限点列表 
            string ids = Request["data"];
            List<Sys_UserPermission> list = new List<Sys_UserPermission>();
            if (!string.IsNullOrEmpty(ids))
            {
                var array = ids.TrimEnd(',').Split(',');
                foreach (var p in array)
                {
                    Sys_UserPermission s = new Sys_UserPermission();
                    s.PU_UDef1 = "Role";
                    s.PU_FunCode = p;
                    list.Add(s);
                }

                var flag = upInstance.UpdatePermission(code, list);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }
            else
            {
                List<Sys_UserPermission> list1 = new List<Sys_UserPermission>();
                var flag = upInstance.UpdatePermission(code, list1);
                return new JsonResult { Data = new { result = "Success", Msg = "数据更新成功！" } };
            }


            //return new JsonResult { Data = new { result = "Fail", Msg = "数据更新失败！" } };
        }


        [OutputCache(CacheProfile = "DeptEmp_CacheConfig")]
        public ActionResult GetEmpList(string id, int page, int rows, string search, string sidx, string sord)
        {

            string filters = Request["filters"] == null ? "" : Request["filters"].ToString();
            string filtersSql = "";
            if (!string.IsNullOrEmpty(filters))
            {
                filtersSql = BulidJqGridSearch.BuildSearch(filters);
            }

            //string 
            List<Bse_Employee> list = new List<Bse_Employee>();
            if (string.IsNullOrEmpty(id))
            {
                if (!string.IsNullOrEmpty(filtersSql))
                {
                    list = hrInstance.GetListByCode(" AND " + filtersSql);
                }
                else
                {
                    list = hrInstance.GetAll();
                }

            }
            else
            {
                if (!string.IsNullOrEmpty(filtersSql))
                {
                    list = hrInstance.GetStuffByDept(id, " AND " + filtersSql);
                }
                else
                {
                    list = hrInstance.GetStuffByDept(id);
                }

            }



            //字典替换
            foreach (var listmodel in list)
            {
                switch (listmodel.Emp_Gendar)
                {
                    case "G001": { listmodel.Emp_Gendar = "男"; break; }
                    case "G002": { listmodel.Emp_Gendar = "女"; break; }
                }

                if (!string.IsNullOrEmpty(listmodel.Emp_Title))
                {
                    var _model = dictInstance.GetModel(" and dict_key='STUFFTITLE' and dict_code='" + listmodel.Emp_Title + "'");
                    listmodel.Emp_Title = _model != null ? _model.Dict_Name : "";

                }

                if (!string.IsNullOrEmpty(listmodel.Emp_Duty))
                {
                    var _model = dictInstance.GetModel(" and dict_key='STUFFDUTYTYPE' and dict_code='" + listmodel.Emp_Duty + "'");
                    listmodel.Emp_Duty = _model != null ? _model.Dict_Name : "";
                }
            }
            var model = list.AsQueryable<Bse_Employee>();
            var result = JsonConvert.SerializeObject(model.ToJqGridData(page, rows, null, search, null), new JsonDateConverter("yyyy-MM-dd"));


            return JavaScript(result);
        }

    }
}
