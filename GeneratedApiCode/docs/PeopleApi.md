# Applications.WeShare.Swagger.Api.PeopleApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FindAllPeople**](PeopleApi.md#findallpeople) | **GET** /people | Find all people that use WeShare |
| [**FindPersonById**](PeopleApi.md#findpersonbyid) | **GET** /api/people/{personId} | Find a person by ID |
| [**Login**](PeopleApi.md#login) | **POST** /api/people | Login to WeShare |

<a name="findallpeople"></a>
# **FindAllPeople**
> List&lt;Person&gt; FindAllPeople ()

Find all people that use WeShare

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindAllPeopleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PeopleApi(config);

            try
            {
                // Find all people that use WeShare
                List<Person> result = apiInstance.FindAllPeople();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleApi.FindAllPeople: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllPeopleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find all people that use WeShare
    ApiResponse<List<Person>> response = apiInstance.FindAllPeopleWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleApi.FindAllPeopleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Person&gt;**](Person.md)

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

<a name="findpersonbyid"></a>
# **FindPersonById**
> Person FindPersonById (int personId)

Find a person by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindPersonByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PeopleApi(config);
            var personId = 56;  // int | The ID of the person

            try
            {
                // Find a person by ID
                Person result = apiInstance.FindPersonById(personId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleApi.FindPersonById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindPersonByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find a person by ID
    ApiResponse<Person> response = apiInstance.FindPersonByIdWithHttpInfo(personId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleApi.FindPersonByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personId** | **int** | The ID of the person |  |

### Return type

[**Person**](Person.md)

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

<a name="login"></a>
# **Login**
> Person Login (LoginDTO loginDTO = null)

Login to WeShare

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PeopleApi(config);
            var loginDTO = new LoginDTO(); // LoginDTO |  (optional) 

            try
            {
                // Login to WeShare
                Person result = apiInstance.Login(loginDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleApi.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login to WeShare
    ApiResponse<Person> response = apiInstance.LoginWithHttpInfo(loginDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleApi.LoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginDTO** | [**LoginDTO**](LoginDTO.md) |  | [optional]  |

### Return type

[**Person**](Person.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad email address |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

