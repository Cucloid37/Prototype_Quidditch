using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace V2._0
{
    public class BattleInitialization : BaseController
    {
        private ControlController _controlController;
        private GameObject factory = new GameObject("Factory");

        private const int OneRing = 765;
        private const int TwoRing = 476;
        private const int TreeRing = 1003;
        

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
                field.Views[OneRing].Position,
                field.Views[TwoRing].Position,
                field.Views[TreeRing].Position,
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
            
            var uiController = new UIController(profilePlayer, input, moveManager);
            
            _controlController = new ControlController(moveManager, moveController, profilePlayer, descriptions, input, canvas, camera);

            
            // UIFactory<MainMenuView>.LoadUI(PathUI.PathBattle, canvas);
            

            controllers.Add(input);
            AddController(_controlController);
            AddController(uiController);
            // controllers.Add(mouseInput);
        }
    }

    public static class UIFactory<T>
    {
        private static Transform _canvas;

        public static void SetCanvas(Transform canvas)
        {
            _canvas = canvas;
        }
        
        public static T LoadUI(string path, Transform canvas)
        {
            var objView = Object.Instantiate(ResourceLoader.LoadPrefab(path), canvas);
            
            return objView.GetComponent<T>();
        }
    }

    public static class PathUI
    {
        public const string PathBattle = "Prefabs/UI/UI_InsideBattle";
    }
}