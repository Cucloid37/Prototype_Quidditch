using UnityEngine;

namespace V2._0
{
    public class SpawnController : BaseController
    {
        private MoveManager manager;
        private SpawnView _view;
        private readonly ProfilePlayer _profile;
        private readonly MoveController _moveController;
        private readonly Descriptions _descriptions;

        public SpawnController(MoveManager manager, ProfilePlayer profile, MoveController moveController, Descriptions descriptions)
        {
            this.manager = manager;
            _profile = profile;
            _moveController = moveController;
            _descriptions = descriptions;
            _view = LoadView();
        }
              //
             // Подписать мышку на PutInPosition
            // 
        public void SelectedFlyer(int buttonIndex)
        {
            _moveController.UnSelectFlyer(manager.SelectedFlyer.Value);
            manager.SelectedFlyer.Value = manager.FlyersDic[buttonIndex];
            _moveController.SelectFlyer(manager.SelectedFlyer.Value); 
               // 
              // 
             // Родилась мысль изменить разделение List либо на единый двухмерный массив или словарь - так будет, полагаю, проще
            // 
        }
    
        public void PutInPosition(Transform positionField)
        {
            manager.SelectedFlyer.Value.Fly(positionField);     // я что-то упускаю очевидное
        }

        public void EndSpawn()
        {
            _profile.CurrentState.Value = GameState.Battle; 
        }

        private SpawnView LoadView()
        {
            var objView = Object.Instantiate(_descriptions.ButtonsConfig.UIForBattle);
            AddGameObjects(objView);

            return objView.GetComponent<SpawnView>();
        }
    }
}