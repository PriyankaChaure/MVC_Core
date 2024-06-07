using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Core_Ex1.Reposiratories;
using MVC_Core_Ex1.ViewModels;

namespace MVC_Core_Ex1.Controllers
{
    public class HomeController : Controller
    {
        FlightFacilityInterface ffi;
        FlightsInterface fi;
        FlightVMInterface vm;
        CityInterface ci;
        FacilityInterface fgi;
        public HomeController(FlightFacilityInterface ffi,FacilityInterface fgi,CityInterface ci, FlightVMInterface vm,FlightsInterface fi)
        {
            this.ffi = ffi;
           this.fi = fi;
            this.vm =vm;
            this.ci = ci;
            this.fgi = fgi;
        }
        public IActionResult Index()
        {
            ViewBag.FacilityId = new MultiSelectList(this.fgi.GetAll(), "FacilityId", "FacilityName");
            ViewBag.CityId = new SelectList(this.ci.GetAll(), "CityId", "CityName");
            ViewBag.CityId1 = new SelectList(this.ci.GetAll(), "CityId", "CityName");
            // ViewBag.DestinationCityId = new SelectList(this.fi.GetAllFlights(), "CityId", "CityName");
            return View(this.vm.GetAllFlightVM());
        }
      
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CityId = new SelectList(this.ci.GetAll(), "CityId", "CityName");
            ViewBag.CityId1 = new SelectList(this.ci.GetAll(), "CityId", "CityName");
            ViewBag.FacilityId = new MultiSelectList(this.fgi.GetAll(),"FacilityId","FacilityName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(FlightVM rec)
        {
            ViewBag.FacilityId = new MultiSelectList(this.fgi.GetAll(), "FacilityId", "FacilityName");
            ViewBag.CityId = new SelectList(this.ci.GetAll(), "CityId", "CityName",rec.CityId);
            ViewBag.CityId1 = new SelectList(this.ci.GetAll(), "CityId", "CityName");
            if (ModelState.IsValid)
            {
                this.vm.Add(rec);
                return RedirectToAction("Index");
            }
           
            //  ViewBag.SourceCityId = new SelectList(this.fi.GetAllFlights(), "CityId", "CityName");
            //  ViewBag.DestinationCityId = new SelectList(this.fi.GetAllFlights(), "CityId", "CityName");
            return View(rec);
        }
    }
}
