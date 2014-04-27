using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Entities
{
    public class Characteristic
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("char_id")]
        public int CharacteristicID { get; set; }

        [Column("char_parent_id")]
        public Characteristic Parent { get; set; }

        [Column("char_level")]
        public int LevelID { get; set; }

        [Column("char_title")]
        public string CharacteristicTitle { get; set; }        
    }
}
