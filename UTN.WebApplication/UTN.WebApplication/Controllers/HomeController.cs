using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UTN.WebApplication.Models;
using UTN.Inc.Data;
using UTN.Inc.Business;
using UTN.Inc.Entities;

namespace UTN.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }


        public JsonResult GetUsers()
        {
            List<Usuario> list = new List<Usuario>();
            list = new UserBussines().GetUsuarios();

            return Json(list);
        }


    }
}
