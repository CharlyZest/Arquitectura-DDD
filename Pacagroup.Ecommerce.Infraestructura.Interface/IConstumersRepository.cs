using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Infraestructura.Interface
{
    public interface IConstumersRepository
    {
        #region Sync Methods

        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(string customerId);
        Customers Get(string customerId);
        IEnumerable<Customers> GetAll();

        #endregion Sync Methods

        #region Async Methods

        Task<bool> InsertAync(Customers customer);
        Task<bool> UpdateAync(Customers customer);
        Task<bool> DeleteAync(string customerId);
        Task<Customers> GetAync(string customerId);
        Task<IEnumerable<Customers>> GetAllAync();

        #endregion Async Methods
    }
}
