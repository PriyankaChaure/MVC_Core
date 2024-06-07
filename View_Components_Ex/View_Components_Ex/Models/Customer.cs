using Microsoft.AspNetCore.Mvc.Formatters;


namespace View_Components_Ex.Models
{
    public class Customer
    {
        public  Int64 CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string  Address { get; set; }
        public string  EmailId { get; set; }
        public string MobileNo { get; set; }
        public decimal CreaditLimit { get; set; }
        public  List<Customer> GetCustomers ()
        {
            List<Customer> lst = new List<Customer>();
            lst.Add(new Customer { CustomerId=1,CustomerName="Sweety",Address="Pune",EmailId="sweety@gmail.com",MobileNo="9876543210",CreaditLimit=50000});
            lst.Add(new Customer { CustomerId = 2, CustomerName = "Guddi", Address = "Pimpri", EmailId = "guddi@gmail.com", MobileNo = "9876549999", CreaditLimit = 60000 });
            lst.Add(new Customer { CustomerId = 3, CustomerName = "Nishu", Address = "Akurdi", EmailId = "nishu@gmail.com", MobileNo = "9876548888", CreaditLimit = 70000 });
            lst.Add(new Customer { CustomerId = 4, CustomerName = "Vishakha", Address = "Chichwad", EmailId = "vishakha@gmail.com", MobileNo = "9876545555", CreaditLimit = 80000 });
            lst.Add(new Customer { CustomerId = 5, CustomerName = "Priya", Address = "Khadki", EmailId = "priya@gmail.com", MobileNo = "9876541111", CreaditLimit = 90000 });
            return lst;
        }
    }
}
