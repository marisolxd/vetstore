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
    public class ProductoConfiguration : EntityTypeConfiguration<Producto>
    {
        public ProductoConfiguration()
        {
            ToTable("Productos");
            HasKey(c => c.ProductoId);
            Property(a => a.ProductoId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
