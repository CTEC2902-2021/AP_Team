using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
    public class EvertonPlayersDataInitialiser : DropCreateDatabaseAlways<EvertonPlayersContext>
    {
        protected override void Seed(EvertonPlayersContext context)
        {

            EvertonPlayers play1 = new EvertonPlayers();
            play1.EvertonPlayersId = 1;
            play1.Appearances = 26;
            play1.Comments = " Born in England, 7 clean sheets ";
            play1.Goals = 0;
            play1.Name = "Jordan Pickford";
            play1.Number = 1;
            play1.Position = "Goalkeeper";
            play1.DOB = Convert.ToDateTime("1994-03-07");

            context.EvertonPlayers.Add(play1);

            EvertonPlayers play2 = new EvertonPlayers();
            play2.EvertonPlayersId = 2;
            play2.Appearances = 0;
            play2.Comments = " Born in Portugal ";
            play2.Goals = 0;
            play2.Name = "Joao Virgínia";
            play2.Number = 31;
            play2.Position = "Goalkeeper";
            play2.DOB = Convert.ToDateTime("1999-10-10");

            context.EvertonPlayers.Add(play2);

            EvertonPlayers play3 = new EvertonPlayers();
            play3.EvertonPlayersId = 3;
            play3.Appearances = 0;
            play3.Comments = " From Sweden, 2 clean sheets";
            play3.Goals = 0;
            play3.Name = "Robin Olsen";
            play3.Number = 33;
            play3.Position = "Goalkeeper";
            play3.DOB = Convert.ToDateTime("1990-01-08");

            context.EvertonPlayers.Add(play3);

            EvertonPlayers play4 = new EvertonPlayers();
            play4.EvertonPlayersId = 4;
            play4.Appearances = 30;
            play4.Comments = " From England, 7 clean sheets ";
            play4.Goals = 3;
            play4.Name = "Michael Keane";
            play4.Number = 5;
            play4.Position = "Defender";
            play4.DOB = Convert.ToDateTime("1997-10-23");

            context.EvertonPlayers.Add(play4);

            EvertonPlayers play5 = new EvertonPlayers();
            play5.EvertonPlayersId = 5;
            play5.Appearances = 25;
            play5.Comments = " From France, 6 clean sheets";
            play5.Goals = 0;
            play5.Name = "Lucas Digne";
            play5.Number = 12;
            play5.Position = "Defender";
            play5.DOB = Convert.ToDateTime("1993-07-20");

            context.EvertonPlayers.Add(play5);

            EvertonPlayers play6 = new EvertonPlayers();
            play6.EvertonPlayersId = 6;
            play6.Appearances = 22;
            play6.Comments = "Born in Colombia, 4 clean sheets";
            play6.Goals = 2;
            play6.Name = "Yerry Mina";
            play6.Number = 13;
            play6.Position = "Defender";
            play6.DOB = Convert.ToDateTime("1994-09-23");

            context.EvertonPlayers.Add(play6);

            EvertonPlayers play7 = new EvertonPlayers();
            play7.EvertonPlayersId = 7;
            play7.Appearances = 25;
            play7.Comments = "Born in Portugal, 1 Assist ";
            play7.Goals = 0;
            play7.Name = "André Gomes";
            play7.Number = 6;
            play7.Position = "Midfielder";
            play7.DOB = Convert.ToDateTime("1993-07-30");

            context.EvertonPlayers.Add(play7);

            EvertonPlayers play8 = new EvertonPlayers();
            play8.EvertonPlayersId = 8;
            play8.Appearances = 22;
            play8.Comments = "From England, 1 Assist";
            play8.Goals = 0;
            play8.Name = "Tom Davies";
            play8.Number = 26;
            play8.Position = "Midfielder";
            play8.DOB = Convert.ToDateTime("1998-06-30");

            context.EvertonPlayers.Add(play8);

            EvertonPlayers play9 = new EvertonPlayers();
            play9.EvertonPlayersId = 9;
            play9.Appearances = 19;
            play9.Comments = "From Colombia, 4 Assists";
            play9.Goals = 6;
            play9.Name = "James Rodríguez";
            play9.Number = 19;
            play9.Position = "Midfielder";
            play9.DOB = Convert.ToDateTime("1991-07-12");

            context.EvertonPlayers.Add(play9);

            EvertonPlayers play10 = new EvertonPlayers();
            play10.EvertonPlayersId = 10;
            play10.Appearances = 29;
            play10.Comments = "Born in Brazil, 3 Assists";
            play10.Goals = 6;
            play10.Name = "Richarlison";
            play10.Number = 7;
            play10.Position = "Forward";
            play10.DOB = Convert.ToDateTime("1997-05-10");

            context.EvertonPlayers.Add(play10);

            EvertonPlayers play11 = new EvertonPlayers();
            play11.EvertonPlayersId = 11;
            play11.Appearances = 28;
            play11.Comments = "Born in England";
            play11.Goals = 15;
            play11.Name = "Dominic Calvert-Lewin";
            play11.Number = 9;
            play11.Position = "Forward";
            play11.DOB = Convert.ToDateTime("1997-03-16");

            context.EvertonPlayers.Add(play11);

            EvertonPlayers play12 = new EvertonPlayers();
            play12.EvertonPlayersId = 12;
            play12.Appearances = 28;
            play12.Comments = "From Nigeria, 2 Assists";
            play12.Goals = 1;
            play12.Name = "Alex Iwobi";
            play12.Number = 17;
            play12.Position = "Forward";
            play12.DOB = Convert.ToDateTime("1996-05-03");

            context.EvertonPlayers.Add(play12);

            base.Seed(context);
        }
    }
}