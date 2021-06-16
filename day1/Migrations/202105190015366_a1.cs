namespace day1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.userinfoes",
                c => new
                    {
                        uid = c.Int(nullable: false, identity: true),
                        uname = c.String(),
                        xname = c.String(),
                        pwd = c.String(),
                        uemail = c.String(),
                    })
                .PrimaryKey(t => t.uid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.userinfoes");
        }
    }
}
