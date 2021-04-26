using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class ProductDataInitialiser : DropCreateDatabaseAlways<TeamContext>
	{
		protected override void Seed(TeamContext context)
		{
			
			base.Seed(context);
		}
	}
}
