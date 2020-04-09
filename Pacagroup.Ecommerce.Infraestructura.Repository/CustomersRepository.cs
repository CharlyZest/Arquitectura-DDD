using System;
using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Infraestructura.Interface;
using Pacagroup.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Pacagroup.Ecommerce.Infraestructura.Repository
{
    public class CustomersRepository : IConstumersRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomersRepository(IConnectionFactory connectionFactory) { _connectionFactory = connectionFactory; }

        #region Sync Methods

        public bool Insert(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerID);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Update(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerID);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Delete(string customerID)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerID);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public Customers Get(string customerID)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetByID";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerID);

                var result = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGet";

                var result = connection.Query<Customers>(query, commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        #endregion Sync Methods

        #region Async Methods

        public async Task<bool> InsertAsync(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerID);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customers customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customer.CustomerID);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(string customerID)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerID);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<Customers> GetAsync(string customerID)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetByID";
                var parameters = new DynamicParameters();

                parameters.Add("CustomerID", customerID);

                var result = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGet";

                var result = await connection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        #endregion Async Methods
    }
}
