
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFcore.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=192.168.41.51;Initial Catalog=AcmGroup_Db;User ID=k.kamalifar;Password=KK123456;");

        //    base.OnConfiguring(optionsBuilder);

        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<tblAPIUrls>().Property(q => q.BaseAddress).HasMaxLength(500).IsRequired();
        //    modelBuilder.Entity<tblAPIUrls>().Property(q => q.AddressUrl).HasMaxLength(500).IsRequired();
        //    modelBuilder.Entity<tblAPIUrls>().Property(q => q.IsLoginUrl).IsRequired();

        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<person> person { get; set; }
        //public DbSet<City> City { get; set; }
    }
}
