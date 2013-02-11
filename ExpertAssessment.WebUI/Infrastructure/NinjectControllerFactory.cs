using ExpertAssessment.Domain.Abstract;
using ExpertAssessment.Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExpertAssessment.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory { 
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected IController GetControllerlnstance( 
        RequestContext requestContext, Type controllerType) 
        {
            return controllerType == null 
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings() 
        {
            Mock<IEntitiesRepository> mock = new Mock<IEntitiesRepository>();
            mock.Setup(m => m.Levels).Returns(new List<Level>{
               new Level  
                {
                   LevelID = 1, 
                   LevelTitle = "Level 1"
                },
               new Level 
                {
                   LevelID = 2, 
                   LevelTitle = "Level 2"
                },
               new Level 
                {
                    LevelID = 3, 
                    LevelTitle = "Level 3"
                }
            }.AsQueryable());
            
            mock.Setup(m => m.Characteristics).Returns(new List<Characteristic>{
               new Characteristic  
                {
                   CharacteristicID = 1, 
                   LevelID = 1,
                   CharacteristicTitle = "Characteristic 1 - Level 1"
                },
               new Characteristic
                {
                   CharacteristicID = 2, 
                   LevelID = 1,
                   CharacteristicTitle = "Characteristic 2 - Level 1"
                },
               new Characteristic 
                {
                    CharacteristicID = 3, 
                    LevelID = 1,
                    CharacteristicTitle = "Characteristic 3 - Level 1"
                },
                new Characteristic
                {
                    CharacteristicID = 4,
                    LevelID = 1,
                    CharacteristicTitle  = "Characteristic 4 - Level 1"
                },
                new Characteristic 
                {
                    CharacteristicID = 5,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 1 - Level 2"
                },
                new Characteristic 
                {
                    CharacteristicID = 5,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 2 - Level 2"
                },
                new Characteristic
                {
                    CharacteristicID = 6,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 3 - Level 2"
                },
                new Characteristic
                {
                    CharacteristicID = 7,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 4 - Level 2"
                },
                new Characteristic
                {
                    CharacteristicID = 8,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 5 - Level 2"
                },
                new Characteristic
                {
                    CharacteristicID = 9,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 6 - Level 2"
                },
                new Characteristic
                {
                    CharacteristicID = 10,
                    LevelID = 2,
                    CharacteristicTitle = "Characteristic 7 - Level 2"
                }
            }.AsQueryable());
            mock.Setup(m => m.Characteristics).Returns(new List<Characteristic> { 
                new Evaluation
                {
                    EvaluationID = 1,
                    CharacteristicID = 1,
                    ToCharacteristicID = 1,
                    LevelID = 1,
                    Value = 1
                },
                new Evaluation
                {
                    EvaluationID = 2,
                    CharacteristicID = 1,
                    ToCharacteristicID = 2,
                    LevelID = 1,
                    Value = 2
                },
                new Evaluation
                {
                    EvaluationID = 3,
                    CharacteristicID = 1,
                    ToCharacteristicID = 3,
                    LevelID = 1,
                    Value = 9
                },
                new Evaluation
                {
                    EvaluationID = 4,
                    CharacteristicID = 1,
                    ToCharacteristicID = 4,
                    LevelID = 1,
                    Value = 3
                },
                new Evaluation
                {
                    EvaluationID = 5,
                    CharacteristicID = 2,
                    ToCharacteristicID = 1,
                    LevelID = 1,
                    Value = 1/2
                },
                new Evaluation
                {
                    EvaluationID = 6,
                    CharacteristicID = 2,
                    ToCharacteristicID = 2,
                    LevelID = 1,
                    Value = 1
                },
                new Evaluation
                {
                    EvaluationID = 7,
                    CharacteristicID = 2,
                    ToCharacteristicID = 3,
                    LevelID = 1,
                    Value = 8
                },
                new Evaluation
                {
                    EvaluationID = 8,
                    CharacteristicID = 2,
                    ToCharacteristicID = 4,
                    LevelID = 1,
                    Value = 4
                },
                new Evaluation
                {
                    EvaluationID = 9,
                    CharacteristicID = 3,
                    ToCharacteristicID = 1,
                    LevelID = 1,
                    Value = 1/9
                },
                new Evaluation
                {
                    EvaluationID = 10,
                    CharacteristicID = 3,
                    ToCharacteristicID = 2,
                    LevelID = 1,
                    Value = 1/8
                },
                new Evaluation
                {
                    EvaluationID = 11,
                    CharacteristicID = 3,
                    ToCharacteristicID = 3,
                    LevelID = 1,
                    Value = 1
                },
                new Evaluation
                {
                    EvaluationID = 12,
                    CharacteristicID = 3,
                    ToCharacteristicID = 4,
                    LevelID = 1,
                    Value = 7
                },
                new Evaluation
                {
                    EvaluationID = 13,
                    CharacteristicID = 4,
                    ToCharacteristicID = 1,
                    LevelID = 1,
                    Value = 1/3
                }
                new Evaluation
                {
                    EvaluationID = 14,
                    CharacteristicID = 4,
                    ToCharacteristicID = 2,
                    LevelID = 1,
                    Value = 1/4
                },
                new Evaluation
                {
                    EvaluationID = 15,
                    CharacteristicID = 4,
                    ToCharacteristicID = 3,
                    LevelID = 1,
                    Value = 1/7
                },
                new Evaluation
                {
                    EvaluationID = 16,
                    CharacteristicID = 4,
                    ToCharacteristicID = 4,
                    LevelID = 1,
                    Value = 1
                },
                new Evaluation
                {
                    EvaluationID = 17,
                    CharacteristicID = 5,
                    ToCharacteristicID = 5,
                    LevelID = 2,
                    Value = 1
                },
                new Evaluation
                {
                    EvaluationID = 18,
                    CharacteristicID = 5,
                    ToCharacteristicID = 6,
                    LevelID = 2,
                    Value = 5
                },
                new Evaluation
                {
                    EvaluationID = 19,
                    CharacteristicID = 5,
                    ToCharacteristicID = 7,
                    LevelID = 2,
                    Value = 6
                },
                new Evaluation
                {
                    EvaluationID = 20,
                    CharacteristicID = 5,
                    ToCharacteristicID = 8,
                    LevelID = 2,
                    Value = 2
                },
                new Evaluation
                {
                    EvaluationID = 21,
                    CharacteristicID = 5,
                    ToCharacteristicID = 9,
                    LevelID = 2,
                    Value = 9
                },
                new Evaluation
                {
                    EvaluationID = 22,
                    CharacteristicID = 5,
                    ToCharacteristicID = 10,
                    LevelID = 2,
                    Value = 3
                },
                new Evaluation
                {
                    EvaluationID = 23,
                    CharacteristicID = 6,
                    ToCharacteristicID = 5,
                    LevelID = 2,
                    Value = 1/5
                },
                new Evaluation
                {
                    EvaluationID = 24,
                    CharacteristicID = 6,
                    ToCharacteristicID = 6,
                    LevelID = 2,
                    Value = 1
                },
                new Evaluation
                {
                    EvaluationID = 25,
                    CharacteristicID = 6,
                    ToCharacteristicID = 7,
                    LevelID = 2,
                    Value = 8
                },
                new Evaluation
                {
                    EvaluationID = 26,
                    CharacteristicID = 6,
                    ToCharacteristicID = 8,
                    LevelID = 2,
                    Value = 4
                },
                new Evaluation
                {
                    EvaluationID = 27,
                    CharacteristicID = 6,
                    ToCharacteristicID = 9,
                    LevelID = 2,
                    Value = 7
                }
                new Evaluation
                {
                    EvaluationID = 28,
                    CharacteristicID = 6,
                    ToCharacteristicID = 10,
                    LevelID = 2,
                    Value = 5
                },
                new Evaluation
                {
                    EvaluationID = 29,
                    CharacteristicID = 7,
                    ToCharacteristicID = 5,
                    LevelID = 2,
                    Value = 1/7
                },
                new Evaluation
                {
                    EvaluationID = 30,
                    CharacteristicID = 7,
                    ToCharacteristicID = 6,
                    LevelID = 2,
                    Value = 1/8
                },
                new Evaluation
                {
                    EvaluationID = 31,
                    CharacteristicID = 7,
                    ToCharacteristicID = 7,
                    LevelID = 2,
                    Value = 1/7
                },

            }.AsQueryable());
        }
    }
}