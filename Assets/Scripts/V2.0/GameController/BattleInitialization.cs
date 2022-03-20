using System;
using UnityEngine;

namespace V2._0
{
    public class BattleInitialization : BaseController
    {
        private SpawnController _spawnController;
        private GameObject factory = new GameObject("Factory");

        public BattleInitialization(ProfilePlayer profilePlayer, Descriptions descriptions, FlyerFactory factoryFlyer, 
            UpdateControllers controllers, Transform canvas, GameObject camera)
        {
            
            var input = new InputController(descriptions.InputDescription);
            var mouseInput = new RayCastManager();

            FieldFactory fieldFactory = factory.AddComponent<FieldFactory>();
            fieldFactory.InitFactory(factoryFlyer.PrefabSquare);
            var field = fieldFactory.CreateField();
            Transform[] fields = 
            {
                field.Views[765].Position,
                field.Views[476].Position,
                field.Views[1003].Position,
                field.Views[781].Position,
                field.Views[1036].Position,
                field.Views[475].Position
            };

            var ringFactory = new RingFactory(fields, factoryFlyer.PrefabRing);
            
            var _flyersInitialization = new FlyersInitialization(factoryFlyer);
            
            profilePlayer.TeamOne.Value = _flyersInitialization.TeamOne;
            profilePlayer.TeamTwo.Value = _flyersInitialization.TeamTwo;

            var moveManager = new MoveManager(profilePlayer);
            var moveController = new MoveController();
            
            _spawnController = new SpawnController(moveManager, moveController, profilePlayer, descriptions, input, canvas, camera);

            controllers.Add(input);
            AddController(_spawnController);
            // controllers.Add(mouseInput);
        }
    }
}