using ExpertAssessment.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpertAssessment.WebUI.Controllers
{
    public class CharacteristicController : Controller
    {
        //
        // GET: /Characteristic/
        private IAhpRepository _repository;

        public CharacteristicController(IAhpRepository characteristicRepository)
        {
            this._repository = characteristicRepository;
        }

        public ViewResult List()
        {
            return View(_repository.AllCharacteristics());
        }

    }
}
