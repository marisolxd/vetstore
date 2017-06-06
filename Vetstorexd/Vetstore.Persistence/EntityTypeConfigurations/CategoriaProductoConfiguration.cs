using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetstore.Entities.Entities;

namespace Vetstore.Persistence.EntityTypeConfigurations
{
    public class CategoriaProductoConfiguration : EntityTypeConfiguration<CategoriaProducto>
    {
        public CategoriaProductoConfiguration()
        {
            ToTable("CategoriasProducto");
            HasKey(c => c.CategoriaProductoId);

            Property(a => a.CategoriaProductoId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            //Relations Configuration

            HasMany(c => c.Productos)
                .WithRequired(c => c.CategoriaProducto)
                 .HasForeignKey(c => c.CategoriaProductoId);
        }
    }
}
