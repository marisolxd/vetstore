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
    public class ServicioAtencionConfiguration : EntityTypeConfiguration<ServicioAtencion>
    {
        public ServicioAtencionConfiguration()
        {
            ToTable("Servicios");
            HasKey(c => c.ServicioAtencionId);

            Property(a => a.ServicioAtencionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration

            HasMany(c => c.Ventas)
                .WithRequired(c => c.ServicioAtencion)
                 .HasForeignKey(c => c.ServicioAtencionId);
        }
    }
}
