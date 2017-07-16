namespace RaysHotDogApp.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedseedchangedpkhdgaddedfkhd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HotDogs", "Group_GroupName", "dbo.HotDogGroups");
            DropIndex("dbo.HotDogs", new[] { "Group_GroupName" });
            RenameColumn(table: "dbo.HotDogs", name: "Group_GroupName", newName: "HotDogGroupId");
            DropPrimaryKey("dbo.HotDogGroups");
            AlterColumn("dbo.HotDogGroups", "GroupName", c => c.String());
            AlterColumn("dbo.HotDogGroups", "HotDogGroupId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.HotDogs", "HotDogGroupId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.HotDogGroups", "HotDogGroupId");
            CreateIndex("dbo.HotDogs", "HotDogGroupId");
            AddForeignKey("dbo.HotDogs", "HotDogGroupId", "dbo.HotDogGroups", "HotDogGroupId", cascadeDelete: true);
            DropColumn("dbo.HotDogs", "GroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HotDogs", "GroupId", c => c.Int(nullable: false));
            DropForeignKey("dbo.HotDogs", "HotDogGroupId", "dbo.HotDogGroups");
            DropIndex("dbo.HotDogs", new[] { "HotDogGroupId" });
            DropPrimaryKey("dbo.HotDogGroups");
            AlterColumn("dbo.HotDogs", "HotDogGroupId", c => c.String(maxLength: 128));
            AlterColumn("dbo.HotDogGroups", "HotDogGroupId", c => c.Int(nullable: false));
            AlterColumn("dbo.HotDogGroups", "GroupName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.HotDogGroups", "GroupName");
            RenameColumn(table: "dbo.HotDogs", name: "HotDogGroupId", newName: "Group_GroupName");
            CreateIndex("dbo.HotDogs", "Group_GroupName");
            AddForeignKey("dbo.HotDogs", "Group_GroupName", "dbo.HotDogGroups", "GroupName");
        }
    }
}
