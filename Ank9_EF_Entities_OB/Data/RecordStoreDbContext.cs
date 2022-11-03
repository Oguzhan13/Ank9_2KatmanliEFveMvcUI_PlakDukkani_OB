using Ank9_EF_Entities_OB.Data.Configuration;
using Ank9_EF_Entities_OB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_OB.Data
{
    public class RecordStoreDbContext:DbContext
    {
        public RecordStoreDbContext(DbContextOptions<RecordStoreDbContext> options):base(options)
        {

        }

        ////class içerisinde yaptığımız Index attribute unun yaptığı işlemi buradaki gibi yapabiliriz 
        ////User.cs -> satır 11-12 aralığında
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasIndex(x => x.Name).IsUnique();
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            /*modelBuilder.Entity<Musician>()
                .HasOne<Band>(m => m.Band)
                .WithMany(b => b.BandMembers)
                .HasForeignKey(c => c.BandId);*/
            //Yukarıdaki yorum satırındaki gibi yazmamak için configuration class içerisinde yaptık işlemleri
            modelBuilder.ApplyConfiguration<Band>(new BandConfiguration());
            modelBuilder.ApplyConfiguration<Musician>(new MusicianConfiguration());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Band> Bands { get; set; }
    }
}
