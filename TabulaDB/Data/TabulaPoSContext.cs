using Microsoft.EntityFrameworkCore;
using TabulaDB.Models;
using DotNetEnv;

namespace TabulaDB.Data
{
    public class TabulaPoSContext : DbContext
    {
        public DbSet<Log> Logs { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<ReceiptProduct> ReceiptProducts { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Receipt> Receipts { get; set; } = null!;
        public DbSet<ReceiptStatus> ReceiptStatus { get; set; } = null!;
        public DbSet<ServiceStation> ServiceStations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Env.TraversePath().Load();

            var server = Env.GetString("DATABASE_SERVER");
            var databaseName = Env.GetString("DATABASE_NAME");
            var databasePort = Env.GetString("DATABASE_PORT");
            var databaseUser = Env.GetString("DATABASE_USER");
            var databasePass = Env.GetString("DATABASE_PASS");

            var connectionString = $"server=localhost;database={databaseName};user={databaseUser};password={databasePass}";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Default Roles
            var adminRole = new Role { Id = 1, Name = "Admin" };
            var managerRole = new Role { Id = 2, Name = "Manager" };
            var cashierRole = new Role { Id = 3, Name = "Cashier" };

            // Default Users
            var user1 = new User { Id = 1, Username = "admin001", RoleId = 1 };
            var user2 = new User { Id = 2, Username = "cashier001", RoleId = 3 };

            modelBuilder.Entity<Role>().HasData(adminRole, managerRole, cashierRole);
            modelBuilder.Entity<User>().HasData(user1, user2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
