using AndreTurismoApp.Models;
using AndreTurismoApp.Repositories;
using System.Data.SqlClient;
using Dapper;

namespace AndreTurismoAppRepositories
{
    public class CityRepository : ICityRepository
    {
        #region[DbConnection]
        private readonly string _stringConnection = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=C:\Banco\AndreTurismo.mdf;";
        
        #endregion
        public City Create(City city)
        {
            City c;
            using (var db = new SqlConnection(_stringConnection))
            {               
                c = (City)db.ExecuteScalar(City.INSERT, city);
            }
            return c;
        }

        public void Delete(int id)
        {
            using (var db = new SqlConnection(_stringConnection))
            {                
                db.Execute(City.DELETE);
            }            
        }

        public List<City> GetAll()
        {
            List<City> cities;
            using (var db = new SqlConnection(_stringConnection))
            {               
                cities = db.Query<City>(City.GET_ALL).ToList();
            }
                return cities;
        }

        public City GetById(City city)
        {
            City c;
            using (var db = new SqlConnection(_stringConnection))
            {
                c = (City)db.Query(City.GET, new {@Id = city.Id});
            }
            return c;
        }

        public void Update(City city)
        {
            using (var db = new SqlConnection(_stringConnection))
            {
                db.Execute(City.UPDATE, city);
            }
        }
    }
}