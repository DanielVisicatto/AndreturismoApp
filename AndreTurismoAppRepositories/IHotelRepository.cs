using AndreTurismoApp.Models;

namespace AndreTurismoApp.Repositories
{
    public interface IHotelRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        Hotel GetById();
        List<Hotel> GetAll();
    }
}
