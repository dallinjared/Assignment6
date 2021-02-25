using System;
using Microsoft.EntityFrameworkCore;

namespace Assignment5.Models
{
    public class DaintreeDBContext : DbContext
    {
       public DaintreeDBContext (DbContextOptions<DaintreeDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
