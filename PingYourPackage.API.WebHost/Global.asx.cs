using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PingYourPackage.API.WebHost
{
    protected void Application_Start(object sender, EventArgs e)
    {
        var config = GlobalConfiguration.Configuration;
        RouteConfig.RegisterRoutes(config);
        WebAPIConfig.Configure(config);
        AutofacWebAPI.Initialize(config);
    }
}