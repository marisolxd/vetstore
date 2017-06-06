namespace Vetstore.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriaProductoes",
                c => new
                    {
                        CategoriaProductoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaProductoId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Costo = c.Double(nullable: false),
                        Vencimiento = c.DateTime(nullable: false),
                        Marca = c.String(),
                        Precio = c.Double(nullable: false),
                        CategoriaProductoId = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.CategoriaProductoes", t => t.CategoriaProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.CategoriaProductoId)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        VentaDay = c.DateTime(nullable: false),
                        SrvicioAtencionId = c.Int(nullable: false),
                        TipoPago = c.Int(nullable: false),
                        ServicioAtencion_ServicioAtencionId = c.Int(),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.ServicioAtencions", t => t.ServicioAtencion_ServicioAtencionId)
                .Index(t => t.ServicioAtencion_ServicioAtencionId);
            
            CreateTable(
                "dbo.ServicioAtencions",
                c => new
                    {
                        ServicioAtencionId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        VeterinarioId = c.Int(nullable: false),
                        ServicioEstetico = c.Int(nullable: false),
                        ServicioClinico = c.Int(nullable: false),
                        ServicioHospedaje = c.Int(nullable: false),
                        ServicioRecreativo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ServicioAtencionId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Veterinarios", t => t.VeterinarioId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.VeterinarioId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.Int(nullable: false),
                        Direccion = c.Int(nullable: false),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Mascotas",
                c => new
                    {
                        MascotaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Especie = c.String(),
                        Raza = c.String(),
                        Color = c.String(),
                        Peso = c.Double(nullable: false),
                        Edad = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MascotaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Veterinarios",
                c => new
                    {
                        VeterinarioId = c.Int(nullable: false, identity: true),
                        Nomnbre = c.String(),
                        Apellido = c.String(),
                        Especialidad = c.String(),
                        CMVP = c.Int(nullable: false),
                        Dni = c.Int(nullable: false),
                        Telefono = c.Int(nullable: false),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.VeterinarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicioAtencions", "VeterinarioId", "dbo.Veterinarios");
            DropForeignKey("dbo.Ventas", "ServicioAtencion_ServicioAtencionId", "dbo.ServicioAtencions");
            DropForeignKey("dbo.ServicioAtencions", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Mascotas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Productoes", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Productoes", "CategoriaProductoId", "dbo.CategoriaProductoes");
            DropIndex("dbo.Mascotas", new[] { "ClienteId" });
            DropIndex("dbo.ServicioAtencions", new[] { "VeterinarioId" });
            DropIndex("dbo.ServicioAtencions", new[] { "ClienteId" });
            DropIndex("dbo.Ventas", new[] { "ServicioAtencion_ServicioAtencionId" });
            DropIndex("dbo.Productoes", new[] { "VentaId" });
            DropIndex("dbo.Productoes", new[] { "CategoriaProductoId" });
            DropTable("dbo.Veterinarios");
            DropTable("dbo.Mascotas");
            DropTable("dbo.Clientes");
            DropTable("dbo.ServicioAtencions");
            DropTable("dbo.Ventas");
            DropTable("dbo.Productoes");
            DropTable("dbo.CategoriaProductoes");
        }
    }
}
