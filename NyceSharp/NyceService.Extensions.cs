using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Abp.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NyceSharp
{
    public partial class NyceService
    {
        public string AccessToken;

        public NyceService(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
            _settings = new Lazy<JsonSerializerSettings>(() =>
            {
                var settings = new JsonSerializerSettings()
                {
                    Error = HandleDeserializationError,
                    NullValueHandling = NullValueHandling.Ignore
                };
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }

        public void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            errorArgs.ErrorContext.Handled = true;
        }

        public NyceService(string baseUrl, string accessToken) : this(baseUrl)
        {
            if (BaseUrl.IsNullOrEmpty() || accessToken.IsNullOrEmpty())
            {
                throw new ArgumentNullException();
            }

            _baseUrl = baseUrl;
            AccessToken = accessToken;
        }

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
        {
        }

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            if (AccessToken != null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            }
        }

        partial void ProcessResponse(HttpClient client, HttpResponseMessage response)
        {
        }

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings)
        {
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
        }
    }
}
