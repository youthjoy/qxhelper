using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// 原料仓库
   /// </summary>
   [Serializable]
   public partial class ADOPC_Warehouse
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加原料仓库 PC_Warehouse对象(即:一条记录)
      /// </summary>
      public int Add(PC_Warehouse pC_Warehouse)
      {
         string sql = "INSERT INTO PC_Warehouse (PCW_Code,PCW_No,PCW_Name,PCW_Unit,PCW_MCode,PCW_MName,PCW_MGroup,PCW_MNum,PCW_MPrice,PCW_iType,PCW_Station,PCW_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCW_Code,@PCW_No,@PCW_Name,@PCW_Unit,@PCW_MCode,@PCW_MName,@PCW_MGroup,@PCW_MNum,@PCW_MPrice,@PCW_iType,@PCW_Station,@PCW_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Code))
         {
            idb.AddParameter("@PCW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Code", pC_Warehouse.PCW_Code);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_No))
         {
            idb.AddParameter("@PCW_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_No", pC_Warehouse.PCW_No);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Name))
         {
            idb.AddParameter("@PCW_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Name", pC_Warehouse.PCW_Name);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Unit))
         {
            idb.AddParameter("@PCW_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Unit", pC_Warehouse.PCW_Unit);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MCode))
         {
            idb.AddParameter("@PCW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MCode", pC_Warehouse.PCW_MCode);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MName))
         {
            idb.AddParameter("@PCW_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MName", pC_Warehouse.PCW_MName);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MGroup))
         {
            idb.AddParameter("@PCW_MGroup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MGroup", pC_Warehouse.PCW_MGroup);
         }
         if (pC_Warehouse.PCW_MNum == 0)
         {
            idb.AddParameter("@PCW_MNum", 0);
         }
         else
         {
            idb.AddParameter("@PCW_MNum", pC_Warehouse.PCW_MNum);
         }
         if (pC_Warehouse.PCW_MPrice == 0)
         {
            idb.AddParameter("@PCW_MPrice", 0);
         }
         else
         {
            idb.AddParameter("@PCW_MPrice", pC_Warehouse.PCW_MPrice);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_iType))
         {
            idb.AddParameter("@PCW_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_iType", pC_Warehouse.PCW_iType);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Station))
         {
            idb.AddParameter("@PCW_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Station", pC_Warehouse.PCW_Station);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Remark))
         {
            idb.AddParameter("@PCW_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Remark", pC_Warehouse.PCW_Remark);
         }
         if (pC_Warehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Warehouse.Stat);
         }
         if (pC_Warehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Warehouse.CreateDate);
         }
         if (pC_Warehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Warehouse.UpdateDate);
         }
         if (pC_Warehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Warehouse.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
         
      }
      /// <summary>
      /// 添加原料仓库 PC_Warehouse对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_Warehouse pC_Warehouse)
      {
         string sql = "INSERT INTO PC_Warehouse (PCW_Code,PCW_No,PCW_Name,PCW_Unit,PCW_MCode,PCW_MName,PCW_MGroup,PCW_MNum,PCW_MPrice,PCW_iType,PCW_Station,PCW_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCW_Code,@PCW_No,@PCW_Name,@PCW_Unit,@PCW_MCode,@PCW_MName,@PCW_MGroup,@PCW_MNum,@PCW_MPrice,@PCW_iType,@PCW_Station,@PCW_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Code))
         {
            idb.AddParameter("@PCW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Code", pC_Warehouse.PCW_Code);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_No))
         {
            idb.AddParameter("@PCW_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_No", pC_Warehouse.PCW_No);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Name))
         {
            idb.AddParameter("@PCW_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Name", pC_Warehouse.PCW_Name);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Unit))
         {
            idb.AddParameter("@PCW_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Unit", pC_Warehouse.PCW_Unit);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MCode))
         {
            idb.AddParameter("@PCW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MCode", pC_Warehouse.PCW_MCode);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MName))
         {
            idb.AddParameter("@PCW_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MName", pC_Warehouse.PCW_MName);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MGroup))
         {
            idb.AddParameter("@PCW_MGroup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MGroup", pC_Warehouse.PCW_MGroup);
         }
         if (pC_Warehouse.PCW_MNum == 0)
         {
            idb.AddParameter("@PCW_MNum", 0);
         }
         else
         {
            idb.AddParameter("@PCW_MNum", pC_Warehouse.PCW_MNum);
         }
         if (pC_Warehouse.PCW_MPrice == 0)
         {
            idb.AddParameter("@PCW_MPrice", 0);
         }
         else
         {
            idb.AddParameter("@PCW_MPrice", pC_Warehouse.PCW_MPrice);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_iType))
         {
            idb.AddParameter("@PCW_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_iType", pC_Warehouse.PCW_iType);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Station))
         {
            idb.AddParameter("@PCW_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Station", pC_Warehouse.PCW_Station);
         }
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Remark))
         {
            idb.AddParameter("@PCW_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Remark", pC_Warehouse.PCW_Remark);
         }
         if (pC_Warehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Warehouse.Stat);
         }
         if (pC_Warehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Warehouse.CreateDate);
         }
         if (pC_Warehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Warehouse.UpdateDate);
         }
         if (pC_Warehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Warehouse.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 var Return = idb.ReturnValue(sql);
                 Ex = Return.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 更新原料仓库 PC_Warehouse对象(即:一条记录
      /// </summary>
      public int Update(PC_Warehouse pC_Warehouse)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_Warehouse       SET ");
            if(pC_Warehouse.PCW_Code_IsChanged){sbParameter.Append("PCW_Code=@PCW_Code, ");}
      if(pC_Warehouse.PCW_No_IsChanged){sbParameter.Append("PCW_No=@PCW_No, ");}
      if(pC_Warehouse.PCW_Name_IsChanged){sbParameter.Append("PCW_Name=@PCW_Name, ");}
      if(pC_Warehouse.PCW_Unit_IsChanged){sbParameter.Append("PCW_Unit=@PCW_Unit, ");}
      if(pC_Warehouse.PCW_MCode_IsChanged){sbParameter.Append("PCW_MCode=@PCW_MCode, ");}
      if(pC_Warehouse.PCW_MName_IsChanged){sbParameter.Append("PCW_MName=@PCW_MName, ");}
      if(pC_Warehouse.PCW_MGroup_IsChanged){sbParameter.Append("PCW_MGroup=@PCW_MGroup, ");}
      if(pC_Warehouse.PCW_MNum_IsChanged){sbParameter.Append("PCW_MNum=@PCW_MNum, ");}
      if(pC_Warehouse.PCW_MPrice_IsChanged){sbParameter.Append("PCW_MPrice=@PCW_MPrice, ");}
      if(pC_Warehouse.PCW_iType_IsChanged){sbParameter.Append("PCW_iType=@PCW_iType, ");}
      if(pC_Warehouse.PCW_Station_IsChanged){sbParameter.Append("PCW_Station=@PCW_Station, ");}
      if(pC_Warehouse.PCW_Remark_IsChanged){sbParameter.Append("PCW_Remark=@PCW_Remark, ");}
      if(pC_Warehouse.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_Warehouse.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_Warehouse.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_Warehouse.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCW_ID=@PCW_ID; " );
      string sql=sb.ToString();
         if(pC_Warehouse.PCW_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Code))
         {
            idb.AddParameter("@PCW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Code", pC_Warehouse.PCW_Code);
         }
          }
         if(pC_Warehouse.PCW_No_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_No))
         {
            idb.AddParameter("@PCW_No", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_No", pC_Warehouse.PCW_No);
         }
          }
         if(pC_Warehouse.PCW_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Name))
         {
            idb.AddParameter("@PCW_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Name", pC_Warehouse.PCW_Name);
         }
          }
         if(pC_Warehouse.PCW_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Unit))
         {
            idb.AddParameter("@PCW_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Unit", pC_Warehouse.PCW_Unit);
         }
          }
         if(pC_Warehouse.PCW_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MCode))
         {
            idb.AddParameter("@PCW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MCode", pC_Warehouse.PCW_MCode);
         }
          }
         if(pC_Warehouse.PCW_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MName))
         {
            idb.AddParameter("@PCW_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MName", pC_Warehouse.PCW_MName);
         }
          }
         if(pC_Warehouse.PCW_MGroup_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_MGroup))
         {
            idb.AddParameter("@PCW_MGroup", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_MGroup", pC_Warehouse.PCW_MGroup);
         }
          }
         if(pC_Warehouse.PCW_MNum_IsChanged)
         {
         if (pC_Warehouse.PCW_MNum == 0)
         {
            idb.AddParameter("@PCW_MNum", 0);
         }
         else
         {
            idb.AddParameter("@PCW_MNum", pC_Warehouse.PCW_MNum);
         }
          }
         if(pC_Warehouse.PCW_MPrice_IsChanged)
         {
         if (pC_Warehouse.PCW_MPrice == 0)
         {
            idb.AddParameter("@PCW_MPrice", 0);
         }
         else
         {
            idb.AddParameter("@PCW_MPrice", pC_Warehouse.PCW_MPrice);
         }
          }
         if(pC_Warehouse.PCW_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_iType))
         {
            idb.AddParameter("@PCW_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_iType", pC_Warehouse.PCW_iType);
         }
          }
         if(pC_Warehouse.PCW_Station_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Station))
         {
            idb.AddParameter("@PCW_Station", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Station", pC_Warehouse.PCW_Station);
         }
          }
         if(pC_Warehouse.PCW_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Warehouse.PCW_Remark))
         {
            idb.AddParameter("@PCW_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCW_Remark", pC_Warehouse.PCW_Remark);
         }
          }
         if(pC_Warehouse.Stat_IsChanged)
         {
         if (pC_Warehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Warehouse.Stat);
         }
          }
         if(pC_Warehouse.CreateDate_IsChanged)
         {
         if (pC_Warehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Warehouse.CreateDate);
         }
          }
         if(pC_Warehouse.UpdateDate_IsChanged)
         {
         if (pC_Warehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Warehouse.UpdateDate);
         }
          }
         if(pC_Warehouse.DeleteDate_IsChanged)
         {
         if (pC_Warehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Warehouse.DeleteDate);
         }
          }

         idb.AddParameter("@PCW_ID", pC_Warehouse.PCW_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 删除原料仓库 PC_Warehouse对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCW_ID)
      {
         string sql = "DELETE PC_Warehouse WHERE 1=1  AND PCW_ID=@PCW_ID ";
         idb.AddParameter("@PCW_ID", pCW_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 获取指定的原料仓库 PC_Warehouse对象(即:一条记录
      /// </summary>
      public PC_Warehouse GetByKey(decimal pCW_ID)
      {
         PC_Warehouse pC_Warehouse = new PC_Warehouse();
         string sql = "SELECT  PCW_ID,PCW_Code,PCW_No,PCW_Name,PCW_Unit,PCW_MCode,PCW_MName,PCW_MGroup,PCW_MNum,PCW_MPrice,PCW_iType,PCW_Station,PCW_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_Warehouse WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCW_ID=@PCW_ID ";
         idb.AddParameter("@PCW_ID", pCW_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCW_ID"] != DBNull.Value) pC_Warehouse.PCW_ID = Convert.ToDecimal(dr["PCW_ID"]);
            if (dr["PCW_Code"] != DBNull.Value) pC_Warehouse.PCW_Code = Convert.ToString(dr["PCW_Code"]);
            if (dr["PCW_No"] != DBNull.Value) pC_Warehouse.PCW_No = Convert.ToString(dr["PCW_No"]);
            if (dr["PCW_Name"] != DBNull.Value) pC_Warehouse.PCW_Name = Convert.ToString(dr["PCW_Name"]);
            if (dr["PCW_Unit"] != DBNull.Value) pC_Warehouse.PCW_Unit = Convert.ToString(dr["PCW_Unit"]);
            if (dr["PCW_MCode"] != DBNull.Value) pC_Warehouse.PCW_MCode = Convert.ToString(dr["PCW_MCode"]);
            if (dr["PCW_MName"] != DBNull.Value) pC_Warehouse.PCW_MName = Convert.ToString(dr["PCW_MName"]);
            if (dr["PCW_MGroup"] != DBNull.Value) pC_Warehouse.PCW_MGroup = Convert.ToString(dr["PCW_MGroup"]);
            if (dr["PCW_MNum"] != DBNull.Value) pC_Warehouse.PCW_MNum = Convert.ToDecimal(dr["PCW_MNum"]);
            if (dr["PCW_MPrice"] != DBNull.Value) pC_Warehouse.PCW_MPrice = Convert.ToDecimal(dr["PCW_MPrice"]);
            if (dr["PCW_iType"] != DBNull.Value) pC_Warehouse.PCW_iType = Convert.ToString(dr["PCW_iType"]);
            if (dr["PCW_Station"] != DBNull.Value) pC_Warehouse.PCW_Station = Convert.ToString(dr["PCW_Station"]);
            if (dr["PCW_Remark"] != DBNull.Value) pC_Warehouse.PCW_Remark = Convert.ToString(dr["PCW_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_Warehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Warehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Warehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Warehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_Warehouse;
      }
      /// <summary>
      /// 获取指定的原料仓库 PC_Warehouse对象集合
      /// </summary>
      public List<PC_Warehouse> GetListByWhere(string strCondition)
      {
         List<PC_Warehouse> ret = new List<PC_Warehouse>();
         string sql = "SELECT  PCW_ID,PCW_Code,PCW_No,PCW_Name,PCW_Unit,PCW_MCode,PCW_MName,PCW_MGroup,PCW_MNum,PCW_MPrice,PCW_iType,PCW_Station,PCW_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_Warehouse WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_Warehouse pC_Warehouse = new PC_Warehouse();
            if (dr["PCW_ID"] != DBNull.Value) pC_Warehouse.PCW_ID = Convert.ToDecimal(dr["PCW_ID"]);
            if (dr["PCW_Code"] != DBNull.Value) pC_Warehouse.PCW_Code = Convert.ToString(dr["PCW_Code"]);
            if (dr["PCW_No"] != DBNull.Value) pC_Warehouse.PCW_No = Convert.ToString(dr["PCW_No"]);
            if (dr["PCW_Name"] != DBNull.Value) pC_Warehouse.PCW_Name = Convert.ToString(dr["PCW_Name"]);
            if (dr["PCW_Unit"] != DBNull.Value) pC_Warehouse.PCW_Unit = Convert.ToString(dr["PCW_Unit"]);
            if (dr["PCW_MCode"] != DBNull.Value) pC_Warehouse.PCW_MCode = Convert.ToString(dr["PCW_MCode"]);
            if (dr["PCW_MName"] != DBNull.Value) pC_Warehouse.PCW_MName = Convert.ToString(dr["PCW_MName"]);
            if (dr["PCW_MGroup"] != DBNull.Value) pC_Warehouse.PCW_MGroup = Convert.ToString(dr["PCW_MGroup"]);
            if (dr["PCW_MNum"] != DBNull.Value) pC_Warehouse.PCW_MNum = Convert.ToDecimal(dr["PCW_MNum"]);
            if (dr["PCW_MPrice"] != DBNull.Value) pC_Warehouse.PCW_MPrice = Convert.ToDecimal(dr["PCW_MPrice"]);
            if (dr["PCW_iType"] != DBNull.Value) pC_Warehouse.PCW_iType = Convert.ToString(dr["PCW_iType"]);
            if (dr["PCW_Station"] != DBNull.Value) pC_Warehouse.PCW_Station = Convert.ToString(dr["PCW_Station"]);
            if (dr["PCW_Remark"] != DBNull.Value) pC_Warehouse.PCW_Remark = Convert.ToString(dr["PCW_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_Warehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Warehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Warehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Warehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_Warehouse);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的原料仓库 PC_Warehouse对象(即:一条记录
      /// </summary>
      public List<PC_Warehouse> GetAll()
      {
         List<PC_Warehouse> ret = new List<PC_Warehouse>();
         string sql = "SELECT  PCW_ID,PCW_Code,PCW_No,PCW_Name,PCW_Unit,PCW_MCode,PCW_MName,PCW_MGroup,PCW_MNum,PCW_MPrice,PCW_iType,PCW_Station,PCW_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_Warehouse where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCW_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_Warehouse pC_Warehouse = new PC_Warehouse();
            if (dr["PCW_ID"] != DBNull.Value) pC_Warehouse.PCW_ID = Convert.ToDecimal(dr["PCW_ID"]);
            if (dr["PCW_Code"] != DBNull.Value) pC_Warehouse.PCW_Code = Convert.ToString(dr["PCW_Code"]);
            if (dr["PCW_No"] != DBNull.Value) pC_Warehouse.PCW_No = Convert.ToString(dr["PCW_No"]);
            if (dr["PCW_Name"] != DBNull.Value) pC_Warehouse.PCW_Name = Convert.ToString(dr["PCW_Name"]);
            if (dr["PCW_Unit"] != DBNull.Value) pC_Warehouse.PCW_Unit = Convert.ToString(dr["PCW_Unit"]);
            if (dr["PCW_MCode"] != DBNull.Value) pC_Warehouse.PCW_MCode = Convert.ToString(dr["PCW_MCode"]);
            if (dr["PCW_MName"] != DBNull.Value) pC_Warehouse.PCW_MName = Convert.ToString(dr["PCW_MName"]);
            if (dr["PCW_MGroup"] != DBNull.Value) pC_Warehouse.PCW_MGroup = Convert.ToString(dr["PCW_MGroup"]);
            if (dr["PCW_MNum"] != DBNull.Value) pC_Warehouse.PCW_MNum = Convert.ToDecimal(dr["PCW_MNum"]);
            if (dr["PCW_MPrice"] != DBNull.Value) pC_Warehouse.PCW_MPrice = Convert.ToDecimal(dr["PCW_MPrice"]);
            if (dr["PCW_iType"] != DBNull.Value) pC_Warehouse.PCW_iType = Convert.ToString(dr["PCW_iType"]);
            if (dr["PCW_Station"] != DBNull.Value) pC_Warehouse.PCW_Station = Convert.ToString(dr["PCW_Station"]);
            if (dr["PCW_Remark"] != DBNull.Value) pC_Warehouse.PCW_Remark = Convert.ToString(dr["PCW_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_Warehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Warehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Warehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Warehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_Warehouse);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
