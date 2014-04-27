using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpertAssessment.Domain.Entities;

namespace ExpertAssessment.Domain.Concrete
{
    class AHPDbContext : DbContext
    {
        static AHPDbContext()
        {
            Database.SetInitializer<AHPDbContext>(new DropCreateDatabaseIfModelChanges<AHPDbContext>());
        }
        public DbSet<ExpertAssessment.Domain.Entities.Action> Actions { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Hierarchy> Hierarchies { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
    }
}
