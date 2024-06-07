using RepositoryUsingModel.Models;
using System.Collections.Generic;

namespace RepositoryUsingModel.Repositories
{
    public interface CustInterface
    {
        List<Customer> GetAll();
        void addcustomer(Customer cust);
        int getcount();
    }
}
