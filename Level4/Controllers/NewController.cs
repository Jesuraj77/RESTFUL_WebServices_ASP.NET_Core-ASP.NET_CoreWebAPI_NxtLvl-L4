using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level4.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //Add XML formatters to the API and send and receive data as JSON and XML and Add the documentation tool, Swagger and add the parameters and enable logging. Extend the get method and filter entries with String
            return View();
        }
    }
}