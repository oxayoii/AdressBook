using AdressBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Data
{
    internal class AdressBookContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Report> Report { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-QLC0IVG\\SQLEXPRESS; Database=Cursach3; Trusted_Connection=true; Encrypt=false;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(b => b.Id)
                .HasName("PrimaryKey_UsersId");
            modelBuilder.Entity<Books>()
                .HasKey(b => b.id)
                .HasName("PrimaryKey_BookId");
            modelBuilder.Entity<Report>()
                .HasKey(b => b.Id)
                .HasName("PrimaryKey_ReportId");
        }
    }
}
