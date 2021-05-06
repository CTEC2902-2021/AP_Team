using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APTeamFootball.Models
{
    public class WestHamUnitedPlayersDataInitialiser : DropCreateDatabaseAlways<WestHamUnitedPlayersContext>
    {
        protected override void Seed(WestHamUnitedPlayersContext context)
        {

            WestHamUnitedPlayers play1 = new WestHamUnitedPlayers();
            play1.WestHamUnitedPlayersId = 1;
            play1.Appearances = 32;
            play1.Comments = "From Poland, 9 Clean Sheets";
            play1.Goals = 0;
            play1.Name = "Lukasz Fabianski";
            play1.Number = 1;
            play1.Position = "Goalkeeper";
            play1.DOB = Convert.ToDateTime("1985-04-18");

            context.WestHamUnitedPlayers.Add(play1);

            WestHamUnitedPlayers play2 = new WestHamUnitedPlayers();
            play2.WestHamUnitedPlayersId = 2;
            play2.Appearances = 0;
            play2.Comments = " Born in England ";
            play2.Goals = 0;
            play2.Name = "David Martin";
            play2.Number = 25;
            play2.Position = "Goalkeeper";
            play2.DOB = Convert.ToDateTime("1986-01-22");

            context.WestHamUnitedPlayers.Add(play2);

            WestHamUnitedPlayers play3 = new WestHamUnitedPlayers();
            play3.WestHamUnitedPlayersId = 3;
            play3.Appearances = 2;
            play3.Comments = " From Ireland ";
            play3.Goals = 0;
            play3.Name = "Darren Randolph";
            play3.Number = 35;
            play3.Position = "Goalkeeper";
            play3.DOB = Convert.ToDateTime("1987-05-12");

            context.WestHamUnitedPlayers.Add(play3);

            WestHamUnitedPlayers play4 = new WestHamUnitedPlayers();
            play4.WestHamUnitedPlayersId = 4;
            play4.Appearances = 32;
            play4.Comments = " From England, 10 clean sheets ";
            play4.Goals = 0;
            play4.Name = "Aaron Cresswell";
            play4.Number = 3;
            play4.Position = "Defender";
            play4.DOB = Convert.ToDateTime("1989-12-15");

            context.WestHamUnitedPlayers.Add(play4);

            WestHamUnitedPlayers play5 = new WestHamUnitedPlayers();
            play5.WestHamUnitedPlayersId = 5;
            play5.Appearances = 18;
            play5.Comments = "From Paraguay, 4 clean sheets";
            play5.Goals = 1;
            play5.Name = "Fabián Balbuena";
            play5.Number = 4;
            play5.Position = "Defender";
            play5.DOB = Convert.ToDateTime("1991-08-23");

            context.WestHamUnitedPlayers.Add(play5);

            WestHamUnitedPlayers play6 = new WestHamUnitedPlayers();
            play6.WestHamUnitedPlayersId = 6;
            play6.Appearances = 25;
            play6.Comments = " Born in Italy, 4 clean sheets ";
            play6.Goals = 2;
            play6.Name = "Angelo Ogbonna";
            play6.Number = 6;
            play6.Position = "Defender";
            play6.DOB = Convert.ToDateTime("1988-05-23");

            context.WestHamUnitedPlayers.Add(play6);

            WestHamUnitedPlayers play7 = new WestHamUnitedPlayers();
            play7.WestHamUnitedPlayersId = 7;
            play7.Appearances = 29;
            play7.Comments = "From Spain, 3 Assists";
            play7.Goals = 3;
            play7.Name = "Pablo Fornals";
            play7.Number = 18;
            play7.Position = "Midfielder";
            play7.DOB = Convert.ToDateTime("1996-02-22");

            context.WestHamUnitedPlayers.Add(play7);

            WestHamUnitedPlayers play8 = new WestHamUnitedPlayers();
            play8.WestHamUnitedPlayersId = 8;
            play8.Appearances = 29;
            play8.Comments = "From England, 1 Assist";
            play8.Goals = 1;
            play8.Name = "Declan Rice";
            play8.Number = 41;
            play8.Position = "Midfielder";
            play8.DOB = Convert.ToDateTime("1999-01-14");

            context.WestHamUnitedPlayers.Add(play8);

            WestHamUnitedPlayers play9 = new WestHamUnitedPlayers();
            play9.WestHamUnitedPlayersId = 9;
            play9.Appearances = 34;
            play9.Comments = "From Poland, 1 Assist";
            play9.Goals = 9;
            play9.Name = "Tomas Soucek";
            play9.Number = 28;
            play9.Position = "Midfielder";
            play9.DOB = Convert.ToDateTime("1992-01-16");

            context.WestHamUnitedPlayers.Add(play9);

            WestHamUnitedPlayers play10 = new WestHamUnitedPlayers();
            play10.WestHamUnitedPlayersId = 10;
            play10.Appearances = 22;
            play10.Comments = "Born in England, 5 Assists";
            play10.Goals = 9;
            play10.Name = "Michail Antonio";
            play10.Number = 30;
            play10.Position = "Forward";
            play10.DOB = Convert.ToDateTime("1990-03-28");

            context.WestHamUnitedPlayers.Add(play10);

            WestHamUnitedPlayers play11 = new WestHamUnitedPlayers();
            play11.WestHamUnitedPlayersId = 11;
            play11.Appearances = 14;
            play11.Comments = "Born in Ukraine, 1 Assist";
            play11.Goals = 0;
            play11.Name = "Andriy Yarmolenko";
            play11.Number = 7;
            play11.Position = "Forward";
            play11.DOB = Convert.ToDateTime("1989-10-23");

            context.WestHamUnitedPlayers.Add(play11);

            WestHamUnitedPlayers play12 = new WestHamUnitedPlayers();
            play12.WestHamUnitedPlayersId = 12;
            play12.Appearances = 34;
            play12.Comments = "From England, 5 Assists";
            play12.Goals = 8;
            play12.Name = "Jarrod Bowen";
            play12.Number = 20;
            play12.Position = "Forward";
            play12.DOB = Convert.ToDateTime("1996-12-20");

            context.WestHamUnitedPlayers.Add(play12);

            base.Seed(context);
        }
    }
}