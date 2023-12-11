# Applications.WeShare.Swagger.Api.PaymentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FindPaymentsMadeByPerson**](PaymentsApi.md#findpaymentsmadebyperson) | **GET** /api/payments/madeby/{personId} | Find all payments made by a person |
| [**PayPaymentRequest**](PaymentsApi.md#paypaymentrequest) | **POST** /api/payments | Pay a payment request |

<a name="findpaymentsmadebyperson"></a>
# **FindPaymentsMadeByPerson**
> List&lt;PaymentDTO&gt; FindPaymentsMadeByPerson (int personId)

Find all payments made by a person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindPaymentsMadeByPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(config);
            var personId = 56;  // int | The ID of the person

            try
            {
                // Find all payments made by a person
                List<PaymentDTO> result = apiInstance.FindPaymentsMadeByPerson(personId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.FindPaymentsMadeByPerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindPaymentsMadeByPersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find all payments made by a person
    ApiResponse<List<PaymentDTO>> response = apiInstance.FindPaymentsMadeByPersonWithHttpInfo(personId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.FindPaymentsMadeByPersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personId** | **int** | The ID of the person |  |

### Return type

[**List&lt;PaymentDTO&gt;**](PaymentDTO.md)

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

<a name="paypaymentrequest"></a>
# **PayPaymentRequest**
> PaymentDTO PayPaymentRequest (NewPaymentDTO newPaymentDTO = null)

Pay a payment request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class PayPaymentRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentsApi(config);
            var newPaymentDTO = new NewPaymentDTO(); // NewPaymentDTO |  (optional) 

            try
            {
                // Pay a payment request
                PaymentDTO result = apiInstance.PayPaymentRequest(newPaymentDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PayPaymentRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayPaymentRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pay a payment request
    ApiResponse<PaymentDTO> response = apiInstance.PayPaymentRequestWithHttpInfo(newPaymentDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.PayPaymentRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newPaymentDTO** | [**NewPaymentDTO**](NewPaymentDTO.md) |  | [optional]  |

### Return type

[**PaymentDTO**](PaymentDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Could not make payment |  -  |
| **404** | Person, Expense or Payment Request not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

