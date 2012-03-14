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
   public partial class ADOBse_Message
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Message对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Message bse_Message)
      {
         string sql = "INSERT INTO Bse_Message (Msg_Code,Msg_Content,Msg_iType,Msg_Type,Msg_Stat,Msg_IsShow,Msg_IsShowName,Msg_TypeName,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Msg_Code,@Msg_Content,@Msg_iType,@Msg_Type,@Msg_Stat,@Msg_IsShow,@Msg_IsShowName,@Msg_TypeName,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_Message.Msg_Code))
         {
            idb.AddParameter("@Msg_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Code", bse_Message.Msg_Code);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_Content))
         {
            idb.AddParameter("@Msg_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Content", bse_Message.Msg_Content);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_iType))
         {
            idb.AddParameter("@Msg_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_iType", bse_Message.Msg_iType);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_Type))
         {
            idb.AddParameter("@Msg_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Type", bse_Message.Msg_Type);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_Stat))
         {
            idb.AddParameter("@Msg_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Stat", bse_Message.Msg_Stat);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_IsShow))
         {
            idb.AddParameter("@Msg_IsShow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_IsShow", bse_Message.Msg_IsShow);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_IsShowName))
         {
            idb.AddParameter("@Msg_IsShowName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_IsShowName", bse_Message.Msg_IsShowName);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_TypeName))
         {
            idb.AddParameter("@Msg_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_TypeName", bse_Message.Msg_TypeName);
         }
         if (bse_Message.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Message.Stat);
         }
         if (bse_Message.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Message.CreateTime);
         }
         if (bse_Message.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Message.UpdateTime);
         }
         if (bse_Message.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Message.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_Message对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Message bse_Message)
      {
         string sql = "INSERT INTO Bse_Message (Msg_Code,Msg_Content,Msg_iType,Msg_Type,Msg_Stat,Msg_IsShow,Msg_IsShowName,Msg_TypeName,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Msg_Code,@Msg_Content,@Msg_iType,@Msg_Type,@Msg_Stat,@Msg_IsShow,@Msg_IsShowName,@Msg_TypeName,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Message.Msg_Code))
         {
            idb.AddParameter("@Msg_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Code", bse_Message.Msg_Code);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_Content))
         {
            idb.AddParameter("@Msg_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Content", bse_Message.Msg_Content);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_iType))
         {
            idb.AddParameter("@Msg_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_iType", bse_Message.Msg_iType);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_Type))
         {
            idb.AddParameter("@Msg_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Type", bse_Message.Msg_Type);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_Stat))
         {
            idb.AddParameter("@Msg_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Stat", bse_Message.Msg_Stat);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_IsShow))
         {
            idb.AddParameter("@Msg_IsShow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_IsShow", bse_Message.Msg_IsShow);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_IsShowName))
         {
            idb.AddParameter("@Msg_IsShowName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_IsShowName", bse_Message.Msg_IsShowName);
         }
         if (string.IsNullOrEmpty(bse_Message.Msg_TypeName))
         {
            idb.AddParameter("@Msg_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_TypeName", bse_Message.Msg_TypeName);
         }
         if (bse_Message.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Message.Stat);
         }
         if (bse_Message.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Message.CreateTime);
         }
         if (bse_Message.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Message.UpdateTime);
         }
         if (bse_Message.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Message.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_Message对象(即:一条记录
      /// </summary>
      public int Update(Bse_Message bse_Message)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Message       SET ");
            if(bse_Message.Msg_Code_IsChanged){sbParameter.Append("Msg_Code=@Msg_Code, ");}
      if(bse_Message.Msg_Content_IsChanged){sbParameter.Append("Msg_Content=@Msg_Content, ");}
      if(bse_Message.Msg_iType_IsChanged){sbParameter.Append("Msg_iType=@Msg_iType, ");}
      if(bse_Message.Msg_Type_IsChanged){sbParameter.Append("Msg_Type=@Msg_Type, ");}
      if(bse_Message.Msg_Stat_IsChanged){sbParameter.Append("Msg_Stat=@Msg_Stat, ");}
      if(bse_Message.Msg_IsShow_IsChanged){sbParameter.Append("Msg_IsShow=@Msg_IsShow, ");}
      if(bse_Message.Msg_IsShowName_IsChanged){sbParameter.Append("Msg_IsShowName=@Msg_IsShowName, ");}
      if(bse_Message.Msg_TypeName_IsChanged){sbParameter.Append("Msg_TypeName=@Msg_TypeName, ");}
      if(bse_Message.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Message.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_Message.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_Message.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Msg_ID=@Msg_ID; " );
      string sql=sb.ToString();
         if(bse_Message.Msg_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_Code))
         {
            idb.AddParameter("@Msg_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Code", bse_Message.Msg_Code);
         }
          }
         if(bse_Message.Msg_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_Content))
         {
            idb.AddParameter("@Msg_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Content", bse_Message.Msg_Content);
         }
          }
         if(bse_Message.Msg_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_iType))
         {
            idb.AddParameter("@Msg_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_iType", bse_Message.Msg_iType);
         }
          }
         if(bse_Message.Msg_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_Type))
         {
            idb.AddParameter("@Msg_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Type", bse_Message.Msg_Type);
         }
          }
         if(bse_Message.Msg_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_Stat))
         {
            idb.AddParameter("@Msg_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_Stat", bse_Message.Msg_Stat);
         }
          }
         if(bse_Message.Msg_IsShow_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_IsShow))
         {
            idb.AddParameter("@Msg_IsShow", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_IsShow", bse_Message.Msg_IsShow);
         }
          }
         if(bse_Message.Msg_IsShowName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_IsShowName))
         {
            idb.AddParameter("@Msg_IsShowName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_IsShowName", bse_Message.Msg_IsShowName);
         }
          }
         if(bse_Message.Msg_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Message.Msg_TypeName))
         {
            idb.AddParameter("@Msg_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Msg_TypeName", bse_Message.Msg_TypeName);
         }
          }
         if(bse_Message.Stat_IsChanged)
         {
         if (bse_Message.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Message.Stat);
         }
          }
         if(bse_Message.CreateTime_IsChanged)
         {
         if (bse_Message.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Message.CreateTime);
         }
          }
         if(bse_Message.UpdateTime_IsChanged)
         {
         if (bse_Message.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Message.UpdateTime);
         }
          }
         if(bse_Message.DeleteTime_IsChanged)
         {
         if (bse_Message.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Message.DeleteTime);
         }
          }

         idb.AddParameter("@Msg_ID", bse_Message.Msg_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_Message对象(即:一条记录
      /// </summary>
      public int Delete(decimal msg_ID)
      {
         string sql = "DELETE Bse_Message WHERE 1=1  AND Msg_ID=@Msg_ID ";
         idb.AddParameter("@Msg_ID", msg_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_Message对象(即:一条记录
      /// </summary>
      public Bse_Message GetByKey(decimal msg_ID)
      {
         Bse_Message bse_Message = new Bse_Message();
         string sql = "SELECT  Msg_ID,Msg_Code,Msg_Content,Msg_iType,Msg_Type,Msg_Stat,Msg_IsShow,Msg_IsShowName,Msg_TypeName,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Message WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Msg_ID=@Msg_ID ";
         idb.AddParameter("@Msg_ID", msg_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Msg_ID"] != DBNull.Value) bse_Message.Msg_ID = Convert.ToDecimal(dr["Msg_ID"]);
            if (dr["Msg_Code"] != DBNull.Value) bse_Message.Msg_Code = Convert.ToString(dr["Msg_Code"]);
            if (dr["Msg_Content"] != DBNull.Value) bse_Message.Msg_Content = Convert.ToString(dr["Msg_Content"]);
            if (dr["Msg_iType"] != DBNull.Value) bse_Message.Msg_iType = Convert.ToString(dr["Msg_iType"]);
            if (dr["Msg_Type"] != DBNull.Value) bse_Message.Msg_Type = Convert.ToString(dr["Msg_Type"]);
            if (dr["Msg_Stat"] != DBNull.Value) bse_Message.Msg_Stat = Convert.ToString(dr["Msg_Stat"]);
            if (dr["Msg_IsShow"] != DBNull.Value) bse_Message.Msg_IsShow = Convert.ToString(dr["Msg_IsShow"]);
            if (dr["Msg_IsShowName"] != DBNull.Value) bse_Message.Msg_IsShowName = Convert.ToString(dr["Msg_IsShowName"]);
            if (dr["Msg_TypeName"] != DBNull.Value) bse_Message.Msg_TypeName = Convert.ToString(dr["Msg_TypeName"]);
            if (dr["Stat"] != DBNull.Value) bse_Message.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Message.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Message.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Message.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Message;
      }
      /// <summary>
      /// 获取指定的Bse_Message对象集合
      /// </summary>
      public List<Bse_Message> GetListByWhere(string strCondition)
      {
         List<Bse_Message> ret = new List<Bse_Message>();
         string sql = "SELECT  Msg_ID,Msg_Code,Msg_Content,Msg_iType,Msg_Type,Msg_Stat,Msg_IsShow,Msg_IsShowName,Msg_TypeName,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Message WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Msg_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Message bse_Message = new Bse_Message();
            if (dr["Msg_ID"] != DBNull.Value) bse_Message.Msg_ID = Convert.ToDecimal(dr["Msg_ID"]);
            if (dr["Msg_Code"] != DBNull.Value) bse_Message.Msg_Code = Convert.ToString(dr["Msg_Code"]);
            if (dr["Msg_Content"] != DBNull.Value) bse_Message.Msg_Content = Convert.ToString(dr["Msg_Content"]);
            if (dr["Msg_iType"] != DBNull.Value) bse_Message.Msg_iType = Convert.ToString(dr["Msg_iType"]);
            if (dr["Msg_Type"] != DBNull.Value) bse_Message.Msg_Type = Convert.ToString(dr["Msg_Type"]);
            if (dr["Msg_Stat"] != DBNull.Value) bse_Message.Msg_Stat = Convert.ToString(dr["Msg_Stat"]);
            if (dr["Msg_IsShow"] != DBNull.Value) bse_Message.Msg_IsShow = Convert.ToString(dr["Msg_IsShow"]);
            if (dr["Msg_IsShowName"] != DBNull.Value) bse_Message.Msg_IsShowName = Convert.ToString(dr["Msg_IsShowName"]);
            if (dr["Msg_TypeName"] != DBNull.Value) bse_Message.Msg_TypeName = Convert.ToString(dr["Msg_TypeName"]);
            if (dr["Stat"] != DBNull.Value) bse_Message.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Message.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Message.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Message.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Message);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Message对象(即:一条记录
      /// </summary>
      public List<Bse_Message> GetAll()
      {
         List<Bse_Message> ret = new List<Bse_Message>();
         string sql = "SELECT  Msg_ID,Msg_Code,Msg_Content,Msg_iType,Msg_Type,Msg_Stat,Msg_IsShow,Msg_IsShowName,Msg_TypeName,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Message where 1=1 AND ((Stat is null) or (Stat=0) ) order by Msg_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Message bse_Message = new Bse_Message();
            if (dr["Msg_ID"] != DBNull.Value) bse_Message.Msg_ID = Convert.ToDecimal(dr["Msg_ID"]);
            if (dr["Msg_Code"] != DBNull.Value) bse_Message.Msg_Code = Convert.ToString(dr["Msg_Code"]);
            if (dr["Msg_Content"] != DBNull.Value) bse_Message.Msg_Content = Convert.ToString(dr["Msg_Content"]);
            if (dr["Msg_iType"] != DBNull.Value) bse_Message.Msg_iType = Convert.ToString(dr["Msg_iType"]);
            if (dr["Msg_Type"] != DBNull.Value) bse_Message.Msg_Type = Convert.ToString(dr["Msg_Type"]);
            if (dr["Msg_Stat"] != DBNull.Value) bse_Message.Msg_Stat = Convert.ToString(dr["Msg_Stat"]);
            if (dr["Msg_IsShow"] != DBNull.Value) bse_Message.Msg_IsShow = Convert.ToString(dr["Msg_IsShow"]);
            if (dr["Msg_IsShowName"] != DBNull.Value) bse_Message.Msg_IsShowName = Convert.ToString(dr["Msg_IsShowName"]);
            if (dr["Msg_TypeName"] != DBNull.Value) bse_Message.Msg_TypeName = Convert.ToString(dr["Msg_TypeName"]);
            if (dr["Stat"] != DBNull.Value) bse_Message.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Message.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Message.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Message.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Message);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
