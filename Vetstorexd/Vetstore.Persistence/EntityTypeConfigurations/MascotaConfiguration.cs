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
    public class MascotaConfiguration : EntityTypeConfiguration<Mascota>
    {
        public MascotaConfiguration()
        {
            ToTable("Mascotas");
            HasKey(c => c.MascotaId);

            Property(b => b.MascotaId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


        }
    }
}
