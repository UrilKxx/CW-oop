namespace _123
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tagsistem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ivents", "IventType", c => c.Int(nullable: false));
            AddColumn("dbo.Ivents", "Tag", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ivents", "Tag");
            DropColumn("dbo.Ivents", "IventType");
        }
    }
}
