using ExpertAssessment.Domain.Concrete;
using ExpertAssessment.Domain.Entities;
using ExpertAssessment.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ExpertAssessment.WebUI.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private AHPRepository _repository;

        public AccountController() 
        {
            _repository = new AHPRepository();
        }

        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!_repository.DoesExpertProfileEdites(model.Login, model.Pass)) 
                ModelState.AddModelError("Login or/and password error", "Login or/and password error");
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Login, true);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public ActionResult LoginIn()
        {
            return PartialView();
        }
        
        public ActionResult Registration()
        {
            return View(new Expert());
        }

        [HttpPost]
        public ActionResult Registration(Expert model)
        {
            if (ModelState.IsValid)
            {
                model.IsLoginIn = true;
             
                FormsAuthentication.SetAuthCookie(model.Login,true);
                _repository.AddExpert(model);
                TempData["message"] = string.Format("{0} has been saved", model.Login);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Logout() 
        {
            FormsAuthentication.SetAuthCookie(null, true);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult DoesUserNameExist(string Login)
        {
            return Json((_repository.DoesExpertLoginExits(Login)));
        }

        [HttpPost]
        public JsonResult DoesExpertLoginEdites(string Login) 
        {
            return Json(_repository.DoesExpertLoginEdites(Login));
        }
    }
}
