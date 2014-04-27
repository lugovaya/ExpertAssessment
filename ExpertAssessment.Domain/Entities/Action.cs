using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Entities
{
    public class Action
    {
        [Column("action_id") ]
        public int ActionID { get; set; }

        [Column("action_expertLogin")]
        public Expert ExpertLogin { get; set; }

        [Column("action_hierarchy")]
        public Hierarchy HierarchyID { get; set; }

        [Column("action_lastModify")]
        public DateTime LastModify { get; set; }
    }
}
