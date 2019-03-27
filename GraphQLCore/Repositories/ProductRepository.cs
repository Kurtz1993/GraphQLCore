using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLCore.Data;
using GraphQLCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLCore.Repositories
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
