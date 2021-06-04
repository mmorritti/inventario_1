namespace inventario_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Name1 = c.String(),
                        Price = c.Double(),
                        PurchaseDate = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaseEntities", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaseEntities", "Category_Id", "dbo.BaseEntities");
            DropIndex("dbo.BaseEntities", new[] { "Category_Id" });
            DropTable("dbo.BaseEntities");
        }
    }
}
