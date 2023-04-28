using AndreTurismoApp.Models;
using System.Data.SqlClient;

namespace AndreTurismoApp.Repositories
{
    public class PacageRepository : IPackageRepository
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

        public List<Package> GetAll()
        {
            throw new NotImplementedException();
        }

        public Package GetById()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
