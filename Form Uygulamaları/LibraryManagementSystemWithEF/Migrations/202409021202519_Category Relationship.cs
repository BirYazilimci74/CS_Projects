namespace LibraryManagementSystemWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryRelationship : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Books", "CategoryId");
            AddForeignKey("dbo.Books", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "CategoryId" });
        }
    }
}
