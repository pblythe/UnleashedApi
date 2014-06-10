using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;
using UnleashedApi.Services;

namespace UnleashedApi.Resources
{
    public class CompanyResource : Resource
    {
        public CompanyResource(IClientExecutionService client) : base(client) { }

        private const string ListUrl = "/Companies";
        private const string ByIdUrl = "/Companies/{id}";

        public Task<IList<Company>> List()
        {
            return Client.ExecuteList<Company>(ListUrl);
        }

        public Task<Company> ById(Guid id)
        {
            return Client.ExecuteSingle<Company>(ByIdUrl, id);
        }
    }
}
