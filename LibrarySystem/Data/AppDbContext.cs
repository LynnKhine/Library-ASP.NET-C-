using LibrarySystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data;

    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Define your tables here as DbSet<T>
    public DbSet<AuthorsEntity> AuthorsDbSet { get; set; }

    public DbSet<BooksEntity> BooksDbSet { get; set; }

    public DbSet<BorrowHistoriesEntity> BorrowHistoriesDbSet { get; set; }

    public DbSet<CategoriesEntity> CategoriesDbSet { get; set; }

    public DbSet<CustomersEntity> CustomersDbSet { get; set; }

    public DbSet<RolesEntity> RolesDbSet { get; set; }

    public DbSet<StaffEntity> StaffDbSet { get; set; }


    // You can override OnModelCreating if you need additional configuration
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional configuration here if needed
    }

}

