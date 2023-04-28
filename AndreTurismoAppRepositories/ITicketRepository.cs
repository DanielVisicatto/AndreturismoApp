using AndreTurismoApp.Models;

namespace AndreTurismoApp.Repositories
{
    public interface ITicketRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        Ticket GetById();
        List<Ticket> GetAll();
    }
}
