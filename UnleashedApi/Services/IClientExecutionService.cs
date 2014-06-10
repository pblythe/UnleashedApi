using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnleashedApi.Models;

namespace UnleashedApi.Services
{
    public interface IClientExecutionService
    {
        Task<IPaginatedList<T>> ExecutePagination<T>(string resource, int page, object parameters = null);
        Task<IList<T>> ExecuteList<T>(string resource, object parameters = null);
        Task<T> ExecuteSingle<T>(string resource, Guid id) where T : new();
        Task ExecutePayload<T>(string resource, T model) where T : class, IKey, new();
    }
}