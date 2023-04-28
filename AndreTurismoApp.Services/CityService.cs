using AndreTurismoApp.Models;
using AndreTurismoApp.Repositories;
using AndreTurismoAppRepositories;

namespace AndreTurismoApp.Services
{
    public class CityService
    {
        //Injeção de Dependencias para chamar os repositories.
        private readonly ICityRepository _cityRepository;
        public CityService()
        {
            _cityRepository =  new CityRepository();
        }

        public City Insert(City city)
        {
            return _cityRepository.Create(city);
        }
        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }
        public City GetById(City city)
        {
            return _cityRepository.GetById(city);
        }
        public void Update(City city)
        {           
            city = _cityRepository.GetById(city);
            try
            {
                _cityRepository.Update(city);                
            }
            catch (Exception e )
            {               
                throw new (e.Message);
            }            
        }
        public void Delete(int id)
        {
            try
            {
                _cityRepository.Delete(id);
            }
            catch
            {
                throw;
            }            
        }

    }
}