using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class ManchasterCityPlayersDataInitialiser : DropCreateDatabaseAlways<ManchasterCityPlayersContext>
	{
		protected override void Seed(ManchasterCityPlayersContext context)
		{

			//seed data to display on the website
			ManchasterCityPlayers Player1 = new ManchasterCityPlayers();
			Player1.ManchasterCityPlayersId = 1;
			Player1.Appearances = 32;
			Player1.Comments = "From Brazil, 2 Assists";
			Player1.DOB = Convert.ToDateTime("1993-08-17");
			Player1.Goals = 0;
			Player1.Name = "Ederson";
			Player1.Number = 31;
			Player1.Position = "Goalkeeper";
			context.ManchasterCityPlayers.Add(Player1);

			ManchasterCityPlayers Player2 = new ManchasterCityPlayers();
			Player2.ManchasterCityPlayersId = 2;
			Player2.Appearances = 1;
			Player2.Comments = "From United States,  0 Assists";
			Player2.DOB = Convert.ToDateTime("1995-04-02");
			Player2.Goals = 0;
			Player2.Name = "Zack Steffen";
			Player2.Number = 13;
			Player2.Position = "Goalkeeper";
			context.ManchasterCityPlayers.Add(Player2);

			ManchasterCityPlayers Player3 = new ManchasterCityPlayers();
			Player3.ManchasterCityPlayersId = 2;
			Player3.Appearances = 145;
			Player3.Comments = "From England, 2 Assists";
			Player3.DOB = Convert.ToDateTime("1985-09-03");
			Player3.Goals = 0;
			Player3.Name = "Scott Carson";
			Player3.Number = 33;
			Player3.Position = "Goalkeeper";
			context.ManchasterCityPlayers.Add(Player3);

			ManchasterCityPlayers Player4 = new ManchasterCityPlayers();
			Player4.ManchasterCityPlayersId = 4;
			Player4.Appearances = 153;
			Player4.Comments = "From Netherlands, 6 Assists";
			Player4.DOB = Convert.ToDateTime("1995-02-18");
			Player4.Goals = 13;
			Player4.Name = "Nathan Aké";
			Player4.Number = 6;
			Player4.Position = "Defender";
			context.ManchasterCityPlayers.Add(Player4);

			ManchasterCityPlayers Player5 = new ManchasterCityPlayers();
			Player5.ManchasterCityPlayersId = 5;
			Player5.Appearances = 153;
			Player5.Comments = "From England, 30 Assists";
			Player5.DOB = Convert.ToDateTime("1990-05-28");
			Player5.Goals = 8;
			Player5.Name = "Kyle Walker";
			Player5.Number = 2;
			Player5.Position = "Defender";
			context.ManchasterCityPlayers.Add(Player5);

			ManchasterCityPlayers Player6 = new ManchasterCityPlayers();
			Player6.ManchasterCityPlayersId = 6;
			Player6.Appearances = 182;
			Player6.Comments = "From England, 0 Assists";
			Player6.DOB = Convert.ToDateTime("1994-05-28");
			Player6.Goals = 5;
			Player6.Name = "John Stones";
			Player6.Number = 5;
			Player6.Position = "Defender";
			context.ManchasterCityPlayers.Add(Player6);


			ManchasterCityPlayers Player7 = new ManchasterCityPlayers();
			Player7.ManchasterCityPlayersId = 7;
			Player7.Appearances = 179;
			Player7.Comments = "From Belgium, 77 Assists";
			Player7.DOB = Convert.ToDateTime("1991-06-28");
			Player7.Goals = 13;
			Player7.Name = "Kevin De Bruyne";
			Player7.Number = 17;
			Player7.Position = "Midfielder";
			context.ManchasterCityPlayers.Add(Player7);


			ManchasterCityPlayers Player8 = new ManchasterCityPlayers();
			Player8.ManchasterCityPlayersId = 8;
			Player8.Appearances = 129;
			Player8.Comments = "From Portugal, 24 Assists";
			Player8.DOB = Convert.ToDateTime("1994-08-10");
			Player8.Goals = 21;
			Player8.Name = "Bernardo Silva";
			Player8.Number = 20;
			Player8.Position = "Midfielder";
			context.ManchasterCityPlayers.Add(Player8);

			ManchasterCityPlayers Player9 = new ManchasterCityPlayers();
			Player9.ManchasterCityPlayersId = 9;
			Player9.Appearances = 242;
			Player9.Comments = "From Brazil, 16 Assists";
			Player9.DOB = Convert.ToDateTime("1985-05-04");
			Player9.Goals = 18;
			Player9.Name = "Fernandinho";
			Player9.Number = 25;
			Player9.Position = "Midfielder";
			context.ManchasterCityPlayers.Add(Player9);


			ManchasterCityPlayers Player10 = new ManchasterCityPlayers();
			Player10.ManchasterCityPlayersId = 10;
			Player10.Appearances = 126;
			Player10.Comments = "From Brazil, 20 Assists";
			Player10.DOB = Convert.ToDateTime("1997-04-03");
			Player10.Goals = 49;
			Player10.Name = "Gabriel Jesus";
			Player10.Number = 9;
			Player10.Position = "Forward";
			context.ManchasterCityPlayers.Add(Player10);

			ManchasterCityPlayers Player11 = new ManchasterCityPlayers();
			Player11.ManchasterCityPlayersId = 11;
			Player11.Appearances = 272;
			Player11.Comments = "From Argentina, 46 Assists";
			Player11.DOB = Convert.ToDateTime("1988-06-02");
			Player11.Goals = 181;
			Player11.Name = "Sergio Agüero";
			Player11.Number = 10;
			Player11.Position = "Forward";
			context.ManchasterCityPlayers.Add(Player11);

			ManchasterCityPlayers Player12 = new ManchasterCityPlayers();
			Player12.ManchasterCityPlayersId = 12;
			Player12.Appearances = 224;
			Player12.Comments = "From Alegeriaa, 44 Assists";
			Player12.DOB = Convert.ToDateTime("1991-02-21");
			Player12.Goals = 66;
			Player12.Name = "Riyad Mahrez";
			Player12.Number = 26;
			Player12.Position = "Forward";
			context.ManchasterCityPlayers.Add(Player12);

			base.Seed(context);

		}
	}
}