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
            optionsBuilder.UseSqlServer(@"Server=78.135.105.238;Database=u7174244_ProBudy;User Id=u7174244_ProBudy; Password=KYyp18Q1HPaj97N;");
        }
        //public Context(DbContextOptions<Context> options) : base(options)+
        //{

        //}
        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Comment> Comments { get; set; }
        
        public DbSet<Contact> Contacts { get; set; }
        
        public DbSet<Writer> Writers { get; set; }
        
        public DbSet<Deneyimler> Deneyimler { get; set; }

        public DbSet<EgitimBilgileri> EgitimBilgileri { get; set; }

        public DbSet<Iletisim> Iletisim { get; set; }

        public DbSet<Kimlik> Kimlik { get; set; }

        public DbSet<Kullanici> Kullanici { get; set; }

        public DbSet<Yetkinlikler> Yetkinlikler { get; set; }

        public DbSet<NewsLetter> NewsLetters { get; set; }

        public DbSet<MailBulteni> MailBultenleri { get; set; }

        public DbSet<BlogRayting> BlogRaytings { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Message2> Message2s { get; set; }

        public DbSet<Admin> Admins { get; set; }








    }
}
