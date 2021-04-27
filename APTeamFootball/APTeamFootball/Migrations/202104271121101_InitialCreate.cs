namespace APTeamFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Manager = c.String(),
                        Draws = c.Int(nullable: false),
                        GoalDiff = c.Int(nullable: false),
                        GoalsAgainst = c.Int(nullable: false),
                        GoalsFor = c.Int(nullable: false),
                        Loss = c.Int(nullable: false),
                        MatchPlayed = c.Int(nullable: false),
                        PLTrophies = c.Int(nullable: false),
                        Points = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Wins = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
        }
    }
}
