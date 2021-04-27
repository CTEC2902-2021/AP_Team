using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class TeamsDataInitialiser : DropCreateDatabaseAlways<TeamContext>
	{
		protected override void Seed(TeamContext context)
		{
			//some seed data 
			Team team1 = new Team();
			team1.TeamId = 1;
			team1.Name = "Manchaster City";
			team1.Manager = "Pep Guardiola";
			team1.Draws = 10;
			team1.GoalDiff = 10;
			team1.GoalsAgainst = 13;
			team1.GoalsFor = 17;
			team1.Loss = 13;
			team1.MatchPlayed = 30;
			team1.PLTrophies = 5;
			team1.Points = 71;
			team1.Position = 1;
			team1.Wins = 22;
			context.Teams.Add(team1);

			Team team2 = new Team();
			team2.TeamId = 2;
			team2.Name = "Manchaster United";
			team2.Manager = "Ole Gunnar Solskjær";
			team2.Draws = 15;
			team2.GoalDiff = 7;
			team2.GoalsAgainst = 17;
			team2.GoalsFor = 15;
			team2.Loss = 10;
			team2.MatchPlayed = 29;
			team2.PLTrophies = 3;
			team2.Points = 57;
			team2.Position = 2;
			team2.Wins = 16;
			context.Teams.Add(team2);

			Team team3 = new Team();
			team3.TeamId = 3;
			team3.Name = "Leicester City";
			team3.Manager = "Brendan Rodgers";
			team3.Draws = 14;
			team3.GoalDiff = 7;
			team3.GoalsAgainst = 12;
			team3.GoalsFor = 9;
			team3.Loss = 4;
			team3.MatchPlayed = 29;
			team3.PLTrophies = 3;
			team3.Points = 56;
			team3.Position = 3;
			team3.Wins = 17;
            context.Teams.Add(team3);

			base.Seed(context);
		}
	}
}
