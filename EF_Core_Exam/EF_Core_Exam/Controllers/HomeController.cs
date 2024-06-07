using EF_Core_Exam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace EF_Core_Exam.Controllers
{
    public class HomeController : Controller
    {
        ClassContext cc;
        public HomeController(ClassContext cc)
        {
            this.cc = cc;
        }
        public IActionResult Index()
        {
            var v = from t1 in this.cc.MFGs
                    join t2 in this.cc.autoarts
                    on t1.mfgid equals t2.mfgid
                    join t3 in this.cc.brands
                    on t2.autopartsid equals t3.brandid
                    join t4 in this.cc.cars
                    on t3.brandid equals t4.brandid
                    //group t4 by t4.carid
                    //into g
                    select new abcmVM
                    {
                        SrNo = t4.carid,
                        brandname = t3.brandname,
                        TotalNoOfParts = t4.qty,
                        TotalPartAmount = (t4.partprice * t4.qty),
                        MinimumPrice = (t4.partprice * t4.qty) / t4.qty,
                        MaximumPrice = (t4.partprice * t4.qty) / t4.qty + (t4.partprice * t4.qty) / t4.qty
                    };

            //var v = from t1 in this.cc.MFGs
            //        join t2 in this.cc.autoarts
            //        on t1.mfgid equals t2.mfgid
            //        join t3 in this.cc.brands
            //        on t2.autopartsid equals t3.brandid
            //        join t4 in this.cc.cars
            //        on t3.brandid equals t4.brandid
            //        group t4 by t3.brandname
            //        into g
            //        select new abcmVM
            //        {
            //            SrNo = g.Sum(p => p.carid),
            //            brandname = g.Key,
            //            TotalNoOfParts = g.Sum(p => p.qty),
            //            TotalPartAmount = g.Sum(p => p.partprice * p.qty),
            //            MinimumPrice = g.Min(p => p.partprice ),
            //            MaximumPrice = g.Max(p => p.partprice ),
            //        };


            return View(v.ToList());
        }
    }
}
