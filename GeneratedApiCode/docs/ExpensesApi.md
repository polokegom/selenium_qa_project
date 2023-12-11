# Applications.WeShare.Swagger.Api.ExpensesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateExpense**](ExpensesApi.md#createexpense) | **POST** /api/expenses | Create a new expense for a person |
| [**FindAllExpenses**](ExpensesApi.md#findallexpenses) | **GET** /api/expenses | Find all expenses |
| [**FindExpenseById**](ExpensesApi.md#findexpensebyid) | **GET** /api/expenses/{expenseId} | Find an expense by ID |
| [**FindExpensesByPerson**](ExpensesApi.md#findexpensesbyperson) | **GET** /api/expenses/person/{personId} | Find expenses for a person |

<a name="createexpense"></a>
# **CreateExpense**
> ExpenseDTO CreateExpense (NewExpenseDTO newExpenseDTO = null)

Create a new expense for a person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class CreateExpenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExpensesApi(config);
            var newExpenseDTO = new NewExpenseDTO(); // NewExpenseDTO |  (optional) 

            try
            {
                // Create a new expense for a person
                ExpenseDTO result = apiInstance.CreateExpense(newExpenseDTO);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExpensesApi.CreateExpense: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateExpenseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new expense for a person
    ApiResponse<ExpenseDTO> response = apiInstance.CreateExpenseWithHttpInfo(newExpenseDTO);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExpensesApi.CreateExpenseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newExpenseDTO** | [**NewExpenseDTO**](NewExpenseDTO.md) |  | [optional]  |

### Return type

[**ExpenseDTO**](ExpenseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Person not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findallexpenses"></a>
# **FindAllExpenses**
> List&lt;ExpenseDTO&gt; FindAllExpenses ()

Find all expenses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindAllExpensesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExpensesApi(config);

            try
            {
                // Find all expenses
                List<ExpenseDTO> result = apiInstance.FindAllExpenses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExpensesApi.FindAllExpenses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindAllExpensesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find all expenses
    ApiResponse<List<ExpenseDTO>> response = apiInstance.FindAllExpensesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExpensesApi.FindAllExpensesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ExpenseDTO&gt;**](ExpenseDTO.md)

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

<a name="findexpensebyid"></a>
# **FindExpenseById**
> ExpenseDTO FindExpenseById (int expenseId)

Find an expense by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindExpenseByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExpensesApi(config);
            var expenseId = 56;  // int | The expense ID

            try
            {
                // Find an expense by ID
                ExpenseDTO result = apiInstance.FindExpenseById(expenseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExpensesApi.FindExpenseById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindExpenseByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find an expense by ID
    ApiResponse<ExpenseDTO> response = apiInstance.FindExpenseByIdWithHttpInfo(expenseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExpensesApi.FindExpenseByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **expenseId** | **int** | The expense ID |  |

### Return type

[**ExpenseDTO**](ExpenseDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Expense not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findexpensesbyperson"></a>
# **FindExpensesByPerson**
> List&lt;ExpenseDTO&gt; FindExpensesByPerson (int personId)

Find expenses for a person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;

namespace Example
{
    public class FindExpensesByPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ExpensesApi(config);
            var personId = 56;  // int | The ID of the person

            try
            {
                // Find expenses for a person
                List<ExpenseDTO> result = apiInstance.FindExpensesByPerson(personId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExpensesApi.FindExpensesByPerson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindExpensesByPersonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find expenses for a person
    ApiResponse<List<ExpenseDTO>> response = apiInstance.FindExpensesByPersonWithHttpInfo(personId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExpensesApi.FindExpensesByPersonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personId** | **int** | The ID of the person |  |

### Return type

[**List&lt;ExpenseDTO&gt;**](ExpenseDTO.md)

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

