using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class OutputController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
