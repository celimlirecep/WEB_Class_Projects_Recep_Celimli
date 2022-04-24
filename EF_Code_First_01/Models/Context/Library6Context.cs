using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_Code_First_01.Models.Entities;

namespace EF_Code_First_01.Models.Entities 
{
    public class Library6Context:DbContext //Eklemek lazım 
    {
        public Library6Context(DbContextOptions<Library6Context> options):base(options)//ctor
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if (!optionsBuilder.IsConfigured)//options builder configure edilmemişse yani veri tabnı eoluşmamışsa
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:LibraryConn");
            }

        }
        
    }
}