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
   /// 植物摆放位置
   /// </summary>
   [Serializable]
   public partial class ADOPlant_Decorations
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加植物摆放位置 Plant_Decorations对象(即:一条记录)
      /// </summary>
      public int Add(Plant_Decorations plant_Decorations)
      {
         string sql = "INSERT INTO Plant_Decorations (PD_Code,PD_Company,PD_Dept,PD_Floor,PD_Position,PD_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PD_Code,@PD_Company,@PD_Dept,@PD_Floor,@PD_Position,@PD_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(plant_Decorations.PD_Code))
         {
            idb.AddParameter("@PD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Code", plant_Decorations.PD_Code);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Company))
         {
            idb.AddParameter("@PD_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Company", plant_Decorations.PD_Company);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Dept))
         {
            idb.AddParameter("@PD_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Dept", plant_Decorations.PD_Dept);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Floor))
         {
            idb.AddParameter("@PD_Floor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Floor", plant_Decorations.PD_Floor);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Position))
         {
            idb.AddParameter("@PD_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Position", plant_Decorations.PD_Position);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Remark))
         {
            idb.AddParameter("@PD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Remark", plant_Decorations.PD_Remark);
         }
         if (plant_Decorations.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plant_Decorations.Stat);
         }
         if (plant_Decorations.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plant_Decorations.CreateDate);
         }
         if (plant_Decorations.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plant_Decorations.UpdateDate);
         }
         if (plant_Decorations.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plant_Decorations.DeleteDate);
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
      /// 添加植物摆放位置 Plant_Decorations对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Plant_Decorations plant_Decorations)
      {
         string sql = "INSERT INTO Plant_Decorations (PD_Code,PD_Company,PD_Dept,PD_Floor,PD_Position,PD_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PD_Code,@PD_Company,@PD_Dept,@PD_Floor,@PD_Position,@PD_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(plant_Decorations.PD_Code))
         {
            idb.AddParameter("@PD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Code", plant_Decorations.PD_Code);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Company))
         {
            idb.AddParameter("@PD_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Company", plant_Decorations.PD_Company);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Dept))
         {
            idb.AddParameter("@PD_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Dept", plant_Decorations.PD_Dept);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Floor))
         {
            idb.AddParameter("@PD_Floor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Floor", plant_Decorations.PD_Floor);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Position))
         {
            idb.AddParameter("@PD_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Position", plant_Decorations.PD_Position);
         }
         if (string.IsNullOrEmpty(plant_Decorations.PD_Remark))
         {
            idb.AddParameter("@PD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Remark", plant_Decorations.PD_Remark);
         }
         if (plant_Decorations.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plant_Decorations.Stat);
         }
         if (plant_Decorations.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plant_Decorations.CreateDate);
         }
         if (plant_Decorations.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plant_Decorations.UpdateDate);
         }
         if (plant_Decorations.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plant_Decorations.DeleteDate);
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
      /// 更新植物摆放位置 Plant_Decorations对象(即:一条记录
      /// </summary>
      public int Update(Plant_Decorations plant_Decorations)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Plant_Decorations       SET ");
            if(plant_Decorations.PD_Code_IsChanged){sbParameter.Append("PD_Code=@PD_Code, ");}
      if(plant_Decorations.PD_Company_IsChanged){sbParameter.Append("PD_Company=@PD_Company, ");}
      if(plant_Decorations.PD_Dept_IsChanged){sbParameter.Append("PD_Dept=@PD_Dept, ");}
      if(plant_Decorations.PD_Floor_IsChanged){sbParameter.Append("PD_Floor=@PD_Floor, ");}
      if(plant_Decorations.PD_Position_IsChanged){sbParameter.Append("PD_Position=@PD_Position, ");}
      if(plant_Decorations.PD_Remark_IsChanged){sbParameter.Append("PD_Remark=@PD_Remark, ");}
      if(plant_Decorations.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(plant_Decorations.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(plant_Decorations.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(plant_Decorations.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PD_ID=@PD_ID; " );
      string sql=sb.ToString();
         if(plant_Decorations.PD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Decorations.PD_Code))
         {
            idb.AddParameter("@PD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Code", plant_Decorations.PD_Code);
         }
          }
         if(plant_Decorations.PD_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Decorations.PD_Company))
         {
            idb.AddParameter("@PD_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Company", plant_Decorations.PD_Company);
         }
          }
         if(plant_Decorations.PD_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Decorations.PD_Dept))
         {
            idb.AddParameter("@PD_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Dept", plant_Decorations.PD_Dept);
         }
          }
         if(plant_Decorations.PD_Floor_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Decorations.PD_Floor))
         {
            idb.AddParameter("@PD_Floor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Floor", plant_Decorations.PD_Floor);
         }
          }
         if(plant_Decorations.PD_Position_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Decorations.PD_Position))
         {
            idb.AddParameter("@PD_Position", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Position", plant_Decorations.PD_Position);
         }
          }
         if(plant_Decorations.PD_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(plant_Decorations.PD_Remark))
         {
            idb.AddParameter("@PD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PD_Remark", plant_Decorations.PD_Remark);
         }
          }
         if(plant_Decorations.Stat_IsChanged)
         {
         if (plant_Decorations.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", plant_Decorations.Stat);
         }
          }
         if(plant_Decorations.CreateDate_IsChanged)
         {
         if (plant_Decorations.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", plant_Decorations.CreateDate);
         }
          }
         if(plant_Decorations.UpdateDate_IsChanged)
         {
         if (plant_Decorations.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", plant_Decorations.UpdateDate);
         }
          }
         if(plant_Decorations.DeleteDate_IsChanged)
         {
         if (plant_Decorations.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", plant_Decorations.DeleteDate);
         }
          }

         idb.AddParameter("@PD_ID", plant_Decorations.PD_ID);

           
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
      /// 删除植物摆放位置 Plant_Decorations对象(即:一条记录
      /// </summary>
      public int Delete(decimal pD_ID)
      {
         string sql = "DELETE Plant_Decorations WHERE 1=1  AND PD_ID=@PD_ID ";
         idb.AddParameter("@PD_ID", pD_ID);

           
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
      /// 获取指定的植物摆放位置 Plant_Decorations对象(即:一条记录
      /// </summary>
      public Plant_Decorations GetByKey(decimal pD_ID)
      {
         Plant_Decorations plant_Decorations = new Plant_Decorations();
         string sql = "SELECT  PD_ID,PD_Code,PD_Company,PD_Dept,PD_Floor,PD_Position,PD_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Plant_Decorations WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PD_ID=@PD_ID ";
         idb.AddParameter("@PD_ID", pD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PD_ID"] != DBNull.Value) plant_Decorations.PD_ID = Convert.ToDecimal(dr["PD_ID"]);
            if (dr["PD_Code"] != DBNull.Value) plant_Decorations.PD_Code = Convert.ToString(dr["PD_Code"]);
            if (dr["PD_Company"] != DBNull.Value) plant_Decorations.PD_Company = Convert.ToString(dr["PD_Company"]);
            if (dr["PD_Dept"] != DBNull.Value) plant_Decorations.PD_Dept = Convert.ToString(dr["PD_Dept"]);
            if (dr["PD_Floor"] != DBNull.Value) plant_Decorations.PD_Floor = Convert.ToString(dr["PD_Floor"]);
            if (dr["PD_Position"] != DBNull.Value) plant_Decorations.PD_Position = Convert.ToString(dr["PD_Position"]);
            if (dr["PD_Remark"] != DBNull.Value) plant_Decorations.PD_Remark = Convert.ToString(dr["PD_Remark"]);
            if (dr["Stat"] != DBNull.Value) plant_Decorations.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plant_Decorations.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plant_Decorations.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plant_Decorations.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return plant_Decorations;
      }
      /// <summary>
      /// 获取指定的植物摆放位置 Plant_Decorations对象集合
      /// </summary>
      public List<Plant_Decorations> GetListByWhere(string strCondition)
      {
         List<Plant_Decorations> ret = new List<Plant_Decorations>();
         string sql = "SELECT  PD_ID,PD_Code,PD_Company,PD_Dept,PD_Floor,PD_Position,PD_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Plant_Decorations WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Plant_Decorations plant_Decorations = new Plant_Decorations();
            if (dr["PD_ID"] != DBNull.Value) plant_Decorations.PD_ID = Convert.ToDecimal(dr["PD_ID"]);
            if (dr["PD_Code"] != DBNull.Value) plant_Decorations.PD_Code = Convert.ToString(dr["PD_Code"]);
            if (dr["PD_Company"] != DBNull.Value) plant_Decorations.PD_Company = Convert.ToString(dr["PD_Company"]);
            if (dr["PD_Dept"] != DBNull.Value) plant_Decorations.PD_Dept = Convert.ToString(dr["PD_Dept"]);
            if (dr["PD_Floor"] != DBNull.Value) plant_Decorations.PD_Floor = Convert.ToString(dr["PD_Floor"]);
            if (dr["PD_Position"] != DBNull.Value) plant_Decorations.PD_Position = Convert.ToString(dr["PD_Position"]);
            if (dr["PD_Remark"] != DBNull.Value) plant_Decorations.PD_Remark = Convert.ToString(dr["PD_Remark"]);
            if (dr["Stat"] != DBNull.Value) plant_Decorations.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plant_Decorations.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plant_Decorations.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plant_Decorations.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(plant_Decorations);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的植物摆放位置 Plant_Decorations对象(即:一条记录
      /// </summary>
      public List<Plant_Decorations> GetAll()
      {
         List<Plant_Decorations> ret = new List<Plant_Decorations>();
         string sql = "SELECT  PD_ID,PD_Code,PD_Company,PD_Dept,PD_Floor,PD_Position,PD_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Plant_Decorations where 1=1 AND ((Stat is null) or (Stat=0) ) order by PD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Plant_Decorations plant_Decorations = new Plant_Decorations();
            if (dr["PD_ID"] != DBNull.Value) plant_Decorations.PD_ID = Convert.ToDecimal(dr["PD_ID"]);
            if (dr["PD_Code"] != DBNull.Value) plant_Decorations.PD_Code = Convert.ToString(dr["PD_Code"]);
            if (dr["PD_Company"] != DBNull.Value) plant_Decorations.PD_Company = Convert.ToString(dr["PD_Company"]);
            if (dr["PD_Dept"] != DBNull.Value) plant_Decorations.PD_Dept = Convert.ToString(dr["PD_Dept"]);
            if (dr["PD_Floor"] != DBNull.Value) plant_Decorations.PD_Floor = Convert.ToString(dr["PD_Floor"]);
            if (dr["PD_Position"] != DBNull.Value) plant_Decorations.PD_Position = Convert.ToString(dr["PD_Position"]);
            if (dr["PD_Remark"] != DBNull.Value) plant_Decorations.PD_Remark = Convert.ToString(dr["PD_Remark"]);
            if (dr["Stat"] != DBNull.Value) plant_Decorations.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) plant_Decorations.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) plant_Decorations.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) plant_Decorations.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(plant_Decorations);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
