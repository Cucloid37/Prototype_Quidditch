using System;
using UnityEngine;

namespace V2._0
{
    public class BattleController : BaseController
    {
        private GameObject factory = new GameObject("Factory");

        public BattleController(ProfilePlayer profilePlayer, Descriptions descriptions, FlyerFactory factoryFlyer, 
            UpdateControllers controllers, GameObject canvas)
        {
            
            var inputInitialization = new InputController(descriptions.InputDescription);
            var mouseInput = new RayCastManager();

            FieldFactory fieldFactory = factory.AddComponent<FieldFactory>();
            fieldFactory.InitFactory(factoryFlyer.PrefabSquare);
            var field = fieldFactory.CreateField();
            
            var _flyersInitialization = new FlyersInitialization(factoryFlyer);
            
            profilePlayer.TeamOne.Value = _flyersInitialization.TeamOne;
            profilePlayer.TeamTwo.Value = _flyersInitialization.TeamTwo;

            var flyerDeployment = new DeploymentOfFlyers(field, profilePlayer);
            
            
            controllers.Add(inputInitialization);
            controllers.Add(mouseInput);
        }
        
    }
}