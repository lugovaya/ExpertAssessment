using ExpertAssessment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertAssessment.Domain.Abstract
{
    public interface IEntitiesRepository
    {
        IQueryable<Level> Levels { get; }
        IQueryable<Characteristic> Characteristics { get; }
        IQueryable<Evaluation> Evaluations { get; }
    }
}
