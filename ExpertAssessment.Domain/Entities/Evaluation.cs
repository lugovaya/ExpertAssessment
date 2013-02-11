using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Entities
{
    public class Evaluation
    {
        public int EvaluationID { get; set; }
        public int CharacteristicID { get; set; }
        public int ToCharacteristicID { get; set; }
        public double Value { get; set; }
    }
}
