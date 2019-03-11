using graphQLS.GraphQL.Types;
using graphQLS.Repositories;
using GraphQL.Types;

namespace graphQLS.GraphQL
{
    public class CarvedRockQuery: ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products", 
                resolve: context => productRepository.GetAll()
            );
        }
    }
}
