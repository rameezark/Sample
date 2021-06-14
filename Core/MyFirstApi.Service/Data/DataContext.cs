using Microsoft.EntityFrameworkCore;
using MyFirstApi.Model.Model;

namespace MyFirstApi.Service.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TransactionType> BaTransType { get; set; }
    }
}
