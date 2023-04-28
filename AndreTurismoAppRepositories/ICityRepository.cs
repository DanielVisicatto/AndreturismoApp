using AndreTurismoApp.Models;

namespace AndreTurismoApp.Repositories
{
    public interface ICityRepository
    {
        City Create(City city);
        void Update(City city);
        void Delete(int id);
        City GetById(City city);
        List<City> GetAll();
    }
}
