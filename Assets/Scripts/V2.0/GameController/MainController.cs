using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class MainController : BaseController
    {
        private BattleController _battleController;
        private MainMenuController _mainMenuController;
        private ChangedMenuController _changedMenuController;
        private UpdateControllers _updateControllers;

        private GameObject _container = new GameObject("Container");
        private readonly Descriptions _descriptions;
        private readonly FlyerFactory _factoryFlyer;
        private readonly GameObject _canvas;    //??
        private readonly ProfilePlayer _profilePlayer;
        private readonly Transform _placeForUi;  //??
        
        
        public MainController(ProfilePlayer profilePlayer, Descriptions descriptions,
            UpdateControllers updateControllers, GameObject canvas)
        {
            _profilePlayer = profilePlayer;
            _placeForUi = canvas.transform;
            _descriptions = descriptions;
            _canvas = canvas;
            _updateControllers = updateControllers;
            var factory = _container.AddComponent<Factory>();
            _factoryFlyer = new FlyerFactory(factory, descriptions);
            _factoryFlyer.LoadView();
            
            profilePlayer.CurrentState.SubscribeOnChange(OnChangeGameState);
            OnChangeGameState(_profilePlayer.CurrentState.Value);
        }
        
        protected override void OnDispose()
        {
            _mainMenuController?.Dispose();
            _battleController?.Dispose();
            _profilePlayer.CurrentState.UnSubscriptionOnChange(OnChangeGameState);
            base.OnDispose();
        }
        
        private void OnChangeGameState(GameState state)
        {
            switch (state)
            {
                case GameState.None:
                    break;
                case GameState.MainMenu:
                    _mainMenuController = new MainMenuController(_placeForUi, _profilePlayer);
                    _battleController?.Dispose();
                    break;
                case GameState.ChangeTeam:
                    _changedMenuController = new ChangedMenuController(_profilePlayer, _factoryFlyer, _descriptions);
                    _mainMenuController?.Dispose();
                    break;
                case GameState.Battle:
                    _battleController = new BattleController(_profilePlayer, _descriptions, _factoryFlyer, _updateControllers, _canvas);
                    _mainMenuController?.Dispose();
                    break;
                default:
                    _mainMenuController?.Dispose();
                    _battleController?.Dispose();
                    break;
            }
        }
    }
}