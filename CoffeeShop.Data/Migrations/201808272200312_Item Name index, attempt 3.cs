namespace CoffeeShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemNameindexattempt3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Items", new[] { "Name" });
            AlterColumn("dbo.Items", "Name", c => c.String(maxLength: 50));
            CreateIndex("dbo.Items", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Items", new[] { "Name" });
            AlterColumn("dbo.Items", "Name", c => c.String(maxLength: 250));
            CreateIndex("dbo.Items", "Name", unique: true);
        }
    }
}
