using AndreTurismoApp.Models;

namespace AndreTurismoApp.Repositories
{
    public interface IPackageRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        Package GetById();
        List<Package> GetAll();

    }
}
