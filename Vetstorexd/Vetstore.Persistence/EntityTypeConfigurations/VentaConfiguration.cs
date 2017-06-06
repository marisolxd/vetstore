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
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            ToTable("Ventas");
            HasKey(c => c.VentaId);

            Property(a => a.VentaId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration

            HasMany(c => c.Productos)
                .WithRequired(c => c.Venta)
                 .HasForeignKey(c => c.VentaId);
        }
    }
}
