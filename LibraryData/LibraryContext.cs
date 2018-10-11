using Microsoft.EntityFrameworkCore;
using System;
using LibraryData.Models;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        //Establishes DbContext class and functions
        public LibraryContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet represents an entity for CRUD operations, think of as a table while DbContext is the database
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BranchHours> BranchHours { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<LibraryAsset> LibraryAssets  { get; set; }
        public DbSet<LibraryBranch> LibraryBranches  { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
