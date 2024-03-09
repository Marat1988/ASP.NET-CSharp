namespace TestIocDi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Author = c.String(maxLength: 50),
                        Style = c.String(maxLength: 25),
                        Year = c.Int(nullable: false),
                        OtherInfo = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
