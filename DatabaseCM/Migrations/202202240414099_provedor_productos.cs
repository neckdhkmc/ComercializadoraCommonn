namespace DatabaseCM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class provedor_productos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provedores",
                c => new
                    {
                        IdProvedor = c.Int(nullable: false, identity: true),
                        NombreProvedor = c.String(),
                        NombreContacto = c.String(),
                        Telefono = c.String(),
                        Direccion = c.String(),
                        email = c.String(),
                        IdEstatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProvedor)
                .ForeignKey("dbo.estatus", t => t.IdEstatus, cascadeDelete: true)
                .Index(t => t.IdEstatus);
            
            CreateTable(
                "dbo.ProvedorProductoes",
                c => new
                    {
                        IdProvedorProducto = c.Int(nullable: false, identity: true),
                        idProvedor = c.Int(nullable: false),
                        IdProdcutos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProvedorProducto)
                .ForeignKey("dbo.Productos", t => t.IdProdcutos, cascadeDelete: true)
                .ForeignKey("dbo.Provedores", t => t.idProvedor, cascadeDelete: true)
                .Index(t => t.idProvedor)
                .Index(t => t.IdProdcutos);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProvedorProductoes", "idProvedor", "dbo.Provedores");
            DropForeignKey("dbo.ProvedorProductoes", "IdProdcutos", "dbo.Productos");
            DropForeignKey("dbo.Provedores", "IdEstatus", "dbo.estatus");
            DropIndex("dbo.ProvedorProductoes", new[] { "IdProdcutos" });
            DropIndex("dbo.ProvedorProductoes", new[] { "idProvedor" });
            DropIndex("dbo.Provedores", new[] { "IdEstatus" });
            DropTable("dbo.ProvedorProductoes");
            DropTable("dbo.Provedores");
        }
    }
}
