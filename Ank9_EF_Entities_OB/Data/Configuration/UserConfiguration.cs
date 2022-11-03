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
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(c => c.UserId)
                //kullanıcı id leri aynı hizadan başlasın diye 1000' den başlattık
                .UseIdentityColumn(1000, 1) 
                .IsRequired();
            builder.Property(c => c.Name)
                .IsRequired()
            .HasMaxLength(30);
            builder.Property(c => c.Password)
                .IsRequired()
                .HasColumnType("NCHAR(8)")
                .IsFixedLength(true);

            //Table bazlı düzenlemelerimiz
            builder.HasKey(c => c.UserId);
            builder.HasIndex(c => c.Name).IsUnique();
        }
    }
}
