using System.Collections.Generic;
using System.Threading.Tasks;
using graphQLS.Data;
using graphQLS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace graphQLS.Repositories
{
    public class ProductRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public ProductRepository(CarvedRockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Product>> GetAll()
        {
            return _dbContext.Products.ToListAsync();
        }
    }
}
