using Microsoft.AspNetCore.Mvc;


namespace usedefaultfiles.Controllers
{
    public class HomeController:Controller
    {
        public string index()
        {
            return "welcome to mvc core services";
        }
        public string sayhello()
        {
            return "sayhello action called from home controller!";
        }
        public string saybye()
        {
            return "saybye action called from home controller!";
        }
        public ActionResult about()
        {
            return View();
        }
      //  public ActionResult GetCustomers()
     //   {
      //      Customer c = new Customer();
     //       var r = c.GetCustomers();
       //     return View(r);
        //}
    }
}
