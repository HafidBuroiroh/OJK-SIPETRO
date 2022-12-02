using Microsoft.AspNetCore.Mvc;
using Login.Models;
using System.Diagnostics;

namespace Login.Controllers
{
    public class GenerateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
