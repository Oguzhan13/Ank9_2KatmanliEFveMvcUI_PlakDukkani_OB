using Ank9_EF_Entities_OB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_OB.Data.Configuration
{
    public class MusicianConfiguration : IEntityTypeConfiguration<Musician>
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            //Bu kod satırını yazmasak ta BandConfiguration içerisinde tanımlı olduğu için işlev yerine gelir
            builder.HasOne<Band>(m => m.Band).WithMany(b => b.BandMembers).HasForeignKey(m => m.BandId);
            
            ////Çoka çok ilişki olsaydı
            //builder.HasMany(m => m.Bands)
            //    .WithMany(b => b.BandMembers);
        }
    }
}
