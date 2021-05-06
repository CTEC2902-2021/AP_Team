using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using APTeamFootball.Models;



namespace APTeamFootball
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			
			AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(new PlayersDataInitialiser());
			Database.SetInitializer(new TeamDataInitialiser());
			Database.SetInitializer(new ManchasterCityPlayersDataInitialiser());
            Database.SetInitializer(new AstonVillaPlayersDataInitialiser());
            Database.SetInitializer(new TottenhamHotsputPlayersDataInitialiser());
            Database.SetInitializer(new EvertonPlayersDataInitialiser());
            Database.SetInitializer(new LiverpoolPlayersDataInitialiser());
            Database.SetInitializer(new WestHamUnitedPlayersDataInitialiser());
        }
    }
}
