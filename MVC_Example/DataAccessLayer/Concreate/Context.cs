using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConn");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>(content =>
                    {
                        content.HasOne(w => w.Writer)
                        .WithMany(c => c.Contents)
                        .HasForeignKey(c => c.WriterId)
                        .OnDelete(DeleteBehavior.SetNull);
                    });
            modelBuilder.Entity<Heading>(heading =>
            {
                heading.HasOne(w => w.Writer)
                .WithMany(h => h.Headings)
                .HasForeignKey(c => c.WriterId)
                .OnDelete(DeleteBehavior.SetNull);
            });

        }


    }
}
