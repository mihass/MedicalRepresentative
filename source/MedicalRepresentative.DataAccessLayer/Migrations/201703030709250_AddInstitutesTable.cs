namespace MedicalRepresentative.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstitutesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Institutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Institutes");
        }
    }
}
