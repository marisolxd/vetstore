using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Vetstore.Entities.Entities;

namespace Vetstore.Persistence.EntityTypeConfigurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Clientes");
            HasKey(c => c.ClienteId);

            Property(b => b.ClienteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Relations Configuration

            HasMany(c => c.Mascotas)
                .WithRequired(c => c.Cliente)
                 .HasForeignKey(c => c.ClienteId);

            //Relations Configuration

            HasMany(c => c.ServicioAtenciones)
                .WithRequired(c => c.Cliente)
                 .HasForeignKey(c => c.ClienteId);
        }
    }
}
