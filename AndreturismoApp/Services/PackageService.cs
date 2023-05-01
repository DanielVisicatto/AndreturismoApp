using AndreTurismoApp.Models;
using Newtonsoft.Json;

namespace AndreturismoApp.Services
{
    public class PackageService
    {
        static readonly HttpClient packageClient = new();

        public async Task<List<Package>> GetPackage()
        {
            try
            {
                HttpResponseMessage response = await PackageService.packageClient.GetAsync("https://localhost:7247/api/Tickets");
                response.EnsureSuccessStatusCode();
                string package = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Package>>(package);
            }
            catch (HttpRequestException e)
            {
                throw new(e.Message);
            }
        }
    }
}
