using ExpertAssessment.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpertAssessment.WebUI.Controllers
{
    public class ExpertController : Controller
    {
        //
        // GET: /Expert/

        private IAhpRepository _repository;

        public ExpertController (IAhpRepository expertRepository)
        {
            this._repository = expertRepository;
        }
        public ActionResult Auth()
        {
            return PartialView(_repository.AllExperts());
        }
    }
}
