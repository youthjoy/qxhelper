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
    public class Bll_RoadComponents
    {
        private ERP.DAL.ADORoad_Components rcInstance = new ADORoad_Components();

        public List<Road_Components> GetCompList(string where)
        {
            return rcInstance.GetListByWhere(string.Format("AND {0}", where));
        }
    }
}
