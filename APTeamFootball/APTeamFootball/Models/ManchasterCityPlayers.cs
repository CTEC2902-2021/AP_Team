﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APTeamFootball.Models
{
	public class ManchasterCityPlayers
	{
		
		//virtual properties - this means they can be overridden 

		public virtual int ManchasterCityPlayersId { get; set; }
		public virtual int Appearances { get; set; }
		public virtual string Comments { get; set; }
		public virtual DateTime DOB { get; set; }
		public virtual int Goals { get; set; }
		public virtual string Name { get; set; }
		public virtual int Number { get; set; }
		public virtual string Position { get; set; }

	}
}