using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public Context()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=94.73.147.7;Database=u7174244_ProBudy;User Id=u7174244_ProBudy; Password=KYyp18Q1HPaj97N;");
        }
        //public Context(DbContextOptions<Context> options) : base(options)
        //{

        //}
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }
        public DbSet<Deneyimler> Deneyimler { get; set; }

        public DbSet<Deneyimler> EgitimBilgileri { get; set; }

        public DbSet<Deneyimler> Iletisim { get; set; }

        public DbSet<Deneyimler> Kimlik { get; set; }

        public DbSet<Deneyimler> Kullanici { get; set; }

        public DbSet<Deneyimler> Yetkinlikler { get; set; }




    }
}
