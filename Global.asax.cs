using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace PIN___LAB6
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-1.10.2.min.js",
                DebugPath = "~/Scripts/jquery-1.10.2.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });

            ScriptManager.ScriptResourceMapping.AddDefinition("jquery.ui.combined", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-ui-1.10.2.min.js",
                DebugPath = "~/Scripts/jquery-ui-1.10.2.js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.2/jquery-ui.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.2/jquery-ui.js",
                CdnSupportsSecureConnection = true
            });
            ScriptManager.ScriptResourceMapping.AddDefinition("bootstrap", new ScriptResourceDefinition
            {
                Path = "~/Scripts/bootstrap.min.js",
                DebugPath = "~/Scripts/bootstrap.js",
                CdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js",
                CdnDebugPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.js",
                CdnSupportsSecureConnection = true
            });
        }
    }
}