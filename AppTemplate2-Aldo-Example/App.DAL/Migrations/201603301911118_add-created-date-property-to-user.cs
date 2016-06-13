namespace App.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcreateddatepropertytouser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblUsers", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblUsers", "CreatedDate");
        }
    }
}
