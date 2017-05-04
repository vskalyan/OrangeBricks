namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToShowings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viewings", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Viewings", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Viewings", "UpdatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Viewings", "BuyerUserId", c => c.String(nullable:false));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Viewings", "BuyerUserId", c => c.String(nullable: false));
            DropColumn("dbo.Viewings", "UpdatedAt");
            DropColumn("dbo.Viewings", "CreatedAt");
            DropColumn("dbo.Viewings", "Status");
        }
    }
}
