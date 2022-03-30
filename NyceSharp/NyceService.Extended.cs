using System;
using Newtonsoft.Json;
using NyceSharp.CustomModels.CustomerReturnResponse;
using NyceSharp.CustomModels.Inventory;
using NyceSharp.CustomModels.InventoryLocation;
using NyceSharp.CustomModels.ProcessedOrder;
using NyceSharp.CustomModels.PurchaseOrderResponse;

namespace NyceSharp
{
    public class ErrorResponse
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int Status { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("traceId", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

    }

    public partial class NyceServiceException
    {
        public ErrorResponse ErrorResponse
        {
            get
            {
                try
                {
                    return JsonConvert.DeserializeObject<ErrorResponse>(Response);
                }
                catch (Exception)
                {
                    //Ignore
                    return null;
                }
            }
        }
    }

    public partial class NyceService
    {
        public async System.Threading.Tasks.Task<ProcessedOrderResponse> ApiGetCustomProcessedordersByPageAsync(System.DateTimeOffset? lastModifiedTime, string orderids, int? pageNumber)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/custom/processedordersbypage?");
            if (lastModifiedTime != null)
            {
                urlBuilder_.Append("lastModifiedTime=").Append(System.Uri.EscapeDataString(lastModifiedTime.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderids != null)
            {
                urlBuilder_.Append("orderids=").Append(System.Uri.EscapeDataString(ConvertToString(orderids, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pageNumber != null)
            {
                urlBuilder_.Append("pageNumber=").Append(System.Uri.EscapeDataString(ConvertToString(pageNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, System.Threading.CancellationToken.None).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ProcessedOrderResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ProcessedOrderResponse>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ProblemDetails);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ProblemDetails>(responseData_, _settings.Value);
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new NyceServiceException<ProblemDetails>("A server side error occurred.", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new NyceServiceException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        return default(ProcessedOrderResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        public async System.Threading.Tasks.Task<InventoryReponse> ApiGetCustomInventoryByPageAsync(System.DateTimeOffset? lastModifiedTime, string skus, int? pageNumber)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/custom/inventorybypage?");
            if (lastModifiedTime != null)
            {
                urlBuilder_.Append("lastModifiedTime=").Append(System.Uri.EscapeDataString(lastModifiedTime.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skus != null)
            {
                urlBuilder_.Append("skus=").Append(System.Uri.EscapeDataString(ConvertToString(skus, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pageNumber != null)
            {
                urlBuilder_.Append("pageNumber=").Append(System.Uri.EscapeDataString(ConvertToString(pageNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, System.Threading.CancellationToken.None).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(InventoryReponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<InventoryReponse>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ProblemDetails);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ProblemDetails>(responseData_, _settings.Value);
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new NyceServiceException<ProblemDetails>("A server side error occurred.", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new NyceServiceException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        return default(InventoryReponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        public async System.Threading.Tasks.Task<InventoryLocationReponse> ApiGetCustomInventorylocationByPageAsync(System.DateTimeOffset? lastModifiedTime, string skus, int? pageNumber)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/custom/inventorylocationbypage?");
            if (lastModifiedTime != null)
            {
                urlBuilder_.Append("lastModifiedTime=").Append(System.Uri.EscapeDataString(lastModifiedTime.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (skus != null)
            {
                urlBuilder_.Append("skus=").Append(System.Uri.EscapeDataString(ConvertToString(skus, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pageNumber != null)
            {
                urlBuilder_.Append("pageNumber=").Append(System.Uri.EscapeDataString(ConvertToString(pageNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, System.Threading.CancellationToken.None).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(InventoryLocationReponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<InventoryLocationReponse>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ProblemDetails);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ProblemDetails>(responseData_, _settings.Value);
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new NyceServiceException<ProblemDetails>("A server side error occurred.", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new NyceServiceException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        return default(InventoryLocationReponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        public async System.Threading.Tasks.Task<PurchaseOrderResponse> ApiGetCustomPurchaseorderGetAsync(System.DateTimeOffset? lastModifiedTime, string orderids, int? pageNumber)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/custom/purchaseorderbypage?");
            if (lastModifiedTime != null)
            {
                urlBuilder_.Append("lastModifiedTime=").Append(System.Uri.EscapeDataString(lastModifiedTime.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderids != null)
            {
                urlBuilder_.Append("orderids=").Append(System.Uri.EscapeDataString(ConvertToString(orderids, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pageNumber != null)
            {
                urlBuilder_.Append("pageNumber=").Append(System.Uri.EscapeDataString(ConvertToString(pageNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, System.Threading.CancellationToken.None).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(PurchaseOrderResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<PurchaseOrderResponse>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ProblemDetails);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ProblemDetails>(responseData_, _settings.Value);
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new NyceServiceException<ProblemDetails>("A server side error occurred.", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new NyceServiceException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        return default(PurchaseOrderResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        public async System.Threading.Tasks.Task<CustomerReturnResponse> ApiGetCustomReturnorderByPageGetAsync(System.DateTimeOffset? lastModifiedTime, string orderids, int? pageNumber)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/custom/returnorderbypage?");
            if (lastModifiedTime != null)
            {
                urlBuilder_.Append("lastModifiedTime=").Append(System.Uri.EscapeDataString(lastModifiedTime.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderids != null)
            {
                urlBuilder_.Append("orderids=").Append(System.Uri.EscapeDataString(ConvertToString(orderids, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (pageNumber != null)
            {
                urlBuilder_.Append("pageNumber=").Append(System.Uri.EscapeDataString(ConvertToString(pageNumber, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, System.Threading.CancellationToken.None).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "200")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(CustomerReturnResponse);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<CustomerReturnResponse>(responseData_, _settings.Value);
                                return result_;
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                        }
                        else
                        if (status_ == "400")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            var result_ = default(ProblemDetails);
                            try
                            {
                                result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ProblemDetails>(responseData_, _settings.Value);
                            }
                            catch (System.Exception exception_)
                            {
                                throw new NyceServiceException("Could not deserialize the response body.", (int)response_.StatusCode, responseData_, headers_, exception_);
                            }
                            throw new NyceServiceException<ProblemDetails>("A server side error occurred.", (int)response_.StatusCode, responseData_, headers_, result_, null);
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new NyceServiceException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }
                        return default(CustomerReturnResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }
    }
}
