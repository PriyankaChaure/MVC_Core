using Microsoft.AspNetCore.Mvc;

namespace EndPointRounting_Ex.Controllers
{
    public class SampleController : Controller
    {
        [Route("sam/hello")]
        public string sayhello()
        {
            return "say hello called!";
        }
        public string saybye()
        {
            return "say bye called!";
        }
        [Route ("sam/s/{id:int:min(10):max(50)}")]
        public string say(string id)
        {
            return "say bye called!"+id;
        }
    }
}