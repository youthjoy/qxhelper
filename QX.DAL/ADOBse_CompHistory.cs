using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOBse_CompHistory
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_CompHistory对象(即:一条记录)
      /// </summary>
      public int Add(Bse_CompHistory bse_CompHistory)
      {
         string sql = "INSERT INTO Bse_CompHistory (CH_Code,CH_CompCode,CH_Auditor,CH_AuditorName,CH_Date,CH_FilePath,CH_Type,CH_iType,CH_Stat,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@CH_Code,@CH_CompCode,@CH_Auditor,@CH_AuditorName,@CH_Date,@CH_FilePath,@CH_Type,@CH_iType,@CH_Stat,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Code))
         {
            idb.AddParameter("@CH_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Code", bse_CompHistory.CH_Code);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_CompCode))
         {
            idb.AddParameter("@CH_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_CompCode", bse_CompHistory.CH_CompCode);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Auditor))
         {
            idb.AddParameter("@CH_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Auditor", bse_CompHistory.CH_Auditor);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_AuditorName))
         {
            idb.AddParameter("@CH_AuditorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_AuditorName", bse_CompHistory.CH_AuditorName);
         }
         if (bse_CompHistory.CH_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CH_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Date", bse_CompHistory.CH_Date);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_FilePath))
         {
            idb.AddParameter("@CH_FilePath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_FilePath", bse_CompHistory.CH_FilePath);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Type))
         {
            idb.AddParameter("@CH_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Type", bse_CompHistory.CH_Type);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_iType))
         {
            idb.AddParameter("@CH_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_iType", bse_CompHistory.CH_iType);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Stat))
         {
            idb.AddParameter("@CH_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Stat", bse_CompHistory.CH_Stat);
         }
         if (bse_CompHistory.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CompHistory.Stat);
         }
         if (bse_CompHistory.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_CompHistory.CreateTime);
         }
         if (bse_CompHistory.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_CompHistory.UpdateTime);
         }
         if (bse_CompHistory.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_CompHistory.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_CompHistory对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_CompHistory bse_CompHistory)
      {
         string sql = "INSERT INTO Bse_CompHistory (CH_Code,CH_CompCode,CH_Auditor,CH_AuditorName,CH_Date,CH_FilePath,CH_Type,CH_iType,CH_Stat,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@CH_Code,@CH_CompCode,@CH_Auditor,@CH_AuditorName,@CH_Date,@CH_FilePath,@CH_Type,@CH_iType,@CH_Stat,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Code))
         {
            idb.AddParameter("@CH_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Code", bse_CompHistory.CH_Code);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_CompCode))
         {
            idb.AddParameter("@CH_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_CompCode", bse_CompHistory.CH_CompCode);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Auditor))
         {
            idb.AddParameter("@CH_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Auditor", bse_CompHistory.CH_Auditor);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_AuditorName))
         {
            idb.AddParameter("@CH_AuditorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_AuditorName", bse_CompHistory.CH_AuditorName);
         }
         if (bse_CompHistory.CH_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CH_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Date", bse_CompHistory.CH_Date);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_FilePath))
         {
            idb.AddParameter("@CH_FilePath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_FilePath", bse_CompHistory.CH_FilePath);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Type))
         {
            idb.AddParameter("@CH_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Type", bse_CompHistory.CH_Type);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_iType))
         {
            idb.AddParameter("@CH_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_iType", bse_CompHistory.CH_iType);
         }
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Stat))
         {
            idb.AddParameter("@CH_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Stat", bse_CompHistory.CH_Stat);
         }
         if (bse_CompHistory.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CompHistory.Stat);
         }
         if (bse_CompHistory.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_CompHistory.CreateTime);
         }
         if (bse_CompHistory.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_CompHistory.UpdateTime);
         }
         if (bse_CompHistory.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_CompHistory.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_CompHistory对象(即:一条记录
      /// </summary>
      public int Update(Bse_CompHistory bse_CompHistory)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_CompHistory       SET ");
            if(bse_CompHistory.CH_Code_IsChanged){sbParameter.Append("CH_Code=@CH_Code, ");}
      if(bse_CompHistory.CH_CompCode_IsChanged){sbParameter.Append("CH_CompCode=@CH_CompCode, ");}
      if(bse_CompHistory.CH_Auditor_IsChanged){sbParameter.Append("CH_Auditor=@CH_Auditor, ");}
      if(bse_CompHistory.CH_AuditorName_IsChanged){sbParameter.Append("CH_AuditorName=@CH_AuditorName, ");}
      if(bse_CompHistory.CH_Date_IsChanged){sbParameter.Append("CH_Date=@CH_Date, ");}
      if(bse_CompHistory.CH_FilePath_IsChanged){sbParameter.Append("CH_FilePath=@CH_FilePath, ");}
      if(bse_CompHistory.CH_Type_IsChanged){sbParameter.Append("CH_Type=@CH_Type, ");}
      if(bse_CompHistory.CH_iType_IsChanged){sbParameter.Append("CH_iType=@CH_iType, ");}
      if(bse_CompHistory.CH_Stat_IsChanged){sbParameter.Append("CH_Stat=@CH_Stat, ");}
      if(bse_CompHistory.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_CompHistory.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_CompHistory.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_CompHistory.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CH_ID=@CH_ID; " );
      string sql=sb.ToString();
         if(bse_CompHistory.CH_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Code))
         {
            idb.AddParameter("@CH_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Code", bse_CompHistory.CH_Code);
         }
          }
         if(bse_CompHistory.CH_CompCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_CompCode))
         {
            idb.AddParameter("@CH_CompCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_CompCode", bse_CompHistory.CH_CompCode);
         }
          }
         if(bse_CompHistory.CH_Auditor_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Auditor))
         {
            idb.AddParameter("@CH_Auditor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Auditor", bse_CompHistory.CH_Auditor);
         }
          }
         if(bse_CompHistory.CH_AuditorName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_AuditorName))
         {
            idb.AddParameter("@CH_AuditorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_AuditorName", bse_CompHistory.CH_AuditorName);
         }
          }
         if(bse_CompHistory.CH_Date_IsChanged)
         {
         if (bse_CompHistory.CH_Date == DateTime.MinValue)
         {
            idb.AddParameter("@CH_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Date", bse_CompHistory.CH_Date);
         }
          }
         if(bse_CompHistory.CH_FilePath_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_FilePath))
         {
            idb.AddParameter("@CH_FilePath", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_FilePath", bse_CompHistory.CH_FilePath);
         }
          }
         if(bse_CompHistory.CH_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Type))
         {
            idb.AddParameter("@CH_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Type", bse_CompHistory.CH_Type);
         }
          }
         if(bse_CompHistory.CH_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_iType))
         {
            idb.AddParameter("@CH_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_iType", bse_CompHistory.CH_iType);
         }
          }
         if(bse_CompHistory.CH_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_CompHistory.CH_Stat))
         {
            idb.AddParameter("@CH_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CH_Stat", bse_CompHistory.CH_Stat);
         }
          }
         if(bse_CompHistory.Stat_IsChanged)
         {
         if (bse_CompHistory.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_CompHistory.Stat);
         }
          }
         if(bse_CompHistory.CreateTime_IsChanged)
         {
         if (bse_CompHistory.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_CompHistory.CreateTime);
         }
          }
         if(bse_CompHistory.UpdateTime_IsChanged)
         {
         if (bse_CompHistory.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_CompHistory.UpdateTime);
         }
          }
         if(bse_CompHistory.DeleteTime_IsChanged)
         {
         if (bse_CompHistory.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_CompHistory.DeleteTime);
         }
          }

         idb.AddParameter("@CH_ID", bse_CompHistory.CH_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_CompHistory对象(即:一条记录
      /// </summary>
      public int Delete(decimal cH_ID)
      {
         string sql = "DELETE Bse_CompHistory WHERE 1=1  AND CH_ID=@CH_ID ";
         idb.AddParameter("@CH_ID", cH_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_CompHistory对象(即:一条记录
      /// </summary>
      public Bse_CompHistory GetByKey(decimal cH_ID)
      {
         Bse_CompHistory bse_CompHistory = new Bse_CompHistory();
         string sql = "SELECT  CH_ID,CH_Code,CH_CompCode,CH_Auditor,CH_AuditorName,CH_Date,CH_FilePath,CH_Type,CH_iType,CH_Stat,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_CompHistory WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CH_ID=@CH_ID ";
         idb.AddParameter("@CH_ID", cH_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CH_ID"] != DBNull.Value) bse_CompHistory.CH_ID = Convert.ToDecimal(dr["CH_ID"]);
            if (dr["CH_Code"] != DBNull.Value) bse_CompHistory.CH_Code = Convert.ToString(dr["CH_Code"]);
            if (dr["CH_CompCode"] != DBNull.Value) bse_CompHistory.CH_CompCode = Convert.ToString(dr["CH_CompCode"]);
            if (dr["CH_Auditor"] != DBNull.Value) bse_CompHistory.CH_Auditor = Convert.ToString(dr["CH_Auditor"]);
            if (dr["CH_AuditorName"] != DBNull.Value) bse_CompHistory.CH_AuditorName = Convert.ToString(dr["CH_AuditorName"]);
            if (dr["CH_Date"] != DBNull.Value) bse_CompHistory.CH_Date = Convert.ToDateTime(dr["CH_Date"]);
            if (dr["CH_FilePath"] != DBNull.Value) bse_CompHistory.CH_FilePath = Convert.ToString(dr["CH_FilePath"]);
            if (dr["CH_Type"] != DBNull.Value) bse_CompHistory.CH_Type = Convert.ToString(dr["CH_Type"]);
            if (dr["CH_iType"] != DBNull.Value) bse_CompHistory.CH_iType = Convert.ToString(dr["CH_iType"]);
            if (dr["CH_Stat"] != DBNull.Value) bse_CompHistory.CH_Stat = Convert.ToString(dr["CH_Stat"]);
            if (dr["Stat"] != DBNull.Value) bse_CompHistory.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_CompHistory.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_CompHistory.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_CompHistory.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_CompHistory;
      }
      /// <summary>
      /// 获取指定的Bse_CompHistory对象集合
      /// </summary>
      public List<Bse_CompHistory> GetListByWhere(string strCondition)
      {
         List<Bse_CompHistory> ret = new List<Bse_CompHistory>();
         string sql = "SELECT  CH_ID,CH_Code,CH_CompCode,CH_Auditor,CH_AuditorName,CH_Date,CH_FilePath,CH_Type,CH_iType,CH_Stat,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_CompHistory WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY CH_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_CompHistory bse_CompHistory = new Bse_CompHistory();
            if (dr["CH_ID"] != DBNull.Value) bse_CompHistory.CH_ID = Convert.ToDecimal(dr["CH_ID"]);
            if (dr["CH_Code"] != DBNull.Value) bse_CompHistory.CH_Code = Convert.ToString(dr["CH_Code"]);
            if (dr["CH_CompCode"] != DBNull.Value) bse_CompHistory.CH_CompCode = Convert.ToString(dr["CH_CompCode"]);
            if (dr["CH_Auditor"] != DBNull.Value) bse_CompHistory.CH_Auditor = Convert.ToString(dr["CH_Auditor"]);
            if (dr["CH_AuditorName"] != DBNull.Value) bse_CompHistory.CH_AuditorName = Convert.ToString(dr["CH_AuditorName"]);
            if (dr["CH_Date"] != DBNull.Value) bse_CompHistory.CH_Date = Convert.ToDateTime(dr["CH_Date"]);
            if (dr["CH_FilePath"] != DBNull.Value) bse_CompHistory.CH_FilePath = Convert.ToString(dr["CH_FilePath"]);
            if (dr["CH_Type"] != DBNull.Value) bse_CompHistory.CH_Type = Convert.ToString(dr["CH_Type"]);
            if (dr["CH_iType"] != DBNull.Value) bse_CompHistory.CH_iType = Convert.ToString(dr["CH_iType"]);
            if (dr["CH_Stat"] != DBNull.Value) bse_CompHistory.CH_Stat = Convert.ToString(dr["CH_Stat"]);
            if (dr["Stat"] != DBNull.Value) bse_CompHistory.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_CompHistory.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_CompHistory.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_CompHistory.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_CompHistory);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_CompHistory对象(即:一条记录
      /// </summary>
      public List<Bse_CompHistory> GetAll()
      {
         List<Bse_CompHistory> ret = new List<Bse_CompHistory>();
         string sql = "SELECT  CH_ID,CH_Code,CH_CompCode,CH_Auditor,CH_AuditorName,CH_Date,CH_FilePath,CH_Type,CH_iType,CH_Stat,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_CompHistory where 1=1 AND ((Stat is null) or (Stat=0) ) order by CH_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_CompHistory bse_CompHistory = new Bse_CompHistory();
            if (dr["CH_ID"] != DBNull.Value) bse_CompHistory.CH_ID = Convert.ToDecimal(dr["CH_ID"]);
            if (dr["CH_Code"] != DBNull.Value) bse_CompHistory.CH_Code = Convert.ToString(dr["CH_Code"]);
            if (dr["CH_CompCode"] != DBNull.Value) bse_CompHistory.CH_CompCode = Convert.ToString(dr["CH_CompCode"]);
            if (dr["CH_Auditor"] != DBNull.Value) bse_CompHistory.CH_Auditor = Convert.ToString(dr["CH_Auditor"]);
            if (dr["CH_AuditorName"] != DBNull.Value) bse_CompHistory.CH_AuditorName = Convert.ToString(dr["CH_AuditorName"]);
            if (dr["CH_Date"] != DBNull.Value) bse_CompHistory.CH_Date = Convert.ToDateTime(dr["CH_Date"]);
            if (dr["CH_FilePath"] != DBNull.Value) bse_CompHistory.CH_FilePath = Convert.ToString(dr["CH_FilePath"]);
            if (dr["CH_Type"] != DBNull.Value) bse_CompHistory.CH_Type = Convert.ToString(dr["CH_Type"]);
            if (dr["CH_iType"] != DBNull.Value) bse_CompHistory.CH_iType = Convert.ToString(dr["CH_iType"]);
            if (dr["CH_Stat"] != DBNull.Value) bse_CompHistory.CH_Stat = Convert.ToString(dr["CH_Stat"]);
            if (dr["Stat"] != DBNull.Value) bse_CompHistory.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_CompHistory.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_CompHistory.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_CompHistory.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_CompHistory);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
