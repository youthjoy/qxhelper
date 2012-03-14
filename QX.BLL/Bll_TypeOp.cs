using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QX.Model;
using QX.Comm;
using System.Collections;

namespace QX.BLL
{
    public partial class Bll_TypeOp
    {
        private Bll_WH_MaterialType instance = new Bll_WH_MaterialType();
        private Bll_Bse_Dict dictInstance = new Bll_Bse_Dict();
       // private Bll_HR_Department deptInstance = new Bll_HR_Department();


        /// <summary>
        /// 同步公司物料类别
        /// </summary>
        /// <param name="itype"></param>
        /// <param name="companycode"></param>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public bool SyncMaterialTypeFromDict(string itype, string companyCode)
        {
            bool result = false;

            List<WH_MaterialType> list = new List<WH_MaterialType>();
            List<Bse_Dict> dictList = new List<Bse_Dict>();
            List<string> Union = new List<string>();
            List<string> InterSect= new List<string>();

            if (!string.IsNullOrEmpty(companyCode) && !string.IsNullOrEmpty(itype))
            {
                try
                {
                    //dictList = dictInstance.GetListByCode(" AND Dict_Key!=Dict_Code AND Dict_PCode='" + itype + "'");
                    // Modify BY QB 
                    // Modify:同步字典中所有子类别
                    // Modify Date:2011-3-22
                    dictList = dictInstance.GetListByCode(" AND Dict_Key!=Dict_Code AND Dict_Key='" + itype + "'");
                    list = instance.GetListByCode(" AND MT_CompanyCode='" + companyCode + "' ");

                    IEnumerable<string> listStrList = list.Select(o => o.MT_TCode);
                    IEnumerable<string> dictStrList = dictList.Select(o => o.Dict_Code);

                    //取Dict与MaterialType中的并集，并比对Maertitype中是否存在，不存在则插入数据，
                    Union = dictStrList.Union(listStrList).ToList<string>();
                    
                    //取交集
                    InterSect = dictStrList.Intersect(listStrList).ToList<string>();

                    //逻辑删除关系类别
                    foreach (var listItem in listStrList)
                    {
                        if (!InterSect.Contains(listItem))
                        {
                            var typeModel = list.Where(o => o.MT_TCode == listItem);
                            if (typeModel.Count() > 0)
                            {
                                typeModel.First().Stat = 1;
                                instance.Update(typeModel.First());
                            }
                        }                            
                    }

                    //更新和插入Type
                    foreach (var item in Union)
                    {
                        var typeModel = list.Where(o => o.MT_TCode == item);
                        var dictModel = dictList.Where(o => o.Dict_Code == item);
                        if (typeModel.Count() > 0)
                        {
                            //更新
                            if (dictModel.First().Dict_Name != typeModel.First().MT_TName)
                            {
                                typeModel.First().MT_TName = dictModel.First().Dict_Name;
                                typeModel.First().MT_TPCode = dictModel.First().Dict_PCode;
                                typeModel.First().MT_Order = dictModel.First().Dict_Order;
                                instance.Update(typeModel.First());
                            }
                        }
                        else
                        {
                            //插入
                            WH_MaterialType model = new WH_MaterialType();
                            model.MT_Code = Bll_Comm.GetTableKey("WH_MaterialType");
                            model.MT_TCode = dictModel.First().Dict_Code;
                            if (!string.IsNullOrEmpty(dictModel.First().Dict_PCode) && dictModel.First().Dict_PCode!=itype)
                            {
                                model.MT_TPCode = dictModel.First().Dict_PCode;
                            }
                            
                            model.MT_TName = dictModel.First().Dict_Name;
                            model.MT_Order = dictModel.First().Dict_Order;
                            model.MT_CompanyCode = companyCode;
                            var deptModel = deptInstance.GetModel(" AND Dept_Code='" + companyCode + "' ");
                            model.MT_Company = deptModel != null ? deptModel.Dept_Name : "";
                            instance.Insert(model);
                        }
                    }

                    result = true;
                }
                catch (System.Exception e)
                {
                    throw;
                }
           }
            return result;  
        }

