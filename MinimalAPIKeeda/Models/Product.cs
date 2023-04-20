using Microsoft.EntityFrameworkCore;

namespace MinimalAPIKeeda.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public bool IsPopular { get; set; }
    }
    class ProductDb : DbContext
    {
        public ProductDb(DbContextOptions<ProductDb> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}
