namespace TripulacionGoingMerry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        TripulantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Tripulants", t => t.TripulantID, cascadeDelete: true)
                .Index(t => t.TripulantID);
            
            CreateTable(
                "dbo.Tripulants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "TripulantID", "dbo.Tripulants");
            DropIndex("dbo.Enrollment", new[] { "TripulantID" });
            DropTable("dbo.Tripulants");
            DropTable("dbo.Enrollment");
        }
    }
}
