using Microsoft.EntityFrameworkCore;

namespace DataBase {
    public class TestContext : DbContext {
        public TestContext(DbContextOptions<TestContext> options) : base(options) {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Item>().ToTable("Item");
        }
    }
}