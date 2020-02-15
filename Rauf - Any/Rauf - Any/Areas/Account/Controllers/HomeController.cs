using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rauf___Any.Areas.Admin.Controllers
{
    [Area("Account")]
    //[Route("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route("[action]/{page:int?}")]
        //public IActionResult Orders()
        //{
        //    return View();
        //}

        //[Route("[action]")]
        //public IActionResult Shop()
        //{
        //    return View();
        //}

        //[Route("[action]/newest")]
        //public IActionResult Payments()
        //{
        //    return View();
        //}
    }
}