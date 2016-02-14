namespace CodeFirstStuff.Migrations.NhlMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerStartDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "StartDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "StartDate");
        }
    }
}
