using AndreTurismoApp.Models;
using Dapper;
using System.Data.SqlClient;

namespace AndreTurismoApp.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        #region[DbConnection]
        static readonly string _stringConnection = @"Server=(localdb)\MSSQLLocalDB;Integrated Security = true; AttachDbFileName=C:\Banco\AndreTurismo.mdf;";        
        #endregion
        public Address Create(Address address)
        {
            Address a;
            using (var db = new SqlConnection(_stringConnection))
            {
                address.RegisterDate = DateTime.Now;
                a = (Address)db.ExecuteScalar(Address.INSERT, address);
            }
            return a;
        }

        public void Delete(int id)
        {
            using (var db = new SqlConnection(_stringConnection))
            {
                db.Execute(Address.DELETE);
            }
        }

        public List<Address> GetAll()
        {
            List<Address> addresses;
            using (var db = new SqlConnection(_stringConnection))
            {
                addresses = db.Query<Address>(Address.GET_ALL).ToList();
            }
            return addresses;
        }

        public Address GetById(Address address)
        {
            Address a;
            using (var db = new SqlConnection(_stringConnection))
            {
                a = (Address)db.Query(Address.GET, new { @Id = address.Id });
            }
            return a;
        }

        public void Update(Address address)
        {
            using (var db = new SqlConnection(_stringConnection))
            {
                db.Execute(Address.UPDATE, address);
            }
        }
    }
}
