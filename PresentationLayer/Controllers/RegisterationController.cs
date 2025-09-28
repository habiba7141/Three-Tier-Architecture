using BusinessLayer.Dtos;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class RegisterationController : Controller
    {
         private readonly IManageRegisteration ManageRegisteration;
        public RegisterationController(IManageRegisteration manageRegisteration)
        {
            ManageRegisteration= manageRegisteration;   
        }
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult AddRegisteration()
        {
            return View();
        }

     
        [HttpPost]
        public IActionResult AddRegisteration(RegisterationModel model)
        {
            if (ModelState.IsValid)
            {
                ManageRegisteration.addRegisteration(model);
                return RedirectToAction("Success");
            }
            return View(model);
        }

       
        public IActionResult Success()
        {
            return View();
        }
    }

    }

