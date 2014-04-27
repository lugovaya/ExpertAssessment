using ExpertAssessment.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpertAssessment.WebUI.Controllers
{
    public class EvaluationController : Controller
    {
        //
        // GET: /Evaluation/
        private IAhpRepository _repository;

        public EvaluationController(IAhpRepository evaluationRepository)
        {
            this._repository = evaluationRepository;
        }
        public ViewResult Matrix()
        {
            return View(_repository.AllEvaluations());
        }

    }
}
