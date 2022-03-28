using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriHealth_Test.Common.Models;

namespace TriHealth_Test.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubmitDataController : Controller
    {
        [HttpPost]
        public bool Post([FromBody] ContactData data)
        {
            //Add Data Here
            return true;
        }
    }
}
