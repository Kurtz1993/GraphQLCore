using GraphQL.Types;
using GraphQLCore.GraphQL.Types;
using GraphQLCore.Repositories;

namespace GraphQLCore.GraphQL
{
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("products", resolve: context => productRepository.GetAll());
        }
    }
}
