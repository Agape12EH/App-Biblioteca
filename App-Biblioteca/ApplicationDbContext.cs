using App_Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace App_Biblioteca
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
        public DbSet<Books> Books { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<StateBook> StateBooks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
