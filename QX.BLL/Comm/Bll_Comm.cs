using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QX.DAL;
using QX.Model;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using QX.Comm;
using QX.Comm.Utils;
using QX.Log;
using QX.Config;
using System.Web;
using QX.ERP.DAL;
namespace QX.BLL
{
    public class Bll_Comm
    {
        public const string root = "ROOT";



       

        private ADOSys_Config_Refer instance = new ADOSys_Config_Refer();
        private ADOSys_Map MapInstance = new ADOSys_Map();

        private ADOComm cinstance = new ADOComm();

        public static string GetOrderString(string sidx, string sord)
        {
            string orderby = string.Empty;
            if (!string.IsNullOrEmpty(sidx) && !string.IsNullOrEmpty(sord))
            {
                switch (sord)
                {
                    case "asc":
                        orderby = " order by " + sidx;
                        break;
                    case "desc":
                        orderby = " order by " + sidx + " desc";
                        break;
                }

                return orderby;
            }
            else
            {
                return orderby;
            }
        }

        /// <summary>
        /// 获取自增编码
        /// </summary>
        /// <param name="NameSapce"></param>
        /// <returns></returns>
        public string GetTableKeyCode(string NameSapce)
        {
            return cinstance.GetTableKeyCode(NameSapce);
            //SqlParameter x1 = new SqlParameter("@sTable", SqlDbType.NChar, 40);
            //x1.Value = NameSapce.Trim();
            //SqlParameter[] param = new SqlParameter[] { x1 };
            //IDbDataParameter[] parames = param as IDbDataParameter[];
            //DataTable dt = instance.RunProcReturnDatatable("findnewid", parames);
            //return dt.Rows[0][0].ToString();
        }

        /// <summary>
        /// 获取自增编码
        /// </summary>
        /// <param name="Module"></param>
        /// <returns></returns>
        public static string GetTableKey(string Module)
        {
            ADOSys_Config_Refer instance = new ADOSys_Config_Refer();
            SqlParameter x1 = new SqlParameter("@sTable", SqlDbType.NChar, 40);
            x1.Value = Module.Trim();
            SqlParameter[] param = new SqlParameter[] { x1 };
            IDbDataParameter[] parames = param as IDbDataParameter[];
            DataTable dt = instance.idb.RunProcReturnDatatable("findnewid", parames);
            return dt.Rows[0][0].ToString();
        }

        /// <summary>
        /// 自增编码-单据
        /// </summary>
        /// <param name="CompanyCode"></param>
        /// <param name="Module"></param>
        /// <returns></returns>
        public static string GetTableKeyForPU(string CompanyCode, string Module)
        {
            ADOSys_Config_Refer instance = new ADOSys_Config_Refer();
            SqlParameter x1 = new SqlParameter("@CompanyCode", SqlDbType.VarChar, 20);
            x1.Value = CompanyCode == null ? "" : CompanyCode;

            SqlParameter x2 = new SqlParameter("@ModuleCode", SqlDbType.VarChar, 20);
            x2.Value = Module;

            SqlParameter x3 = new SqlParameter("@GeneralType", SqlDbType.VarChar, 20);
            x3.Value = "";

            SqlParameter x4 = new SqlParameter("@code", SqlDbType.VarChar, 20);
            x4.Direction = ParameterDirection.Output;

            SqlParameter[] param = new SqlParameter[] { x1, x2, x3, x4 };
            IDbDataParameter[] parames = param as IDbDataParameter[];
            DataTable dt = instance.idb.RunProcReturnDatatable("qx_sp_compcode", parames);
            return dt.Rows[0][0].ToString();
        }


