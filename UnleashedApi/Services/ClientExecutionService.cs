using System.Globalization;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using System;
using System.Collections.Generic;
using UnleashedApi.Exceptions;
using UnleashedApi.Models;

namespace UnleashedApi.Services
{
    public class ClientExecutionService : IClientExecutionService
    {
        private readonly RestClient _client; 

        public ClientExecutionService(IApiSettings settings)
        {
            _client = BuildClient(settings);
        }

        private RestClient BuildClient(IApiSettings settings)
        {
            return new RestClient(settings.Url)
            {
                Authenticator = new HmacSignatureAuthenticator(settings.ApiId, settings.ApiKey),
                UserAgent = "UnleashedApi.Net 1.0"
            };
        }

        public Task<IPaginatedList<T>> ExecutePagination<T>(string resource, int page, object parameters = null)
        {
            var request = new RestRequest(resource, Method.GET);
            request.AddUrlSegment("page", page.ToString(CultureInfo.InvariantCulture));
            request.AddParameters(parameters);

            return ExecuteRequest<RequestMetadata<T>>(request).ContinueWith(p => p.Result.ToPaginatedList());
        }

        public Task<IList<T>> ExecuteList<T>(string resource, object parameters = null)
        {
            var request = new RestRequest(resource, Method.GET);
            request.AddParameters(parameters);
            request.RequestFormat = DataFormat.Json;

            return ExecuteRequest<RequestMetadata<T>>(request).ContinueWith<IList<T>>(p => p.Result.Items);
        }

        public Task<T> ExecuteSingle<T>(string resource, Guid id) where T : new()
        {
            var request = new RestRequest(resource, Method.GET);
            request.AddUrlSegment("id", id.ToString());
            request.RequestFormat = DataFormat.Json;
            return ExecuteRequest<T>(request);
        }

        public Task ExecutePayload<T>(string resource, T model) where T : class, IKey, new()
        {
            if (model == null)
                throw new ArgumentNullException("model");

            if (model.Guid == Guid.Empty)
                model.Guid = Guid.NewGuid();

            var request = new RestRequest(resource, Method.POST) { RequestFormat = DataFormat.Json };
            request.AddUrlSegment("id", model.Guid.ToString());
            request.AddBody(model);

            return ExecuteRequest<T>(request);
        }

        private Task<T> ExecuteRequest<T>(IRestRequest request) where T : new()
        {
            if (request == null)
                throw new ArgumentNullException("request");

            //Adds Unique Slug On The End Of Http Requests
            request.AddParameter("timestamp", DateTime.UtcNow.Ticks);

            //Optimize for small http requests
            ServicePointManager.UseNagleAlgorithm = false;

            var taskCompletionSource = new TaskCompletionSource<T>();
            _client.ExecuteAsync<T>(request, (response) =>
            {
                if (response.ErrorException != null)
                {
                    taskCompletionSource.SetException(new RequestException("There was a problem processing the request, see inner exception for details", response.ErrorException));
                    return;
                }

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    taskCompletionSource.SetException(new NotFoundException(string.Format("Resource With Uri '{0}' Couldn't Be Found", response.ResponseUri)));
                    return;
                }

                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    taskCompletionSource.SetException(new InvalidRequestException(string.Format("BadRequest {0}", response.Content)));
                    return;
                }

                if (response.StatusCode == HttpStatusCode.Forbidden)
                {
                    taskCompletionSource.SetException(new AuthenticationException(string.Format("Request ApiId/Signature Invalid, {0}", response.Content)));
                    return;
                }

                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    taskCompletionSource.SetException(new RequestException(string.Format("There was a problem processing the request {0}", response.Content)));
                    return;
                }

                taskCompletionSource.SetResult(response.Data);
            });

            return taskCompletionSource.Task;
        }
    }
}
