using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class LeicesterPlayersDataInitialiser : DropCreateDatabaseAlways<LeicesterPlayersContext>
	{
		protected override void Seed(LeicesterPlayersContext context)
		{

			//seed data to display on the website
			LeicesterPlayers Player1 = new LeicesterPlayers();
			Player1.LeicesterPlayersId = 1;
			Player1.Appearances = 34;
			Player1.Comments = "From Denmark, 0 Assists";
			Player1.DOB = Convert.ToDateTime("1986-07-11");
			Player1.Goals = 0;
			Player1.Name = "Kasper Schmeichel";
			Player1.Number = 1;
			Player1.Position = "Goalkeeper";
			context.LeicesterPlayers.Add(Player1);

			LeicesterPlayers Player2 = new LeicesterPlayers();
			Player2.LeicesterPlayersId = 2;
			Player2.Appearances = 0;
			Player2.Comments = "From Wales,  0 Assists";
			Player2.DOB = Convert.ToDateTime("1983-01-27");
			Player2.Goals = 0;
			Player2.Name = "Danny Ward";
			Player2.Number = 12;
			Player2.Position = "Goalkeeper";
			context.LeicesterPlayers.Add(Player2);

			LeicesterPlayers Player3 = new LeicesterPlayers();
			Player3.LeicesterPlayersId = 2;
			Player3.Appearances = 7;
			Player3.Comments = "From Poland, 0 Assists";
			Player3.DOB = Convert.ToDateTime("1987-02-22");
			Player3.Goals = 0;
			Player3.Name = "Jakub Stolarczyk";
			Player3.Number = 51;
			Player3.Position = "Goalkeeper";
			context.LeicesterPlayers.Add(Player3);

			LeicesterPlayers Player4 = new LeicesterPlayers();
			Player4.LeicesterPlayersId = 4;
			Player4.Appearances = 27;
			Player4.Comments = "From England, 2 Assists";
			Player4.DOB = Convert.ToDateTime("1994-02-18");
			Player4.Goals = 2;
			Player4.Name = "James Justin";
			Player4.Number = 9;
			Player4.Position = "Defender";
			context.LeicesterPlayers.Add(Player4);

			LeicesterPlayers Player5 = new LeicesterPlayers();
			Player5.LeicesterPlayersId = 5;
			Player5.Appearances = 19;
			Player5.Comments = "From Turkey, 1 Assists";
			Player5.DOB = Convert.ToDateTime("1996-05-28");
			Player5.Goals = 0;
			Player5.Name = "Çaglar Söyüncü";
			Player5.Number = 1;
			Player5.Position = "Defender";
			context.LeicesterPlayers.Add(Player5);

			LeicesterPlayers Player6 = new LeicesterPlayers();
			Player6.LeicesterPlayersId = 6;
			Player6.Appearances = 3;
			Player6.Comments = "From Jamaica, 0 Assists";
			Player6.DOB = Convert.ToDateTime("1994-05-28");
			Player6.Goals = 0;
			Player6.Name = "Wes Morgan";
			Player6.Number = 5;
			Player6.Position = "Defender";
			context.LeicesterPlayers.Add(Player6);


			LeicesterPlayers Player7 = new LeicesterPlayers();
			Player7.LeicesterPlayersId = 7;
			Player7.Appearances = 34;
			Player7.Comments = "From Belgium, 3 Assists";
			Player7.DOB = Convert.ToDateTime("1989-06-28");
			Player7.Goals = 6;
			Player7.Name = "Youri Tielemans";
			Player7.Number = 8;
			Player7.Position = "Midfielder";
			context.LeicesterPlayers.Add(Player7);


			LeicesterPlayers Player8 = new LeicesterPlayers();
			Player8.LeicesterPlayersId = 8;
			Player8.Appearances = 7;
			Player8.Comments = "From England, 5 Assists";
			Player8.DOB = Convert.ToDateTime("1994-08-10");
			Player8.Goals = 8;
			Player8.Name = "James Maddison";
			Player8.Number = 10;
			Player8.Position = "Midfielder";
			context.LeicesterPlayers.Add(Player8);

			LeicesterPlayers Player9 = new LeicesterPlayers();
			Player9.LeicesterPlayersId = 9;
			Player9.Appearances = 27;
			Player9.Comments = "From England, 4 Assists";
			Player9.DOB = Convert.ToDateTime("1985-05-04");
			Player9.Goals = 0;
			Player9.Name = "Marc Albrighton";
			Player9.Number = 11;
			Player9.Position = "Midfielder";
			context.LeicesterPlayers.Add(Player9);


			LeicesterPlayers Player10 = new LeicesterPlayers();
			Player10.LeicesterPlayersId = 10;
			Player10.Appearances = 30;
			Player10.Comments = "From France, 8 Assists";
			Player10.DOB = Convert.ToDateTime("1997-04-03");
			Player10.Goals = 13;
			Player10.Name = "Jamie Vardy";
			Player10.Number = 9;
			Player10.Position = "Forward";
			context.LeicesterPlayers.Add(Player10);

			LeicesterPlayers Player11 = new LeicesterPlayers();
			Player11.LeicesterPlayersId = 11;
			Player11.Appearances = 21;
			Player11.Comments = "From Nigeria, 2 Assists";
			Player11.DOB = Convert.ToDateTime("1988-06-02");
			Player11.Goals = 10;
			Player11.Name = "Kelechi Iheanacho";
			Player11.Number = 14;
			Player11.Position = "Forward";
			context.LeicesterPlayers.Add(Player11);

			LeicesterPlayers Player12 = new LeicesterPlayers();
			Player12.LeicesterPlayersId = 12;
			Player12.Appearances = 13;
			Player12.Comments = "From Spain, 13 Assists";
			Player12.DOB = Convert.ToDateTime("1991-02-21");
			Player12.Goals = 43;
			Player12.Name = "Ayoze Pérez";
			Player12.Number = 17;
			Player12.Position = "Forward";
			context.LeicesterPlayers.Add(Player12);

			base.Seed(context);

		}
	}
}