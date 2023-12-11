using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Client;
using Applications.WeShare.Swagger.Model;
using RestSharp;


namespace OpenApiTests;

    public class PaymentRequestHelper
    {

        protected static string basePath = "http://localhost:5050";

        protected static RestClient client = new RestClient(basePath);


        protected static PaymentRequestDTO CreatePaymentRequest(NewPaymentRequestDTO newPaymentRequestDTO)
        {
            RestRequest request = new RestRequest("/api/paymentrequests");
            request.AddBody(newPaymentRequestDTO);
            return client.PostAsync<PaymentRequestDTO>(request).GetAwaiter().GetResult();
        }

        protected static System.Collections.Generic.List<PaymentRequestDTO>  FindAllPaymentRequests()
        {
            RestRequest request = new RestRequest("/api/paymentrequests");
            return client.GetAsync<System.Collections.Generic.List<PaymentRequestDTO> >(request).GetAwaiter().GetResult();
        }

        protected static System.Collections.Generic.List<PaymentRequestDTO>  FindPaymentRequestsReceivedByPerson(int personId)
        {
            RestRequest request = new RestRequest("/api/paymentrequests/received/" + personId);
            return client.GetAsync<System.Collections.Generic.List<PaymentRequestDTO> >(request).GetAwaiter().GetResult();
        }

        protected static System.Collections.Generic.List<PaymentRequestDTO>  FindPaymentRequestsSentByPerson( int paymentRequestId)
        {
            RestRequest request = new RestRequest("/api/paymentrequests/sent/"+ paymentRequestId);
            return client.GetAsync<System.Collections.Generic.List<PaymentRequestDTO> >(request).GetAwaiter().GetResult();
        }

        protected static PaymentRequestDTO GetPaymentRequestByID(int paymentRequestId)
        {
            RestRequest request = new RestRequest("/api/paymentrequests/"+ paymentRequestId);
            return client.GetAsync<PaymentRequestDTO>(request).GetAwaiter().GetResult();
        }

        protected static void RecallAnUnpaidPaymentRequest( int paymentRequestId)
        {
            RestRequest request = new RestRequest("/api/paymentrequests/"+ paymentRequestId);
            client.DeleteAsync(request).GetAwaiter().GetResult();
        }
    }