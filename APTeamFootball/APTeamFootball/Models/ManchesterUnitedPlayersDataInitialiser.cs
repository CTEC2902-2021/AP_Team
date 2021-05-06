using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class ManchesterUnitedPlayersDataInitialiser : DropCreateDatabaseAlways<ManchesterUnitedPlayersContext>
	{
		protected override void Seed(ManchesterUnitedPlayersContext context)
		{

			//seed data to display on the website
			ManchesterUnitedPlayers Player1 = new ManchesterUnitedPlayers();
			Player1.ManchesterUnitedPlayersId = 1;
			Player1.Appearances = 24;
			Player1.Comments = "From Spain, 0 Assists";
			Player1.DOB = Convert.ToDateTime("1990-07-11");
			Player1.Goals = 0;
			Player1.Name = "David de Gea";
			Player1.Number = 1;
			Player1.Position = "Goalkeeper";
			context.ManchesterUnitedPlayers.Add(Player1);

			ManchesterUnitedPlayers Player2 = new ManchesterUnitedPlayers();
			Player2.ManchesterUnitedPlayersId = 2;
			Player2.Appearances = 11;
			Player2.Comments = "From England,  0 Assists";
			Player2.DOB = Convert.ToDateTime("1983-01-27");
			Player2.Goals = 0;
			Player2.Name = "Lee Grant";
			Player2.Number = 13;
			Player2.Position = "Goalkeeper";
			context.ManchesterUnitedPlayers.Add(Player2);

			ManchesterUnitedPlayers Player3 = new ManchesterUnitedPlayers();
			Player3.ManchesterUnitedPlayersId = 2;
			Player3.Appearances = 7;
			Player3.Comments = "From Argentina, 0 Assists";
			Player3.DOB = Convert.ToDateTime("1987-02-22");
			Player3.Goals = 0;
			Player3.Name = "Sergio Romero";
			Player3.Number = 22;
			Player3.Position = "Goalkeeper";
			context.ManchesterUnitedPlayers.Add(Player3);

			ManchesterUnitedPlayers Player4 = new ManchesterUnitedPlayers();
			Player4.ManchesterUnitedPlayersId = 4;
			Player4.Appearances = 27;
			Player4.Comments = "From Sweden, 2 Assists";
			Player4.DOB = Convert.ToDateTime("1994-02-18");
			Player4.Goals = 1;
			Player4.Name = "Victor Lindelöf";
			Player4.Number = 6;
			Player4.Position = "Defender";
			context.ManchesterUnitedPlayers.Add(Player4);

			ManchesterUnitedPlayers Player5 = new ManchesterUnitedPlayers();
			Player5.ManchesterUnitedPlayersId = 5;
			Player5.Appearances = 8;
			Player5.Comments = "From England, 30 Assists";
			Player5.DOB = Convert.ToDateTime("1990-05-28");
			Player5.Goals = 0;
			Player5.Name = "Kyle Walker";
			Player5.Number = 3;
			Player5.Position = "Defender";
			context.ManchesterUnitedPlayers.Add(Player5);

			ManchesterUnitedPlayers Player6 = new ManchesterUnitedPlayers();
			Player6.ManchesterUnitedPlayersId = 6;
			Player6.Appearances = 0;
			Player6.Comments = "From England, 0 Assists";
			Player6.DOB = Convert.ToDateTime("1994-05-28");
			Player6.Goals = 0;
			Player6.Name = "Philip Jones";
			Player6.Number = 4;
			Player6.Position = "Defender";
			context.ManchesterUnitedPlayers.Add(Player6);


			ManchesterUnitedPlayers Player7 = new ManchesterUnitedPlayers();
			Player7.ManchesterUnitedPlayersId = 7;
			Player7.Appearances = 24;
			Player7.Comments = "From France, 3 Assists";
			Player7.DOB = Convert.ToDateTime("1989-06-28");
			Player7.Goals = 3;
			Player7.Name = "Paul Pogba";
			Player7.Number = 6;
			Player7.Position = "Midfielder";
			context.ManchesterUnitedPlayers.Add(Player7);


			ManchesterUnitedPlayers Player8 = new ManchesterUnitedPlayers();
			Player8.ManchesterUnitedPlayersId = 8;
			Player8.Appearances = 7;
			Player8.Comments = "From Spain, 2 Assists";
			Player8.DOB = Convert.ToDateTime("1994-08-10");
			Player8.Goals = 0;
			Player8.Name = "Juan Mata";
			Player8.Number = 8;
			Player8.Position = "Midfielder";
			context.ManchesterUnitedPlayers.Add(Player8);

			ManchesterUnitedPlayers Player9 = new ManchesterUnitedPlayers();
			Player9.ManchesterUnitedPlayersId = 9;
			Player9.Appearances = 28;
			Player9.Comments = "From Brazil, 0 Assists";
			Player9.DOB = Convert.ToDateTime("1985-05-04");
			Player9.Goals = 1;
			Player9.Name = "Fred";
			Player9.Number = 17;
			Player9.Position = "Midfielder";
			context.ManchesterUnitedPlayers.Add(Player9);


			ManchesterUnitedPlayers Player10 = new ManchesterUnitedPlayers();
			Player10.ManchesterUnitedPlayersId = 10;
			Player10.Appearances = 22;
			Player10.Comments = "From France, 3 Assists";
			Player10.DOB = Convert.ToDateTime("1997-04-03");
			Player10.Goals = 4;
			Player10.Name = "Anthony Mrtial";
			Player10.Number = 9;
			Player10.Position = "Forward";
			context.ManchesterUnitedPlayers.Add(Player10);

			ManchesterUnitedPlayers Player11 = new ManchesterUnitedPlayers();
			Player11.ManchesterUnitedPlayersId = 11;
			Player11.Appearances = 34;
			Player11.Comments = "From England, 8 Assists";
			Player11.DOB = Convert.ToDateTime("1988-06-02");
			Player11.Goals = 10;
			Player11.Name = "Marcus Rashford";
			Player11.Number = 10;
			Player11.Position = "Forward";
			context.ManchesterUnitedPlayers.Add(Player11);

			ManchesterUnitedPlayers Player12 = new ManchesterUnitedPlayers();
			Player12.ManchesterUnitedPlayersId = 12;
			Player12.Appearances = 22;
			Player12.Comments = "From Uruguay, 2 Assists";
			Player12.DOB = Convert.ToDateTime("1991-02-21");
			Player12.Goals = 8;
			Player12.Name = "Edinson Cavani";
			Player12.Number = 7;
			Player12.Position = "Forward";
			context.ManchesterUnitedPlayers.Add(Player12);

			base.Seed(context);

		}
	}
}