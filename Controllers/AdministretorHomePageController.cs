using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetWebApplication.Controllers
{
    public class AdministretorHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
