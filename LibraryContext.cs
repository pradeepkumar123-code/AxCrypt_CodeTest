using AxCrypt_v2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxCrypt_v2
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "BookA" , DueDate = DateTime.UtcNow.AddDays(-40) },
                new Book { Id = 2, Title = "BookB", DueDate = DateTime.UtcNow.AddDays(-30)},
                new Book { Id = 3, Title = "BookC", DueDate = DateTime.UtcNow.AddDays(-20)}
            );
        }
    }
}
