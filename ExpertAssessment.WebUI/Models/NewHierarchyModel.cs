using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpertAssessment.WebUI.Models
{
    public class NewHierarchyModel
    {
        public NewHierarchyModel() 
        {
            LevelCharacteristics = new List<LevelCharacteristicModel> ();
        }
        [Required]
        public string HierarchyTitle { get; set; }
        public string HierarchyGoal { get; set; }
        public List<LevelCharacteristicModel> LevelCharacteristics { get; set; }
    }

    public class LevelCharacteristicModel
    {
        public LevelCharacteristicModel()
        {
            Values = new List<string>();
        }
        [DataType(DataType.Text)]
        public int Id { get; set; }
        public List<string> Values { get; set; }
    }

}