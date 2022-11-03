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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasIndex(x => x.Name).IsUnique();
        //}

        public DbSet<User> Users { get; set; }
    }
}
