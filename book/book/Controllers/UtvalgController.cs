using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace book.Controllers
{
    public class UtvalgController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}