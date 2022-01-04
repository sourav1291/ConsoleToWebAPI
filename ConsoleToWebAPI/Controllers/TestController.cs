using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [Route("test/{action}", Name = "test", Order = 1)]
    [ApiController]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Returning from TestController Get Method";
        }
        public string Get1()
        {
            return "Returning from TestController Get1 Method";
        }
    }
}
