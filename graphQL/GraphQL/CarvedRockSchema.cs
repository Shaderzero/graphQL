using GraphQL;
using GraphQL.Types;

namespace graphQLS.GraphQL
{
    public class CarvedRockSchema: Schema
    {
        public CarvedRockSchema(IDependencyResolver resolver): base(resolver)
        {           
            Query = resolver.Resolve<CarvedRockQuery>();
        }
    }
}
