using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APTeamFootball.Models
{
	public class Team
	{
		//virtual properties - this means they can be overridden 

		public virtual int TeamId { get; set; }
		public virtual string Name { get; set; }
		public virtual string Manager { get; set; }
		public virtual int Draws { get; set; }
		public virtual int GoalDiff { get; set; }
		public virtual int GoalsAgainst { get; set; }
		public virtual int GoalsFor { get; set; }
		public virtual int Loss { get; set; }
		public virtual int MatchPlayed { get; set; }
		public virtual int PLTrophies { get; set; }
		public virtual int Points { get; set; }
		public virtual int Position { get; set; }
		public virtual int Wins { get; set; }
	}
}