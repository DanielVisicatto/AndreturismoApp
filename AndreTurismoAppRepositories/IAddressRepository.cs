using AndreTurismoApp.Models;

namespace AndreTurismoApp.Repositories
{
    public interface IAddressRepository
    {
        Address Create(Address addres);
        void Update(Address address);
        void Delete(int id);
        Address GetById(Address address);
        List<Address> GetAll();
    }
}
