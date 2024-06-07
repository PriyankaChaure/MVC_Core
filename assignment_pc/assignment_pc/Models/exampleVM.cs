using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class exampleVM
    {
        public Int64 AreaId { get; set; }
        public string AreaName { get; set; }
        public Int64 BillId { get; set; }
        public DateTime BillDate { get; set; }
        public Int64 BillNo { get; set; }
        public decimal BillAmount { get; set; }
        public Int64 CityId { get; set; }
        public string CityName { get; set; }
        public Int64 CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Int64 PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal? TotalBillAmount {  get; set; }
        public decimal? TotalPaidAmount { get;set; }
        public decimal? BalanceAmount { get; set; }
    }
}