namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "Writer_WriterID", c => c.Int());
            CreateIndex("dbo.Contents", "Writer_WriterID");
            AddForeignKey("dbo.Contents", "Writer_WriterID", "dbo.Writers", "WriterID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "Writer_WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "Writer_WriterID" });
            DropColumn("dbo.Contents", "Writer_WriterID");
        }
    }
}
