using ExpertAssessment.Domain.Abstract;
using ExpertAssessment.Domain.Entities;
using ExpertAssessment.Domain.Concrete;
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
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {

            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);

        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IAhpRepository>().To<AHPRepository>();
            //    Mock<IAhpRepository> mock = new Mock<IAhpRepository>();
            //    mock.Setup(m => m.Experts).Returns(new List<Expert>{
            //       new Expert  
            //        {
            //           Login = "Expert 1",
            //           Email = "Email 1",
            //           Pass = "Pass 1"
            //        },
            //       new Expert 
            //        {
            //           Login = "Expert 2",
            //           Email = "Email 2",
            //           Pass = "Pass 2"
            //        },
            //       new Expert 
            //        {
            //           Login = "Expert 3",
            //           Email = "Email 3",
            //           Pass = "Pass 3"
            //        }
            //    }.AsQueryable());

            //    List<Characteristic> listChar = new List<Characteristic>{
            //       new Characteristic  
            //        {
            //           CharacteristicID = 1, 
            //           LevelID = 1,
            //           CharacteristicTitle = "Characteristic 1 - Level 1"
            //        },
            //       new Characteristic
            //        {
            //           CharacteristicID = 2, 
            //           LevelID = 1,
            //           CharacteristicTitle = "Characteristic 2 - Level 1"
            //        },
            //       new Characteristic 
            //        {
            //            CharacteristicID = 3, 
            //            LevelID = 1,
            //            CharacteristicTitle = "Characteristic 3 - Level 1"
            //        },
            //        new Characteristic
            //        {
            //            CharacteristicID = 4,
            //            LevelID = 1,
            //            CharacteristicTitle  = "Characteristic 4 - Level 1"
            //        },
            //        new Characteristic 
            //        {
            //            CharacteristicID = 5,
            //            LevelID = 2,
            //            CharacteristicTitle = "Characteristic 1 - Level 2"
            //        },                
            //        new Characteristic
            //        {
            //            CharacteristicID = 6,
            //            LevelID = 2,
            //            CharacteristicTitle = "Characteristic 3 - Level 2"
            //        },
            //        new Characteristic
            //        {
            //            CharacteristicID = 7,
            //            LevelID = 2,
            //            CharacteristicTitle = "Characteristic 4 - Level 2"
            //        },
            //        new Characteristic
            //        {
            //            CharacteristicID = 8,
            //            LevelID = 2,
            //            CharacteristicTitle = "Characteristic 5 - Level 2"
            //        },
            //        new Characteristic
            //        {
            //            CharacteristicID = 9,
            //            LevelID = 2,
            //            CharacteristicTitle = "Characteristic 6 - Level 2"
            //        },
            //        new Characteristic
            //        {
            //            CharacteristicID = 10,
            //            LevelID = 2,
            //            CharacteristicTitle = "Characteristic 7 - Level 2"
            //        }
            //    };
            //    mock.Setup(m => m.Characteristics).Returns(listChar.AsQueryable());
            //    mock.Setup(m => m.Evaluations).Returns(new List<Evaluation> { 
            //        new Evaluation
            //        {
            //            EvaluationID = 1,
            //            CharacteristicID = listChar[0],
            //            ToCharacteristicID = listChar[0],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 2,
            //            CharacteristicID = listChar[0],
            //            ToCharacteristicID = listChar[1],
            //            Value = 2
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 3,
            //            CharacteristicID = listChar[0],
            //            ToCharacteristicID = listChar[2],
            //            Value = 9
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 4,
            //            CharacteristicID = listChar[0],
            //            ToCharacteristicID = listChar[3],
            //            Value = 3
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 5,
            //            CharacteristicID = listChar[1],
            //            ToCharacteristicID = listChar[0],
            //            Value = 1/2.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 6,
            //            CharacteristicID = listChar[1],
            //            ToCharacteristicID = listChar[1],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 7,
            //            CharacteristicID = listChar[1],
            //            ToCharacteristicID = listChar[2],
            //            Value = 8
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 8,
            //            CharacteristicID = listChar[1],
            //            ToCharacteristicID = listChar[3],
            //            Value = 4
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 9,
            //            CharacteristicID = listChar[2],
            //            ToCharacteristicID = listChar[0],
            //            Value = 1/9.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 10,
            //            CharacteristicID = listChar[2],
            //            ToCharacteristicID = listChar[1],
            //            Value = 1/8.0
            //        }, 
            //        new Evaluation
            //        {
            //            EvaluationID = 11,
            //            CharacteristicID = listChar[2],
            //            ToCharacteristicID = listChar[2],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 12,
            //            CharacteristicID = listChar[2],
            //            ToCharacteristicID = listChar[3],
            //            Value = 7
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 13,
            //            CharacteristicID = listChar[3],
            //            ToCharacteristicID = listChar[0],
            //            Value = 1/3.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 14,
            //            CharacteristicID = listChar[3],
            //            ToCharacteristicID = listChar[1],
            //            Value = 1/4.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 15,
            //            CharacteristicID = listChar[3],
            //            ToCharacteristicID = listChar[2],
            //            Value = 1/7.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 16,
            //            CharacteristicID = listChar[3],
            //            ToCharacteristicID = listChar[3],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 17,
            //            CharacteristicID = listChar[4],
            //            ToCharacteristicID = listChar[4],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 18,
            //            CharacteristicID = listChar[4],
            //            ToCharacteristicID = listChar[5],
            //            Value = 5
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 19,
            //            CharacteristicID = listChar[4],
            //            ToCharacteristicID = listChar[6],
            //            Value = 6
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 20,
            //            CharacteristicID = listChar[4],
            //            ToCharacteristicID = listChar[7],
            //            Value = 2
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 21,
            //            CharacteristicID = listChar[4],
            //            ToCharacteristicID = listChar[8],
            //            Value = 9
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 22,
            //            CharacteristicID = listChar[4],
            //            ToCharacteristicID = listChar[9],
            //            Value = 3
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 23,
            //            CharacteristicID = listChar[5],
            //            ToCharacteristicID = listChar[4],
            //            Value = 1/5.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 24,
            //            CharacteristicID = listChar[5],
            //            ToCharacteristicID = listChar[5],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 25,
            //            CharacteristicID = listChar[5],
            //            ToCharacteristicID = listChar[6],
            //            Value = 8
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 26,
            //            CharacteristicID = listChar[5],
            //            ToCharacteristicID = listChar[7],
            //            Value = 4
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 27,
            //            CharacteristicID = listChar[5],
            //            ToCharacteristicID = listChar[8],
            //            Value = 7
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 28,
            //            CharacteristicID = listChar[5],
            //            ToCharacteristicID = listChar[9],
            //            Value = 5
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 29,
            //            CharacteristicID = listChar[6],
            //            ToCharacteristicID = listChar[4],
            //            Value = 1/7.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 30,
            //            CharacteristicID = listChar[6],
            //            ToCharacteristicID = listChar[5],
            //            Value = 1/8.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 31,
            //            CharacteristicID = listChar[6],
            //            ToCharacteristicID = listChar[6],
            //            Value = 1/7.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 32,
            //            CharacteristicID = listChar[6],
            //            ToCharacteristicID = listChar[7],
            //            Value = 6
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 33,
            //            CharacteristicID = listChar[6],
            //            ToCharacteristicID = listChar[8],
            //            Value = 2
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 34,
            //            CharacteristicID = listChar[6],
            //            ToCharacteristicID = listChar[9],
            //            Value = 9
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 35,
            //            CharacteristicID = listChar[7],
            //            ToCharacteristicID = listChar[4],
            //            Value = 1/2.0
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 36,
            //            CharacteristicID = listChar[7],
            //            ToCharacteristicID = listChar[5],
            //            Value = 1/4.0
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 37,
            //            CharacteristicID = listChar[7],
            //            ToCharacteristicID = listChar[6],
            //            Value = 1/6.0
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 38,
            //            CharacteristicID = listChar[7],
            //            ToCharacteristicID = listChar[7],
            //            Value = 1
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 39,
            //            CharacteristicID = listChar[7],
            //            ToCharacteristicID = listChar[8],
            //            Value = 3
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 40,
            //            CharacteristicID = listChar[7],
            //            ToCharacteristicID = listChar[9],
            //            Value = 8
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 41,
            //            CharacteristicID = listChar[8],
            //            ToCharacteristicID = listChar[4],
            //            Value = 1/9.0
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 42,
            //            CharacteristicID = listChar[8],
            //            ToCharacteristicID = listChar[5],
            //            Value = 1/7.0
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 43,
            //            CharacteristicID = listChar[8],
            //            ToCharacteristicID = listChar[6],
            //            Value = 1/6.0
            //        },
            //new Evaluation
            //        {
            //            EvaluationID = 44,
            //            CharacteristicID = listChar[8],
            //            ToCharacteristicID = listChar[7],
            //            Value = 1/3.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 45,
            //            CharacteristicID = listChar[8],
            //            ToCharacteristicID = listChar[8],
            //            Value = 1
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 46,
            //            CharacteristicID = listChar[8],
            //            ToCharacteristicID = listChar[9],
            //            Value = 4
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 47,
            //            CharacteristicID = listChar[9],
            //            ToCharacteristicID = listChar[4],
            //            Value = 1/3.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 48,
            //            CharacteristicID = listChar[9],
            //            ToCharacteristicID = listChar[5],
            //            Value = 1/5
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 49,
            //            CharacteristicID = listChar[9],
            //            ToCharacteristicID = listChar[6],
            //            Value = 1/9.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 50,
            //            CharacteristicID = listChar[9],
            //            ToCharacteristicID = listChar[7],
            //            Value = 1/8.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 51,
            //            CharacteristicID = listChar[9],
            //            ToCharacteristicID = listChar[8],
            //            Value = 1/4.0
            //        },
            //        new Evaluation
            //        {
            //            EvaluationID = 52,
            //            CharacteristicID = listChar[9],
            //            ToCharacteristicID = listChar[9],
            //            Value = 1
            //        }

            //    }.AsQueryable());
            //    ninjectKernel.Bind<IAhpRepository>().ToConstant(mock.Object);
        }
    }
}