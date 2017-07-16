namespace RaysHotDogApp.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HotDogs",
                c => new
                    {
                        HotDogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        ImagePath = c.String(),
                        Price = c.Single(nullable: false),
                        Avaliable = c.Boolean(nullable: false),
                        PrepTime = c.Int(nullable: false),
                        IsFavourite = c.Boolean(nullable: false),
                        Group_GroupName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HotDogId)
                .ForeignKey("dbo.HotDogGroups", t => t.Group_GroupName)
                .Index(t => t.Group_GroupName);
            
            CreateTable(
                "dbo.HotDogGroups",
                c => new
                    {
                        GroupName = c.String(nullable: false, maxLength: 128),
                        HotDogGroupId = c.Int(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.GroupName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HotDogs", "Group_GroupName", "dbo.HotDogGroups");
            DropIndex("dbo.HotDogs", new[] { "Group_GroupName" });
            DropTable("dbo.HotDogGroups");
            DropTable("dbo.HotDogs");
        }
    }
}
