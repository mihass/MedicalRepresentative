namespace MedicalRepresentative.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNotNullToInstituteAndOccupationNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Institutes", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Occupations", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Occupations", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Institutes", "Name", c => c.String(maxLength: 255));
        }
    }
}
