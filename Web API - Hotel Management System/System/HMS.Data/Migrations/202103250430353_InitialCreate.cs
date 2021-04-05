namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        StatusofBooking = c.String(),
                        RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        RoomCategory = c.String(),
                        RoomPrice = c.String(),
                        IsActive = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(),
                        HotelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .Index(t => t.HotelID);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Pincode = c.Int(nullable: false),
                        ContactNumber = c.String(),
                        ContactPerson = c.String(),
                        Website = c.String(),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "HotelID", "dbo.Hotels");
            DropForeignKey("dbo.Bookings", "RoomID", "dbo.Rooms");
            DropIndex("dbo.Rooms", new[] { "HotelID" });
            DropIndex("dbo.Bookings", new[] { "RoomID" });
            DropTable("dbo.Hotels");
            DropTable("dbo.Rooms");
            DropTable("dbo.Bookings");
        }
    }
}
