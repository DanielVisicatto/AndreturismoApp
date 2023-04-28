using AndreTurismoApp.Models;
using System.Data.SqlClient;

namespace AndreTurismoApp.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        #region[DbConnection]
        static readonly string _stringConnection = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=C:\Banco\AndreTurismo.mdf;";
        static readonly SqlConnection _connection;
        #endregion
        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Hotel GetById()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
