using ExpertAssessment.Domain.Abstract;
using ExpertAssessment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExpertAssessment.Domain.Concrete
{
    public class AHPRepository : IAhpRepository
    {
        public IEnumerable<ExpertAssessment.Domain.Entities.Action> AllActions()
        {
            using (var c = new AHPDbContext())
            {
                return c.Actions.ToList();
            }
        }

        public IEnumerable<Expert> AllExperts()
        {
            using (var c = new AHPDbContext())
            {
                return c.Experts.ToList();
            }
        }

        public void AddExpert(Expert expert)
        {
            using (var c = new AHPDbContext())
            {

                if (expert.Login != null &&
                    c.Experts.Find(expert.Login) == null)
                {
                    c.Experts.Add(expert);
                }
                c.SaveChanges();
            }
        }

        public bool DoesExpertLoginExits(string name)
        {
            using (var c = new AHPDbContext())
            {
                return (c.Experts.Find(name) == null);
            }
        }

        public bool DoesExpertLoginEdites(string name)
        {
            using (var c = new AHPDbContext())
            {
                return (c.Experts.FirstOrDefault(x => x.Login == name) != null);
            }
        }

        public bool DoesExpertProfileEdites(string name, string pass)
        {
            using (var c = new AHPDbContext())
            {
                return (c.Experts.FirstOrDefault(x => (x.Login == name && x.Pass == pass)) != null);
            }
        }

        public IEnumerable<Hierarchy> AllHierarchies()
        {
            using (var c = new AHPDbContext())
            {
                return c.Hierarchies.ToList();
            }
        }

        public IEnumerable<Characteristic> AllCharacteristics()
        {
            using (var c = new AHPDbContext())
            {
                return c.Characteristics.ToList();
            }
        }

        public IEnumerable<Evaluation> AllEvaluations()
        {
            using (var c = new AHPDbContext())
            {
                return c.Evaluations.ToList();
            }
        }


        public Hierarchy AddHierarchy(string hierarchyTitle, string goal = "", IList<Characteristic> characteristics = null)
        {
            var hierarchyGoal = new Characteristic { CharacteristicTitle = goal, LevelID = 0 };
            using (var c = new AHPDbContext())
            {
                var hierarchy = new Hierarchy(hierarchyTitle);
                characteristics.Add(hierarchyGoal);
                hierarchy.Characteristics = characteristics;

                c.Hierarchies.Add(hierarchy);
                c.SaveChanges();

                return hierarchy;
            }
        }



        public void AddGoal(Hierarchy hierarchy, string characteristycTitle)
        {
            using (var c = new AHPDbContext())
            {
                var charcteristyc = new Characteristic()
                    {
                        CharacteristicTitle = characteristycTitle,
                        LevelID = 1
                    };
                hierarchy.Characteristics.Add(charcteristyc);
                c.Characteristics.Add(charcteristyc);
                c.SaveChanges();
            }
        }

        public void AddCharacteristic(Hierarchy hierarchy, Characteristic characteristic)
        {
            using (var c = new AHPDbContext())
            {
                hierarchy.Characteristics.Add(characteristic);
                c.Characteristics.Add(characteristic);
                c.SaveChanges();
            }
        }

        public void AddAction(string p1, string p2)
        {
            throw new NotImplementedException();
        }

    }
}
