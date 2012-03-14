using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
using QX.Comm;

namespace QX.BLL
{
    public partial class Bll_System_Menu
    {
        //private ADOSystem_Menu instance = new ADOSystem_Menu();

        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        //public List<System_Menu> GetAll()
        //{
        //    List<System_Menu> list = instance.GetAll();
        //    return list;
        //}
        /// <summary>
        /// 获取所有的信息
        /// </summary>
        /// <returns></returns>
        public List<System_Menu> GetAllShortcut()
        {
            List<System_Menu> list = instance.GetAllShortcut();
            return list;
        }       
     
        /// <summary>
        /// 获取菜单数据
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public List<System_Menu> GetMenu(MenuLocation location)
        {
            List<System_Menu> list = instance.GetListByWhere("  AND Menu_Location='" + location.ToString() + "' AND Menu_Enable='Enable' ORDER BY Menu_Order ASC ");
            return list;
        }
        /// <summary>
        /// 生成包含层级关系的子节点列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<System_Menu> GetChildListMenu()
        {
            List<System_Menu> allMenus = instance.GetAll();
            IEnumerable<System_Menu> root = allMenus.Where(o => o.Menu_PCode=="root");
            foreach (var d in root)
            {
                GenerateChild(d, allMenus);
            }
            return root;
        }
        private void GenerateChild(System_Menu Menu, List<System_Menu> allMenu)
        {
            Menu.ChildrenMenus = allMenu.Where(o => o.Menu_PCode == Menu.Menu_Code);

            if (Menu.ChildrenMenus.Count() == 0)
            {
                return;
            }
            foreach (var d in Menu.ChildrenMenus)
            {
                GenerateChild(d, allMenu);
            }
        }
    }
}
