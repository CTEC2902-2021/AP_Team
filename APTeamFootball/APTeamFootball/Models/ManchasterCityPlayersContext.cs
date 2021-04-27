using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using APTeamFootball.Models; // makes code cleaner -- provides use of models 

namespace APTeamFootball.Models
{
    public class ManchasterCityPlayersContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ManchasterCityPlayersContext() : base("name=ManchasterCityPlayersContext")
        {
        }

		public DbSet<APTeamFootball.Models.ManchasterCityPlayers> ManchasterCityPlayers { get; set; }
	}
}
