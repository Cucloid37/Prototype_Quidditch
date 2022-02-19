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
            _view.Init(StartChangingTeam);
        }

        private MainMenuView LoadView(Transform placeForUi)
        {
            var objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath), placeForUi, false);
            AddGameObjects(objectView);
        
            return objectView.GetComponent<MainMenuView>();
        }

        private void StartChangingTeam()
        {
            _profilePlayer.CurrentState.Value = GameState.ChangeTeam;
        }
    }
}