namespace DatabaseCM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ventas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        IdVenta = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Folio = c.String(),
                        MyProperty = c.Int(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        cantidad = c.Int(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdCajero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVenta)
                .ForeignKey("dbo.Productos", t => t.IdProducto, cascadeDelete: false)
                .ForeignKey("dbo.Usuarios", t => t.IdCajero, cascadeDelete: false)
                .Index(t => t.IdProducto)
                .Index(t => t.IdCajero);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "IdCajero", "dbo.Usuarios");
            DropForeignKey("dbo.Ventas", "IdProducto", "dbo.Productos");
            DropIndex("dbo.Ventas", new[] { "IdCajero" });
            DropIndex("dbo.Ventas", new[] { "IdProducto" });
            DropTable("dbo.Ventas");
        }
    }
}
