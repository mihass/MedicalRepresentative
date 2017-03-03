namespace MedicalRepresentative.DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        InstituteId = c.Int(),
                        OccupationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Institutes", t => t.InstituteId)
                .ForeignKey("dbo.Occupations", t => t.OccupationId)
                .Index(t => t.InstituteId)
                .Index(t => t.OccupationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "OccupationId", "dbo.Occupations");
            DropForeignKey("dbo.Workers", "InstituteId", "dbo.Institutes");
            DropIndex("dbo.Workers", new[] { "OccupationId" });
            DropIndex("dbo.Workers", new[] { "InstituteId" });
            DropTable("dbo.Workers");
        }
    }
}
