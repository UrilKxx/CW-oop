namespace _123
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        FeedBackId = c.Int(nullable: false, identity: true),
                        FeedBackMessage = c.String(nullable: false),
                        PostDate = c.DateTime(nullable: false),
                        FeedBackImage = c.Binary(),
                        UsersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeedBackId)
                .ForeignKey("dbo.Users", t => t.UsersId, cascadeDelete: true)
                .Index(t => t.UsersId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Ivents",
                c => new
                    {
                        IventId = c.Int(nullable: false, identity: true),
                        IventName = c.String(),
                        Description = c.String(),
                        Image = c.Binary(),
                        IventDate = c.DateTime(nullable: false),
                        IventDateBegin = c.DateTime(nullable: false),
                        IventDateEnd = c.DateTime(nullable: false),
                        FeedBackId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IventId)
                .ForeignKey("dbo.FeedBacks", t => t.FeedBackId, cascadeDelete: true)
                .Index(t => t.FeedBackId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ivents", "FeedBackId", "dbo.FeedBacks");
            DropForeignKey("dbo.FeedBacks", "UsersId", "dbo.Users");
            DropIndex("dbo.Ivents", new[] { "FeedBackId" });
            DropIndex("dbo.FeedBacks", new[] { "UsersId" });
            DropTable("dbo.Ivents");
            DropTable("dbo.Users");
            DropTable("dbo.FeedBacks");
        }
    }
}
