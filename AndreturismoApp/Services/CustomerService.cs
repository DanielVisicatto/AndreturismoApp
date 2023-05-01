using AndreTurismoApp.Models;
using Newtonsoft.Json;

namespace AndreturismoApp.Services
{
    public class CustomerService
    {
        static readonly HttpClient customerClient = new();

        public async Task<List<Customer>> GetCustomer()
        {
            try
            {
                HttpResponseMessage response = await CustomerService.customerClient.GetAsync("");
                response.EnsureSuccessStatusCode();
                string customer = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Customer>>(customer);
            }
            catch (HttpRequestException e)
            {
                throw new(e.Message);
            }
        }
    }
}
