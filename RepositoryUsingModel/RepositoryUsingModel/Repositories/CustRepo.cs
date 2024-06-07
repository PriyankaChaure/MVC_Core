using System.Collections.Generic;
using System.Linq;
using RepositoryUsingModel.Models;

namespace RepositoryUsingModel.Repositories
{
    public class CustRepo:CustInterface
    {
        private List<Customer> lst;
        public CustRepo() 
        {
            lst = new List<Customer>();
            lst.Add(new Customer() { customerid = 1,customername="Priyanka",customeraddress="pune",customeremailid="priya@gmail.com" ,customerphone="8976543",customercreditlimit=56000}) ;
            lst.Add(new Customer() { customerid = 2, customername = "Sweety", customeraddress = "mumbai", customeremailid = "sweety@gmail.com", customerphone = "9996543", customercreditlimit = 50000 });
            lst.Add(new Customer() { customerid = 3, customername = "Guddi", customeraddress = "nashi", customeremailid = "guddi@gmail.com", customerphone = "4446543", customercreditlimit = 66000 });
            lst.Add(new Customer() { customerid = 4, customername = "Vishakha", customeraddress = "nagpur", customeremailid = "vishakha@gmail.com", customerphone = "2226543", customercreditlimit = 59000 });
            lst.Add(new Customer() { customerid = 5, customername = "Nishu", customeraddress = "delhi", customeremailid = "nishu@gmail.com", customerphone = "6666543", customercreditlimit = 96000 });
        }
        public List<Customer>GetAll()
        {
            return lst;
        }

        public void addcustomer(Customer cust)
        {
            long max=0;
            max = lst.Max(p => p.customerid);
            max++;
            cust.customerid= max;
            lst.Add(cust);
        }
        public int getcount()
        {
            return this.lst.Count();
        }
    }
}
