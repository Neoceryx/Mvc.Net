using App.BLL; //Referencia a la capa de negocios
using App.Entities; //Referencia a las entidades.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class UserController : Controller
    {
        private UserBusiness _userBll;

        public UserController()
        {
            _userBll = new UserBusiness();
        }
        public ActionResult Index()
        {
            return View();
        }

        //Controlador
        public ActionResult Create()
        {
            
            return View();
        }

        public ActionResult test()
        {
            return View();
        }

        //Controlador
        [HttpPost]
        public ActionResult Create(User model)
        {
            
            if(ModelState.IsValid)
            {
                try
                {
                    model.CreatedDate = DateTime.Now;
                    _userBll.AddUser(model);
                }
                catch (UserAlreadyExistException)
                {
                    ModelState.AddModelError("Name", "Name Already Exist");
                }
            }
            return View();
        }

        public ActionResult ListUser()
        {
            var users = _userBll.GetAll();
            return View(users);
        }

    }
}