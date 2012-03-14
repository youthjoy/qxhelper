using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;

namespace QX.ERP.DAL
{
   /// <summary>
   /// 零件图号信息
   /// </summary>
   [Serializable]
   public partial class ADORoad_Components
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加零件图号信息 Road_Components对象(即:一条记录)
      /// </summary>
      public int Add(Road_Components road_Components)
      {
         string sql = "INSERT INTO Road_Components (Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime,Comp_IsBusy,Comp_Udef1,Comp_Udef2) VALUES (@Comp_Code,@Comp_Name,@Comp_Design,@Comp_Bak,@Comp_Stat,@Comp_CatCode,@Comp_CatName,@Stat,@Comp_Order,@AuditStat,@AuditCurAudit,@Comp_CurNode,@Comp_Creator,@Comp_CreatTime,@Comp_IsBusy,@Comp_Udef1,@Comp_Udef2)";
         if (string.IsNullOrEmpty(road_Components.Comp_Code))
         {
            idb.AddParameter("@Comp_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Code", road_Components.Comp_Code);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Name))
         {
            idb.AddParameter("@Comp_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Name", road_Components.Comp_Name);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Design))
         {
            idb.AddParameter("@Comp_Design", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Design", road_Components.Comp_Design);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Bak))
         {
            idb.AddParameter("@Comp_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Bak", road_Components.Comp_Bak);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Stat))
         {
            idb.AddParameter("@Comp_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Stat", road_Components.Comp_Stat);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_CatCode))
         {
            idb.AddParameter("@Comp_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CatCode", road_Components.Comp_CatCode);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_CatName))
         {
            idb.AddParameter("@Comp_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CatName", road_Components.Comp_CatName);
         }
         if (road_Components.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_Components.Stat);
         }
         if (road_Components.Comp_Order == 0)
         {
            idb.AddParameter("@Comp_Order", 0);
         }
         else
         {
            idb.AddParameter("@Comp_Order", road_Components.Comp_Order);
         }
         if (string.IsNullOrEmpty(road_Components.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", road_Components.AuditStat);
         }
         if (string.IsNullOrEmpty(road_Components.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", road_Components.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_CurNode))
         {
            idb.AddParameter("@Comp_CurNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CurNode", road_Components.Comp_CurNode);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Creator))
         {
            idb.AddParameter("@Comp_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Creator", road_Components.Comp_Creator);
         }
         if (road_Components.Comp_CreatTime == DateTime.MinValue)
         {
            idb.AddParameter("@Comp_CreatTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CreatTime", road_Components.Comp_CreatTime);
         }
         if (road_Components.Comp_IsBusy == 0)
         {
            idb.AddParameter("@Comp_IsBusy", 0);
         }
         else
         {
            idb.AddParameter("@Comp_IsBusy", road_Components.Comp_IsBusy);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Udef1))
         {
            idb.AddParameter("@Comp_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Udef1", road_Components.Comp_Udef1);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Udef2))
         {
            idb.AddParameter("@Comp_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Udef2", road_Components.Comp_Udef2);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加零件图号信息 Road_Components对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Road_Components road_Components)
      {
         string sql = "INSERT INTO Road_Components (Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime,Comp_IsBusy,Comp_Udef1,Comp_Udef2) VALUES (@Comp_Code,@Comp_Name,@Comp_Design,@Comp_Bak,@Comp_Stat,@Comp_CatCode,@Comp_CatName,@Stat,@Comp_Order,@AuditStat,@AuditCurAudit,@Comp_CurNode,@Comp_Creator,@Comp_CreatTime,@Comp_IsBusy,@Comp_Udef1,@Comp_Udef2);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(road_Components.Comp_Code))
         {
            idb.AddParameter("@Comp_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Code", road_Components.Comp_Code);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Name))
         {
            idb.AddParameter("@Comp_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Name", road_Components.Comp_Name);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Design))
         {
            idb.AddParameter("@Comp_Design", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Design", road_Components.Comp_Design);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Bak))
         {
            idb.AddParameter("@Comp_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Bak", road_Components.Comp_Bak);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Stat))
         {
            idb.AddParameter("@Comp_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Stat", road_Components.Comp_Stat);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_CatCode))
         {
            idb.AddParameter("@Comp_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CatCode", road_Components.Comp_CatCode);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_CatName))
         {
            idb.AddParameter("@Comp_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CatName", road_Components.Comp_CatName);
         }
         if (road_Components.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_Components.Stat);
         }
         if (road_Components.Comp_Order == 0)
         {
            idb.AddParameter("@Comp_Order", 0);
         }
         else
         {
            idb.AddParameter("@Comp_Order", road_Components.Comp_Order);
         }
         if (string.IsNullOrEmpty(road_Components.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", road_Components.AuditStat);
         }
         if (string.IsNullOrEmpty(road_Components.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", road_Components.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_CurNode))
         {
            idb.AddParameter("@Comp_CurNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CurNode", road_Components.Comp_CurNode);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Creator))
         {
            idb.AddParameter("@Comp_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Creator", road_Components.Comp_Creator);
         }
         if (road_Components.Comp_CreatTime == DateTime.MinValue)
         {
            idb.AddParameter("@Comp_CreatTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CreatTime", road_Components.Comp_CreatTime);
         }
         if (road_Components.Comp_IsBusy == 0)
         {
            idb.AddParameter("@Comp_IsBusy", 0);
         }
         else
         {
            idb.AddParameter("@Comp_IsBusy", road_Components.Comp_IsBusy);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Udef1))
         {
            idb.AddParameter("@Comp_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Udef1", road_Components.Comp_Udef1);
         }
         if (string.IsNullOrEmpty(road_Components.Comp_Udef2))
         {
            idb.AddParameter("@Comp_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Udef2", road_Components.Comp_Udef2);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新零件图号信息 Road_Components对象(即:一条记录
      /// </summary>
      public int Update(Road_Components road_Components)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Road_Components       SET ");
            if(road_Components.Comp_Code_IsChanged){sbParameter.Append("Comp_Code=@Comp_Code, ");}
      if(road_Components.Comp_Name_IsChanged){sbParameter.Append("Comp_Name=@Comp_Name, ");}
      if(road_Components.Comp_Design_IsChanged){sbParameter.Append("Comp_Design=@Comp_Design, ");}
      if(road_Components.Comp_Bak_IsChanged){sbParameter.Append("Comp_Bak=@Comp_Bak, ");}
      if(road_Components.Comp_Stat_IsChanged){sbParameter.Append("Comp_Stat=@Comp_Stat, ");}
      if(road_Components.Comp_CatCode_IsChanged){sbParameter.Append("Comp_CatCode=@Comp_CatCode, ");}
      if(road_Components.Comp_CatName_IsChanged){sbParameter.Append("Comp_CatName=@Comp_CatName, ");}
      if(road_Components.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(road_Components.Comp_Order_IsChanged){sbParameter.Append("Comp_Order=@Comp_Order, ");}
      if(road_Components.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(road_Components.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(road_Components.Comp_CurNode_IsChanged){sbParameter.Append("Comp_CurNode=@Comp_CurNode, ");}
      if(road_Components.Comp_Creator_IsChanged){sbParameter.Append("Comp_Creator=@Comp_Creator, ");}
      if(road_Components.Comp_CreatTime_IsChanged){sbParameter.Append("Comp_CreatTime=@Comp_CreatTime, ");}
      if(road_Components.Comp_IsBusy_IsChanged){sbParameter.Append("Comp_IsBusy=@Comp_IsBusy, ");}
      if(road_Components.Comp_Udef1_IsChanged){sbParameter.Append("Comp_Udef1=@Comp_Udef1, ");}
      if(road_Components.Comp_Udef2_IsChanged){sbParameter.Append("Comp_Udef2=@Comp_Udef2 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Comp_ID=@Comp_ID; " );
      string sql=sb.ToString();
         if(road_Components.Comp_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Code))
         {
            idb.AddParameter("@Comp_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Code", road_Components.Comp_Code);
         }
          }
         if(road_Components.Comp_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Name))
         {
            idb.AddParameter("@Comp_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Name", road_Components.Comp_Name);
         }
          }
         if(road_Components.Comp_Design_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Design))
         {
            idb.AddParameter("@Comp_Design", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Design", road_Components.Comp_Design);
         }
          }
         if(road_Components.Comp_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Bak))
         {
            idb.AddParameter("@Comp_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Bak", road_Components.Comp_Bak);
         }
          }
         if(road_Components.Comp_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Stat))
         {
            idb.AddParameter("@Comp_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Stat", road_Components.Comp_Stat);
         }
          }
         if(road_Components.Comp_CatCode_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_CatCode))
         {
            idb.AddParameter("@Comp_CatCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CatCode", road_Components.Comp_CatCode);
         }
          }
         if(road_Components.Comp_CatName_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_CatName))
         {
            idb.AddParameter("@Comp_CatName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CatName", road_Components.Comp_CatName);
         }
          }
         if(road_Components.Stat_IsChanged)
         {
         if (road_Components.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", road_Components.Stat);
         }
          }
         if(road_Components.Comp_Order_IsChanged)
         {
         if (road_Components.Comp_Order == 0)
         {
            idb.AddParameter("@Comp_Order", 0);
         }
         else
         {
            idb.AddParameter("@Comp_Order", road_Components.Comp_Order);
         }
          }
         if(road_Components.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", road_Components.AuditStat);
         }
          }
         if(road_Components.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", road_Components.AuditCurAudit);
         }
          }
         if(road_Components.Comp_CurNode_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_CurNode))
         {
            idb.AddParameter("@Comp_CurNode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CurNode", road_Components.Comp_CurNode);
         }
          }
         if(road_Components.Comp_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Creator))
         {
            idb.AddParameter("@Comp_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Creator", road_Components.Comp_Creator);
         }
          }
         if(road_Components.Comp_CreatTime_IsChanged)
         {
         if (road_Components.Comp_CreatTime == DateTime.MinValue)
         {
            idb.AddParameter("@Comp_CreatTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CreatTime", road_Components.Comp_CreatTime);
         }
          }
         if(road_Components.Comp_IsBusy_IsChanged)
         {
         if (road_Components.Comp_IsBusy == 0)
         {
            idb.AddParameter("@Comp_IsBusy", 0);
         }
         else
         {
            idb.AddParameter("@Comp_IsBusy", road_Components.Comp_IsBusy);
         }
          }
         if(road_Components.Comp_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Udef1))
         {
            idb.AddParameter("@Comp_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Udef1", road_Components.Comp_Udef1);
         }
          }
         if(road_Components.Comp_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(road_Components.Comp_Udef2))
         {
            idb.AddParameter("@Comp_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Udef2", road_Components.Comp_Udef2);
         }
          }

         idb.AddParameter("@Comp_ID", road_Components.Comp_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除零件图号信息 Road_Components对象(即:一条记录
      /// </summary>
      public int Delete(Int64 comp_ID)
      {
         string sql = "DELETE Road_Components WHERE 1=1  AND Comp_ID=@Comp_ID ";
         idb.AddParameter("@Comp_ID", comp_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的零件图号信息 Road_Components对象(即:一条记录
      /// </summary>
      public Road_Components GetByKey(Int64 comp_ID)
      {
         Road_Components road_Components = new Road_Components();
         string sql = "SELECT  Comp_ID,Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime,Comp_IsBusy,Comp_Udef1,Comp_Udef2 FROM Road_Components WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Comp_ID=@Comp_ID ";
         idb.AddParameter("@Comp_ID", comp_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Comp_ID"] != DBNull.Value) road_Components.Comp_ID = Convert.ToInt64(dr["Comp_ID"]);
            if (dr["Comp_Code"] != DBNull.Value) road_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
            if (dr["Comp_Name"] != DBNull.Value) road_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
            if (dr["Comp_Design"] != DBNull.Value) road_Components.Comp_Design = Convert.ToString(dr["Comp_Design"]);
            if (dr["Comp_Bak"] != DBNull.Value) road_Components.Comp_Bak = Convert.ToString(dr["Comp_Bak"]);
            if (dr["Comp_Stat"] != DBNull.Value) road_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
            if (dr["Comp_CatCode"] != DBNull.Value) road_Components.Comp_CatCode = Convert.ToString(dr["Comp_CatCode"]);
            if (dr["Comp_CatName"] != DBNull.Value) road_Components.Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
            if (dr["Stat"] != DBNull.Value) road_Components.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Comp_Order"] != DBNull.Value) road_Components.Comp_Order = Convert.ToInt32(dr["Comp_Order"]);
            if (dr["AuditStat"] != DBNull.Value) road_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) road_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Comp_CurNode"] != DBNull.Value) road_Components.Comp_CurNode = Convert.ToString(dr["Comp_CurNode"]);
            if (dr["Comp_Creator"] != DBNull.Value) road_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
            if (dr["Comp_CreatTime"] != DBNull.Value) road_Components.Comp_CreatTime = Convert.ToDateTime(dr["Comp_CreatTime"]);
            if (dr["Comp_IsBusy"] != DBNull.Value) road_Components.Comp_IsBusy = Convert.ToInt32(dr["Comp_IsBusy"]);
            if (dr["Comp_Udef1"] != DBNull.Value) road_Components.Comp_Udef1 = Convert.ToString(dr["Comp_Udef1"]);
            if (dr["Comp_Udef2"] != DBNull.Value) road_Components.Comp_Udef2 = Convert.ToString(dr["Comp_Udef2"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return road_Components;
      }
      /// <summary>
      /// 获取指定的零件图号信息 Road_Components对象集合
      /// </summary>
      public List<Road_Components> GetListByWhere(string strCondition)
      {
         List<Road_Components> ret = new List<Road_Components>();
         string sql = "SELECT  Comp_ID,Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime,Comp_IsBusy,Comp_Udef1,Comp_Udef2 FROM Road_Components WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Comp_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Road_Components road_Components = new Road_Components();
            if (dr["Comp_ID"] != DBNull.Value) road_Components.Comp_ID = Convert.ToInt64(dr["Comp_ID"]);
            if (dr["Comp_Code"] != DBNull.Value) road_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
            if (dr["Comp_Name"] != DBNull.Value) road_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
            if (dr["Comp_Design"] != DBNull.Value) road_Components.Comp_Design = Convert.ToString(dr["Comp_Design"]);
            if (dr["Comp_Bak"] != DBNull.Value) road_Components.Comp_Bak = Convert.ToString(dr["Comp_Bak"]);
            if (dr["Comp_Stat"] != DBNull.Value) road_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
            if (dr["Comp_CatCode"] != DBNull.Value) road_Components.Comp_CatCode = Convert.ToString(dr["Comp_CatCode"]);
            if (dr["Comp_CatName"] != DBNull.Value) road_Components.Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
            if (dr["Stat"] != DBNull.Value) road_Components.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Comp_Order"] != DBNull.Value) road_Components.Comp_Order = Convert.ToInt32(dr["Comp_Order"]);
            if (dr["AuditStat"] != DBNull.Value) road_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) road_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Comp_CurNode"] != DBNull.Value) road_Components.Comp_CurNode = Convert.ToString(dr["Comp_CurNode"]);
            if (dr["Comp_Creator"] != DBNull.Value) road_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
            if (dr["Comp_CreatTime"] != DBNull.Value) road_Components.Comp_CreatTime = Convert.ToDateTime(dr["Comp_CreatTime"]);
            if (dr["Comp_IsBusy"] != DBNull.Value) road_Components.Comp_IsBusy = Convert.ToInt32(dr["Comp_IsBusy"]);
            if (dr["Comp_Udef1"] != DBNull.Value) road_Components.Comp_Udef1 = Convert.ToString(dr["Comp_Udef1"]);
            if (dr["Comp_Udef2"] != DBNull.Value) road_Components.Comp_Udef2 = Convert.ToString(dr["Comp_Udef2"]);
            ret.Add(road_Components);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的零件图号信息 Road_Components对象(即:一条记录
      /// </summary>
      public List<Road_Components> GetAll()
      {
         List<Road_Components> ret = new List<Road_Components>();
         string sql = "SELECT  Comp_ID,Comp_Code,Comp_Name,Comp_Design,Comp_Bak,Comp_Stat,Comp_CatCode,Comp_CatName,Stat,Comp_Order,AuditStat,AuditCurAudit,Comp_CurNode,Comp_Creator,Comp_CreatTime,Comp_IsBusy,Comp_Udef1,Comp_Udef2 FROM Road_Components where 1=1 AND ((Stat is null) or (Stat=0) ) order by Comp_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Road_Components road_Components = new Road_Components();
            if (dr["Comp_ID"] != DBNull.Value) road_Components.Comp_ID = Convert.ToInt64(dr["Comp_ID"]);
            if (dr["Comp_Code"] != DBNull.Value) road_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
            if (dr["Comp_Name"] != DBNull.Value) road_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
            if (dr["Comp_Design"] != DBNull.Value) road_Components.Comp_Design = Convert.ToString(dr["Comp_Design"]);
            if (dr["Comp_Bak"] != DBNull.Value) road_Components.Comp_Bak = Convert.ToString(dr["Comp_Bak"]);
            if (dr["Comp_Stat"] != DBNull.Value) road_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
            if (dr["Comp_CatCode"] != DBNull.Value) road_Components.Comp_CatCode = Convert.ToString(dr["Comp_CatCode"]);
            if (dr["Comp_CatName"] != DBNull.Value) road_Components.Comp_CatName = Convert.ToString(dr["Comp_CatName"]);
            if (dr["Stat"] != DBNull.Value) road_Components.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Comp_Order"] != DBNull.Value) road_Components.Comp_Order = Convert.ToInt32(dr["Comp_Order"]);
            if (dr["AuditStat"] != DBNull.Value) road_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) road_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Comp_CurNode"] != DBNull.Value) road_Components.Comp_CurNode = Convert.ToString(dr["Comp_CurNode"]);
            if (dr["Comp_Creator"] != DBNull.Value) road_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
            if (dr["Comp_CreatTime"] != DBNull.Value) road_Components.Comp_CreatTime = Convert.ToDateTime(dr["Comp_CreatTime"]);
            if (dr["Comp_IsBusy"] != DBNull.Value) road_Components.Comp_IsBusy = Convert.ToInt32(dr["Comp_IsBusy"]);
            if (dr["Comp_Udef1"] != DBNull.Value) road_Components.Comp_Udef1 = Convert.ToString(dr["Comp_Udef1"]);
            if (dr["Comp_Udef2"] != DBNull.Value) road_Components.Comp_Udef2 = Convert.ToString(dr["Comp_Udef2"]);
            ret.Add(road_Components);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
