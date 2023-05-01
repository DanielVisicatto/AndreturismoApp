using AndreTurismoApp.Models;
using Newtonsoft.Json;

namespace AndreturismoApp.Services
{
    public class TicketService
    {
        static readonly HttpClient ticketClient = new();

        public async Task<List<Ticket>> GetTicket()
        {
            try
            {
                HttpResponseMessage response = await TicketService.ticketClient.GetAsync("");
                response.EnsureSuccessStatusCode();
                string ticket = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Ticket>>(ticket);
            }
            catch (HttpRequestException e)
            {
                throw new(e.Message);
            }
        }
    }
}
