using AndreTurismoApp.Models;
using Newtonsoft.Json;

namespace AndreturismoApp.Services
{
    public class HotelService
    {
        static readonly HttpClient hotelClient = new();

        public async Task<List<Hotel>> GetHotel()
        {
            try
            {
                HttpResponseMessage response = await HotelService.hotelClient.GetAsync("https://localhost:7221/api/Hotels");
                response.EnsureSuccessStatusCode();
                string hotel = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Hotel>>(hotel);
            }
            catch (HttpRequestException e)
            {
                throw new(e.Message);
            }
        }
    }
}
