using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;

namespace QX.ERP.DAL
{
   [Serializable]
   public partial class ADOSD_Customer
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加SD_Customer对象(即:一条记录)
      /// </summary>
      public int Add(SD_Customer sD_Customer)
      {
         string sql = "INSERT INTO SD_Customer (Cust_Code,Cust_Name,Cust_Addr,Cust_Contact,Cust_COwner,Cust_CTel,Cust_CMobile,Cust_CMail,Cust_TypeCode,Cust_TypeName,Cust_Owner,Cust_Date,Stat,Cust_Type) VALUES (@Cust_Code,@Cust_Name,@Cust_Addr,@Cust_Contact,@Cust_COwner,@Cust_CTel,@Cust_CMobile,@Cust_CMail,@Cust_TypeCode,@Cust_TypeName,@Cust_Owner,@Cust_Date,@Stat,@Cust_Type)";
         if (string.IsNullOrEmpty(sD_Customer.Cust_Code))
         {
            idb.AddParameter("@Cust_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Code", sD_Customer.Cust_Code);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Name))
         {
            idb.AddParameter("@Cust_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Name", sD_Customer.Cust_Name);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Addr))
         {
            idb.AddParameter("@Cust_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Addr", sD_Customer.Cust_Addr);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Contact))
         {
            idb.AddParameter("@Cust_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Contact", sD_Customer.Cust_Contact);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_COwner))
         {
            idb.AddParameter("@Cust_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_COwner", sD_Customer.Cust_COwner);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_CTel))
         {
            idb.AddParameter("@Cust_CTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CTel", sD_Customer.Cust_CTel);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_CMobile))
         {
            idb.AddParameter("@Cust_CMobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CMobile", sD_Customer.Cust_CMobile);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_CMail))
         {
            idb.AddParameter("@Cust_CMail", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CMail", sD_Customer.Cust_CMail);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_TypeCode))
         {
            idb.AddParameter("@Cust_TypeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_TypeCode", sD_Customer.Cust_TypeCode);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_TypeName))
         {
            idb.AddParameter("@Cust_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_TypeName", sD_Customer.Cust_TypeName);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Owner))
         {
            idb.AddParameter("@Cust_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Owner", sD_Customer.Cust_Owner);
         }
         if (sD_Customer.Cust_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Cust_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Date", sD_Customer.Cust_Date);
         }
         if (sD_Customer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Customer.Stat);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Type))
         {
            idb.AddParameter("@Cust_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Type", sD_Customer.Cust_Type);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加SD_Customer对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(SD_Customer sD_Customer)
      {
         string sql = "INSERT INTO SD_Customer (Cust_Code,Cust_Name,Cust_Addr,Cust_Contact,Cust_COwner,Cust_CTel,Cust_CMobile,Cust_CMail,Cust_TypeCode,Cust_TypeName,Cust_Owner,Cust_Date,Stat,Cust_Type) VALUES (@Cust_Code,@Cust_Name,@Cust_Addr,@Cust_Contact,@Cust_COwner,@Cust_CTel,@Cust_CMobile,@Cust_CMail,@Cust_TypeCode,@Cust_TypeName,@Cust_Owner,@Cust_Date,@Stat,@Cust_Type);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sD_Customer.Cust_Code))
         {
            idb.AddParameter("@Cust_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Code", sD_Customer.Cust_Code);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Name))
         {
            idb.AddParameter("@Cust_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Name", sD_Customer.Cust_Name);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Addr))
         {
            idb.AddParameter("@Cust_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Addr", sD_Customer.Cust_Addr);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Contact))
         {
            idb.AddParameter("@Cust_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Contact", sD_Customer.Cust_Contact);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_COwner))
         {
            idb.AddParameter("@Cust_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_COwner", sD_Customer.Cust_COwner);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_CTel))
         {
            idb.AddParameter("@Cust_CTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CTel", sD_Customer.Cust_CTel);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_CMobile))
         {
            idb.AddParameter("@Cust_CMobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CMobile", sD_Customer.Cust_CMobile);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_CMail))
         {
            idb.AddParameter("@Cust_CMail", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CMail", sD_Customer.Cust_CMail);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_TypeCode))
         {
            idb.AddParameter("@Cust_TypeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_TypeCode", sD_Customer.Cust_TypeCode);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_TypeName))
         {
            idb.AddParameter("@Cust_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_TypeName", sD_Customer.Cust_TypeName);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Owner))
         {
            idb.AddParameter("@Cust_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Owner", sD_Customer.Cust_Owner);
         }
         if (sD_Customer.Cust_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Cust_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Date", sD_Customer.Cust_Date);
         }
         if (sD_Customer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Customer.Stat);
         }
         if (string.IsNullOrEmpty(sD_Customer.Cust_Type))
         {
            idb.AddParameter("@Cust_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Type", sD_Customer.Cust_Type);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新SD_Customer对象(即:一条记录
      /// </summary>
      public int Update(SD_Customer sD_Customer)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       SD_Customer       SET ");
            if(sD_Customer.Cust_Code_IsChanged){sbParameter.Append("Cust_Code=@Cust_Code, ");}
      if(sD_Customer.Cust_Name_IsChanged){sbParameter.Append("Cust_Name=@Cust_Name, ");}
      if(sD_Customer.Cust_Addr_IsChanged){sbParameter.Append("Cust_Addr=@Cust_Addr, ");}
      if(sD_Customer.Cust_Contact_IsChanged){sbParameter.Append("Cust_Contact=@Cust_Contact, ");}
      if(sD_Customer.Cust_COwner_IsChanged){sbParameter.Append("Cust_COwner=@Cust_COwner, ");}
      if(sD_Customer.Cust_CTel_IsChanged){sbParameter.Append("Cust_CTel=@Cust_CTel, ");}
      if(sD_Customer.Cust_CMobile_IsChanged){sbParameter.Append("Cust_CMobile=@Cust_CMobile, ");}
      if(sD_Customer.Cust_CMail_IsChanged){sbParameter.Append("Cust_CMail=@Cust_CMail, ");}
      if(sD_Customer.Cust_TypeCode_IsChanged){sbParameter.Append("Cust_TypeCode=@Cust_TypeCode, ");}
      if(sD_Customer.Cust_TypeName_IsChanged){sbParameter.Append("Cust_TypeName=@Cust_TypeName, ");}
      if(sD_Customer.Cust_Owner_IsChanged){sbParameter.Append("Cust_Owner=@Cust_Owner, ");}
      if(sD_Customer.Cust_Date_IsChanged){sbParameter.Append("Cust_Date=@Cust_Date, ");}
      if(sD_Customer.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(sD_Customer.Cust_Type_IsChanged){sbParameter.Append("Cust_Type=@Cust_Type ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Cust_ID=@Cust_ID; " );
      string sql=sb.ToString();
         if(sD_Customer.Cust_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_Code))
         {
            idb.AddParameter("@Cust_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Code", sD_Customer.Cust_Code);
         }
          }
         if(sD_Customer.Cust_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_Name))
         {
            idb.AddParameter("@Cust_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Name", sD_Customer.Cust_Name);
         }
          }
         if(sD_Customer.Cust_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_Addr))
         {
            idb.AddParameter("@Cust_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Addr", sD_Customer.Cust_Addr);
         }
          }
         if(sD_Customer.Cust_Contact_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_Contact))
         {
            idb.AddParameter("@Cust_Contact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Contact", sD_Customer.Cust_Contact);
         }
          }
         if(sD_Customer.Cust_COwner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_COwner))
         {
            idb.AddParameter("@Cust_COwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_COwner", sD_Customer.Cust_COwner);
         }
          }
         if(sD_Customer.Cust_CTel_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_CTel))
         {
            idb.AddParameter("@Cust_CTel", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CTel", sD_Customer.Cust_CTel);
         }
          }
         if(sD_Customer.Cust_CMobile_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_CMobile))
         {
            idb.AddParameter("@Cust_CMobile", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CMobile", sD_Customer.Cust_CMobile);
         }
          }
         if(sD_Customer.Cust_CMail_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_CMail))
         {
            idb.AddParameter("@Cust_CMail", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_CMail", sD_Customer.Cust_CMail);
         }
          }
         if(sD_Customer.Cust_TypeCode_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_TypeCode))
         {
            idb.AddParameter("@Cust_TypeCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_TypeCode", sD_Customer.Cust_TypeCode);
         }
          }
         if(sD_Customer.Cust_TypeName_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_TypeName))
         {
            idb.AddParameter("@Cust_TypeName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_TypeName", sD_Customer.Cust_TypeName);
         }
          }
         if(sD_Customer.Cust_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_Owner))
         {
            idb.AddParameter("@Cust_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Owner", sD_Customer.Cust_Owner);
         }
          }
         if(sD_Customer.Cust_Date_IsChanged)
         {
         if (sD_Customer.Cust_Date == DateTime.MinValue)
         {
            idb.AddParameter("@Cust_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Date", sD_Customer.Cust_Date);
         }
          }
         if(sD_Customer.Stat_IsChanged)
         {
         if (sD_Customer.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sD_Customer.Stat);
         }
          }
         if(sD_Customer.Cust_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(sD_Customer.Cust_Type))
         {
            idb.AddParameter("@Cust_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Cust_Type", sD_Customer.Cust_Type);
         }
          }

         idb.AddParameter("@Cust_ID", sD_Customer.Cust_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除SD_Customer对象(即:一条记录
      /// </summary>
      public int Delete(Int64 cust_ID)
      {
         string sql = "DELETE SD_Customer WHERE 1=1  AND Cust_ID=@Cust_ID ";
         idb.AddParameter("@Cust_ID", cust_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的SD_Customer对象(即:一条记录
      /// </summary>
      public SD_Customer GetByKey(Int64 cust_ID)
      {
         SD_Customer sD_Customer = new SD_Customer();
         string sql = "SELECT  Cust_ID,Cust_Code,Cust_Name,Cust_Addr,Cust_Contact,Cust_COwner,Cust_CTel,Cust_CMobile,Cust_CMail,Cust_TypeCode,Cust_TypeName,Cust_Owner,Cust_Date,Stat,Cust_Type FROM SD_Customer WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Cust_ID=@Cust_ID ";
         idb.AddParameter("@Cust_ID", cust_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Cust_ID"] != DBNull.Value) sD_Customer.Cust_ID = Convert.ToInt64(dr["Cust_ID"]);
            if (dr["Cust_Code"] != DBNull.Value) sD_Customer.Cust_Code = Convert.ToString(dr["Cust_Code"]);
            if (dr["Cust_Name"] != DBNull.Value) sD_Customer.Cust_Name = Convert.ToString(dr["Cust_Name"]);
            if (dr["Cust_Addr"] != DBNull.Value) sD_Customer.Cust_Addr = Convert.ToString(dr["Cust_Addr"]);
            if (dr["Cust_Contact"] != DBNull.Value) sD_Customer.Cust_Contact = Convert.ToString(dr["Cust_Contact"]);
            if (dr["Cust_COwner"] != DBNull.Value) sD_Customer.Cust_COwner = Convert.ToString(dr["Cust_COwner"]);
            if (dr["Cust_CTel"] != DBNull.Value) sD_Customer.Cust_CTel = Convert.ToString(dr["Cust_CTel"]);
            if (dr["Cust_CMobile"] != DBNull.Value) sD_Customer.Cust_CMobile = Convert.ToString(dr["Cust_CMobile"]);
            if (dr["Cust_CMail"] != DBNull.Value) sD_Customer.Cust_CMail = Convert.ToString(dr["Cust_CMail"]);
            if (dr["Cust_TypeCode"] != DBNull.Value) sD_Customer.Cust_TypeCode = Convert.ToString(dr["Cust_TypeCode"]);
            if (dr["Cust_TypeName"] != DBNull.Value) sD_Customer.Cust_TypeName = Convert.ToString(dr["Cust_TypeName"]);
            if (dr["Cust_Owner"] != DBNull.Value) sD_Customer.Cust_Owner = Convert.ToString(dr["Cust_Owner"]);
            if (dr["Cust_Date"] != DBNull.Value) sD_Customer.Cust_Date = Convert.ToDateTime(dr["Cust_Date"]);
            if (dr["Stat"] != DBNull.Value) sD_Customer.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Cust_Type"] != DBNull.Value) sD_Customer.Cust_Type = Convert.ToString(dr["Cust_Type"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sD_Customer;
      }
      /// <summary>
      /// 获取指定的SD_Customer对象集合
      /// </summary>
      public List<SD_Customer> GetListByWhere(string strCondition)
      {
         List<SD_Customer> ret = new List<SD_Customer>();
         string sql = "SELECT  Cust_ID,Cust_Code,Cust_Name,Cust_Addr,Cust_Contact,Cust_COwner,Cust_CTel,Cust_CMobile,Cust_CMail,Cust_TypeCode,Cust_TypeName,Cust_Owner,Cust_Date,Stat,Cust_Type FROM SD_Customer WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY Cust_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Customer sD_Customer = new SD_Customer();
            if (dr["Cust_ID"] != DBNull.Value) sD_Customer.Cust_ID = Convert.ToInt64(dr["Cust_ID"]);
            if (dr["Cust_Code"] != DBNull.Value) sD_Customer.Cust_Code = Convert.ToString(dr["Cust_Code"]);
            if (dr["Cust_Name"] != DBNull.Value) sD_Customer.Cust_Name = Convert.ToString(dr["Cust_Name"]);
            if (dr["Cust_Addr"] != DBNull.Value) sD_Customer.Cust_Addr = Convert.ToString(dr["Cust_Addr"]);
            if (dr["Cust_Contact"] != DBNull.Value) sD_Customer.Cust_Contact = Convert.ToString(dr["Cust_Contact"]);
            if (dr["Cust_COwner"] != DBNull.Value) sD_Customer.Cust_COwner = Convert.ToString(dr["Cust_COwner"]);
            if (dr["Cust_CTel"] != DBNull.Value) sD_Customer.Cust_CTel = Convert.ToString(dr["Cust_CTel"]);
            if (dr["Cust_CMobile"] != DBNull.Value) sD_Customer.Cust_CMobile = Convert.ToString(dr["Cust_CMobile"]);
            if (dr["Cust_CMail"] != DBNull.Value) sD_Customer.Cust_CMail = Convert.ToString(dr["Cust_CMail"]);
            if (dr["Cust_TypeCode"] != DBNull.Value) sD_Customer.Cust_TypeCode = Convert.ToString(dr["Cust_TypeCode"]);
            if (dr["Cust_TypeName"] != DBNull.Value) sD_Customer.Cust_TypeName = Convert.ToString(dr["Cust_TypeName"]);
            if (dr["Cust_Owner"] != DBNull.Value) sD_Customer.Cust_Owner = Convert.ToString(dr["Cust_Owner"]);
            if (dr["Cust_Date"] != DBNull.Value) sD_Customer.Cust_Date = Convert.ToDateTime(dr["Cust_Date"]);
            if (dr["Stat"] != DBNull.Value) sD_Customer.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Cust_Type"] != DBNull.Value) sD_Customer.Cust_Type = Convert.ToString(dr["Cust_Type"]);
            ret.Add(sD_Customer);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的SD_Customer对象(即:一条记录
      /// </summary>
      public List<SD_Customer> GetAll()
      {
         List<SD_Customer> ret = new List<SD_Customer>();
         string sql = "SELECT  Cust_ID,Cust_Code,Cust_Name,Cust_Addr,Cust_Contact,Cust_COwner,Cust_CTel,Cust_CMobile,Cust_CMail,Cust_TypeCode,Cust_TypeName,Cust_Owner,Cust_Date,Stat,Cust_Type FROM SD_Customer where 1=1 AND ((Stat is null) or (Stat=0) ) order by Cust_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            SD_Customer sD_Customer = new SD_Customer();
            if (dr["Cust_ID"] != DBNull.Value) sD_Customer.Cust_ID = Convert.ToInt64(dr["Cust_ID"]);
            if (dr["Cust_Code"] != DBNull.Value) sD_Customer.Cust_Code = Convert.ToString(dr["Cust_Code"]);
            if (dr["Cust_Name"] != DBNull.Value) sD_Customer.Cust_Name = Convert.ToString(dr["Cust_Name"]);
            if (dr["Cust_Addr"] != DBNull.Value) sD_Customer.Cust_Addr = Convert.ToString(dr["Cust_Addr"]);
            if (dr["Cust_Contact"] != DBNull.Value) sD_Customer.Cust_Contact = Convert.ToString(dr["Cust_Contact"]);
            if (dr["Cust_COwner"] != DBNull.Value) sD_Customer.Cust_COwner = Convert.ToString(dr["Cust_COwner"]);
            if (dr["Cust_CTel"] != DBNull.Value) sD_Customer.Cust_CTel = Convert.ToString(dr["Cust_CTel"]);
            if (dr["Cust_CMobile"] != DBNull.Value) sD_Customer.Cust_CMobile = Convert.ToString(dr["Cust_CMobile"]);
            if (dr["Cust_CMail"] != DBNull.Value) sD_Customer.Cust_CMail = Convert.ToString(dr["Cust_CMail"]);
            if (dr["Cust_TypeCode"] != DBNull.Value) sD_Customer.Cust_TypeCode = Convert.ToString(dr["Cust_TypeCode"]);
            if (dr["Cust_TypeName"] != DBNull.Value) sD_Customer.Cust_TypeName = Convert.ToString(dr["Cust_TypeName"]);
            if (dr["Cust_Owner"] != DBNull.Value) sD_Customer.Cust_Owner = Convert.ToString(dr["Cust_Owner"]);
            if (dr["Cust_Date"] != DBNull.Value) sD_Customer.Cust_Date = Convert.ToDateTime(dr["Cust_Date"]);
            if (dr["Stat"] != DBNull.Value) sD_Customer.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["Cust_Type"] != DBNull.Value) sD_Customer.Cust_Type = Convert.ToString(dr["Cust_Type"]);
            ret.Add(sD_Customer);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