        /// <summary>
        /// 获取特殊自增编码,根据Sys_DictModule中存在的配置为特殊编码
        /// </summary>
        /// <param name="CompanyCode">公司编码</param>
        /// <param name="Module">模块名称：MMType 为物料类别编码</param>
        /// <param name="GeneralType">如果有父级时，传入子级编码</param>
        /// <param name="Code">传出编码</param>
        /// <returns></returns>
        public static string GetTableKey(string CompanyCode, string Module, string GeneralType, string Code)
        {
            ADOSys_Config_Refer instance = new ADOSys_Config_Refer();
            ADOSys_DictModule DictModule = new ADOSys_DictModule();
            var DModuleList = DictModule.GetListByWhere(" AND ModuleCode='" + Module + "' ");

            SqlParameter x1 = new SqlParameter("@CompanyCode", SqlDbType.VarChar, 20);
            x1.Value = CompanyCode;

            SqlParameter x2 = new SqlParameter("@ModuleCode", SqlDbType.VarChar, 20);
            x2.Value = Module;

            SqlParameter x3 = new SqlParameter("@GeneralType", SqlDbType.VarChar, 20);
            x3.Value = GeneralType;

            SqlParameter x4 = new SqlParameter("@code", SqlDbType.VarChar, 20);
            x4.Direction = ParameterDirection.Output;

            SqlParameter x5 = new SqlParameter("@sTable", SqlDbType.NChar, 40);
            x5.Value = Module.Trim();

            DataTable dt = new DataTable();

            if (DModuleList.Count > 0)
            {
                SqlParameter[] param = new SqlParameter[] { x1, x2, x3, x4 };
                IDbDataParameter[] parames = param as IDbDataParameter[];
                dt = instance.idb.RunProcReturnDatatable("qx_sp_compcode", parames);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[] { x5 };
                IDbDataParameter[] parames = param as IDbDataParameter[];
                dt = instance.idb.RunProcReturnDatatable("findnewid", parames);
            }

            return dt.Rows[0][0].ToString();
        }


        /// <summary>
        /// 通用映射获取
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public Sys_Map CommMap(string ModuleName, string source)
        {
            Sys_Map model = new Sys_Map();
            List<Sys_Map> list = MapInstance.GetListByWhere(" AND Map_Module='" + ModuleName + "' AND Map_Source='" + source + "' ");
            if (list.Count > 0)
            {
                model = list[0];
            }
            return model;
        }
        
