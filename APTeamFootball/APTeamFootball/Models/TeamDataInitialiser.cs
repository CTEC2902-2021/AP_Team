using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class TeamDataInitialiser : DropCreateDatabaseAlways<TeamContext>
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
			team4.TeamId = 4;
			team4.Name = "Chelsea";
			team4.Manager = "Thomas Tuchel";
			team4.Draws = 4;
			team4.GoalDiff = 7;
			team4.GoalsAgainst = 22;
			team4.GoalsFor = 11;
			team4.Loss = 4;
			team4.MatchPlayed = 29;
			team4.PLTrophies = 3;
			team4.Points = 51;
			team4.Position = 4;
			team4.Wins = 14;
			context.Teams.Add(team4);

			Team team5 = new Team();
			team5.TeamId = 5;
			team5.Name = "West Ham United";
			team5.Manager = "David Moyes";
			team5.Draws = 4;
			team5.GoalDiff = 7;
			team5.GoalsAgainst = 22;
			team5.GoalsFor = 11;
			team5.Loss = 4;
			team5.MatchPlayed = 29;
			team5.PLTrophies = 3;
			team5.Points = 46;
			team5.Position = 5;
			team5.Wins = 13;
			context.Teams.Add(team5);

			Team team6 = new Team();
			team6.TeamId = 6;
			team6.Name = "Liverpool";
			team6.Manager = "Jürgen Klopp";
			team6.Draws = 4;
			team6.GoalDiff = 7;
			team6.GoalsAgainst = 12;
			team6.GoalsFor = 11;
			team6.Loss = 2;
			team6.MatchPlayed = 18;
			team6.PLTrophies = 3;
			team6.Points = 46;
			team6.Position = 6;
			team6.Wins = 14;
			context.Teams.Add(team6);


			Team team7 = new Team();
			team7.TeamId = 7;
			team7.Name = "Everton";
			team7.Manager = "Carlo Ancelotti";
			team7.Draws = 3;
			team7.GoalDiff = 7;
			team7.GoalsAgainst = 15;
			team7.GoalsFor = 10;
			team7.Loss = 2;
			team7.MatchPlayed = 28;
			team7.PLTrophies = 3;
			team7.Points = 45;
			team7.Position = 7;
			team7.Wins = 13;
			context.Teams.Add(team7);


			Team team8 = new Team();
			team8.TeamId = 8;
			team8.Name = "Tottenham Hotspur";
			team8.Manager = "Ryan Mascon";
			team8.Draws = 5;
			team8.GoalDiff = 3;
			team8.GoalsAgainst = 15;
			team8.GoalsFor = 10;
			team8.Loss = 2;
			team8.MatchPlayed = 28;
			team8.PLTrophies = 3;
			team8.Points = 45;
			team8.Position = 8;
			team8.Wins = 13;
			context.Teams.Add(team8);

			Team team9 = new Team();
			team9.TeamId = 9;
			team9.Name = "Aston Villa";
			team9.Manager = "Dean Smith";
			team9.Draws = 5;
			team9.GoalDiff = 3;
			team9.GoalsAgainst = 15;
			team9.GoalsFor = 10;
			team9.Loss = 2;
			team9.MatchPlayed = 27;
			team9.PLTrophies = 3;
			team9.Points = 42;
			team9.Position = 9;
			team9.Wins = 12;
			context.Teams.Add(team9);


			Team team10 = new Team();
			team10.TeamId = 10;
			team10.Name = "Arsenal";
			team10.Manager = "Mikel Arteta";
			team10.Draws = 5;
			team10.GoalDiff = 6;
			team10.GoalsAgainst = 10;
			team10.GoalsFor = 10;
			team10.Loss = 2;
			team10.MatchPlayed = 29;
			team10.PLTrophies = 3;
			team10.Points = 41;
			team10.Position = 10;
			team10.Wins = 12;
			context.Teams.Add(team10);

	
			base.Seed(context);
		}
	}
}