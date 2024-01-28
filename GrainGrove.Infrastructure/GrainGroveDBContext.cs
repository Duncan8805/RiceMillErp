using GrainGrove.Domain.Po;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GrainGrove.Infrastructure;

public class GrainGroveDBContext : DbContext
{
    protected readonly IConfiguration _configuration;
    public GrainGroveDBContext(DbContextOptions<GrainGroveDBContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// 顧客資料
    /// </summary>
    public DbSet<CustInfoPo> CustInfo { get; set; }
    /// <summary>
    /// 顧客資料
    /// </summary>
    public DbSet<ProductInfoPo> ProductInfo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustInfoPo>().HasKey(c => c.CustNo);

        modelBuilder.Entity<ProductInfoPo>().HasKey(c => c.ProductNo);
    }

}