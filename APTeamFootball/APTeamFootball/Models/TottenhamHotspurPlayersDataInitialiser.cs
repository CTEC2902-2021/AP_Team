using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
    public class TottenhamHotsputPlayersDataInitialiser : DropCreateDatabaseAlways<TottenhamHotspurPlayersContext>
    {
        protected override void Seed(TottenhamHotspurPlayersContext context)
        {

            TottenhamHotspurPlayers play1 = new TottenhamHotspurPlayers();
            play1.TottenhamHotspurPlayersId = 1;
            play1.Appearances = 34;
            play1.Comments = "From France, 11 Clean Sheets";
            play1.Goals = 0;
            play1.Name = "Hugo Lloris";
            play1.Number = 1;
            play1.Position = "Goalkeeper";
            play1.DOB = Convert.ToDateTime("1986-12-26");

            context.TottenhamHotspurPlayers.Add(play1);

            TottenhamHotspurPlayers play2 = new TottenhamHotspurPlayers();
            play2.TottenhamHotspurPlayersId = 2;
            play2.Appearances = 0;
            play2.Comments = " Born in England ";
            play2.Goals = 0;
            play2.Name = "Joe Hart";
            play2.Number = 12;
            play2.Position = "Goalkeeper";
            play2.DOB = Convert.ToDateTime("1987-04-19");

            context.TottenhamHotspurPlayers.Add(play2);

            TottenhamHotspurPlayers play3 = new TottenhamHotspurPlayers();
            play3.TottenhamHotspurPlayersId = 3;
            play3.Appearances = 0;
            play3.Comments = " From England ";
            play3.Goals = 0;
            play3.Name = "Alfie Whiteman";
            play3.Number = 41;
            play3.Position = "Goalkeeper";
            play3.DOB = Convert.ToDateTime("1998-02-10");

            context.TottenhamHotspurPlayers.Add(play3);

            TottenhamHotspurPlayers play4 = new TottenhamHotspurPlayers();
            play4.TottenhamHotspurPlayersId = 4;
            play4.Appearances = 21;
            play4.Comments = " From Belgium, 8 clean sheets ";
            play4.Goals = 1;
            play4.Name = "Toby Alderweireld";
            play4.Number = 4;
            play4.Position = "Defender";
            play4.DOB = Convert.ToDateTime("1989-03-02");

            context.TottenhamHotspurPlayers.Add(play4);

            TottenhamHotspurPlayers play5 = new TottenhamHotspurPlayers();
            play5.TottenhamHotspurPlayersId = 5;
            play5.Appearances = 18;
            play5.Comments = "Unknown, 4 clean sheets";
            play5.Goals = 2;
            play5.Name = "Serge Aurier";
            play5.Number = 24;
            play5.Position = "Defender";
            play5.DOB = Convert.ToDateTime("1995-09-18");

            context.TottenhamHotspurPlayers.Add(play5);

            TottenhamHotspurPlayers play6 = new TottenhamHotspurPlayers();
            play6.TottenhamHotspurPlayersId = 6;
            play6.Appearances = 17;
            play6.Comments = " Born in Colombia, 4 clean sheets ";
            play6.Goals = 0;
            play6.Name = "Davinson Sánchez";
            play6.Number = 6;
            play6.Position = "Defender";
            play6.DOB = Convert.ToDateTime("1996-06-12");

            context.TottenhamHotspurPlayers.Add(play6);

            TottenhamHotspurPlayers play7 = new TottenhamHotspurPlayers();
            play7.TottenhamHotspurPlayersId = 7;
            play7.Appearances = 20;
            play7.Comments = "From Wales, 4 clean sheets ";
            play7.Goals = 0;
            play7.Name = "Ben Davies";
            play7.Number = 33;
            play7.Position = "Midfielder";
            play7.DOB = Convert.ToDateTime("1993-04-24");

            context.TottenhamHotspurPlayers.Add(play7);

            TottenhamHotspurPlayers play8 = new TottenhamHotspurPlayers();
            play8.TottenhamHotspurPlayersId = 8;
            play8.Appearances = 4;
            play8.Comments = "From England";
            play8.Goals = 0;
            play8.Name = "Japhet Tanganga";
            play8.Number = 25;
            play8.Position = "Midfielder";
            play8.DOB = Convert.ToDateTime("1999-03-31");

            context.TottenhamHotspurPlayers.Add(play8);

            TottenhamHotspurPlayers play9 = new TottenhamHotspurPlayers();
            play9.TottenhamHotspurPlayersId = 9;
            play9.Appearances = 15;
            play9.Comments = "From Ireland";
            play9.Goals = 0;
            play9.Name = "Matt Doherty";
            play9.Number = 0;
            play9.Position = "Midfielder";
            play9.DOB = Convert.ToDateTime("1992-01-16");

            context.TottenhamHotspurPlayers.Add(play9);

            TottenhamHotspurPlayers play10 = new TottenhamHotspurPlayers();
            play10.TottenhamHotspurPlayersId = 10;
            play10.Appearances = 28;
            play10.Comments = "Born in Brazil, 4 Assists";
            play10.Goals = 3;
            play10.Name = "Lucas Moura";
            play10.Number = 27;
            play10.Position = "Forward";
            play10.DOB = Convert.ToDateTime("1992-08-13");

            context.TottenhamHotspurPlayers.Add(play10);

            TottenhamHotspurPlayers play11 = new TottenhamHotspurPlayers();
            play11.TottenhamHotspurPlayersId = 11;
            play11.Appearances = 33;
            play11.Comments = "Born in South Korea, 10 Assists";
            play11.Goals = 16;
            play11.Name = "Son Heung-Min";
            play11.Number = 7;
            play11.Position = "Forward";
            play11.DOB = Convert.ToDateTime("1992-07-08");

            context.TottenhamHotspurPlayers.Add(play11);

            TottenhamHotspurPlayers play12 = new TottenhamHotspurPlayers();
            play12.TottenhamHotspurPlayersId = 12;
            play12.Appearances = 31;
            play12.Comments = "From England, 13 Assists";
            play12.Goals = 21;
            play12.Name = "Harry Kane";
            play12.Number = 10;
            play12.Position = "Forward";
            play12.DOB = Convert.ToDateTime("1993-07-28");

            context.TottenhamHotspurPlayers.Add(play12);

            base.Seed(context);
        }
    }
}