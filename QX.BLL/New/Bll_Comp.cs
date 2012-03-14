using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QX.Model;
using QX.DAL;
using QX.Comm;
using QX.Config;
using QX.ERP.DAL;

namespace QX.BLL
{
    public class Bll_Comp
    {
        private ADOBse_Components cInstance = new ADOBse_Components();
    //    private ADOBse_CompHistory chInstance = new ADOBse_CompHistory();

        private ADOSD_Customer sdInstance = new ADOSD_Customer();

        private Bll_Comm comInstance = new Bll_Comm();

        public List<Bse_Components> GetCompDraftList(string filter)
        {
            List<Bse_Components> list = new List<Bse_Components>();
            string where = string.Format(" AND Comp_Stat='{0}' AND Comp_Creator ='{1}' AND {2} ", "Draft", SessionConfig.UserId(), filter, AllotType.Distribution.ToString());
            return cInstance.GetListByWhere(where);
        }

        public Bse_Components GetModel(string where)
        {
            return cInstance.GetListByWhere(where).FirstOrDefault();
        }

      //  private Bll_Audit auditInstance = new Bll_Audit();

       

        public List<SD_Customer> GetCustomerList(string where)
        {
            return sdInstance.GetListByWhere(string.Format("AND {0} AND Cust_Type='GCustomer'", where));
        }

        public List<TheTreeNode> GenerateCompTree()
        {
            //获取客户列表-->转换成TheTreeNode
            List<SD_Customer> list = sdInstance.GetListByWhere(string.Format(" AND Cust_Type='GCustomer'"));
            List<Bse_Components> compList = cInstance.GetAll();
            List<TheTreeNode> root = (from c in list select new TheTreeNode {parent="", state = c.Cust_Code, data = c.Cust_Name }).ToList();

            foreach (var c in root)
            {
                GenerateChild(c, compList);
            }

            //获取客户图号列表-->转换成TheTreeNode
            return root;
        }

        private void GenerateChild(TheTreeNode dict, List<Bse_Components> allData)
        {
            dict.childrenenum = (from c in allData where c.Comp_Customer == dict.state select new TheTreeNode {parent=dict.state, state = c.Comp_CCode, data = c.Comp_CCode }).Distinct(o => o.state).ToList();

            //if (dict.childrenenum.Count() == 0)
            //{
            //    return;
            //}

            //foreach (var d in dict.childrenenum)
            //{
            //    GenerateChild(d, allData);
            //}
        }



        /// <summary>
        /// 获取文档列表（不是草稿状态的代办)--已审核，但未进一步操作的（比如分发）
        /// </summary>
        /// <returns></returns>


  

        /// <summary>
        /// 获取与用户相关的所有图纸（可以查看的（分发、审核））
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
    

        /// <summary>
        /// 获取图号以及客户相关的图纸列表(id是图号或者客户编号)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        

        /// <summary>
        /// 获取用户相关已提交图纸
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
     

        public string GenerateCompCode()
        {
            return comInstance.GetTableKeyCode("Bse_Components");
        }

        public bool AddComp(Bse_Components model)
        {
            if (cInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateComp(Bse_Components model)
        {
            if (cInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteComp(Bse_Components model)
        {
            model.Stat = 1;
            if (cInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        
    }
}
