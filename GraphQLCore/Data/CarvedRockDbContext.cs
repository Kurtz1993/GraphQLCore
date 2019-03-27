using GraphQLCore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLCore.Data
{
    public class CarvedRockDbContext: DbContext
    {
        public CarvedRockDbContext(DbContextOptions<CarvedRockDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
