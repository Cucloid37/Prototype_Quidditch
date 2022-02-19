using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class ChangedMenuController : BaseController
    {
        //todo перенести в config или создать статический класс ResourcePath
        private readonly ResourcePath _viewPath = new ResourcePath {PathResource = "Prefabs/ChangedMenu"};
        private readonly ProfilePlayer _profile;
        private readonly FlyerFactory _factoryFlyer;
        private ChangedMenuView _view;
        private FlyersInitialization _flyersInitialization;

        public ChangedMenuController(ProfilePlayer profile, FlyerFactory factoryFlyer)
        {
            _profile = profile;
            _factoryFlyer = factoryFlyer;
            _flyersInitialization = new FlyersInitialization(_factoryFlyer);
            _profile.TeamOne.Value = _flyersInitialization.TeamOne;
            _profile.TeamTwo.Value = _flyersInitialization.TeamTwo;
            _view = LoadView();
            _view.Init(StartBattle, ChangeTeam);
            _profile.TeamOne.SubscribeOnChange(CharactersChange);
        }

        public void CharactersChange(List<IFlyer> flyers)
        {
            //todo судя по всему, здесь я могу изменять значения в UI
            Debug.Log($"Мы изменили значение в {flyers[0].Team}");
        }

        private void StartBattle()
        {
            Debug.Log("Запущен метод StartBattle");
            _profile.CurrentState.Value = GameState.Battle;
        }

        private void ChangeFlyer(IFlyer flyer)
        {
            
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
        
            return objView.GetComponentInChildren<ChangedMenuView>();
        }
    }
}