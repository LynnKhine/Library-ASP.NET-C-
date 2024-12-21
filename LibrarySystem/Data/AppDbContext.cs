using LibrarySystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data;

    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Define your tables here as DbSet<T>
    public DbSet<AuthorEntity> AuthorDbSet { get; set; }

    public DbSet<BookEntity> BookDbSet { get; set; }

    public DbSet<BorrowHistoryEntity> BorrowHistoryDbSet { get; set; }

    public DbSet<CategoryEntity> CategoryDbSet { get; set; }

    public DbSet<CustomerEntity> CustomerDbSet { get; set; }

    public DbSet<RoleEntity> RoleDbSet { get; set; }

    public DbSet<StaffEntity> StaffDbSet { get; set; }


    // You can override OnModelCreating if you need additional configuration
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional configuration here if needed
    }

}

