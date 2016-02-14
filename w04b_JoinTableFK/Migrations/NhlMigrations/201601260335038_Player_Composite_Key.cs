namespace CodeFirstStuff.Migrations.NhlMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Player_Composite_Key : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Players");
            AlterColumn("dbo.Players", "FirstName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Players", "LastName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Players", new[] { "JerseyNumber", "FirstName", "LastName" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Players");
            AlterColumn("dbo.Players", "LastName", c => c.String());
            AlterColumn("dbo.Players", "FirstName", c => c.String());
            AddPrimaryKey("dbo.Players", "JerseyNumber");
        }
    }
}
