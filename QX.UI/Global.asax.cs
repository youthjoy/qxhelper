using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using QX.Config.MvcXmlRouting;
using System.Configuration;
using QX.Log;

namespace QX.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           
            MvcRouteConfigurationSection section =
                (MvcRouteConfigurationSection)ConfigurationManager.GetSection("RouteConfiguration");
            routes.MapRoute(section);

        }

        protected void Application_Start()
        {
            //ModelBinders.Binders.Add(typeof(QX.Model.Bse_Dict), new QX.HtmlHelperLib.ModelBinder.Dict_ModelBinder());

            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);

         

            PlateLog.Init();           
            
        }

    }   
}