using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.wwwroot.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("[action]")]
        public string Phone()
        {
            return "555 5555 555";
        }

        [Route("address")]
        public string Address()
        {
            return "Address";
        }
    }
}
