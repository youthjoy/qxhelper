using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QX.DAL;
using QX.Model;
using System.Threading;
namespace QX.BLL
{
    public class Bll_Message
    {
        private ADOBse_Message mInstance = new ADOBse_Message();
        private Bll_Comm comInstance = new Bll_Comm();
        public List<Bse_Message> GetMsgList(string where)
        {
            return mInstance.GetListByWhere(string.Format("AND {0}", where));
        }

        public Bse_Message GetModel(string where)
        {
            return mInstance.GetListByWhere(where).FirstOrDefault();
        }

        public string GenerateMsgCode()
        {
            return comInstance.GetTableKeyCode("Bse_Message");
        }

        public bool Add(Bse_Message model)
        {
            if (mInstance.Add(model) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(Bse_Message model)
        {
            model.UpdateTime = DateTime.Now;
            if (mInstance.Update(model) > 0)
            {
                return true;
            }

            return false;
        }

        #region 消息提示


        #endregion
    }
}
