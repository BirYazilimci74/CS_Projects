namespace LibraryManagementSystemWithEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookremovedinBorrowedBook : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BorrowedBooks", "BookID", "dbo.Books");
            DropIndex("dbo.BorrowedBooks", new[] { "BookID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.BorrowedBooks", "BookID");
            AddForeignKey("dbo.BorrowedBooks", "BookID", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