        /// <summary>
        /// 获取公司物料类别，同步公司物料
        /// </summary>
        /// <param name="itype"></param>
        /// <param name="companyCode"></param>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public List<WH_MaterialType> GetListData(string itype, string companyCode, string deptCode)
        {
            List<WH_MaterialType> list = new List<WH_MaterialType>();
            List<Bse_Dict> dictList = new List<Bse_Dict>();
            //List<string> Union = new List<string>();
            //List<string> InterSect= new List<string>();

            //if (!string.IsNullOrEmpty(companyCode) && !string.IsNullOrEmpty(itype))
            //{
            //    dictList = dictInstance.GetListByCode(" AND Dict_Key!=Dict_Code AND Dict_PCode='"+itype+"'");
            //    list = instance.GetListByCode(" AND MT_CompanyCode='"+companyCode+"' ");
                
            //    //取Dict与MaterialType中的并集，并比对Maertitype中是否存在，不存在则插入数据，
            //    Union = dictList.Select(o => o.Dict_Code).Union(list.Select(o => o.MT_TCode)).ToList<string>();
            //    //取交集
            //    InterSect = dictList.Select(o => o.Dict_Code).Intersect(list.Select(o => o.MT_TCode)).ToList<string>();


            //    if (list.Count==0)
            //    {
            //        WH_MaterialType model = new WH_MaterialType();
            //        foreach (var item in dictList)
            //        {
            //            model.MT_Code = Bll_Comm.GetTableKey("WH_MaterialType");
            //            model.MT_TCode = item.Dict_Code;
            //            model.MT_TName = item.Dict_Name;
            //            model.MT_CompanyCode = companyCode;
            //            var deptModel = deptInstance.GetModel(" AND Dept_Code='" + companyCode + "' ");
            //            model.MT_Company = deptModel != null ? deptModel.Dept_Name : "";
            //            instance.Insert(model);
            //        }
            //    }              
            //}

            list = instance.GetListByCode(" AND MT_CompanyCode='" + companyCode + "' AND isnull(MT_TPCode,'')='' ");

            return list;
            
        }


        public bool Update(string code, string stat, string company)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(code) && !string.IsNullOrEmpty(stat))
            {
                var model = instance.GetModel(" AND MT_Code='" + code + "' ");
                if (model != null)
                {
                    model.MT_Status = stat;
                    instance.Update(model);
                    result = true;
                    if (result)
                    {
                        List<WH_MaterialType> allNode = GetChildListTypeNon(model.MT_TCode, company);
                        foreach (var item in allNode)
                        {
                            item.MT_Status = stat;
                            instance.Update(item);
                        }
                    }
                }
            }
            
            return result;
        }


        public static List<WH_MaterialType> staticDeptList = new List<WH_MaterialType>();

        #region 生成不包含层级关系的子节点列表
        public List<WH_MaterialType> GetChildListTypeNon(string Code,string  Company)
        {
            List<WH_MaterialType> all = instance.GetListByCode(" AND MT_CompanyCode='"+Company+"' ");
            IEnumerable<WH_MaterialType> root = all.Where(o => o.MT_TPCode == Code && !string.IsNullOrEmpty(o.MT_TCode));
            foreach (var d in root)
            {
                staticDeptList.Add(d);
                GenerateChildNon(d, all);
            }
            return staticDeptList;
        }

        private void GenerateChildNon(WH_MaterialType dept, List<WH_MaterialType> all)
        {
            dept.ChildrenType = all.Where(o => o.MT_TPCode == dept.MT_TCode);

            if (dept.ChildrenType.Count() == 0)
            {
                return;
            }
            foreach (var d in dept.ChildrenType)
            {
                staticDeptList.Add(d);
                GenerateChildNon(d, all);
            }
        }


        #endregion

    }
}
