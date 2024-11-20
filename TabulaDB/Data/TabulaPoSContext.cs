using Microsoft.EntityFrameworkCore;
using TabulaDB.Models;
using DotNetEnv;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

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
        public DbSet<Table> Tables { get; set; } = null!; 
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DotNetEnv.Env.TraversePath().Load();

            var server = DotNetEnv.Env.GetString("DATABASE_SERVER");
            var databaseName = DotNetEnv.Env.GetString("DATABASE_NAME");
            var databasePort = DotNetEnv.Env.GetString("DATABASE_PORT");
            var databaseUser = DotNetEnv.Env.GetString("DATABASE_USER");
            var databasePass = DotNetEnv.Env.GetString("DATABASE_PASS");            

            var connectionString = $"server={server};database={databaseName};user={databaseUser};password={databasePass}";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