        public Sys_Map CommMap(string ModuleName)
        {
            return MapInstance.GetListByWhere(" AND Map_Module='" + ModuleName + "' ").FirstOrDefault();
        }
        /// <summary>
        /// 获取依赖映射的信息
        /// </summary>
        /// <param name="RefDepend_Code"></param>
        /// <param name="Module"></param>
        /// <returns></returns>
        //public static Sys_Rec_RefDepend CommRefDepend(string RefDepend_Code)
        //{
        //    Bll_Sys_Rec_RefDepend instance = new Bll_Sys_Rec_RefDepend();
        //    Sys_Rec_RefDepend model = instance.GetModel(" AND RefDepend_Code=RefDepend_Object AND RefDepend_Code='" + RefDepend_Code + "'  and isnull(RefDepend_ConfFlag,0) = 1");
        //    if (model == null)
        //    {
        //        model = instance.GetModel("  AND RefDepend_Code='" + RefDepend_Code + "'  and isnull(RefDepend_ConfFlag,0) = 1");
        //    }
        //    return model;
        //}

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static DataTable RunProc(string procName, IDbDataParameter[] para)
        {
            ADOSys_Config_Refer instance = new ADOSys_Config_Refer();
            return instance.idb.RunProcReturnDatatable(procName, para);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <returns></returns>
        public static DataTable RunProc(string procName)
        {
            ADOSys_Config_Refer instance = new ADOSys_Config_Refer();
            return instance.idb.RunProcReturnDatatable(procName);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public DataTable ExcuteProc(string procName, IDbDataParameter[] para)
        {
            return cinstance.ExcuteProc(procName, para);

        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public DataTable ExcuteProc(string procName)
        {
            return cinstance.ExcuteProc(procName);

        }

        /// <summary>
        /// 获取表相关信息
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataSet GetTableInfo(string tableName)
        {
            DataSet ret = new DataSet();
            try
            {
                //instance.idb.ClearParameter();
                instance.idb.AddParameter("@objname", tableName);
                ret = instance.idb.RunProcReturnDataSet("sp_help");
            }
            catch (Exception e)
            {
                throw e;
            }
            return ret;
        }



        /// <summary>
        /// 获取表主键
        /// </summary>
        /// <param name="dsTableInfo"></param>
        /// <returns></returns>
        public string GetTableKey(DataSet dsTableInfo)
        {
            string strKeyColumns;
            if (dsTableInfo.Tables.Count > 5 && dsTableInfo.Tables[5].Rows.Count > 0)
            {
                strKeyColumns = dsTableInfo.Tables[5].Rows[0][2].ToString().Trim();
            }
            else
            {
                throw new Exception(dsTableInfo.Tables[1].TableName + ":表缺少主键");
            }
            return strKeyColumns;
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public DataTable ListViewData(string sql)
        {
            ADOSys_Config_ListPage instance = new ADOSys_Config_ListPage();
            //string sql = "SELECT * FROM " + TableName + " WHERE (Stat is null or Stat=0) AND " + filter;
            return instance.idb.ReturnDataTable(sql);
        }


        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static DataTable ListDataByCode(string TableName, string filter)
        {
            ADOSys_Config_ListPage instance = new ADOSys_Config_ListPage();
            string sql = "SELECT * FROM " + TableName + " WHERE (Stat is null or Stat=0) AND " + filter;
            return instance.idb.ReturnDataTable(sql);
        }

        public static DataTable ListDataBySql(string sql)
        {
            ADOSys_Config_ListPage instance = new ADOSys_Config_ListPage();
            return instance.idb.ReturnDataTable(sql);
        }

        //public static List<HR_Department> GetCompanyList(string CompanyCode)
        //{
        //    ADOHR_Department instance = new ADOHR_Department();
        //    List<HR_Department> list = instance.GetListByWhere(" AND isnull(Dept_PCode,'')='' ");
        //    return list;
        //}


        #region 获取节点下面所有部门节点 --- 生成不包含层级关系的子节点列表
       private ADOBse_Department deptInstance = new ADOBse_Department();
        public static List<Bse_Department> staticDeptList = new List<Bse_Department>();

        /// <summary>
        /// 获取节点下面所有部门节点
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public List<Bse_Department> GetChildListDeptNon(string deptCode)
        {
            List<Bse_Department> allDept = deptInstance.GetAll();
            IEnumerable<Bse_Department> root = allDept.Where(o => o.Dept_PCode == deptCode && !string.IsNullOrEmpty(o.Dept_PCode));
            foreach (var d in root)
            {
                staticDeptList.Add(d);
                GenerateChildNon(d, allDept);
            }
            return staticDeptList;
        }

        private void GenerateChildNon(Bse_Department dept, List<Bse_Department> allDept)
        {
            dept.ChildrenDept = allDept.Where(o => o.Dept_PCode == dept.Dept_Code);

            if (dept.ChildrenDept.Count() == 0)
            {
                return;
            }
            foreach (var d in dept.ChildrenDept)
            {
                staticDeptList.Add(d);
                GenerateChildNon(d, allDept);
            }
        }


        #endregion

        #region  获取节点下面所有部门节点 -- 生成包含层级关系的子节点列表
        /// <summary>
        /// 生成包含层级关系的子节点列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Bse_Department> GetChildListDept(string deptCode)
        {
            List<Bse_Department> allDept = deptInstance.GetListByWhere(" AND Dept_PCode='" + deptCode + "'");
            IEnumerable<Bse_Department> root = allDept.Where(o => string.IsNullOrEmpty(o.Dept_PCode));
            foreach (var d in root)
            {
                GenerateChild(d, allDept);
            }
            return root;

        }
        private void GenerateChild(Bse_Department dept, List<Bse_Department> allDept)
        {
            dept.ChildrenDept = allDept.Where(o => o.Dept_PCode == dept.Dept_Code);

            if (dept.ChildrenDept.Count() == 0)
            {
                return;
            }

            foreach (var d in dept.ChildrenDept)
            {
                GenerateChild(d, allDept);
            }
        }

        #endregion


        //public static List<T> CommTreeWithNon;

        //public IEnumerable<T> GetChild(List<T> all,T root, Func<T, IEnumerable<T>> childrenProperty)
        //{
        //    var child = childrenProperty(root);
        //    if (child==null || child.Count()==0)
        //    {
        //        return;
        //    }

        //}





        /// <summary>
        /// 获取公司帐期
        /// </summary>
        /// <param name="Company"></param>
        /// <returns></returns>
        //public static Bse_Period GetCurCompanyPeriod(string Company)
        //{
        //    Bll_Bse_Period PeriodInstance = new Bll_Bse_Period();
        //    Bse_Period model = PeriodInstance.GetModel(" and BP_CompanyCode='" + Company + "' AND BP_IsCurrent='1' order by BP_ID DESC");
        //    return model;
        //}

        /// <summary>
        /// JqGrid通用分页序列化，根据数据配置字段进行时间格式化
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static string JsonForJqgrid(string Module, DataTable dt, int pageIndex, int pageSize, int totalCount)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            int total = 0;
            int page = totalCount / pageSize;
            total = totalCount > pageSize ? totalCount / pageSize : 1;
            if (totalCount > pageSize)
            {
                if (totalCount % pageSize > 0)
                {
                    total = total + 1;
                }
            }
            if (totalCount == 0)
            {
                total = 0;
                pageIndex = 0;
            }

            jsonBuilder.Append("{\"Page\":" + pageIndex + ",\"Total\":" + total + ",\"Records\":" + totalCount + ",\"Rows\":");


            #region 对时间进行格式化

            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            List<Sys_Config_Fieled> listfiled = new List<Sys_Config_Fieled>();
            GetListConfig(Module, out M_Model, out listfiled);

            DataTable newDt = dt.Clone();
            //DataTable resultDt = dt.Clone();

            //string json = JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd"));

            for (var x = 0; x < newDt.Columns.Count; x++)
            {
                var D_Index = dt.Columns[x].ColumnName;

                var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                if (tmpModel.Count() > 0)
                {
                    if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                    {
                        newDt.Columns[x].DataType = typeof(string);
                    }
                    else if (tmpModel.FirstOrDefault().D_EditType == "date")
                    {
                        newDt.Columns[x].DataType = typeof(string);
                    }
                }
            }

            newDt.Rows.Clear();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow newRow = newDt.NewRow();
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    var D_Index = dt.Columns[j].ColumnName;
                    var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                    if (tmpModel.Count() > 0)
                    {
                        if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                        {

                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd HH:mm:ss")).Replace("\"", " ") : "";
                        }
                        else if (tmpModel.FirstOrDefault().D_EditType == "date")
                        {
                            //newDt.Columns[j].DataType = typeof(string);
                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd")).Replace("\"", " ") : "";
                        }
                        else
                        {
                            newRow[D_Index] = dt.Rows[i][D_Index];
                        }
                    }
                }
                newDt.Rows.Add(newRow);
            }
            #endregion


