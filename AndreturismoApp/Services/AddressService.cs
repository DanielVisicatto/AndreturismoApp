﻿using AndreTurismoApp.Models;
using Newtonsoft.Json;

namespace AndreturismoApp.Services
{
    public class AddressService
    {
        static readonly HttpClient addressClient = new();

        public async Task<List<Address>> GetAddress()
        {
            try
            {
                HttpResponseMessage response = await AddressService.addressClient.GetAsync("https://localhost:7060/api/Addresses");
                response.EnsureSuccessStatusCode();
                string address = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Address>>(address);
            }
            catch (HttpRequestException e)
            {
                throw new  (e.Message);
            }
        }

    }
}
