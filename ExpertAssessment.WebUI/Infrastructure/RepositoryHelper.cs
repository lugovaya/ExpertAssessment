using ExpertAssessment.Domain.Entities;
using ExpertAssessment.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertAssessment.WebUI.Infrastructure
{
    public class RepositoryHelper
    {
        public IList<Characteristic> ToCharacteristics(List<LevelCharacteristicModel> characteristics)
        {
            var characters = new List<Characteristic>();
            foreach (var chars in characteristics)
            {
                var levelId = chars.Id+1;
                foreach (var title in chars.Values)
                {
                    characters.Add(new Characteristic
                    {
                        LevelID = levelId,
                        CharacteristicTitle = title
                    });
                }
            }

            return characters;
        }
        
    }
}