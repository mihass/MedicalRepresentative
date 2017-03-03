namespace MedicalRepresentative.DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddReportsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.WorkerId)
                .Index(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reports", "WorkerId", "dbo.Workers");
            DropIndex("dbo.Reports", new[] { "WorkerId" });
            DropTable("dbo.Reports");
        }
    }
}