            jsonBuilder.Append(JsonConvert.SerializeObject(newDt, new DataTableConverter()));
            //jsonBuilder.Append(" ,\"UserData\":{ \"PUD_Num\":100 } ");
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }


        /// <summary>
        /// JqGrid通用分页序列化，根据数据配置字段进行时间格式化
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static string JsonForJqgridForRpt(string Module, DataTable dt, int pageIndex, int pageSize, int totalCount)
        {

            StringBuilder jsonBuilder = new StringBuilder();

            StringBuilder sumBuilder = new StringBuilder();

            int total = 0;
            int page = totalCount / pageSize;
            total = totalCount > pageSize ? totalCount / pageSize : 1;
            if (totalCount > pageSize)
            {
                if (totalCount % pageSize > 0)
                {
                    total = total + 1;
                }
            }
            if (totalCount == 0)
            {
                total = 0;
                pageIndex = 0;
            }

            jsonBuilder.Append("{\"Page\":" + pageIndex + ",\"Total\":" + total + ",\"Records\":" + totalCount + ",\"Rows\":");


            #region 对时间进行格式化

            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            List<Sys_Config_Fieled> listfiled = new List<Sys_Config_Fieled>();
            GetListConfig(Module, out M_Model, out listfiled);

            DataTable newDt = dt.Clone();
            //DataTable resultDt = dt.Clone();

            //string json = JsonConvert.SerializeObject(dt, new DataTableConverter(), new JsonDateConverter("yyyy-MM-dd"));

            for (var x = 0; x < newDt.Columns.Count; x++)
            {
                var D_Index = dt.Columns[x].ColumnName;

                var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                if (tmpModel.Count() > 0)
                {
                    if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                    {
                        newDt.Columns[x].DataType = typeof(string);
                    }
                    else if (tmpModel.FirstOrDefault().D_EditType == "date")
                    {
                        newDt.Columns[x].DataType = typeof(string);
                    }
                }
            }

            var D_SumList = listfiled.Where(o => !string.IsNullOrEmpty(o.D_Summary));

            newDt.Rows.Clear();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow newRow = newDt.NewRow();

                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    var D_Index = dt.Columns[j].ColumnName;
                    var tmpModel = listfiled.Where(o => o.D_Index == D_Index);
                    if (tmpModel.Count() > 0)
                    {
                        if (tmpModel.FirstOrDefault().D_EditType == "datetime")
                        {

                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd HH:mm:ss")).Replace("\"", " ") : "";
                        }
                        else if (tmpModel.FirstOrDefault().D_EditType == "date")
                        {
                            //newDt.Columns[j].DataType = typeof(string);
                            newRow[D_Index] = dt.Rows[i][D_Index] != null && !string.IsNullOrEmpty(dt.Rows[i][D_Index].ToString())
                                ? JsonConvert.SerializeObject(DateTime.Parse(dt.Rows[i][D_Index].ToString()), new JsonDateConverter("yyyy-MM-dd")).Replace("\"", " ") : "";
                        }
                        else
                        {
                            newRow[D_Index] = dt.Rows[i][D_Index];
                        }
                    }
                }

                newDt.Rows.Add(newRow);
            }
            #endregion

            if (D_SumList.Count() > 0 && newDt.Rows.Count > 0)
            {
                sumBuilder.Append(",\"UserData\":{");
                StringBuilder sb = new StringBuilder();
                foreach (var item in D_SumList)
                {
                    if (newDt.Columns.Contains(item.D_Index))
                    {
                        var val = newDt.Compute(string.Format("Sum({0})", item.D_Index), "");
                        //var d = decimal.Parse(val.ToString());
                        sb.AppendFormat("\"{0}\":{1},", item.D_Index, val);
                    }
                }
                sumBuilder.Append(sb.ToString().TrimEnd(','));
                sumBuilder.Append(" }");
            }
            else
            {
                sumBuilder.Append(",\"UserData\":{");
                StringBuilder sb = new StringBuilder();
                foreach (var item in D_SumList)
                {
                    //if (newDt.Columns.Contains(item.D_Index))
                    //{
                        //var val = newDt.Compute(string.Format("Sum({0})", item.D_Index), "");
                        //var d = decimal.Parse(val.ToString());
                        sb.AppendFormat("\"{0}\":{1},", item.D_Index, "0");
                    //}
                }
                sumBuilder.Append(sb.ToString().TrimEnd(','));
                sumBuilder.Append(" }");
            }

            jsonBuilder.Append(JsonConvert.SerializeObject(newDt, new DataTableConverter()));
            if (!string.IsNullOrEmpty(sumBuilder.ToString()))
            {
                jsonBuilder.Append(sumBuilder.ToString());
            }
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// Jqgrid通用分页
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


        /// <summary>
        /// 获取Sys_Config_ListPage,Sys_Config_Fieled配置
        /// </summary>
        /// <param name="moduleName"></param>
        /// <param name="M_Model"></param>
        /// <param name="D_List"></param>
        /// <returns></returns>
        public static Sys_Config_ListPage GetListConfig(string moduleName, out Sys_Config_ListPage M_Model, out List<Sys_Config_Fieled> D_List)
        {
            ADOSys_Config_ListPage ListInstance = new ADOSys_Config_ListPage();
            ADOSys_Config_Fieled FieledInstance = new ADOSys_Config_Fieled();
            M_Model = null;
            D_List = null;
            try
            {
                if (!string.IsNullOrEmpty(moduleName))
                {
                    //第一步：根据传入模块获取Grid配置
                    List<Sys_Config_ListPage> _ListPage = ListInstance.GetListByWhere(" AND M_ModuleCode='" +
                    moduleName + "'");
                    if (_ListPage.Count > 0)
                    {
                        M_Model = _ListPage[0];
                    }
                    //第二步：根据模块获取所有字段
                    D_List = FieledInstance.GetListByWhere(" AND D_ModuleCode='" + moduleName + "'");
                }
                else
                {
                    M_Model = null;
                    D_List = null;
                }
            }
            catch (System.Exception ex)
            {
                M_Model = null;
                D_List = null;
            }

            return M_Model;
        }

        // Modify BY QB 
        // Modify:
        // Modify Date:2011-3-12
        /// <summary>
        /// 通用字典转换
        /// </summary>
        /// <param name="Module"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DataTable ConvertDict(string Module, DataTable dt)
        {
            QX.DAL.ADOBse_Dict dictInstance = new QX.DAL.ADOBse_Dict();
            Sys_Config_ListPage M_Model = new Sys_Config_ListPage();
            List<Sys_Config_Fieled> D_List = new List<Sys_Config_Fieled>();
            Bll_Comm.GetListConfig(Module, out M_Model, out D_List);
            if (M_Model != null && D_List.Count > 0 && dt.Rows.Count > 0)
            {
                List<Sys_Config_Fieled> newDList = D_List.Where(o => !string.IsNullOrEmpty(o.D_DictKey)).ToList();
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (var item in newDList)
                    {
                        var model = dictInstance.GetListByWhere(" AND Dict_Key='" + item.D_DictKey + "' AND Dict_Code='" + dt.Rows[i][item.D_Index] + "'");
                        if (model.Count > 0)
                        {
                            dt.Rows[i][item.D_Index] = model.First().Dict_Name;
                        }
                    }
                }
            }
            return dt;
        }

        #region 树形数据生成

        /// <summary>
        /// 构造字典树形结构
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static IList<Bse_Dict> DictTree(IList<Bse_Dict> ds)
        {
            //定义字典类型，将List转换成字典类型，集合中的元素个数是相同的
            var dic = new Dictionary<string, Bse_Dict>(ds.Count);

            foreach (var child in ds)
            {
                dic.Add(child.Dict_Code, child);
            }

            //通过一次遍历集合，转换成具有层次结构的类型
            foreach (var child in dic.Values)
            {
                if (dic.ContainsKey(child.Dict_PCode))
                {
                    if (dic[child.Dict_PCode].Childrens == null)
                        dic[child.Dict_PCode].Childrens = new List<Bse_Dict>();

                    dic[child.Dict_PCode].Childrens.Add(child);
                }
            }

            //仅仅选择最顶层节点返回
            return dic.Values.Where(t => string.IsNullOrEmpty(t.Dict_PCode)).ToList();
        }

        /// <summary>
        /// 获取某节点下的所有子节点,包含当前节点
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public List<Bse_Dict> DictTreeNoDepth(IList<Bse_Dict> ds, string Node)
        {
            List<Bse_Dict> result = new List<Bse_Dict>();
            var root = ds.Where(o => o.Dict_Code == Node);
            foreach (var item in root)
            {
                result.Add(item);
                FindDictChild(item, ds.ToList(), ref result);
            }
            return result;
        }

        private void FindDictChild(Bse_Dict model, List<Bse_Dict> all, ref List<Bse_Dict> ResultList)
        {
            var child = all.Where(o => o.Dict_PCode == model.Dict_Code);
            if (child.Count() == 0)
            {
                return;
            }
            foreach (var item in child)
            {
                ResultList.Add(item);
                FindDictChild(item, all, ref ResultList);
            }
        }


        /// <summary>
        /// 构造字典树形结构
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        //public static IList<WH_Warehouse> WareHouseTree(IList<WH_Warehouse> ds)
        //{
        //    //定义字典类型，将List转换成字典类型，集合中的元素个数是相同的
        //    var dic = new Dictionary<string, WH_Warehouse>(ds.Count);

        //    foreach (var child in ds)
        //    {
        //        dic.Add(child.Warehouse_Code, child);
        //    }

        //    //通过一次遍历集合，转换成具有层次结构的类型
        //    foreach (var child in dic.Values)
        //    {
        //        if (dic.ContainsKey(child.Warehouse_PCode))
        //        {
        //            if (dic[child.Warehouse_PCode].Childrens == null)
        //                dic[child.Warehouse_PCode].Childrens = new List<WH_Warehouse>();

        //            dic[child.Warehouse_PCode].Childrens.Add(child);
        //        }
        //    }

        //    //仅仅选择最顶层节点返回
        //    return dic.Values.Where(t => string.IsNullOrEmpty(t.Warehouse_PCode)).ToList();
        //}

        /// <summary>
        /// 获取某节点下的所有子节点,包含当前节点
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        //public List<WH_Warehouse> WareHouseTreeNoDepth(IList<WH_Warehouse> ds, string Node)
        //{
        //    List<WH_Warehouse> result = new List<WH_Warehouse>();
        //    var root = ds.Where(o => o.Warehouse_Code == Node);
        //    foreach (var item in root)
        //    {
        //        result.Add(item);
        //        FindHouseChild(item, ds.ToList(), ref result);
        //    }
        //    return result;
        //}

        //private void FindHouseChild(WH_Warehouse model, List<WH_Warehouse> all, ref List<WH_Warehouse> ResultList)
        //{
        //    var child = all.Where(o => o.Warehouse_PCode == model.Warehouse_Code);
        //    if (child.Count() == 0)
        //    {
        //        return;
        //    }
        //    foreach (var item in child)
        //    {
        //        ResultList.Add(item);
        //        FindHouseChild(item, all, ref ResultList);
        //    }
        //}

        #endregion


        #region 功能权限树形节点

        /// <summary>
        /// 构造字典树形结构
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        //public static IList<Sys_Function> RoleTree(IList<Sys_Function> ds)
        //{
        //    //定义字典类型，将List转换成字典类型，集合中的元素个数是相同的
        //    var dic = new Dictionary<string, Sys_Function>(ds.Count);

        //    foreach (var child in ds)
        //    {
        //        dic.Add(child.Fun_Code, child);
        //    }

        //    //通过一次遍历集合，转换成具有层次结构的类型
        //    foreach (var child in dic.Values)
        //    {
        //        if (dic.ContainsKey(child.Fun_PCode))
        //        {
        //            if (dic[child.Fun_PCode].Childrens == null)
        //                dic[child.Fun_PCode].Childrens = new List<Sys_Function>();

        //            dic[child.Fun_PCode].Childrens.Add(child);
        //        }
        //    }

        //    //仅仅选择最顶层节点返回
        //    return dic.Values.Where(t => string.IsNullOrEmpty(t.Fun_PCode)).ToList();
        //}

        /// <summary>
        /// 获取某节点下的所有子节点,包含当前节点
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        //public List<Sys_Function> RoleTreeNoDepth(IList<Sys_Function> ds, string Node)
        //{
        //    List<Sys_Function> result = new List<Sys_Function>();
        //    var root = ds.Where(o => o.Fun_Code == Node);
        //    foreach (var item in root)
        //    {
        //        result.Add(item);
        //        FindRoleChild(item, ds.ToList(), ref result);
        //    }
        //    return result;
        //}

        //private void FindRoleChild(Sys_Function model, List<Sys_Function> all, ref List<Sys_Function> ResultList)
        //{
        //    var child = all.Where(o => o.Fun_PCode == model.Fun_Code);
        //    if (child.Count() == 0)
        //    {
        //        return;
        //    }
        //    foreach (var item in child)
        //    {
        //        ResultList.Add(item);
        //        FindRoleChild(item, all, ref ResultList);
        //    }
        //}

        #endregion


        #region 根据用户获取权限列表
        /// <summary>
        /// 用户获取权限列表
        /// </summary>
        /// <param name="UserId">用户编码</param>
        /// <returns>用户权限字典</returns>
        //public static Dictionary<string, string> UserPermissionDict(string UserId)
        //{
        //    Dictionary<string, string> DictPermmission = new Dictionary<string, string>();
        //    List<Sys_UserPermission> ListPermission = UserPermissionList(UserId);
        //    foreach (var item in ListPermission)
        //    {
        //        DictPermmission.Add(item.PU_FunCode, item.PU_FunName);
        //    }
        //    return DictPermmission;
        //}
        /// <summary>
        /// 用户权限列表
        /// </summary>
        /// <param name="UserId">用户编码</param>
        /// <returns>用户权限数组</returns>
        //public static string[] UserPermissionArray(string UserId)
        //{
        //    List<Sys_UserPermission> ListPermission = UserPermissionList(UserId);
        //    string[] StrPermission = new string[ListPermission.Count];
        //    for (var i = 0; i < ListPermission.Count; i++)
        //    {
        //        StrPermission[i] = ListPermission[i].PU_FunCode;
        //    }
        //    return StrPermission;
        //}

        /// <summary>
        /// 用户权限列表
        /// </summary>
        /// <param name="UserId">用户编码</param>
        /// <returns>用户权限List</returns>
        //public static List<Sys_UserPermission> UserPermissionList(string UserId)
        //{
        //    ADOSys_UserPermission PermissionInstance = new ADOSys_UserPermission();
        //    List<Sys_UserPermission> ListPermission = PermissionInstance
        //        .GetUserPerimission(UserId).Where(o => o.PU_IsCheck == "1" && (!o.PU_FunCode.StartsWith("C"))).ToList();
        //    return ListPermission;
        //}

        /// <summary>
        /// 获取用户没有权限的功能点列表 
        /// </summary>
        /// <param name="UserId">用户编码</param>
        /// <returns>用户无权限功能列表</returns>
        //public static List<Sys_UserPermission> UserNotPermisionnList(string UserId)
        //{
        //    ADOSys_UserPermission PermissionInstance = new ADOSys_UserPermission();
        //    List<Sys_UserPermission> ListPermission = PermissionInstance
        //        .GetUserPerimission(UserId).Where(o => (string.IsNullOrEmpty(o.PU_IsCheck) || o.PU_IsCheck != "1") && (!o.PU_FunCode.StartsWith("C")) ).ToList();
        //    return ListPermission;
        //}

        /// <summary>
        /// 写入操作日志
        /// </summary>
        /// <param name="Module">模块编码 </param>
        /// <param name="ModuleName">模块名称</param>
        /// <param name="Message">异常信息</param>
        public static void OpLog(string Module, string ModuleName, string Message)
        {
            var IS_OPEN_PERMISSION = ConfigHelper.GetApp("IS_OPEN_FUNCATIONLOG");
            if (!string.IsNullOrEmpty(IS_OPEN_PERMISSION) && IS_OPEN_PERMISSION == "true")
            {
                try
                {
                    PlateLog.WriteOp(SessionConfig.UserId(), SessionConfig.UserName(),
                    HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.ToString(),
                    Message, PlateLog.LogMessageType.Info, Module, ModuleName);
                }
                catch (System.Exception ex)
                {
                    PlateLog.WriteInFile(SessionConfig.UserId(), SessionConfig.UserName(),
                    HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.ToString(),
                    Message, PlateLog.LogMessageType.Error, ex);
                }
            }

        }

        /// <summary>
        /// 写入用户登录日志
        /// </summary>
        public static void LoginLog(string UserName , string Msg)
        {
            try
            {
                Bll_Sys_LoginLog instance = new Bll_Sys_LoginLog();
                Sys_LoginLog model = new Sys_LoginLog()
                {
                    EL_Date = DateTime.Now,
                    EL_UserCode = UserName,
                    EL_UserName = SessionConfig.UserName(),
                    EL_IP = HttpContext.Current.Request.UserHostAddress,
                    EL_Mac = "",
                    EL_Company = SessionConfig.Company(),
                    EL_Dept = SessionConfig.DeptName(),
                    EL_Success = Msg
                };
                instance.Insert(model);    
            }
            catch (System.Exception ex)
            {
                PlateLog.WriteInFile(SessionConfig.UserId(), SessionConfig.UserName(),
                    HttpContext.Current.Request.UserHostAddress, HttpContext.Current.Request.Url.ToString(),
                    ex.Message, PlateLog.LogMessageType.Error, ex);
            }
                   
       }

        #endregion


    }
}
