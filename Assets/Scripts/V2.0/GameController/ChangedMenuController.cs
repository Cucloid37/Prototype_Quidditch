using System.Collections.Generic;
using UnityEngine;
using V2._0.UI;

namespace V2._0
{
    public class ChangedMenuController : BaseController
    {
        //todo перенести в config или создать статический класс ResourcePath
        private readonly ResourcePath _viewPath = new ResourcePath {PathResource = "Prefabs/UI/CreateTeam/CreateTeam"};
        private readonly ProfilePlayer _profile;
        private readonly FlyerFactory _factoryFlyer;
        private readonly Descriptions _descriptions;
        private ChangedMenuView _view;
        private FlyersInitialization _flyersInitialization;

        public ChangedMenuController(ProfilePlayer profile, FlyerFactory factoryFlyer, Descriptions descriptions)
        {
            _profile = profile;
            _factoryFlyer = factoryFlyer;
            _descriptions = descriptions;
            /*_flyersInitialization = new FlyersInitialization(_factoryFlyer);
            
            _profile.TeamOne.Value = _flyersInitialization.TeamOne;
            _profile.TeamTwo.Value = _flyersInitialization.TeamTwo;*/

            _view = LoadView();
            _view.InitButtons(descriptions.ButtonsConfig.ButtonsFlyer, descriptions.ButtonsConfig.ButtonsChange);
            _view.Init(StartBattle, ChangeTeam, ChangeFlyer, CharactersChange);
            
        }

        private void StartBattle()
        {
            Debug.Log("Запущен метод StartBattle");
            _profile.CurrentState.Value = GameState.Battle;
        }

        private void ChangeFlyer(IFlyer flyer)
        {
            
        }

        private void CharactersChange(ButtonChange button)
        {
            //button.DisplayOnUI.GetComponent<>()
        }

        private void ChangeTeam(FlyerTeam team)
        {
            //todo понять, каким методом изменять команду
            Debug.Log($"Была нажата кнопка TeamOne или TeamTwo");
        }

        private ChangedMenuView LoadView()
        {
            var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
            AddGameObjects(objView);

            return objView.GetComponent<ChangedMenuView>();
        }
    }
}