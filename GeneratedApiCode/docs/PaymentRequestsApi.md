# Applications.WeShare.Swagger.Api.PaymentRequestsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePaymentRequest**](PaymentRequestsApi.md#createpaymentrequest) | **POST** /api/paymentrequests | Create a new payment request |
| [**FindAllPaymentRequests**](PaymentRequestsApi.md#findallpaymentrequests) | **GET** /api/paymentrequests | Find all payment requests |
| [**FindPaymentRequestsReceived**](PaymentRequestsApi.md#findpaymentrequestsreceived) | **GET** /api/paymentrequests/received/{personId} | Find payment requests received by a person |
| [**FindPaymentRequestsSent**](PaymentRequestsApi.md#findpaymentrequestssent) | **GET** /api/paymentrequests/sent/{personId} | Find payment requests sent by a person |
| [**GetPaymentRequestById**](PaymentRequestsApi.md#getpaymentrequestbyid) | **GET** /api/paymentrequests/{paymentRequestId} | Get payment request by ID |
| [**RecallUnpaidPaymentRequest**](PaymentRequestsApi.md#recallunpaidpaymentrequest) | **DELETE** /api/paymentrequests/{paymentRequestId} | Recall an unpaid payment request |

<a name="createpaymentrequest"></a>
# **CreatePaymentRequest**
> PaymentRequestDTO CreatePaymentRequest (NewPaymentRequestDTO newPaymentRequestDTO = null)

Create a new payment request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class CreatePaymentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentRequestsApi(config);
            var newPaymentRequestDTO = new NewPaymentRequestDTO(); // NewPaymentRequestDTO |  (optional) 

            try
            {
                // Create a new payment request
                PaymentRequestDTO result = apiInstance.CreatePaymentRequest(newPaymentRequestDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentRequestsApi.CreatePaymentRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePaymentRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new payment request
    ApiResponse<PaymentRequestDTO> response = apiInstance.CreatePaymentRequestWithHttpInfo(newPaymentRequestDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentRequestsApi.CreatePaymentRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newPaymentRequestDTO** | [**NewPaymentRequestDTO**](NewPaymentRequestDTO.md) |  | [optional]  |

### Return type

[**PaymentRequestDTO**](PaymentRequestDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Persons or Expense not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallpaymentrequests"></a>
# **FindAllPaymentRequests**
> List&lt;PaymentRequestDTO&gt; FindAllPaymentRequests ()

Find all payment requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindAllPaymentRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentRequestsApi(config);

            try
            {
                // Find all payment requests
                List<PaymentRequestDTO> result = apiInstance.FindAllPaymentRequests();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentRequestsApi.FindAllPaymentRequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllPaymentRequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find all payment requests
    ApiResponse<List<PaymentRequestDTO>> response = apiInstance.FindAllPaymentRequestsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentRequestsApi.FindAllPaymentRequestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PaymentRequestDTO&gt;**](PaymentRequestDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpaymentrequestsreceived"></a>
# **FindPaymentRequestsReceived**
> List&lt;PaymentRequestDTO&gt; FindPaymentRequestsReceived (int personId)

Find payment requests received by a person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindPaymentRequestsReceivedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentRequestsApi(config);
            var personId = 56;  // int | The ID of the person that received payment requests

            try
            {
                // Find payment requests received by a person
                List<PaymentRequestDTO> result = apiInstance.FindPaymentRequestsReceived(personId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentRequestsApi.FindPaymentRequestsReceived: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindPaymentRequestsReceivedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find payment requests received by a person
    ApiResponse<List<PaymentRequestDTO>> response = apiInstance.FindPaymentRequestsReceivedWithHttpInfo(personId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentRequestsApi.FindPaymentRequestsReceivedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personId** | **int** | The ID of the person that received payment requests |  |

### Return type

[**List&lt;PaymentRequestDTO&gt;**](PaymentRequestDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Person not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findpaymentrequestssent"></a>
# **FindPaymentRequestsSent**
> List&lt;PaymentRequestDTO&gt; FindPaymentRequestsSent (int personId)

Find payment requests sent by a person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindPaymentRequestsSentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentRequestsApi(config);
            var personId = 56;  // int | The ID of the person that sent payment requests

            try
            {
                // Find payment requests sent by a person
                List<PaymentRequestDTO> result = apiInstance.FindPaymentRequestsSent(personId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentRequestsApi.FindPaymentRequestsSent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindPaymentRequestsSentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find payment requests sent by a person
    ApiResponse<List<PaymentRequestDTO>> response = apiInstance.FindPaymentRequestsSentWithHttpInfo(personId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentRequestsApi.FindPaymentRequestsSentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personId** | **int** | The ID of the person that sent payment requests |  |

### Return type

[**List&lt;PaymentRequestDTO&gt;**](PaymentRequestDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Person not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentrequestbyid"></a>
# **GetPaymentRequestById**
> PaymentRequestDTO GetPaymentRequestById (int paymentRequestId)

Get payment request by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class GetPaymentRequestByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentRequestsApi(config);
            var paymentRequestId = 56;  // int | The payment request ID

            try
            {
                // Get payment request by ID
                PaymentRequestDTO result = apiInstance.GetPaymentRequestById(paymentRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentRequestsApi.GetPaymentRequestById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentRequestByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get payment request by ID
    ApiResponse<PaymentRequestDTO> response = apiInstance.GetPaymentRequestByIdWithHttpInfo(paymentRequestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentRequestsApi.GetPaymentRequestByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentRequestId** | **int** | The payment request ID |  |

### Return type

[**PaymentRequestDTO**](PaymentRequestDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | PaymentRequest not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recallunpaidpaymentrequest"></a>
# **RecallUnpaidPaymentRequest**
> void RecallUnpaidPaymentRequest (int paymentRequestId)

Recall an unpaid payment request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class RecallUnpaidPaymentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentRequestsApi(config);
            var paymentRequestId = 56;  // int | The payment request ID

            try
            {
                // Recall an unpaid payment request
                apiInstance.RecallUnpaidPaymentRequest(paymentRequestId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentRequestsApi.RecallUnpaidPaymentRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecallUnpaidPaymentRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Recall an unpaid payment request
    apiInstance.RecallUnpaidPaymentRequestWithHttpInfo(paymentRequestId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentRequestsApi.RecallUnpaidPaymentRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentRequestId** | **int** | The payment request ID |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Recalled |  -  |
| **400** | Payment Request could not be recalled |  -  |
| **404** | Payment Request not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

