using Microsoft.AspNetCore.Mvc;

namespace Custome_ActionFilter.Controllers
{
    public class TestController : Controller
    {
       public string sayhello()
        {
            return "say hello called!";
        }
        public string saybye()
        {
            return "say bye called!";
        }
    }
}
