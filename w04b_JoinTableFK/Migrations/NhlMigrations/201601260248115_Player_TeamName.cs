namespace CodeFirstStuff.Migrations.NhlMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Player_TeamName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Players", name: "Team_TeamName", newName: "TeamName");
            RenameIndex(table: "dbo.Players", name: "IX_Team_TeamName", newName: "IX_TeamName");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Players", name: "IX_TeamName", newName: "IX_Team_TeamName");
            RenameColumn(table: "dbo.Players", name: "TeamName", newName: "Team_TeamName");
        }
    }
}
