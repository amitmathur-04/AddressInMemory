using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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