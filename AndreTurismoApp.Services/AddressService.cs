using AndreTurismoApp.Models;
using AndreTurismoApp.Repositories;
using AndreTurismoAppRepositories;

namespace AndreTurismoApp.Services
{
    public class AddressService
    {
        private readonly AddressRepository _addressRepository;
        public AddressService(AddressRepository addressService)
        {
            _addressRepository = addressService;
        }

        public Address Insert(Address address)
        {
            return _addressRepository.Create(address);
        }
        public List<Address> GetAll()
        {
            return _addressRepository.GetAll();
        }
        public Address GetById(Address address)
        {
            return _addressRepository.GetById(address);
        }
        public void Update(Address address)
        {
            address = _addressRepository.GetById(address);
            try
            {
                _addressRepository.Update(address);
            }
            catch (Exception e)
            {
                throw new(e.Message);
            }

        }
        public void Delete(int id)
        {
            try
            {
                _addressRepository.Delete(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
