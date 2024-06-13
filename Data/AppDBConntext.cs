using Frame_Manager.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;

namespace Frame_Manager.Data
{
    public class AppDBConntext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDBConntext(DbContextOptions<AppDBConntext> options , IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        public DbSet<History> Histories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("sqlConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tùy chỉnh ánh xạ dữ liệu ở đây nếu cần thiết
            modelBuilder.Entity<History>()
                .ToTable("TB_HIS003")
                ;
        }
    }
}
