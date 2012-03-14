using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;
using QX.Comm.Utils;
using System.Data.SqlClient;
using QX.ERP.DAL;

namespace QX.BLL
{
    public partial class Bll_Bse_Employee
    {


       private Bll_DeptEmployee_Relation derInstance;

       //private Bll_DeptEmployee_Relation derInstance = new Bll_DeptEmployee_Relation();

       public Bll_Bse_Employee()
        {
            derInstance = new Bll_DeptEmployee_Relation();
        }

        public List<Bse_Employee> GetStuffByDept(string deptCode, string where)
        {
            return derInstance.GetStuffByDept(deptCode, where);
            //string where = string.Format("");
        }

        public List<Bse_Employee> GetStuffByDept(string deptCode)
        {
            return derInstance.GetStuffByDept(deptCode);
            //string where = string.Format("");
        }

     



        public Bse_Employee GetModelByCode(string code)
        {
            return GetModel(string.Format("AND Emp_Code='{0}'", code));
        }


        
        public string GetDeptCode(string DeptPCode)
        {
            return Bll_Comm.GetTableKey("", "HR_Department", DeptPCode, "");
        }
    }
}
