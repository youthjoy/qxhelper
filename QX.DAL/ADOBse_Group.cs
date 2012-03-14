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
   public partial class ADOBse_Group
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Group对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Group bse_Group)
      {
         string sql = "INSERT INTO Bse_Group (GP_Code,GP_Name,GP_iType,GP_Creator,GP_CreatorName,GP_Date,GP_Type,GP_TypeName,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@GP_Code,@GP_Name,@GP_iType,@GP_Creator,@GP_CreatorName,@GP_Date,@GP_Type,@GP_TypeName,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_Group.GP_Code))
         {
            idb.AddParameter("@GP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Code", bse_Group.GP_Code);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_Name))
         {
            idb.AddParameter("@GP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Name", bse_Group.GP_Name);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_iType))
         {
            idb.AddParameter("@GP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_iType", bse_Group.GP_iType);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_Creator))
         {
            idb.AddParameter("@GP_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Creator", bse_Group.GP_Creator);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_CreatorName))
         {
            idb.AddParameter("@GP_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_CreatorName", bse_Group.GP_CreatorName);
         }
         if (bse_Group.GP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@GP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Date", bse_Group.GP_Date);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_Type))
         {
            idb.AddParameter("@GP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Type", bse_Group.GP_Type);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_TypeName))
         {
            idb.AddParameter("@GP_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_TypeName", bse_Group.GP_TypeName);
         }
         if (bse_Group.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Group.Stat);
         }
         if (bse_Group.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Group.CreateTime);
         }
         if (bse_Group.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Group.UpdateTime);
         }
         if (bse_Group.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Group.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_Group对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Group bse_Group)
      {
         string sql = "INSERT INTO Bse_Group (GP_Code,GP_Name,GP_iType,GP_Creator,GP_CreatorName,GP_Date,GP_Type,GP_TypeName,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@GP_Code,@GP_Name,@GP_iType,@GP_Creator,@GP_CreatorName,@GP_Date,@GP_Type,@GP_TypeName,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Group.GP_Code))
         {
            idb.AddParameter("@GP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Code", bse_Group.GP_Code);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_Name))
         {
            idb.AddParameter("@GP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Name", bse_Group.GP_Name);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_iType))
         {
            idb.AddParameter("@GP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_iType", bse_Group.GP_iType);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_Creator))
         {
            idb.AddParameter("@GP_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Creator", bse_Group.GP_Creator);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_CreatorName))
         {
            idb.AddParameter("@GP_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_CreatorName", bse_Group.GP_CreatorName);
         }
         if (bse_Group.GP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@GP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Date", bse_Group.GP_Date);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_Type))
         {
            idb.AddParameter("@GP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Type", bse_Group.GP_Type);
         }
         if (string.IsNullOrEmpty(bse_Group.GP_TypeName))
         {
            idb.AddParameter("@GP_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_TypeName", bse_Group.GP_TypeName);
         }
         if (bse_Group.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Group.Stat);
         }
         if (bse_Group.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Group.CreateTime);
         }
         if (bse_Group.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Group.UpdateTime);
         }
         if (bse_Group.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Group.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_Group对象(即:一条记录
      /// </summary>
      public int Update(Bse_Group bse_Group)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Group       SET ");
            if(bse_Group.GP_Code_IsChanged){sbParameter.Append("GP_Code=@GP_Code, ");}
      if(bse_Group.GP_Name_IsChanged){sbParameter.Append("GP_Name=@GP_Name, ");}
      if(bse_Group.GP_iType_IsChanged){sbParameter.Append("GP_iType=@GP_iType, ");}
      if(bse_Group.GP_Creator_IsChanged){sbParameter.Append("GP_Creator=@GP_Creator, ");}
      if(bse_Group.GP_CreatorName_IsChanged){sbParameter.Append("GP_CreatorName=@GP_CreatorName, ");}
      if(bse_Group.GP_Date_IsChanged){sbParameter.Append("GP_Date=@GP_Date, ");}
      if(bse_Group.GP_Type_IsChanged){sbParameter.Append("GP_Type=@GP_Type, ");}
      if(bse_Group.GP_TypeName_IsChanged){sbParameter.Append("GP_TypeName=@GP_TypeName, ");}
      if(bse_Group.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Group.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_Group.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_Group.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and GP_ID=@GP_ID; " );
      string sql=sb.ToString();
         if(bse_Group.GP_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_Code))
         {
            idb.AddParameter("@GP_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Code", bse_Group.GP_Code);
         }
          }
         if(bse_Group.GP_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_Name))
         {
            idb.AddParameter("@GP_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Name", bse_Group.GP_Name);
         }
          }
         if(bse_Group.GP_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_iType))
         {
            idb.AddParameter("@GP_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_iType", bse_Group.GP_iType);
         }
          }
         if(bse_Group.GP_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_Creator))
         {
            idb.AddParameter("@GP_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Creator", bse_Group.GP_Creator);
         }
          }
         if(bse_Group.GP_CreatorName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_CreatorName))
         {
            idb.AddParameter("@GP_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_CreatorName", bse_Group.GP_CreatorName);
         }
          }
         if(bse_Group.GP_Date_IsChanged)
         {
         if (bse_Group.GP_Date == DateTime.MinValue)
         {
            idb.AddParameter("@GP_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Date", bse_Group.GP_Date);
         }
          }
         if(bse_Group.GP_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_Type))
         {
            idb.AddParameter("@GP_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_Type", bse_Group.GP_Type);
         }
          }
         if(bse_Group.GP_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Group.GP_TypeName))
         {
            idb.AddParameter("@GP_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@GP_TypeName", bse_Group.GP_TypeName);
         }
          }
         if(bse_Group.Stat_IsChanged)
         {
         if (bse_Group.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Group.Stat);
         }
          }
         if(bse_Group.CreateTime_IsChanged)
         {
         if (bse_Group.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Group.CreateTime);
         }
          }
         if(bse_Group.UpdateTime_IsChanged)
         {
         if (bse_Group.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Group.UpdateTime);
         }
          }
         if(bse_Group.DeleteTime_IsChanged)
         {
         if (bse_Group.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Group.DeleteTime);
         }
          }

         idb.AddParameter("@GP_ID", bse_Group.GP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_Group对象(即:一条记录
      /// </summary>
      public int Delete(decimal gP_ID)
      {
         string sql = "DELETE Bse_Group WHERE 1=1  AND GP_ID=@GP_ID ";
         idb.AddParameter("@GP_ID", gP_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_Group对象(即:一条记录
      /// </summary>
      public Bse_Group GetByKey(decimal gP_ID)
      {
         Bse_Group bse_Group = new Bse_Group();
         string sql = "SELECT  GP_ID,GP_Code,GP_Name,GP_iType,GP_Creator,GP_CreatorName,GP_Date,GP_Type,GP_TypeName,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Group WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND GP_ID=@GP_ID ";
         idb.AddParameter("@GP_ID", gP_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["GP_ID"] != DBNull.Value) bse_Group.GP_ID = Convert.ToDecimal(dr["GP_ID"]);
            if (dr["GP_Code"] != DBNull.Value) bse_Group.GP_Code = Convert.ToString(dr["GP_Code"]);
            if (dr["GP_Name"] != DBNull.Value) bse_Group.GP_Name = Convert.ToString(dr["GP_Name"]);
            if (dr["GP_iType"] != DBNull.Value) bse_Group.GP_iType = Convert.ToString(dr["GP_iType"]);
            if (dr["GP_Creator"] != DBNull.Value) bse_Group.GP_Creator = Convert.ToString(dr["GP_Creator"]);
            if (dr["GP_CreatorName"] != DBNull.Value) bse_Group.GP_CreatorName = Convert.ToString(dr["GP_CreatorName"]);
            if (dr["GP_Date"] != DBNull.Value) bse_Group.GP_Date = Convert.ToDateTime(dr["GP_Date"]);
            if (dr["GP_Type"] != DBNull.Value) bse_Group.GP_Type = Convert.ToString(dr["GP_Type"]);
            if (dr["GP_TypeName"] != DBNull.Value) bse_Group.GP_TypeName = Convert.ToString(dr["GP_TypeName"]);
            if (dr["Stat"] != DBNull.Value) bse_Group.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Group.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Group.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Group.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Group;
      }
      /// <summary>
      /// 获取指定的Bse_Group对象集合
      /// </summary>
      public List<Bse_Group> GetListByWhere(string strCondition)
      {
         List<Bse_Group> ret = new List<Bse_Group>();
         string sql = "SELECT  GP_ID,GP_Code,GP_Name,GP_iType,GP_Creator,GP_CreatorName,GP_Date,GP_Type,GP_TypeName,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Group WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY GP_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Group bse_Group = new Bse_Group();
            if (dr["GP_ID"] != DBNull.Value) bse_Group.GP_ID = Convert.ToDecimal(dr["GP_ID"]);
            if (dr["GP_Code"] != DBNull.Value) bse_Group.GP_Code = Convert.ToString(dr["GP_Code"]);
            if (dr["GP_Name"] != DBNull.Value) bse_Group.GP_Name = Convert.ToString(dr["GP_Name"]);
            if (dr["GP_iType"] != DBNull.Value) bse_Group.GP_iType = Convert.ToString(dr["GP_iType"]);
            if (dr["GP_Creator"] != DBNull.Value) bse_Group.GP_Creator = Convert.ToString(dr["GP_Creator"]);
            if (dr["GP_CreatorName"] != DBNull.Value) bse_Group.GP_CreatorName = Convert.ToString(dr["GP_CreatorName"]);
            if (dr["GP_Date"] != DBNull.Value) bse_Group.GP_Date = Convert.ToDateTime(dr["GP_Date"]);
            if (dr["GP_Type"] != DBNull.Value) bse_Group.GP_Type = Convert.ToString(dr["GP_Type"]);
            if (dr["GP_TypeName"] != DBNull.Value) bse_Group.GP_TypeName = Convert.ToString(dr["GP_TypeName"]);
            if (dr["Stat"] != DBNull.Value) bse_Group.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Group.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Group.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Group.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Group);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Group对象(即:一条记录
      /// </summary>
      public List<Bse_Group> GetAll()
      {
         List<Bse_Group> ret = new List<Bse_Group>();
         string sql = "SELECT  GP_ID,GP_Code,GP_Name,GP_iType,GP_Creator,GP_CreatorName,GP_Date,GP_Type,GP_TypeName,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Group where 1=1 AND ((Stat is null) or (Stat=0) ) order by GP_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Group bse_Group = new Bse_Group();
            if (dr["GP_ID"] != DBNull.Value) bse_Group.GP_ID = Convert.ToDecimal(dr["GP_ID"]);
            if (dr["GP_Code"] != DBNull.Value) bse_Group.GP_Code = Convert.ToString(dr["GP_Code"]);
            if (dr["GP_Name"] != DBNull.Value) bse_Group.GP_Name = Convert.ToString(dr["GP_Name"]);
            if (dr["GP_iType"] != DBNull.Value) bse_Group.GP_iType = Convert.ToString(dr["GP_iType"]);
            if (dr["GP_Creator"] != DBNull.Value) bse_Group.GP_Creator = Convert.ToString(dr["GP_Creator"]);
            if (dr["GP_CreatorName"] != DBNull.Value) bse_Group.GP_CreatorName = Convert.ToString(dr["GP_CreatorName"]);
            if (dr["GP_Date"] != DBNull.Value) bse_Group.GP_Date = Convert.ToDateTime(dr["GP_Date"]);
            if (dr["GP_Type"] != DBNull.Value) bse_Group.GP_Type = Convert.ToString(dr["GP_Type"]);
            if (dr["GP_TypeName"] != DBNull.Value) bse_Group.GP_TypeName = Convert.ToString(dr["GP_TypeName"]);
            if (dr["Stat"] != DBNull.Value) bse_Group.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Group.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Group.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Group.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Group);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
