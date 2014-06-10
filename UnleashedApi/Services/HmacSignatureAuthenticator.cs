using RestSharp;
using System;
using System.Security.Cryptography;

namespace UnleashedApi.Services
{
    public class HmacSignatureAuthenticator : IAuthenticator
    {
        private readonly string _apiId;
        private readonly string _apiKey;

        public HmacSignatureAuthenticator(string apiId, string apiKey)
        {
            _apiId = apiId;
            _apiKey = apiKey;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddHeader("api-auth-id", _apiId);
            request.AddHeader("api-auth-signature", GenerateSignature(client, request));
        }

        private string GenerateSignature(IRestClient client, IRestRequest request)
        {
            var uri = client.BuildUri(request);
            var query = uri.Query;

            if (!string.IsNullOrEmpty(query))
                query = query.Substring(1);

            var encoding = new System.Text.ASCIIEncoding();
            var key = encoding.GetBytes(_apiKey);
            var myhmacsha256 = new HMACSHA256(key);
            var hashValue = myhmacsha256.ComputeHash(encoding.GetBytes(query));
            var hmac64 = Convert.ToBase64String(hashValue);
            return hmac64;
        }
    }
}
