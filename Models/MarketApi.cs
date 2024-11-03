using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Web_Test_Api.Model;

namespace Web_Test_Api.Models
{
    public class MarketApi : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MarketApi(DbContextOptions<MarketApi> opt):base (opt)
        {

        }
      
    }
}
