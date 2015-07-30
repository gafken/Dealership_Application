namespace Dealship_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class boughtBy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "boughtBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "boughtBy");
        }
    }
}
