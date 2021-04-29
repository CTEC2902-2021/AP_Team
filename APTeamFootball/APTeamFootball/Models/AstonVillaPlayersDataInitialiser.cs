using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
    public class AstonVillaPlayersDataInitialiser: DropCreateDatabaseAlways<AstonVillaPlayersContext>
    {
        protected override void Seed(AstonVillaPlayersContext context)
        {

            AstonVillaPlayers play1 = new AstonVillaPlayers();
            play1.AstonVillaPlayersId = 1;
            play1.Appearances = 32;
            play1.Comments = " Born in Argentina ";
            play1.Goals = 0;
            play1.Name = "Emiliano Martínez";
            play1.Number = 26;
            play1.Position = "Goalkeeper";
            play1.DOB = Convert.ToDateTime("1992-09-02");

            context.AstonVillaPlayers.Add(play1);

            AstonVillaPlayers play2 = new AstonVillaPlayers();
            play2.AstonVillaPlayersId = 2;
            play2.Appearances = 0;
            play2.Comments = " Born in England ";
            play2.Goals = 0;
            play2.Name = "Tom Heaton";
            play2.Number = 1;
            play2.Position = "Goalkeeper";
            play2.DOB = Convert.ToDateTime("1986-04-15");

            context.AstonVillaPlayers.Add(play2);

            AstonVillaPlayers play3 = new AstonVillaPlayers();
            play3.AstonVillaPlayersId = 3;
            play3.Appearances = 0;
            play3.Comments = " From England ";
            play3.Goals = 0;
            play3.Name = "Jed Steer";
            play3.Number = 12;
            play3.Position = "Goalkeeper";
            play3.DOB = Convert.ToDateTime("1992-09-23");

            context.AstonVillaPlayers.Add(play3);

            AstonVillaPlayers play4 = new AstonVillaPlayers();
            play4.AstonVillaPlayersId = 4;
            play4.Appearances = 30;
            play4.Comments = " From England ";
            play4.Goals = 2;
            play4.Name = "Ezi Konsa Ngoyo";
            play4.Number = 4;
            play4.Position = "Defender";
            play4.DOB = Convert.ToDateTime("1997-10-23");

            context.AstonVillaPlayers.Add(play4);

            AstonVillaPlayers play5 = new AstonVillaPlayers();
            play5.AstonVillaPlayersId = 5;
            play5.Appearances = 32;
            play5.Comments = " From England ";
            play5.Goals = 0;
            play5.Name = "Matt Targett";
            play5.Number = 18;
            play5.Position = "Defender";
            play5.DOB = Convert.ToDateTime("1995-09-18");

            context.AstonVillaPlayers.Add(play5);

            AstonVillaPlayers play6 = new AstonVillaPlayers();
            play6.AstonVillaPlayersId = 6;
            play6.Appearances = 0;
            play6.Comments = " Born in Belgium ";
            play6.Goals = 0;
            play6.Name = "Bjorn Engels";
            play6.Number = 22;
            play6.Position = "Defender";
            play6.DOB = Convert.ToDateTime("1994-09-15");

            context.AstonVillaPlayers.Add(play6);

            AstonVillaPlayers play7 = new AstonVillaPlayers();
            play7.AstonVillaPlayersId = 7;
            play7.Appearances = 28;
            play7.Comments = "Born in Brazil, 2 Assists ";
            play7.Goals = 0;
            play7.Name = "Douglas Luiz";
            play7.Number = 6;
            play7.Position = "Midfielder";
            play7.DOB = Convert.ToDateTime("1998-05-09");

            context.AstonVillaPlayers.Add(play7);

            AstonVillaPlayers play8 = new AstonVillaPlayers();
            play8.AstonVillaPlayersId = 8;
            play8.Appearances = 31;
            play8.Comments = "Born in Scotland, 5 Assists";
            play8.Goals = 2;
            play8.Name = "John McGinn";
            play8.Number = 7;
            play8.Position = "Midfielder";
            play8.DOB = Convert.ToDateTime("1994-10-18");

            context.AstonVillaPlayers.Add(play8);

            AstonVillaPlayers play9 = new AstonVillaPlayers();
            play9.AstonVillaPlayersId = 9;
            play9.Appearances = 22;
            play9.Comments = "From England, 10 Assists";
            play9.Goals = 6;
            play9.Name = "Jack Grealish";
            play9.Number = 10;
            play9.Position = "Midfielder";
            play9.DOB = Convert.ToDateTime("1995-09-10");

            context.AstonVillaPlayers.Add(play9);

            AstonVillaPlayers play10 = new AstonVillaPlayers();
            play10.AstonVillaPlayersId = 10;
            play10.Appearances = 11;
            play10.Comments = "Born in England, 1 Assist";
            play10.Goals = 1;
            play10.Name = "Keinan Davis";
            play10.Number = 39;
            play10.Position = "Forward";
            play10.DOB = Convert.ToDateTime("1998-02-13");

            context.AstonVillaPlayers.Add(play10);

            AstonVillaPlayers play11 = new AstonVillaPlayers();
            play11.AstonVillaPlayersId = 11;
            play11.Appearances = 32;
            play11.Comments = "Born in England, 4 Assists";
            play11.Goals = 12;
            play11.Name = "Ollie Watkins";
            play11.Number = 11;
            play11.Position = "Forward";
            play11.DOB = Convert.ToDateTime("1995-12-30");

            context.AstonVillaPlayers.Add(play11);

            AstonVillaPlayers play12 = new AstonVillaPlayers();
            play12.AstonVillaPlayersId = 12;
            play12.Appearances = 30;
            play12.Comments = "From Burkina Faso, 4 Assists";
            play12.Goals = 5;
            play12.Name = "Bertrand Traoré";
            play12.Number = 15;
            play12.Position = "Forward";
            play12.DOB = Convert.ToDateTime("1995-09-06");

            context.AstonVillaPlayers.Add(play12);

            base.Seed(context);
        }
    }
}