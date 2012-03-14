using System;
using System.Collections.Generic;
using System.Text;

namespace QX.ERP.DAL
{
    public class DBOperator
    {
        // Methods
        public static IDBOperator GetInstance()
        {
            string assemblyName = System.Configuration.ConfigurationSettings.AppSettings["ERPassemblyName"];
            string typeName = System.Configuration.ConfigurationSettings.AppSettings["ERPtypeName"];
            IDBOperator db= (IDBOperator)System.Reflection.Assembly.Load(assemblyName).CreateInstance(typeName);
            return db;
        }
    } 

}
