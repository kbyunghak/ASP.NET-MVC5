namespace CodeFirstStuff.Migrations.NhlMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JerseyNoString : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        JerseyNumber = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Position = c.String(),
                        IsRight = c.Boolean(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Team_TeamName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.JerseyNumber)
                .ForeignKey("dbo.Teams", t => t.Team_TeamName)
                .Index(t => t.Team_TeamName);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamName = c.String(nullable: false, maxLength: 128),
                        City = c.String(),
                        Province = c.String(),
                        CaptainJerseyNumber = c.Int(nullable: false),
                        Manager = c.String(),
                        SalaryCap = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TeamName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_TeamName", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_TeamName" });
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
        }
    }
}
