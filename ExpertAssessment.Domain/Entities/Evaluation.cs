using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Entities
{
    public class Evaluation
    {
        [Column("eval_id")]
        public int EvaluationID { get; set; }

        [Column("eval_charID")]
        public Characteristic CharacteristicID { get; set; }

        [Column("eval_toCharID")]
        public Characteristic ToCharacteristicID { get; set; }

        [Column("eval_value")]
        public double Value { get; set; }

        public List<Characteristic> GetCharacteristics(Characteristic characteristicID)
        {
            if (this.CharacteristicID == characteristicID)             
                return new List<Characteristic> { this.ToCharacteristicID};
            // return new[] { new { this.ToCharacteristicID } }.ToList();
            return null;            
        }
        public int GetLevelByCharacteristicID(Guid characteristicID)
        { 
            //TODO
            return 0;
        }

        
    }
}
