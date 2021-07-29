using DatabaseFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Driverdetail> Get()
        {
            using(var context = new vehiclerentContext())
            {
                return context.Driverdetails.ToList();
            }
        }

    }
}
