using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace APTeamFootball.Models
{
    public class PlayersDataInitialiser : DropCreateDatabaseAlways<PlayersContext>
    {
        protected override void Seed(PlayersContext context)
        {

            Players play1 = new Players();
            play1.PlayersId = 1;
            play1.Appearances = 31;
            play1.Comments = " German nationality";
            play1.Goals = 0;
            play1.Name = "Bernd Leno";
            play1.Number = 1;
            play1.Position = "Goalkeeper";
            play1.DOB = Convert.ToDateTime("1992-03-04");

            context.Players.Add(play1);

            Players play2 = new Players();
            play2.PlayersId = 2;
            play2.Appearances = 1;
            play2.Comments = " Born in Iceland";
            play2.Goals = 0;
            play2.Name = "Rúnar Alex Rúnarsson";
            play2.Number = 13;
            play2.Position = "Goalkeeper";
            play2.DOB = Convert.ToDateTime("1995-02-18");

            context.Players.Add(play2);

            Players play3 = new Players();
            play3.PlayersId = 3;
            play3.Appearances = 2;
            play3.Comments = " Born in Australia";
            play3.Goals = 0;
            play3.Name = "Mat Ryan";
            play3.Number = 33;
            play3.Position = "Goalkeeper";
            play3.DOB = Convert.ToDateTime("1992-04-08");

            context.Players.Add(play3);

            Players play4 = new Players();
            play4.PlayersId = 4;
            play4.Appearances = 23;
            play4.Comments = " Spanish nationality";
            play4.Goals = 1;
            play4.Name = "Héctor Bellerín";
            play4.Number = 2;
            play4.Position = "Defender";
            play4.DOB = Convert.ToDateTime("1995-03-19");

            context.Players.Add(play4);

            Players play5 = new Players();
            play5.PlayersId = 5;
            play5.Appearances = 23;
            play5.Comments = " From Scotland";
            play5.Goals = 1;
            play5.Name = "Kieran Tierney";
            play5.Number = 3;
            play5.Position = "Defender";
            play5.DOB = Convert.ToDateTime("1997-06-05");

            context.Players.Add(play5);

            Players play6 = new Players();
            play6.PlayersId = 6;
            play6.Appearances = 26;
            play6.Comments = " From England";
            play6.Goals = 0;
            play6.Name = "Rob Holding";
            play6.Number = 16;
            play6.Position = "Defender";
            play6.DOB = Convert.ToDateTime("1995-09-20");

            context.Players.Add(play6);

            Players play7 = new Players();
            play7.PlayersId = 7;
            play7.Appearances = 19;
            play7.Comments = "Born in Egypt";
            play7.Goals = 0;
            play7.Name = "Mohamed Elneny";
            play7.Number = 25;
            play7.Position = "Midfielder";
            play7.DOB = Convert.ToDateTime("1992-07-11");

            context.Players.Add(play7);

            Players play8 = new Players();
            play8.PlayersId = 8;
            play8.Appearances = 16;
            play8.Comments = "Born in England, 4 Assists";
            play8.Goals = 0;
            play8.Name = "Emile Smith Rowe";
            play8.Number = 32;
            play8.Position = "Midfielder";
            play8.DOB = Convert.ToDateTime("2000-07-28");

            context.Players.Add(play8);

            Players play9 = new Players();
            play9.PlayersId = 9;
            play9.Appearances = 28;
            play9.Comments = "From Switzerland, 2 Assists";
            play9.Goals = 1;
            play9.Name = "Granit Xhaka";
            play9.Number = 34;
            play9.Position = "Midfielder";
            play9.DOB = Convert.ToDateTime("1992-09-27");

            context.Players.Add(play9);

            Players play10 = new Players();
            play10.PlayersId = 10;
            play10.Appearances = 28;
            play10.Comments = "Born in France, 2 Assists";
            play10.Goals = 13;
            play10.Name = "Alexandre Lacazette";
            play10.Number = 9;
            play10.Position = "Forward";
            play10.DOB = Convert.ToDateTime("1991-05-28");

            context.Players.Add(play10);

            Players play11 = new Players();
            play11.PlayersId = 11;
            play11.Appearances = 25;
            play11.Comments = "Born in Gabon, 1 Assist";
            play11.Goals = 9;
            play11.Name = "Pierre-Emerick Aubameyang";
            play11.Number = 14;
            play11.Position = "Forward";
            play11.DOB = Convert.ToDateTime("1989-06-18");

            context.Players.Add(play11);

            Players play12 = new Players();
            play12.PlayersId = 12;
            play12.Appearances = 25;
            play12.Comments = "Unknown Nationality, 1 Assist";
            play12.Goals = 5;
            play12.Name = "Nicolas Pépé";
            play12.Number = 19;
            play12.Position = "Forward";
            play12.DOB = Convert.ToDateTime("1989-05-20");

            context.Players.Add(play12);

            base.Seed(context);
        }
    }
}