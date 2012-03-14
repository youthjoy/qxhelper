using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.DAL;
using QX.Model;

namespace QX.BLL
{
    public partial class Bll_Bse_Department
    {
 

        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <returns></returns>
        public List<Bse_Department> GetDeptList()
        {
            string where = " AND Dept_PCode IS NULL";

            return instance.GetListByWhere(where);
        }


        //获取下一级节点(未使用)
        public List<Bse_Department> GetDeptByParent(string parentCode)
        {
            string where = string.Format(" AND Dept_PCode='{0}'", parentCode);
            return instance.GetListByWhere(where);
        }


        /// <summary>
        /// 获取树控件节点列表
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public List<TheTreeNode> GetDeptTree()
        {

            List<Bse_Department> allData = GetAll();

            IEnumerable<Bse_Department> temp = allData.Where(o => (string.IsNullOrEmpty(o.Dept_PCode)));
            List<TheTreeNode> rootTreeNode = (from t in temp select new TheTreeNode { data = t.Dept_Name, attr = new Attr { id = t.Dept_Code } }).ToList();

            //List<TheTreeNode> result = new List<TheTreeNode>();

            foreach (var d in rootTreeNode)
            {

                GenerateTree(d, allData);
                //rootTreeNode.Add(d);
            }

            return rootTreeNode;
        }

        private void GenerateTree(TheTreeNode node, List<Bse_Department> allData)
        {
            var list = allData.Where(o => o.Dept_PCode == node.attr.id);

            node.children = (from d in list select new TheTreeNode { data = d.Dept_Name, attr = new Attr { id = d.Dept_Code } }).ToList();


            if (node.children.Count == 0)
            {
                return;
            }

            foreach (var d in node.children)
            {
                GenerateTree(d, allData);
            }
        }



        /// <summary>
        /// 获取某节点下面所有子节点(有误)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<Bse_Department> GetLevelDeptList(string code)
        {
            List<Bse_Department> allDept = this.GetAll();
            List<Bse_Department> list = new List<Bse_Department>();
            //foreach (var d in allDept)
            //{

            //    list.Add(d);
            //    GenerateDept(list, allDept, allDept.Where(o => o.Dept_PCode == d.Dept_Code));
            //}

            return list;
        }


        #region 获取层级部门节点列表

        /// <summary>
        /// 获取某节点下面所有子节点
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<Bse_Department> GetLevelDeptListWidthSeft(string code)
        {
            List<Bse_Department> allDept = this.GetAll();
            List<Bse_Department> list = new List<Bse_Department>();
            list.Add(allDept.FirstOrDefault(o => o.Dept_Code == code));
            foreach (var d in allDept.Where(o => o.Dept_PCode == code))
            {

                list.Add(d);
                GenerateDept(list, allDept, allDept.Where(o => o.Dept_PCode == d.Dept_Code));
            }

            return list;
        }

        public string GetLevelDeptListWidthSeftForRpt(string code)
        {
            List<Bse_Department> allDept = this.GetAll();
            List<Bse_Department> list = new List<Bse_Department>();
            list.Add(allDept.FirstOrDefault(o => o.Dept_Code == code));
            foreach (var d in allDept.Where(o => o.Dept_PCode == code))
            {

                list.Add(d);
                GenerateDept(list, allDept, allDept.Where(o => o.Dept_PCode == d.Dept_Code));
            }

            StringBuilder sb = new StringBuilder();

            foreach (var p in list)
            {
                sb.AppendFormat("'{0}',",p.Dept_Code);    
            }
            string re = sb.ToString().TrimEnd(',');
            return re;
        }

        private void GenerateDept(List<Bse_Department> list, List<Bse_Department> allData, IEnumerable<Bse_Department> parentNodes)
        {
            if (parentNodes.Count() == 0)
            {
                return;
            }
            foreach (var d in parentNodes)
            {
                
                list.Add(d);
                GenerateDept(list, allData, allData.Where(o => o.Dept_PCode == d.Dept_Code));
            }
        }

        /// <summary>
        /// 生成包含层级关系的子节点列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Bse_Department> GetChildListDept()
        {
            List<Bse_Department> allDept = instance.GetAll();
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
        /// <summary>
        /// 新增或更新对象
        /// </summary>
        /// <param name="Mn"></param>
        /// <returns></returns>
        public bool AddUpdatePlanObject(Bse_Department dep)
        {
            if (dep.Dept_ID.Equals(0))
            {
                return instance.Add(dep).Equals(1);
            }
            else
            {
                return instance.Update(dep).Equals(1);
            }
        }
        #endregion

    }
}
