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
   public partial class ADOBse_Components
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Bse_Components对象(即:一条记录)
      /// </summary>
      public int Add(Bse_Components bse_Components)
      {
         string sql = "INSERT INTO Bse_Components (Comp_Code,Comp_CCode,Comp_Name,Comp_Type,Comp_TypeName,Comp_Cate,Comp_CateName,Comp_Customer,Comp_CustomerName,Comp_Stat,Comp_Content,Comp_Creator,Comp_CreatorName,Comp_Date,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Comp_Code,@Comp_CCode,@Comp_Name,@Comp_Type,@Comp_TypeName,@Comp_Cate,@Comp_CateName,@Comp_Customer,@Comp_CustomerName,@Comp_Stat,@Comp_Content,@Comp_Creator,@Comp_CreatorName,@Comp_Date,@AuditStat,@AuditCurAudit,@Stat,@CreateTime,@UpdateTime,@DeleteTime)";
         if (string.IsNullOrEmpty(bse_Components.Comp_Code))
         {
            idb.AddParameter("@Comp_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Code", bse_Components.Comp_Code);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CCode))
         {
            idb.AddParameter("@Comp_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CCode", bse_Components.Comp_CCode);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Name))
         {
            idb.AddParameter("@Comp_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Name", bse_Components.Comp_Name);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Type))
         {
            idb.AddParameter("@Comp_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Type", bse_Components.Comp_Type);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_TypeName))
         {
            idb.AddParameter("@Comp_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_TypeName", bse_Components.Comp_TypeName);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Cate))
         {
            idb.AddParameter("@Comp_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Cate", bse_Components.Comp_Cate);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CateName))
         {
            idb.AddParameter("@Comp_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CateName", bse_Components.Comp_CateName);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Customer))
         {
            idb.AddParameter("@Comp_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Customer", bse_Components.Comp_Customer);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CustomerName))
         {
            idb.AddParameter("@Comp_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CustomerName", bse_Components.Comp_CustomerName);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Stat))
         {
            idb.AddParameter("@Comp_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Stat", bse_Components.Comp_Stat);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Content))
         {
            idb.AddParameter("@Comp_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Content", bse_Components.Comp_Content);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Creator))
         {
            idb.AddParameter("@Comp_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Creator", bse_Components.Comp_Creator);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CreatorName))
         {
            idb.AddParameter("@Comp_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CreatorName", bse_Components.Comp_CreatorName);
         }
         if (bse_Components.Comp_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Comp_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Date", bse_Components.Comp_Date);
         }
         if (string.IsNullOrEmpty(bse_Components.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_Components.AuditStat);
         }
         if (string.IsNullOrEmpty(bse_Components.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_Components.AuditCurAudit);
         }
         if (bse_Components.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Components.Stat);
         }
         if (bse_Components.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Components.CreateTime);
         }
         if (bse_Components.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Components.UpdateTime);
         }
         if (bse_Components.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Components.DeleteTime);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加Bse_Components对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Bse_Components bse_Components)
      {
         string sql = "INSERT INTO Bse_Components (Comp_Code,Comp_CCode,Comp_Name,Comp_Type,Comp_TypeName,Comp_Cate,Comp_CateName,Comp_Customer,Comp_CustomerName,Comp_Stat,Comp_Content,Comp_Creator,Comp_CreatorName,Comp_Date,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,DeleteTime) VALUES (@Comp_Code,@Comp_CCode,@Comp_Name,@Comp_Type,@Comp_TypeName,@Comp_Cate,@Comp_CateName,@Comp_Customer,@Comp_CustomerName,@Comp_Stat,@Comp_Content,@Comp_Creator,@Comp_CreatorName,@Comp_Date,@AuditStat,@AuditCurAudit,@Stat,@CreateTime,@UpdateTime,@DeleteTime);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(bse_Components.Comp_Code))
         {
            idb.AddParameter("@Comp_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Code", bse_Components.Comp_Code);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CCode))
         {
            idb.AddParameter("@Comp_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CCode", bse_Components.Comp_CCode);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Name))
         {
            idb.AddParameter("@Comp_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Name", bse_Components.Comp_Name);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Type))
         {
            idb.AddParameter("@Comp_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Type", bse_Components.Comp_Type);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_TypeName))
         {
            idb.AddParameter("@Comp_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_TypeName", bse_Components.Comp_TypeName);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Cate))
         {
            idb.AddParameter("@Comp_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Cate", bse_Components.Comp_Cate);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CateName))
         {
            idb.AddParameter("@Comp_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CateName", bse_Components.Comp_CateName);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Customer))
         {
            idb.AddParameter("@Comp_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Customer", bse_Components.Comp_Customer);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CustomerName))
         {
            idb.AddParameter("@Comp_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CustomerName", bse_Components.Comp_CustomerName);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Stat))
         {
            idb.AddParameter("@Comp_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Stat", bse_Components.Comp_Stat);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Content))
         {
            idb.AddParameter("@Comp_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Content", bse_Components.Comp_Content);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_Creator))
         {
            idb.AddParameter("@Comp_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Creator", bse_Components.Comp_Creator);
         }
         if (string.IsNullOrEmpty(bse_Components.Comp_CreatorName))
         {
            idb.AddParameter("@Comp_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CreatorName", bse_Components.Comp_CreatorName);
         }
         if (bse_Components.Comp_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Comp_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Date", bse_Components.Comp_Date);
         }
         if (string.IsNullOrEmpty(bse_Components.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_Components.AuditStat);
         }
         if (string.IsNullOrEmpty(bse_Components.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_Components.AuditCurAudit);
         }
         if (bse_Components.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Components.Stat);
         }
         if (bse_Components.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Components.CreateTime);
         }
         if (bse_Components.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Components.UpdateTime);
         }
         if (bse_Components.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Components.DeleteTime);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新Bse_Components对象(即:一条记录
      /// </summary>
      public int Update(Bse_Components bse_Components)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Bse_Components       SET ");
            if(bse_Components.Comp_Code_IsChanged){sbParameter.Append("Comp_Code=@Comp_Code, ");}
      if(bse_Components.Comp_CCode_IsChanged){sbParameter.Append("Comp_CCode=@Comp_CCode, ");}
      if(bse_Components.Comp_Name_IsChanged){sbParameter.Append("Comp_Name=@Comp_Name, ");}
      if(bse_Components.Comp_Type_IsChanged){sbParameter.Append("Comp_Type=@Comp_Type, ");}
      if(bse_Components.Comp_TypeName_IsChanged){sbParameter.Append("Comp_TypeName=@Comp_TypeName, ");}
      if(bse_Components.Comp_Cate_IsChanged){sbParameter.Append("Comp_Cate=@Comp_Cate, ");}
      if(bse_Components.Comp_CateName_IsChanged){sbParameter.Append("Comp_CateName=@Comp_CateName, ");}
      if(bse_Components.Comp_Customer_IsChanged){sbParameter.Append("Comp_Customer=@Comp_Customer, ");}
      if(bse_Components.Comp_CustomerName_IsChanged){sbParameter.Append("Comp_CustomerName=@Comp_CustomerName, ");}
      if(bse_Components.Comp_Stat_IsChanged){sbParameter.Append("Comp_Stat=@Comp_Stat, ");}
      if(bse_Components.Comp_Content_IsChanged){sbParameter.Append("Comp_Content=@Comp_Content, ");}
      if(bse_Components.Comp_Creator_IsChanged){sbParameter.Append("Comp_Creator=@Comp_Creator, ");}
      if(bse_Components.Comp_CreatorName_IsChanged){sbParameter.Append("Comp_CreatorName=@Comp_CreatorName, ");}
      if(bse_Components.Comp_Date_IsChanged){sbParameter.Append("Comp_Date=@Comp_Date, ");}
      if(bse_Components.AuditStat_IsChanged){sbParameter.Append("AuditStat=@AuditStat, ");}
      if(bse_Components.AuditCurAudit_IsChanged){sbParameter.Append("AuditCurAudit=@AuditCurAudit, ");}
      if(bse_Components.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(bse_Components.CreateTime_IsChanged){sbParameter.Append("CreateTime=@CreateTime, ");}
      if(bse_Components.UpdateTime_IsChanged){sbParameter.Append("UpdateTime=@UpdateTime, ");}
      if(bse_Components.DeleteTime_IsChanged){sbParameter.Append("DeleteTime=@DeleteTime ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Comp_ID=@Comp_ID; " );
      string sql=sb.ToString();
         if(bse_Components.Comp_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Code))
         {
            idb.AddParameter("@Comp_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Code", bse_Components.Comp_Code);
         }
          }
         if(bse_Components.Comp_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_CCode))
         {
            idb.AddParameter("@Comp_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CCode", bse_Components.Comp_CCode);
         }
          }
         if(bse_Components.Comp_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Name))
         {
            idb.AddParameter("@Comp_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Name", bse_Components.Comp_Name);
         }
          }
         if(bse_Components.Comp_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Type))
         {
            idb.AddParameter("@Comp_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Type", bse_Components.Comp_Type);
         }
          }
         if(bse_Components.Comp_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_TypeName))
         {
            idb.AddParameter("@Comp_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_TypeName", bse_Components.Comp_TypeName);
         }
          }
         if(bse_Components.Comp_Cate_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Cate))
         {
            idb.AddParameter("@Comp_Cate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Cate", bse_Components.Comp_Cate);
         }
          }
         if(bse_Components.Comp_CateName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_CateName))
         {
            idb.AddParameter("@Comp_CateName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CateName", bse_Components.Comp_CateName);
         }
          }
         if(bse_Components.Comp_Customer_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Customer))
         {
            idb.AddParameter("@Comp_Customer", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Customer", bse_Components.Comp_Customer);
         }
          }
         if(bse_Components.Comp_CustomerName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_CustomerName))
         {
            idb.AddParameter("@Comp_CustomerName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CustomerName", bse_Components.Comp_CustomerName);
         }
          }
         if(bse_Components.Comp_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Stat))
         {
            idb.AddParameter("@Comp_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Stat", bse_Components.Comp_Stat);
         }
          }
         if(bse_Components.Comp_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Content))
         {
            idb.AddParameter("@Comp_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Content", bse_Components.Comp_Content);
         }
          }
         if(bse_Components.Comp_Creator_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_Creator))
         {
            idb.AddParameter("@Comp_Creator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Creator", bse_Components.Comp_Creator);
         }
          }
         if(bse_Components.Comp_CreatorName_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.Comp_CreatorName))
         {
            idb.AddParameter("@Comp_CreatorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_CreatorName", bse_Components.Comp_CreatorName);
         }
          }
         if(bse_Components.Comp_Date_IsChanged)
         {
         if (bse_Components.Comp_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Comp_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Comp_Date", bse_Components.Comp_Date);
         }
          }
         if(bse_Components.AuditStat_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.AuditStat))
         {
            idb.AddParameter("@AuditStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditStat", bse_Components.AuditStat);
         }
          }
         if(bse_Components.AuditCurAudit_IsChanged)
         {
         if (string.IsNullOrEmpty(bse_Components.AuditCurAudit))
         {
            idb.AddParameter("@AuditCurAudit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@AuditCurAudit", bse_Components.AuditCurAudit);
         }
          }
         if(bse_Components.Stat_IsChanged)
         {
         if (bse_Components.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", bse_Components.Stat);
         }
          }
         if(bse_Components.CreateTime_IsChanged)
         {
         if (bse_Components.CreateTime == DateTime.MinValue)
         {
            idb.AddParameter("@CreateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateTime", bse_Components.CreateTime);
         }
          }
         if(bse_Components.UpdateTime_IsChanged)
         {
         if (bse_Components.UpdateTime == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateTime", bse_Components.UpdateTime);
         }
          }
         if(bse_Components.DeleteTime_IsChanged)
         {
         if (bse_Components.DeleteTime == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteTime", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteTime", bse_Components.DeleteTime);
         }
          }

         idb.AddParameter("@Comp_ID", bse_Components.Comp_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除Bse_Components对象(即:一条记录
      /// </summary>
      public int Delete(decimal comp_ID)
      {
         string sql = "DELETE Bse_Components WHERE 1=1  AND Comp_ID=@Comp_ID ";
         idb.AddParameter("@Comp_ID", comp_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的Bse_Components对象(即:一条记录
      /// </summary>
      public Bse_Components GetByKey(decimal comp_ID)
      {
         Bse_Components bse_Components = new Bse_Components();
         string sql = "SELECT  Comp_ID,Comp_Code,Comp_CCode,Comp_Name,Comp_Type,Comp_TypeName,Comp_Cate,Comp_CateName,Comp_Customer,Comp_CustomerName,Comp_Stat,Comp_Content,Comp_Creator,Comp_CreatorName,Comp_Date,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Components WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Comp_ID=@Comp_ID ";
         idb.AddParameter("@Comp_ID", comp_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Comp_ID"] != DBNull.Value) bse_Components.Comp_ID = Convert.ToDecimal(dr["Comp_ID"]);
            if (dr["Comp_Code"] != DBNull.Value) bse_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
            if (dr["Comp_CCode"] != DBNull.Value) bse_Components.Comp_CCode = Convert.ToString(dr["Comp_CCode"]);
            if (dr["Comp_Name"] != DBNull.Value) bse_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
            if (dr["Comp_Type"] != DBNull.Value) bse_Components.Comp_Type = Convert.ToString(dr["Comp_Type"]);
            if (dr["Comp_TypeName"] != DBNull.Value) bse_Components.Comp_TypeName = Convert.ToString(dr["Comp_TypeName"]);
            if (dr["Comp_Cate"] != DBNull.Value) bse_Components.Comp_Cate = Convert.ToString(dr["Comp_Cate"]);
            if (dr["Comp_CateName"] != DBNull.Value) bse_Components.Comp_CateName = Convert.ToString(dr["Comp_CateName"]);
            if (dr["Comp_Customer"] != DBNull.Value) bse_Components.Comp_Customer = Convert.ToString(dr["Comp_Customer"]);
            if (dr["Comp_CustomerName"] != DBNull.Value) bse_Components.Comp_CustomerName = Convert.ToString(dr["Comp_CustomerName"]);
            if (dr["Comp_Stat"] != DBNull.Value) bse_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
            if (dr["Comp_Content"] != DBNull.Value) bse_Components.Comp_Content = Convert.ToString(dr["Comp_Content"]);
            if (dr["Comp_Creator"] != DBNull.Value) bse_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
            if (dr["Comp_CreatorName"] != DBNull.Value) bse_Components.Comp_CreatorName = Convert.ToString(dr["Comp_CreatorName"]);
            if (dr["Comp_Date"] != DBNull.Value) bse_Components.Comp_Date = Convert.ToDateTime(dr["Comp_Date"]);
            if (dr["AuditStat"] != DBNull.Value) bse_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) bse_Components.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Components.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Components.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Components.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return bse_Components;
      }
      /// <summary>
      /// 获取指定的Bse_Components对象集合
      /// </summary>
      public List<Bse_Components> GetListByWhere(string strCondition)
      {
         List<Bse_Components> ret = new List<Bse_Components>();
         string sql = "SELECT  Comp_ID,Comp_Code,Comp_CCode,Comp_Name,Comp_Type,Comp_TypeName,Comp_Cate,Comp_CateName,Comp_Customer,Comp_CustomerName,Comp_Stat,Comp_Content,Comp_Creator,Comp_CreatorName,Comp_Date,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Components WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Bse_Components bse_Components = new Bse_Components();
            if (dr["Comp_ID"] != DBNull.Value) bse_Components.Comp_ID = Convert.ToDecimal(dr["Comp_ID"]);
            if (dr["Comp_Code"] != DBNull.Value) bse_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
            if (dr["Comp_CCode"] != DBNull.Value) bse_Components.Comp_CCode = Convert.ToString(dr["Comp_CCode"]);
            if (dr["Comp_Name"] != DBNull.Value) bse_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
            if (dr["Comp_Type"] != DBNull.Value) bse_Components.Comp_Type = Convert.ToString(dr["Comp_Type"]);
            if (dr["Comp_TypeName"] != DBNull.Value) bse_Components.Comp_TypeName = Convert.ToString(dr["Comp_TypeName"]);
            if (dr["Comp_Cate"] != DBNull.Value) bse_Components.Comp_Cate = Convert.ToString(dr["Comp_Cate"]);
            if (dr["Comp_CateName"] != DBNull.Value) bse_Components.Comp_CateName = Convert.ToString(dr["Comp_CateName"]);
            if (dr["Comp_Customer"] != DBNull.Value) bse_Components.Comp_Customer = Convert.ToString(dr["Comp_Customer"]);
            if (dr["Comp_CustomerName"] != DBNull.Value) bse_Components.Comp_CustomerName = Convert.ToString(dr["Comp_CustomerName"]);
            if (dr["Comp_Stat"] != DBNull.Value) bse_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
            if (dr["Comp_Content"] != DBNull.Value) bse_Components.Comp_Content = Convert.ToString(dr["Comp_Content"]);
            if (dr["Comp_Creator"] != DBNull.Value) bse_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
            if (dr["Comp_CreatorName"] != DBNull.Value) bse_Components.Comp_CreatorName = Convert.ToString(dr["Comp_CreatorName"]);
            if (dr["Comp_Date"] != DBNull.Value) bse_Components.Comp_Date = Convert.ToDateTime(dr["Comp_Date"]);
            if (dr["AuditStat"] != DBNull.Value) bse_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) bse_Components.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Components.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Components.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Components.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Components);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Bse_Components对象(即:一条记录
      /// </summary>
      public List<Bse_Components> GetAll()
      {
         List<Bse_Components> ret = new List<Bse_Components>();
         string sql = "SELECT  Comp_ID,Comp_Code,Comp_CCode,Comp_Name,Comp_Type,Comp_TypeName,Comp_Cate,Comp_CateName,Comp_Customer,Comp_CustomerName,Comp_Stat,Comp_Content,Comp_Creator,Comp_CreatorName,Comp_Date,AuditStat,AuditCurAudit,Stat,CreateTime,UpdateTime,DeleteTime FROM Bse_Components where 1=1 AND ((Stat is null) or (Stat=0) ) order by Comp_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Bse_Components bse_Components = new Bse_Components();
            if (dr["Comp_ID"] != DBNull.Value) bse_Components.Comp_ID = Convert.ToDecimal(dr["Comp_ID"]);
            if (dr["Comp_Code"] != DBNull.Value) bse_Components.Comp_Code = Convert.ToString(dr["Comp_Code"]);
            if (dr["Comp_CCode"] != DBNull.Value) bse_Components.Comp_CCode = Convert.ToString(dr["Comp_CCode"]);
            if (dr["Comp_Name"] != DBNull.Value) bse_Components.Comp_Name = Convert.ToString(dr["Comp_Name"]);
            if (dr["Comp_Type"] != DBNull.Value) bse_Components.Comp_Type = Convert.ToString(dr["Comp_Type"]);
            if (dr["Comp_TypeName"] != DBNull.Value) bse_Components.Comp_TypeName = Convert.ToString(dr["Comp_TypeName"]);
            if (dr["Comp_Cate"] != DBNull.Value) bse_Components.Comp_Cate = Convert.ToString(dr["Comp_Cate"]);
            if (dr["Comp_CateName"] != DBNull.Value) bse_Components.Comp_CateName = Convert.ToString(dr["Comp_CateName"]);
            if (dr["Comp_Customer"] != DBNull.Value) bse_Components.Comp_Customer = Convert.ToString(dr["Comp_Customer"]);
            if (dr["Comp_CustomerName"] != DBNull.Value) bse_Components.Comp_CustomerName = Convert.ToString(dr["Comp_CustomerName"]);
            if (dr["Comp_Stat"] != DBNull.Value) bse_Components.Comp_Stat = Convert.ToString(dr["Comp_Stat"]);
            if (dr["Comp_Content"] != DBNull.Value) bse_Components.Comp_Content = Convert.ToString(dr["Comp_Content"]);
            if (dr["Comp_Creator"] != DBNull.Value) bse_Components.Comp_Creator = Convert.ToString(dr["Comp_Creator"]);
            if (dr["Comp_CreatorName"] != DBNull.Value) bse_Components.Comp_CreatorName = Convert.ToString(dr["Comp_CreatorName"]);
            if (dr["Comp_Date"] != DBNull.Value) bse_Components.Comp_Date = Convert.ToDateTime(dr["Comp_Date"]);
            if (dr["AuditStat"] != DBNull.Value) bse_Components.AuditStat = Convert.ToString(dr["AuditStat"]);
            if (dr["AuditCurAudit"] != DBNull.Value) bse_Components.AuditCurAudit = Convert.ToString(dr["AuditCurAudit"]);
            if (dr["Stat"] != DBNull.Value) bse_Components.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateTime"] != DBNull.Value) bse_Components.CreateTime = Convert.ToDateTime(dr["CreateTime"]);
            if (dr["UpdateTime"] != DBNull.Value) bse_Components.UpdateTime = Convert.ToDateTime(dr["UpdateTime"]);
            if (dr["DeleteTime"] != DBNull.Value) bse_Components.DeleteTime = Convert.ToDateTime(dr["DeleteTime"]);
            ret.Add(bse_Components);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
