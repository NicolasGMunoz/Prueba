using Microsoft.AspNetCore.Mvc;
using UTN.Inc.Business;
using UTN.Inc.Data.Repository;
using UTN.Inc.Entities;

namespace UTN.WebApplication.Controllers
{
    public class HomeController : Controller

    {

        
        private readonly UserBussines _repo;

        public HomeController(UserBussines context)
        {
       
            _repo = context;
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
            List<Usuario> list = _repo.ObtenerUsuario();
            

            return Json(list);
        }


    }
}
