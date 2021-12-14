using Microsoft.EntityFrameworkCore;
using MVCDemoS.Models;

namespace MVCDemoS.Data
{
    public class ApplicationConnectDb : DbContext
    {
        public ApplicationConnectDb(DbContextOptions<ApplicationConnectDb> options) : base(options)
        {

        }
        public DbSet<SiteInfo> SiteInfo { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
