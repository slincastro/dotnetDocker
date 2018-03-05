using System;
using Microsoft.AspNetCore.Mvc;
using webApi.Domain;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    public class BeverageController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return new Beer().GetBeer();
        }

        [HttpGet("{id}")]
        public string Get(string id){   
            return new Beer().GetBeers(Convert.ToInt16(id));
        }
    }
}