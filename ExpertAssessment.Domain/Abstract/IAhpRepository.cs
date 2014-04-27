using ExpertAssessment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Abstract
{
    public interface IAhpRepository
    {
        IEnumerable<ExpertAssessment.Domain.Entities.Action> AllActions();
        IEnumerable<Expert> AllExperts();
        void AddExpert (Expert expert);
        IEnumerable<Characteristic> AllCharacteristics ();
        IEnumerable<Evaluation> AllEvaluations();
        IEnumerable<Hierarchy> AllHierarchies();
    }
}
