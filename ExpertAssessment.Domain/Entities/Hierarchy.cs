using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Entities
{
    public class Hierarchy
    {
        public Hierarchy()
        {
            Characteristics = new List<Characteristic>();
        }

        public Hierarchy(string hierarchyTitle) :this()
        {
            HierarchyTitle = hierarchyTitle;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("hierarchy_id")]
        public int HierarchyID { get; set; }

        [Column("hierarchy_title")]
        public string HierarchyTitle { get; set; }

        public IList<Characteristic> Characteristics { get; set; }
    }
}
