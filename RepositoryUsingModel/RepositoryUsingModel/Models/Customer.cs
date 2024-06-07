using System;

namespace RepositoryUsingModel.Models
{
    public class Customer
    {
        public Int64 customerid { get; set; }
        public string customername { get; set; }
        public string customeraddress { get; set; }
        public string customerphone { get; set; }
        public string customeremailid { get; set; }
        public decimal customercreditlimit{ get; set; }
    }
}
