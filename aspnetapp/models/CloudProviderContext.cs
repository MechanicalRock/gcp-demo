using Microsoft.EntityFrameworkCore;
namespace aspnetapp.Models
{
    public class CloudProviderContext : DbContext
    {
        public CloudProviderContext(DbContextOptions<CloudProviderContext> options) : base(options)
        {
        }
        public DbSet<CloudProvider> CloudProviders { get; set; }

    }
}