using ExpertAssessment.Domain.Concrete;
using ExpertAssessment.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using ExpertAssessment.WebUI.Infrastructure;

namespace ExpertAssessment.WebUI.Controllers
{

    public class HttpParamActionAttribute : ActionNameSelectorAttribute
    {
        public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
        {
            if (actionName.Equals(methodInfo.Name, StringComparison.InvariantCultureIgnoreCase))
                return true;

            if (!actionName.Equals("Action", StringComparison.InvariantCultureIgnoreCase))
                return false;

            var request = controllerContext.RequestContext.HttpContext.Request;
            return request[methodInfo.Name] != null;
        }
    }



    public class HierarchyController : Controller
    {


        //
        // GET: /NewHierarchy/
        private AHPRepository _repository;
        //private List<string> _characteristicList = new List<string>() {"o","la","la" };
        private RepositoryHelper _helper = new RepositoryHelper(); 


        public HierarchyController()
        {
            _repository = new AHPRepository();
        }

        public ActionResult CreateNewHierarchy()
        {
            
            return View(new NewHierarchyModel());
        }

        [HttpPost]
        [HttpParamAction]    
        public ActionResult SaveDatShit(NewHierarchyModel model)
        {
            var h = _repository.AddHierarchy(model.HierarchyTitle, model.HierarchyGoal,
               _helper.ToCharacteristics(model.LevelCharacteristics));
            
            //_repository.AddGoal(h, model.HierarchyGoal);


            return View("MadedHierarchy", model);
        }

        public ActionResult MadedHierarchy(NewHierarchyModel model) 
        {
            return View(model);
        }

        [HttpPost]
        [HttpParamAction]    
        public ActionResult AddNewLevel(NewHierarchyModel model) // don't know how to take parameter index
        {
            //var h = _repository.AddHierarchy(model.HierarchyTitle);
            //_repository.AddGoal(h, model.HierarchyGoal);
            //_repository.AddAction(User.Identity.Name, model.HierarchyTitle);
            //model.HierarchyLevels.Add(index);
            model.LevelCharacteristics.Add(new LevelCharacteristicModel() 
            { 
                Id = model.LevelCharacteristics.Count, 
                Values = new List<string> { "" } 
            });
            return View("CreateNewHierarchy", model);
        }

        [HttpPost]
        [HttpParamAction]    
        public ActionResult AddNewCharacteristic(NewHierarchyModel model, int levelIndex = 0) 
        {
      //      model.LevelCharacteristics[levelIndex].Add(characteristicName);
            //model.LevelCharacteristics[levelIndex].Values.Add(characteristicName);
            model.LevelCharacteristics.FirstOrDefault(x => x.Id == levelIndex).Values.Add("");
            return View("CreateNewHierarchy", model);
        }
    }
}
