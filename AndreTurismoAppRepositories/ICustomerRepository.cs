using AndreTurismoApp.Models;

namespace AndreTurismoApp.Repositories
{
    public interface ICustomerRepository
    {
        bool Create();
        bool Update();
        bool Delete();
        Customer GetById();
        List<Customer> GetAll();
    }
}
