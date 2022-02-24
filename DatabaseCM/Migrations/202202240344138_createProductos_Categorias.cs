namespace DatabaseCM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createProductos_Categorias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Detalle = c.String(),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        existencia = c.Int(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        descripcion = c.String(),
                        Marca = c.String(),
                        CodigoBarras = c.String(),
                        imagen = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Categorias", t => t.IdCategoria, cascadeDelete: false)
                .Index(t => t.IdCategoria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "IdCategoria", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "IdCategoria" });
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
