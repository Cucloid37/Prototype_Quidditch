using UnityEngine;

namespace V2._0
{
    public class MainMenuController : BaseController
    {
        // мне не шибко нравится подобная реализация ссылок. Мне кажется, лучше создать статический класс
        // содержащий список всех ссылок и константных данных
        private readonly ResourcePath _viewPath = new ResourcePath {PathResource = "Prefabs/mainMenu"};
        private readonly ProfilePlayer _profilePlayer;
        private readonly MainMenuView _view;

        public MainMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(StartBattle);
            AddGameObjects(_view.gameObject);
        }

        private MainMenuView LoadView(Transform placeForUi)
        {
            /*var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath.PathResource), placeForUi, false);
            AddGameObjects(objectView);*/

            return UIFactory<MainMenuView>.LoadUI(_viewPath.PathResource, placeForUi); /*objectView.GetComponent<MainMenuView>();*/
        }

        private void StartBattle()
        {
            _profilePlayer.CurrentState.Value = GameState.Spawn;
        }
        
        private void StartChangingTeam()
        {
            _profilePlayer.CurrentState.Value = GameState.ChangeTeam;
        }
    }
}