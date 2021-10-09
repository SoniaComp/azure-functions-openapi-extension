using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Resolvers;

using Newtonsoft.Json.Serialization;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.TestApp.Examples
{
    public class SingleParameterExample : OpenApiExample<float>
    {
        public override IOpenApiExample<float> Build(NamingStrategy namingStrategy = null)
        {
            this.Examples.Add(OpenApiExampleResolver.Resolve("singleValue1", (float)1.1, namingStrategy));
            this.Examples.Add(OpenApiExampleResolver.Resolve("singleValue2", (float)0.0, namingStrategy));
            return this;
        }
    }
}
