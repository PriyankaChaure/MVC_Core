using System;

namespace Tag_Helpers.Models
{
    public class Customer
    {
        public Int64 customerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmailId { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerAddress { get; set; }
        public Int64 CityId { get; set; }
        public decimal CustomerCreditLimit { get; set; }
        public Boolean IsActive { get; set; }
        public string Password { get; set; }

    }
}
