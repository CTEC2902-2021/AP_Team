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

			Team team4 = new Team();
			team3.TeamId = 4;
			team3.Name = "Chelsea";
			team3.Manager = "Thomas Tuchel";
			team3.Draws = 4;
			team3.GoalDiff = 7;
			team3.GoalsAgainst = 22;
			team3.GoalsFor = 11;
			team3.Loss = 4;
			team3.MatchPlayed = 29;
			team3.PLTrophies = 3;
			team3.Points = 51;
			team3.Position = 4;
			team3.Wins = 14;
			context.Teams.Add(team4);

			Team team5 = new Team();
			team3.TeamId = 5;
			team3.Name = "West Ham United";
			team3.Manager = "David Moyes";
			team3.Draws = 4;
			team3.GoalDiff = 7;
			team3.GoalsAgainst = 22;
			team3.GoalsFor = 11;
			team3.Loss = 4;
			team3.MatchPlayed = 29;
			team3.PLTrophies = 3;
			team3.Points = 46;
			team3.Position = 5;
			team3.Wins = 13;
			context.Teams.Add(team5);

			Team team6 = new Team();
			team3.TeamId = 6;
			team3.Name = "Liverpool";
			team3.Manager = "Jürgen Klopp";
			team3.Draws = 4;
			team3.GoalDiff = 7;
			team3.GoalsAgainst = 12;
			team3.GoalsFor = 11;
			team3.Loss = 2;
			team3.MatchPlayed = 18;
			team3.PLTrophies = 3;
			team3.Points = 46;
			team3.Position = 6;
			team3.Wins = 14;
			context.Teams.Add(team6);


			Team team7 = new Team();
			team3.TeamId = 7;
			team3.Name = "Everton";
			team3.Manager = "Carlo Ancelotti";
			team3.Draws = 3;
			team3.GoalDiff = 7;
			team3.GoalsAgainst = 15;
			team3.GoalsFor = 10;
			team3.Loss = 2;
			team3.MatchPlayed = 28;
			team3.PLTrophies = 3;
			team3.Points = 45;
			team3.Position = 7;
			team3.Wins = 13;
			context.Teams.Add(team7);


			Team team8 = new Team();
			team3.TeamId = 8;
			team3.Name = "Tottenham Hotspur";
			team3.Manager = "Ryan Mascon";
			team3.Draws = 5;
			team3.GoalDiff = 3;
			team3.GoalsAgainst = 15;
			team3.GoalsFor = 10;
			team3.Loss = 2;
			team3.MatchPlayed = 28;
			team3.PLTrophies = 3;
			team3.Points = 45;
			team3.Position = 8;
			team3.Wins = 13;
			context.Teams.Add(team8);

			

			Team team10 = new Team();
			team3.TeamId = 10;
			team3.Name = "Arsenal";
			team3.Manager = "Mikel Arteta";
			team3.Draws = 5;
			team3.GoalDiff = 6;
			team3.GoalsAgainst = 10;
			team3.GoalsFor = 10;
			team3.Loss = 2;
			team3.MatchPlayed = 29;
			team3.PLTrophies = 3;
			team3.Points = 41;
			team3.Position = 10;
			team3.Wins = 12;
			context.Teams.Add(team10);

			Team team9 = new Team();
			team3.TeamId = 9;
			team3.Name = "Aston Villa";
			team3.Manager = "Dean Smith";
			team3.Draws = 5;
			team3.GoalDiff = 3;
			team3.GoalsAgainst = 15;
			team3.GoalsFor = 10;
			team3.Loss = 2;
			team3.MatchPlayed = 27;
			team3.PLTrophies = 3;
			team3.Points = 42;
			team3.Position = 9;
			team3.Wins = 12;
			context.Teams.Add(team9);

			base.Seed(context);
		}
	}
}
