using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;using System.Data.Entity;

namespace APTeamFootball.Models
{
    public class PlayersDataInitialiser : DropCreateDatabaseAlways<PlayersContext>
    {
        protected override void Seed(PlayersContext context)
        {

            Players play1 = new Players();
            play1.PlayersId = 1;
            play1.Appearances = 5;
            play1.Comments = "A very good player";
            play1.Goals = 1;
            play1.Name = "Some Name";
            play1.Number = 16;
            play1.Position = "Defender";
            play1.DOB = Convert.ToDateTime("1998-02-02");

            context.Players.Add(play1);


            base.Seed(context);
        }
    }
}