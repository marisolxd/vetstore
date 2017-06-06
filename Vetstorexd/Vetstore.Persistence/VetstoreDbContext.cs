using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Entities;
using Vetstore.Persistence.EntityTypeConfigurations;

namespace Vetstore.Persistence
{
    public class VetstoreDbContext : DbContext
    {
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ServicioAtencion> ServicioAtenciones { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<CategoriaProducto> CategoriasProductos { get; set; }

        public VetstoreDbContext(): base("VetStore")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ServicioAtencionConfiguration());
            //modelBuilder.Configurations.Add(new ClienteConfiguration());
            //modelBuilder.Configurations.Add(new MascotaConfiguration());
            //modelBuilder.Configurations.Add(new VentaConfiguration());
            //modelBuilder.Configurations.Add(new VeterinarioConfiguration());

            //categoria producto
            modelBuilder.Entity<CategoriaProducto>().ToTable("CategoriasProducto");
            modelBuilder.Entity<CategoriaProducto>().HasKey(c => c.CategoriaProductoId);

            modelBuilder.Entity<CategoriaProducto>().Property(a => a.CategoriaProductoId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<CategoriaProducto>().HasMany(c => c.Productos)
                .WithRequired(c => c.CategoriaProducto)
                 .HasForeignKey(c => c.CategoriaProductoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
