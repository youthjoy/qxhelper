using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using QX.Model;
using QX.BLL;
using QX.Comm;
using QX.HtmlHelperLib.JqGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Web.UI;
using System.Diagnostics;
using QX.AOP;
using QX.Config;

namespace QX.Controllers.Controllers
{
    [ExceptionFillters]
    [ActionFillters]
    [ResultFillters][QX.Cache.CompressFilter][QX.Cache.CacheFilter(Duration=120)]
    
    public class HRController : Controller
    {

        Bll_Bse_Employee hrInstance = new Bll_Bse_Employee();
       
        Bll_Bse_Department deptInstance = new Bll_Bse_Department();

        /// <summary>
        /// 获取部门信息列表（通用控件使用）
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile = "Dept_CacheConfig")]
        public ActionResult GetDeptTree()
        {
            var list = deptInstance.GetDeptTree();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        #region Index 列表
        //
        // GET: /HR/

        public ActionResult HR_Department()
        {
            string id = Request.QueryString["id"];
            ViewData["DeptList"] = deptInstance.GetChildListDept();
            Bse_Department depmodel = new Bse_Department();
            if (string.IsNullOrEmpty(id))
            {
                depmodel = new BLL.Bll_Bse_Department().GetModel(" and Dept_Code='root'");
                return View(depmodel);
            }
            else
            {
                depmodel = new BLL.Bll_Bse_Department().GetModel(" and Dept_Code='" + id + "'");
                var result = JsonConvert.SerializeObject(depmodel, new JsonDateConverter("yyyy-MM-dd"));
                return JavaScript(result);
            }
        }
       
        /// <summary>
        /// 用户信息列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="search"></param>
        /// <param name="sidx"></param>
        /// <param name="sord"></param>
        /// <returns></returns>
        [OutputCache(CacheProfile = "DeptEmp_CacheConfig")]
        public ActionResult List(string id, int page, int rows, string search, string sidx, string sord)
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
                }else{
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

            Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();

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
                    var _model=dictInstance.GetModel(" and dict_key='STUFFTITLE' and dict_code='" + listmodel.Emp_Title + "'");
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
        #endregion


    }
}
