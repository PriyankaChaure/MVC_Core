using System;
using System.Collections.Generic;

namespace usedefaultfiles.Models
{
    public class Customer
    {
        public Int64 customerid {  get; set; }
        public string customername { get; set; }
        public string customeraddress { get; set; }
        public string customeremailid { get; set; }
        public string customermobileno { get; set; }
        public decimal customercreditlimit { get; set; }

        public List<Customer> GetCustomers()
        {
            List<Customer> cust = new List<Customer>();
            cust.Add(new Customer() { customerid = 1, customername = "Priyanka",customeraddress="Pune",customeremailid="priya@gmail.com",customermobileno="9876543210",customercreditlimit=55000 });
            cust.Add(new Customer() { customerid = 2, customername = "sweety", customeraddress = "Mumbai", customeremailid = "sweety@gmail.com", customermobileno = "1111543210", customercreditlimit = 45000 });
            cust.Add(new Customer() { customerid = 3, customername = "Guddi", customeraddress = "nashik", customeremailid = "guddi@gmail.com", customermobileno = "2222543210", customercreditlimit = 35000 });
            cust.Add(new Customer() { customerid = 4, customername = "vishakha", customeraddress = "nagpur", customeremailid = "vishakha@gmail.com", customermobileno = "3333543210", customercreditlimit = 25000 });
            cust.Add(new Customer() { customerid = 5, customername = "Nishu", customeraddress = "Goa", customeremailid = "nishu@gmail.com", customermobileno = "4444543210", customercreditlimit = 15000 });
            cust.Add(new Customer() { customerid = 6, customername = "Prachi", customeraddress = "Delhi", customeremailid = "prachi@gmail.com", customermobileno = "555543210", customercreditlimit = 65000 });
            cust.Add(new Customer() { customerid = 7, customername = "Sonali", customeraddress = "Chennai", customeremailid = "sonali@gmail.com", customermobileno = "6666543210", customercreditlimit = 75000 });
            cust.Add(new Customer() { customerid = 8, customername = "shweta", customeraddress = "Dubai", customeremailid = "shweta@gmail.com", customermobileno = "7777543210", customercreditlimit = 85000 });
            cust.Add(new Customer() { customerid = 9, customername = "Shital", customeraddress = "Kamshet", customeremailid = "shital@gmail.com", customermobileno = "8888543210", customercreditlimit = 95000 });
            cust.Add(new Customer() { customerid = 10, customername = "Piya", customeraddress = "Kharadi", customeremailid = "piya@gmail.com", customermobileno = "9999543210", customercreditlimit = 5000 });
            return cust;
        }

    }
}
