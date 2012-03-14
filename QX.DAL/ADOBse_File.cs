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
   public partial class ADOBse_File
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_File对象(即:一条记录)
      /// </summary>
      public int Add(Bse_File bse_File)
      {
         string sql = "INSERT INTO Bse_File (CF_Code,CF_Name,CF_Path,CF_Cate,CF_CateName,CF_Type,CF_TypeName,CF_iType,AuditStat,AuditCurAudit,CF_Bak,Stat,CreateTime,UpdateTime,DeleteTime,CF_Creator,CF_CreatorName) VALUES (@CF_Code,@CF_Name,@CF_Path,@CF_Cate,@CF_CateName,@CF_Type,@CF_TypeName,@CF_iType,@AuditStat,@AuditCurAudit,@CF_Bak,@Stat,@CreateTime,@UpdateTime,@DeleteTime,@CF_Creator,@CF_CreatorName)";
         if (string.IsNullOrEmpty(bse_File.CF_Code))
         {
            idb.AddParameter("@CF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Code", bse_File.CF_Code);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Name))
         {
            idb.AddParameter("@CF_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Name", bse_File.CF_Name);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Path))
         {
            idb.AddParameter("@CF_Path", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Path", bse_File.CF_Path);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Cate))
         {
            idb.AddParameter("@CF_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Cate", bse_File.CF_Cate);
         }
         if (string.IsNullOrEmpty(bse_File.CF_CateName))
         {
            idb.AddParameter("@CF_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_CateName", bse_File.CF_CateName);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Type))
         {
            idb.AddParameter("@CF_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Type", bse_File.CF_Type);
         }
         if (string.IsNullOrEmpty(bse_File.CF_TypeName))
         {
            idb.AddParameter("@CF_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_TypeName", bse_File.CF_TypeName);
         }
         if (string.IsNullOrEmpty(bse_File.CF_iType))
         {
            idb.AddParameter("@CF_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_iType", bse_File.CF_iType);
         }
         if (string.IsNullOrEmpty(bse_File.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_File.AuditStat);
         }
         if (string.IsNullOrEmpty(bse_File.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_File.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Bak))
         {
            idb.AddParameter("@CF_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Bak", bse_File.CF_Bak);
         }
         if (bse_File.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_File.Stat);
         }
         if (bse_File.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_File.CreateTime);
         }
         if (bse_File.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_File.UpdateTime);
         }
         if (bse_File.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_File.DeleteTime);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Creator))
         {
            idb.AddParameter("@CF_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Creator", bse_File.CF_Creator);
         }
         if (string.IsNullOrEmpty(bse_File.CF_CreatorName))
         {
            idb.AddParameter("@CF_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_CreatorName", bse_File.CF_CreatorName);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_File对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_File bse_File)
      {
         string sql = "INSERT INTO Bse_File (CF_Code,CF_Name,CF_Path,CF_Cate,CF_CateName,CF_Type,CF_TypeName,CF_iType,AuditStat,AuditCurAudit,CF_Bak,Stat,CreateTime,UpdateTime,DeleteTime,CF_Creator,CF_CreatorName) VALUES (@CF_Code,@CF_Name,@CF_Path,@CF_Cate,@CF_CateName,@CF_Type,@CF_TypeName,@CF_iType,@AuditStat,@AuditCurAudit,@CF_Bak,@Stat,@CreateTime,@UpdateTime,@DeleteTime,@CF_Creator,@CF_CreatorName);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_File.CF_Code))
         {
            idb.AddParameter("@CF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Code", bse_File.CF_Code);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Name))
         {
            idb.AddParameter("@CF_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Name", bse_File.CF_Name);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Path))
         {
            idb.AddParameter("@CF_Path", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Path", bse_File.CF_Path);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Cate))
         {
            idb.AddParameter("@CF_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Cate", bse_File.CF_Cate);
         }
         if (string.IsNullOrEmpty(bse_File.CF_CateName))
         {
            idb.AddParameter("@CF_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_CateName", bse_File.CF_CateName);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Type))
         {
            idb.AddParameter("@CF_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Type", bse_File.CF_Type);
         }
         if (string.IsNullOrEmpty(bse_File.CF_TypeName))
         {
            idb.AddParameter("@CF_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_TypeName", bse_File.CF_TypeName);
         }
         if (string.IsNullOrEmpty(bse_File.CF_iType))
         {
            idb.AddParameter("@CF_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_iType", bse_File.CF_iType);
         }
         if (string.IsNullOrEmpty(bse_File.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_File.AuditStat);
         }
         if (string.IsNullOrEmpty(bse_File.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_File.AuditCurAudit);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Bak))
         {
            idb.AddParameter("@CF_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Bak", bse_File.CF_Bak);
         }
         if (bse_File.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_File.Stat);
         }
         if (bse_File.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_File.CreateTime);
         }
         if (bse_File.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_File.UpdateTime);
         }
         if (bse_File.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_File.DeleteTime);
         }
         if (string.IsNullOrEmpty(bse_File.CF_Creator))
         {
            idb.AddParameter("@CF_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Creator", bse_File.CF_Creator);
         }
         if (string.IsNullOrEmpty(bse_File.CF_CreatorName))
         {
            idb.AddParameter("@CF_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_CreatorName", bse_File.CF_CreatorName);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_File对象(即:一条记录
      /// </summary>
      public int Update(Bse_File bse_File)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_File       SET ");
            if(bse_File.CF_Code_IsChanged){sbParameter.Append("CF_Code=@CF_Code, ");}
      if(bse_File.CF_Name_IsChanged){sbParameter.Append("CF_Name=@CF_Name, ");}
      if(bse_File.CF_Path_IsChanged){sbParameter.Append("CF_Path=@CF_Path, ");}
      if(bse_File.CF_Cate_IsChanged){sbParameter.Append("CF_Cate=@CF_Cate, ");}
      if(bse_File.CF_CateName_IsChanged){sbParameter.Append("CF_CateName=@CF_CateName, ");}
      if(bse_File.CF_Type_IsChanged){sbParameter.Append("CF_Type=@CF_Type, ");}
      if(bse_File.CF_TypeName_IsChanged){sbParameter.Append("CF_TypeName=@CF_TypeName, ");}
      if(bse_File.CF_iType_IsChanged){sbParameter.Append("CF_iType=@CF_iType, ");}
      if(bse_File.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(bse_File.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(bse_File.CF_Bak_IsChanged){sbParameter.Append("CF_Bak=@CF_Bak, ");}
      if(bse_File.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_File.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_File.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_File.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime, ");}
      if(bse_File.CF_Creator_IsChanged){sbParameter.Append("CF_Creator=@CF_Creator, ");}
      if(bse_File.CF_CreatorName_IsChanged){sbParameter.Append("CF_CreatorName=@CF_CreatorName ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and CF_ID=@CF_ID; " );
      string sql=sb.ToString();
         if(bse_File.CF_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Code))
         {
            idb.AddParameter("@CF_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Code", bse_File.CF_Code);
         }
          }
         if(bse_File.CF_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Name))
         {
            idb.AddParameter("@CF_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Name", bse_File.CF_Name);
         }
          }
         if(bse_File.CF_Path_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Path))
         {
            idb.AddParameter("@CF_Path", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Path", bse_File.CF_Path);
         }
          }
         if(bse_File.CF_Cate_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Cate))
         {
            idb.AddParameter("@CF_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Cate", bse_File.CF_Cate);
         }
          }
         if(bse_File.CF_CateName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_CateName))
         {
            idb.AddParameter("@CF_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_CateName", bse_File.CF_CateName);
         }
          }
         if(bse_File.CF_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Type))
         {
            idb.AddParameter("@CF_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Type", bse_File.CF_Type);
         }
          }
         if(bse_File.CF_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_TypeName))
         {
            idb.AddParameter("@CF_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_TypeName", bse_File.CF_TypeName);
         }
          }
         if(bse_File.CF_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_iType))
         {
            idb.AddParameter("@CF_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_iType", bse_File.CF_iType);
         }
          }
         if(bse_File.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_File.AuditStat);
         }
          }
         if(bse_File.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_File.AuditCurAudit);
         }
          }
         if(bse_File.CF_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Bak))
         {
            idb.AddParameter("@CF_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Bak", bse_File.CF_Bak);
         }
          }
         if(bse_File.Stat_IsChanged)
         {
         if (bse_File.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_File.Stat);
         }
          }
         if(bse_File.CreateTime_IsChanged)
         {
         if (bse_File.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_File.CreateTime);
         }
          }
         if(bse_File.UpdateTime_IsChanged)
         {
         if (bse_File.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_File.UpdateTime);
         }
          }
         if(bse_File.DeleteTime_IsChanged)
         {
         if (bse_File.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_File.DeleteTime);
         }
          }
         if(bse_File.CF_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_Creator))
         {
            idb.AddParameter("@CF_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_Creator", bse_File.CF_Creator);
         }
          }
         if(bse_File.CF_CreatorName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_File.CF_CreatorName))
         {
            idb.AddParameter("@CF_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CF_CreatorName", bse_File.CF_CreatorName);
         }
          }

         idb.AddParameter("@CF_ID", bse_File.CF_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_File对象(即:一条记录
      /// </summary>
      public int Delete(decimal cF_ID)
      {
         string sql = "DELETE Bse_File WHERE 1=1  AND CF_ID=@CF_ID ";
         idb.AddParameter("@CF_ID", cF_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_File对象(即:一条记录
      /// </summary>
      public Bse_File GetByKey(decimal cF_ID)
      {
         Bse_File bse_File = new Bse_File();
         string sql = "SELECT  CF_ID,CF_Code,CF_Name,CF_Path,CF_Cate,CF_CateName,CF_Type,CF_TypeName,CF_iType,AuditStat,AuditCurAudit,CF_Bak,Stat,CreateTime,UpdateTime,DeleteTime,CF_Creator,CF_CreatorName FROM Bse_File WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND CF_ID=@CF_ID ";
         idb.AddParameter("@CF_ID", cF_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["CF_ID"] != DBNull.Value) bse_File.CF_ID = Convert.ToDecimal(dr["CF_ID"]);
            if (dr["CF_Code"] != DBNull.Value) bse_File.CF_Code = Convert.ToString(dr["CF_Code"]);
            if (dr["CF_Name"] != DBNull.Value) bse_File.CF_Name = Convert.ToString(dr["CF_Name"]);
            if (dr["CF_Path"] != DBNull.Value) bse_File.CF_Path = Convert.ToString(dr["CF_Path"]);
            if (dr["CF_Cate"] != DBNull.Value) bse_File.CF_Cate = Convert.ToString(dr["CF_Cate"]);
            if (dr["CF_CateName"] != DBNull.Value) bse_File.CF_CateName = Convert.ToString(dr["CF_CateName"]);
            if (dr["CF_Type"] != DBNull.Value) bse_File.CF_Type = Convert.ToString(dr["CF_Type"]);
            if (dr["CF_TypeName"] != DBNull.Value) bse_File.CF_TypeName = Convert.ToString(dr["CF_TypeName"]);
            if (dr["CF_iType"] != DBNull.Value) bse_File.CF_iType = Convert.ToString(dr["CF_iType"]);
            if (dr["AuditStat"] != DBNull.Value) bse_File.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_File.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["CF_Bak"] != DBNull.Value) bse_File.CF_Bak = Convert.ToString(dr["CF_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_File.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_File.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_File.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_File.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["CF_Creator"] != DBNull.Value) bse_File.CF_Creator = Convert.ToString(dr["CF_Creator"]);
            if (dr["CF_CreatorName"] != DBNull.Value) bse_File.CF_CreatorName = Convert.ToString(dr["CF_CreatorName"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_File;
      }
      /// <summary>
      /// 获取指定的Bse_File对象集合
      /// </summary>
      public List<Bse_File> GetListByWhere(string strCondition)
      {
         List<Bse_File> ret = new List<Bse_File>();
         string sql = "SELECT  CF_ID,CF_Code,CF_Name,CF_Path,CF_Cate,CF_CateName,CF_Type,CF_TypeName,CF_iType,AuditStat,AuditCurAudit,CF_Bak,Stat,CreateTime,UpdateTime,DeleteTime,CF_Creator,CF_CreatorName FROM Bse_File WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY CF_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_File bse_File = new Bse_File();
            if (dr["CF_ID"] != DBNull.Value) bse_File.CF_ID = Convert.ToDecimal(dr["CF_ID"]);
            if (dr["CF_Code"] != DBNull.Value) bse_File.CF_Code = Convert.ToString(dr["CF_Code"]);
            if (dr["CF_Name"] != DBNull.Value) bse_File.CF_Name = Convert.ToString(dr["CF_Name"]);
            if (dr["CF_Path"] != DBNull.Value) bse_File.CF_Path = Convert.ToString(dr["CF_Path"]);
            if (dr["CF_Cate"] != DBNull.Value) bse_File.CF_Cate = Convert.ToString(dr["CF_Cate"]);
            if (dr["CF_CateName"] != DBNull.Value) bse_File.CF_CateName = Convert.ToString(dr["CF_CateName"]);
            if (dr["CF_Type"] != DBNull.Value) bse_File.CF_Type = Convert.ToString(dr["CF_Type"]);
            if (dr["CF_TypeName"] != DBNull.Value) bse_File.CF_TypeName = Convert.ToString(dr["CF_TypeName"]);
            if (dr["CF_iType"] != DBNull.Value) bse_File.CF_iType = Convert.ToString(dr["CF_iType"]);
            if (dr["AuditStat"] != DBNull.Value) bse_File.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_File.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["CF_Bak"] != DBNull.Value) bse_File.CF_Bak = Convert.ToString(dr["CF_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_File.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_File.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_File.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_File.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["CF_Creator"] != DBNull.Value) bse_File.CF_Creator = Convert.ToString(dr["CF_Creator"]);
            if (dr["CF_CreatorName"] != DBNull.Value) bse_File.CF_CreatorName = Convert.ToString(dr["CF_CreatorName"]);
            ret.Add(bse_File);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_File对象(即:一条记录
      /// </summary>
      public List<Bse_File> GetAll()
      {
         List<Bse_File> ret = new List<Bse_File>();
         string sql = "SELECT  CF_ID,CF_Code,CF_Name,CF_Path,CF_Cate,CF_CateName,CF_Type,CF_TypeName,CF_iType,AuditStat,AuditCurAudit,CF_Bak,Stat,CreateTime,UpdateTime,DeleteTime,CF_Creator,CF_CreatorName FROM Bse_File where 1=1 AND ((Stat is null) or (Stat=0) ) order by CF_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_File bse_File = new Bse_File();
            if (dr["CF_ID"] != DBNull.Value) bse_File.CF_ID = Convert.ToDecimal(dr["CF_ID"]);
            if (dr["CF_Code"] != DBNull.Value) bse_File.CF_Code = Convert.ToString(dr["CF_Code"]);
            if (dr["CF_Name"] != DBNull.Value) bse_File.CF_Name = Convert.ToString(dr["CF_Name"]);
            if (dr["CF_Path"] != DBNull.Value) bse_File.CF_Path = Convert.ToString(dr["CF_Path"]);
            if (dr["CF_Cate"] != DBNull.Value) bse_File.CF_Cate = Convert.ToString(dr["CF_Cate"]);
            if (dr["CF_CateName"] != DBNull.Value) bse_File.CF_CateName = Convert.ToString(dr["CF_CateName"]);
            if (dr["CF_Type"] != DBNull.Value) bse_File.CF_Type = Convert.ToString(dr["CF_Type"]);
            if (dr["CF_TypeName"] != DBNull.Value) bse_File.CF_TypeName = Convert.ToString(dr["CF_TypeName"]);
            if (dr["CF_iType"] != DBNull.Value) bse_File.CF_iType = Convert.ToString(dr["CF_iType"]);
            if (dr["AuditStat"] != DBNull.Value) bse_File.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_File.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["CF_Bak"] != DBNull.Value) bse_File.CF_Bak = Convert.ToString(dr["CF_Bak"]);
            if (dr["Stat"] != DBNull.Value) bse_File.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_File.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_File.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_File.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            if (dr["CF_Creator"] != DBNull.Value) bse_File.CF_Creator = Convert.ToString(dr["CF_Creator"]);
            if (dr["CF_CreatorName"] != DBNull.Value) bse_File.CF_CreatorName = Convert.ToString(dr["CF_CreatorName"]);
            ret.Add(bse_File);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
