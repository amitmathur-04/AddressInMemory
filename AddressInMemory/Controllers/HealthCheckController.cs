using Microsoft.AspNetCore.Mvc;

namespace AddressInMemory.Controllers
{
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [Route("/health")]
        public ActionResult Working()
        {
             return new EmptyResult();
        }
    }
}