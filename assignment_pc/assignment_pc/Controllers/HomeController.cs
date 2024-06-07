using assignment_pc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignment_pc.Controllers
{
    public class HomeController : Controller
    {
        ClassContext cc=new ClassContext();
        public ActionResult Index()
        {
            ViewBag.AreaId = new SelectList(this.cc.Areatbls.ToList(), "AreaId", "AreaName");

            //var v = from t1 in this.cc.Areatbls
            //        join t2 in this.cc.citytbls
            //        on t1.CityId equals t2.CityId
            //        join t3 in this.cc.Customers
            //        on t1.AreaId equals t3.AreaId
            //        join t4 in this.cc.bills
            //        on t3.CustomerId equals t4.CustomerId
            //        join t5 in this.cc.Payments
            //        on t4.BillId equals t5.BillId
            //        group t5 by t3.CustomerName
            //        into g
            //        select new exampleVM
            //        {

            //            CustomerName = g.Key,
            //            CustomerId=g.Sum(p=>p.Bill.CustomerId),
            //            TotalBillAmount = g.Sum(p => p.Bill.BillAmount),
            //            TotalPaidAmount = g.Sum(p => p.PaymentAmount),
            //            BalanceAmount = g.Sum(p => p.Bill.BillAmount - p.PaymentAmount)
            //        };
            var v = from t1 in this.cc.Areatbls
                    join t2 in this.cc.citytbls
                    on t1.CityId equals t2.CityId
                    join t3 in this.cc.Customers
                    on t1.AreaId equals t3.AreaId
                    join t4 in this.cc.bills
                    on t3.CustomerId equals t4.CustomerId
                    join t5 in this.cc.Payments
                    on t4.BillId equals t5.BillId
                    select new exampleVM
                    {
                        CustomerName=t3.CustomerName,
                        TotalBillAmount=t4.BillAmount,
                        TotalPaidAmount=t5.PaymentAmount,
                        BalanceAmount=t4.BillAmount-t5.PaymentAmount
                    };

                return View(v.ToList());
            
        }
        public ActionResult SearchByArea(Int64 AreaId=0)
        {
            ViewBag.AreaId= new SelectList(this.cc.Areatbls.ToList(), "AreaId", "AreaName");
            if (AreaId==0)
                return View("Index");

            else
            {
                var v = from t1 in this.cc.Areatbls
                        join t2 in this.cc.citytbls
                        on t1.CityId equals t2.CityId
                        join t3 in this.cc.Customers
                        on t1.AreaId equals t3.AreaId
                        join t4 in this.cc.bills
                        on t3.CustomerId equals t4.CustomerId
                        join t5 in this.cc.Payments
                        on t4.BillId equals t5.BillId
                        where( t1.AreaId == AreaId)
                        group t5 by t3.CustomerName
                        //group t5 by t1.AreaId
                        into g
                        select new exampleVM
                        {

                            CustomerName = g.Key,
                            AreaId=g.Sum(p=>p.Bill.Customer.AreaId),
                            CustomerId = g.Sum(p => p.Bill.CustomerId),
                            TotalBillAmount = g.Sum(p => p.Bill.BillAmount),
                            TotalPaidAmount = g.Sum(p => p.PaymentAmount),
                            BalanceAmount = g.Sum(p => p.Bill.BillAmount - p.PaymentAmount)
                        };
                return View("Index", v.ToList());
            }
        }
        //var v = from t in this.cntx.CityTbles
        //        join t1 in this.cntx.AreaTbles
        //        on t.CityId equals t1.CityId
        //        join t2 in this.cntx.CustomerTables
        //        on t1.AreaId equals t2.AreaId
        //        join t3 in this.cntx.BillTables
        //        on t2.CustomerId equals t3.CustomerId
        //        join t4 in this.cntx.PaymentTables
        //        on t3.BillId equals t4.BillId
        //        where t1.AreaId == AreaId
        //        select new BillPayVM
        //        {
        //            CustomerName = t2.CustomerName,

        //            TotalBillAmount = t3.BillAmount,
        //            TotalPaymentAmount = t4.PaymentAmount,
        //            BalanceAmount = (t3.BillAmount) - (t4.PaymentAmount)
        //        };
    }
}