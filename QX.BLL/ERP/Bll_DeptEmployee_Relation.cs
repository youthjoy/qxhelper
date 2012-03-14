using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;
using QX.Comm;
using QX.ERP.DAL;

namespace QX.BLL
{
    public partial class Bll_DeptEmployee_Relation
    {

        private Bll_Bse_Department deptInstance = new Bll_Bse_Department();
        private ADOBse_Employee einstance = new ADOBse_Employee();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deptCode">选中部门节点</param>
        /// <returns></returns>
        public List<Bse_Employee> GetStuffByDept(string deptCode, string filter)
        {
            List<Bse_Department> list = deptInstance.GetLevelDeptListWidthSeft(deptCode).Distinct(new HR_IEqualityComparer()).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                var d = list[i];
                sb.AppendFormat("'{0}',", d.Dept_Code);
            }
            string where = string.Empty;
            if (string.IsNullOrEmpty(filter))
            {
                where = string.Format(" and  Emp_Dept_Code in ({0})", sb.ToString().Trim().TrimEnd(','));
            }
            else
            {
                where = string.Format(" and  Emp_Dept_Code in ({0}) {1}", sb.ToString().Trim().TrimEnd(','), filter);
            }

            return einstance.GetListByWhere(where);
        }

        public List<Bse_Employee> GetStuffByDept(string deptCode)
        {
            List<Bse_Department> list = deptInstance.GetLevelDeptListWidthSeft(deptCode).Distinct(new HR_IEqualityComparer()).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                var d = list[i];
                sb.AppendFormat("'{0}',", d.Dept_Code);
            }
            string where = string.Empty;

            where = string.Format(" and  Emp_Dept_Code in ({0})", sb.ToString().Trim().TrimEnd(','));


            return einstance.GetListByWhere(where);
        }

    }

    public class HR_IEqualityComparer : IEqualityComparer<Bse_Department>
    {

        #region IEqualityComparer<Bse_Employee> 成员

        public bool Equals(Bse_Department x, Bse_Department y)
        {
            if (x.Dept_Code == y.Dept_Code)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Bse_Department obj)
        {
            return obj.Dept_Code.GetHashCode();
        }

        #endregion
    }

}
