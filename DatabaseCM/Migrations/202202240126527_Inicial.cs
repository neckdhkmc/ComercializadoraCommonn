namespace DatabaseCM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.estatus",
                c => new
                    {
                        IdStatus = c.Int(nullable: false, identity: true),
                        NombreEstatus = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IdStatus);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        IdPermiso = c.Int(nullable: false, identity: true),
                        NombrePermiso = c.String(),
                        Descripcion = c.String(),
                        Accion = c.String(),
                        Controlador = c.String(),
                        IdEstatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPermiso)
                .ForeignKey("dbo.estatus", t => t.IdEstatus, cascadeDelete: false)
                .Index(t => t.IdEstatus);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        IdRol = c.Int(nullable: false, identity: true),
                        NombreRol = c.String(),
                        Descripcion = c.String(),
                        IdEstatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRol)
                .ForeignKey("dbo.estatus", t => t.IdEstatus, cascadeDelete: false)
                .Index(t => t.IdEstatus);
            
            CreateTable(
                "dbo.RolPermisoes",
                c => new
                    {
                        IdRolPermiso = c.Int(nullable: false, identity: true),
                        IdRol = c.Int(nullable: false),
                        IdPermiso = c.Int(nullable: false),
                        IdEstatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRolPermiso)
                .ForeignKey("dbo.estatus", t => t.IdEstatus, cascadeDelete: false)
                .ForeignKey("dbo.Permisos", t => t.IdPermiso, cascadeDelete: false)
                .ForeignKey("dbo.Rols", t => t.IdRol, cascadeDelete: false)
                .Index(t => t.IdRol)
                .Index(t => t.IdPermiso)
                .Index(t => t.IdEstatus);
            
            CreateTable(
                "dbo.TipoUsuarios",
                c => new
                    {
                        IdTipoUsuario = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        NickName = c.String(),
                        Pasword = c.String(),
                        NumEmpleado = c.String(),
                        Email = c.String(),
                        Telfono = c.String(),
                        tokenRecovery = c.String(),
                        IdRol = c.Int(nullable: false),
                        IdTipoUsuario = c.Int(nullable: false),
                        IdStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.estatus", t => t.IdStatus, cascadeDelete: false)
                .ForeignKey("dbo.Rols", t => t.IdRol, cascadeDelete: false)
                .ForeignKey("dbo.TipoUsuarios", t => t.IdTipoUsuario, cascadeDelete: false)
                .Index(t => t.IdRol)
                .Index(t => t.IdTipoUsuario)
                .Index(t => t.IdStatus);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdTipoUsuario", "dbo.TipoUsuarios");
            DropForeignKey("dbo.Usuarios", "IdRol", "dbo.Rols");
            DropForeignKey("dbo.Usuarios", "IdStatus", "dbo.estatus");
            DropForeignKey("dbo.RolPermisoes", "IdRol", "dbo.Rols");
            DropForeignKey("dbo.RolPermisoes", "IdPermiso", "dbo.Permisos");
            DropForeignKey("dbo.RolPermisoes", "IdEstatus", "dbo.estatus");
            DropForeignKey("dbo.Rols", "IdEstatus", "dbo.estatus");
            DropForeignKey("dbo.Permisos", "IdEstatus", "dbo.estatus");
            DropIndex("dbo.Usuarios", new[] { "IdStatus" });
            DropIndex("dbo.Usuarios", new[] { "IdTipoUsuario" });
            DropIndex("dbo.Usuarios", new[] { "IdRol" });
            DropIndex("dbo.RolPermisoes", new[] { "IdEstatus" });
            DropIndex("dbo.RolPermisoes", new[] { "IdPermiso" });
            DropIndex("dbo.RolPermisoes", new[] { "IdRol" });
            DropIndex("dbo.Rols", new[] { "IdEstatus" });
            DropIndex("dbo.Permisos", new[] { "IdEstatus" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.TipoUsuarios");
            DropTable("dbo.RolPermisoes");
            DropTable("dbo.Rols");
            DropTable("dbo.Permisos");
            DropTable("dbo.estatus");
        }
    }
}
