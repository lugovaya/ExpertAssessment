using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Entities
{
    public class Characteristic
    {
        public int CharacteristicID { get; set; }
        public int LevelID { get; set; }
        public string CharacteristicTitle { get; set; }
    }
}
