using graphQLS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace graphQLS.Data
{
    public class CarvedRockDbContext: DbContext
    {
        public CarvedRockDbContext(DbContextOptions<CarvedRockDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
