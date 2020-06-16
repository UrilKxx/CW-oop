namespace _123
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtimetoivents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ivents", "IventDateStart", c => c.DateTime(nullable: false));
            DropColumn("dbo.Ivents", "IventDate");
            DropColumn("dbo.Ivents", "IventDateBegin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ivents", "IventDateBegin", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ivents", "IventDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Ivents", "IventDateStart");
        }
    }
}
