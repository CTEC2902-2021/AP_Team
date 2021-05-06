using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
	public class ChelseaPlayersDataInitialiser : DropCreateDatabaseAlways<ChelseaPlayersContext>
	{
		protected override void Seed(ChelseaPlayersContext context)
		{

			//seed data to display on the website
			ChelseaPlayers Player1 = new ChelseaPlayers();
			Player1.ChelseaPlayersId = 1;
			Player1.Appearances = 5;
			Player1.Comments = "From Spain, 0 Assists";
			Player1.DOB = Convert.ToDateTime("1986-07-11");
			Player1.Goals = 0;
			Player1.Name = "Kepa Arrizabalaga";
			Player1.Number = 1;
			Player1.Position = "Goalkeeper";
			context.ChelseaPlayers.Add(Player1);

			ChelseaPlayers Player2 = new ChelseaPlayers();
			Player2.ChelseaPlayersId = 2;
			Player2.Appearances =1;
			Player2.Comments = "From Argentina,  0 Assists";
			Player2.DOB = Convert.ToDateTime("1983-01-27");
			Player2.Goals = 0;
			Player2.Name = "Willy Caballero";
			Player2.Number = 13;
			Player2.Position = "Goalkeeper";
			context.ChelseaPlayers.Add(Player2);

			ChelseaPlayers Player3 = new ChelseaPlayers();
			Player3.ChelseaPlayersId = 2;
			Player3.Appearances = 28;
			Player3.Comments = "From Senegal, 0 Assists";
			Player3.DOB = Convert.ToDateTime("1987-02-22");
			Player3.Goals = 0;
			Player3.Name = "Eduardo Mendy";
			Player3.Number = 16;
			Player3.Position = "Goalkeeper";
			context.ChelseaPlayers.Add(Player3);

			ChelseaPlayers Player4 = new ChelseaPlayers();
			Player4.ChelseaPlayersId = 4;
			Player4.Appearances = 12;
			Player4.Comments = "From Spain, 2 Assists";
			Player4.DOB = Convert.ToDateTime("1994-02-18");
			Player4.Goals = 1;
			Player4.Name = "Marcos Alonso";
			Player4.Number = 3;
			Player4.Position = "Defender";
			context.ChelseaPlayers.Add(Player4);

			ChelseaPlayers Player5 = new ChelseaPlayers();
			Player5.ChelseaPlayersId = 5;
			Player5.Appearances = 16;
			Player5.Comments = "From Denmark, 1 Assists";
			Player5.DOB = Convert.ToDateTime("1996-05-28");
			Player5.Goals = 0;
			Player5.Name = "Andreas Christensen";
			Player5.Number = 4;
			Player5.Position = "Defender";
			context.ChelseaPlayers.Add(Player5);

			ChelseaPlayers Player6 = new ChelseaPlayers();
			Player6.ChelseaPlayersId = 6;
			Player6.Appearances = 15;
			Player6.Comments = "From France, 2 Assists";
			Player6.DOB = Convert.ToDateTime("1994-05-28");
			Player6.Goals = 0;
			Player6.Name = "Kurt Zouma";
			Player6.Number = 15;
			Player6.Position = "Defender";
			context.ChelseaPlayers.Add(Player6);


			ChelseaPlayers Player7 = new ChelseaPlayers();
			Player7.ChelseaPlayersId = 7;
			Player7.Appearances = 20;
			Player7.Comments = "From Morocco, 3 Assists";
			Player7.DOB = Convert.ToDateTime("1989-06-28");
			Player7.Goals = 1;
			Player7.Name = "Hakim Ziyech";
			Player7.Number = 22;
			Player7.Position = "Midfielder";
			context.ChelseaPlayers.Add(Player7);


			ChelseaPlayers Player8 = new ChelseaPlayers();
			Player8.ChelseaPlayersId = 8;
			Player8.Appearances = 24;
			Player8.Comments = "From Italy, 1 Assists";
			Player8.DOB = Convert.ToDateTime("1994-08-10");
			Player8.Goals = 6;
			Player8.Name = "Jorginho";
			Player8.Number = 5;
			Player8.Position = "Midfielder";
			context.ChelseaPlayers.Add(Player8);

			ChelseaPlayers Player9 = new ChelseaPlayers();
			Player9.ChelseaPlayersId = 9;
			Player9.Appearances = 28;
			Player9.Comments = "From France, 2 Assists";
			Player9.DOB = Convert.ToDateTime("1985-05-04");
			Player9.Goals = 0;
			Player9.Name = "N'Golo Kanté";
			Player9.Number = 7;
			Player9.Position = "Midfielder";
			context.ChelseaPlayers.Add(Player9);


			ChelseaPlayers Player10 = new ChelseaPlayers();
			Player10.ChelseaPlayersId = 10;
			Player10.Appearances = 15;
			Player10.Comments = "From France, 0 Assists";
			Player10.DOB = Convert.ToDateTime("1997-04-03");
			Player10.Goals = 4;
			Player10.Name = "Olivier Giroud";
			Player10.Number = 18;
			Player10.Position = "Forward";
			context.ChelseaPlayers.Add(Player10);

			ChelseaPlayers Player11 = new ChelseaPlayers();
			Player11.ChelseaPlayersId = 11;
			Player11.Appearances = 32;
			Player11.Comments = "From Germany, 7 Assists";
			Player11.DOB = Convert.ToDateTime("1988-06-02");
			Player11.Goals = 6;
			Player11.Name = "Tim Werner";
			Player11.Number = 11;
			Player11.Position = "Forward";
			context.ChelseaPlayers.Add(Player11);

			ChelseaPlayers Player12 = new ChelseaPlayers();
			Player12.ChelseaPlayersId = 12;
			Player12.Appearances = 22;
			Player12.Comments = "From England, 1 Assists";
			Player12.DOB = Convert.ToDateTime("1991-02-21");
			Player12.Goals = 6;
			Player12.Name = "Tammy Abraham";
			Player12.Number = 9;
			Player12.Position = "Forward";
			context.ChelseaPlayers.Add(Player12);

			base.Seed(context);

		}
	}
}