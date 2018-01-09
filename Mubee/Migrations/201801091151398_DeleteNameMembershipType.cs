namespace Mubee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteNameMembershipType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
