using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public abstract class Resource
    {
        protected readonly IClientExecutionService Client;

        protected Resource(IClientExecutionService client)
        {
            Client = client;
        }
    }
}
