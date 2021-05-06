using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APTeamFootball.Models
{
    public class LiverpoolPlayersDataInitialiser : DropCreateDatabaseAlways<LiverpoolPlayersContext>
    {
        protected override void Seed(LiverpoolPlayersContext context)
        {

            LiverpoolPlayers play1 = new LiverpoolPlayers();
            play1.LiverpoolPlayersId = 1;
            play1.Appearances = 29;
            play1.Comments = " From Brazil, 7 clean sheets ";
            play1.Goals = 0;
            play1.Name = "Allison";
            play1.Number = 1;
            play1.Position = "Goalkeeper";
            play1.DOB = Convert.ToDateTime("1992-10-02");

            context.LiverpoolPlayers.Add(play1);

            LiverpoolPlayers play2 = new LiverpoolPlayers();
            play2.LiverpoolPlayersId = 2;
            play2.Appearances = 0;
            play2.Comments = " Born in Spain ";
            play2.Goals = 0;
            play2.Name = "Adrián";
            play2.Number = 13;
            play2.Position = "Goalkeeper";
            play2.DOB = Convert.ToDateTime("1987-01-03");

            context.LiverpoolPlayers.Add(play2);

            LiverpoolPlayers play3 = new LiverpoolPlayers();
            play3.LiverpoolPlayersId = 3;
            play3.Appearances = 0;
            play3.Comments = " From Ireland ";
            play3.Goals = 0;
            play3.Name = "Caoimhin Kelleher";
            play3.Number = 62;
            play3.Position = "Goalkeeper";
            play3.DOB = Convert.ToDateTime("1998-11-23");

            context.LiverpoolPlayers.Add(play3);

            LiverpoolPlayers play4 = new LiverpoolPlayers();
            play4.LiverpoolPlayersId = 4;
            play4.Appearances = 34;
            play4.Comments = " From Scotland, 8 clean sheets ";
            play4.Goals = 1;
            play4.Name = "Andrew Robertson";
            play4.Number = 26;
            play4.Position = "Defender";
            play4.DOB = Convert.ToDateTime("1994-03-11");

            context.LiverpoolPlayers.Add(play4);

            LiverpoolPlayers play5 = new LiverpoolPlayers();
            play5.LiverpoolPlayersId = 5;
            play5.Appearances = 10;
            play5.Comments = " From Cameroon, 3 clean sheets";
            play5.Goals = 1;
            play5.Name = "Joel Matip";
            play5.Number = 32;
            play5.Position = "Defender";
            play5.DOB = Convert.ToDateTime("1991-08-08");

            context.LiverpoolPlayers.Add(play5);

            LiverpoolPlayers play6 = new LiverpoolPlayers();
            play6.LiverpoolPlayersId = 6;
            play6.Appearances = 32;
            play6.Comments = "Born in England, 7 clean sheets";
            play6.Goals = 2;
            play6.Name = "Trent Alexander-Arnold";
            play6.Number = 66;
            play6.Position = "Defender";
            play6.DOB = Convert.ToDateTime("1998-10-07");

            context.LiverpoolPlayers.Add(play6);

            LiverpoolPlayers play7 = new LiverpoolPlayers();
            play7.LiverpoolPlayersId = 7;
            play7.Appearances = 26;
            play7.Comments = "Born in Brazil";
            play7.Goals = 0;
            play7.Name = "Fabinho";
            play7.Number = 3;
            play7.Position = "Midfielder";
            play7.DOB = Convert.ToDateTime("1993-10-23");

            context.LiverpoolPlayers.Add(play7);

            LiverpoolPlayers play8 = new LiverpoolPlayers();
            play8.LiverpoolPlayersId = 8;
            play8.Appearances = 33;
            play8.Comments = "From Netherlands";
            play8.Goals = 2;
            play8.Name = "Georginio Wijnaldum";
            play8.Number = 5;
            play8.Position = "Midfielder";
            play8.DOB = Convert.ToDateTime("1990-11-11");

            context.LiverpoolPlayers.Add(play8);

            LiverpoolPlayers play9 = new LiverpoolPlayers();
            play9.LiverpoolPlayersId = 9;
            play9.Appearances = 25;
            play9.Comments = "From England, 1 Assist";
            play9.Goals = 0;
            play9.Name = "James Milner";
            play9.Number = 7;
            play9.Position = "Midfielder";
            play9.DOB = Convert.ToDateTime("1986-01-04");

            context.LiverpoolPlayers.Add(play9);

            LiverpoolPlayers play10 = new LiverpoolPlayers();
            play10.LiverpoolPlayersId = 10;
            play10.Appearances = 31;
            play10.Comments = "Born in Senegal, 5 Assists";
            play10.Goals = 8;
            play10.Name = "Sadio Mané";
            play10.Number = 10;
            play10.Position = "Forward";
            play10.DOB = Convert.ToDateTime("1992-04-10");

            context.LiverpoolPlayers.Add(play10);

            LiverpoolPlayers play11 = new LiverpoolPlayers();
            play11.LiverpoolPlayersId = 11;
            play11.Appearances = 33;
            play11.Comments = "Born in Egypt, 3 Assists";
            play11.Goals = 20;
            play11.Name = "Mohamed Salah";
            play11.Number = 11;
            play11.Position = "Forward";
            play11.DOB = Convert.ToDateTime("1992-06-15");

            context.LiverpoolPlayers.Add(play11);

            LiverpoolPlayers play12 = new LiverpoolPlayers();
            play12.LiverpoolPlayersId = 12;
            play12.Appearances = 16;
            play12.Comments = "From Portugal";
            play12.Goals = 8;
            play12.Name = "Diogo Jota";
            play12.Number = 20;
            play12.Position = "Forward";
            play12.DOB = Convert.ToDateTime("1996-12-04");

            context.LiverpoolPlayers.Add(play12);

            base.Seed(context);
        }
    }
    }