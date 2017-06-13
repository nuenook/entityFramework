using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace TestWebAPICalling
{
    class Program
    {
        
        static HttpClient client = new HttpClient();
        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task<Customer> GetCustomerAsync(string path)
        {
            Customer product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Customer>();
            }
            return product;
        }

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost/api/Webapitest");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Customer ReCus = new Customer();
            

            
            Console.Write(ReCus.ToString());
            Console.ReadLine();
            
            
        }

        public class Customer
        {
            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }

        }
    }
}
