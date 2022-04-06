using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    //todo класс нуждается в рефакторинге
    public class ControlController : BaseController
    {
        private readonly MoveManager manager;
        private readonly SpawnView _view;
        private readonly Transform _camera;
        private readonly ProfilePlayer _profile;
        private readonly MoveController _moveController;
        private readonly Descriptions _descriptions;
        private readonly InputController _input;
        private readonly Transform _canvas;
        
        private Transform positionField;
        private int teamIndex = 0;

        public ControlController(MoveManager manager, MoveController moveController, ProfilePlayer profile, Descriptions descriptions, 
            InputController input, Transform canvas, GameObject camera)
        {
            this.manager = manager;
            _profile = profile;
            _moveController = moveController;
            _descriptions = descriptions;
            _input = input;
            _canvas = canvas;
            _camera = camera.transform;
            //_view = LoadView();
            _view = UIFactory<SpawnView>.LoadUI(PathUI.PathBattle, canvas);
            _view.Init(SelectFlyer, TransformToLayer, ChangeTeam);

            _input.OnClickMouseLeft += SelectTransform;
            _input.OnClickMouseLeft += PutInPosition;
            _input.OnClickMouseRight += RightMouseInput;
            _input.OnClickButtonBack += CameraDown;
            _input.OnClickButtonForward += CameraUp;
        }

        private void RightMouseInput()
        {
            Debug.LogWarning("RightMouseInput");
        }
        
        private void CameraDown()
        {
            if(_camera.position.y < 14)
                return;
            var position = _camera.position;
            position.Set(position.x, position.y-10, position.z);
            _camera.position = position;
        }
        
        private void CameraUp()
        {
            if(_camera.position.y > 80)
                return;
            var position = _camera.position;
            position.Set(position.x, position.y+10, position.z);
            _camera.position = position;
        }

        private void TransformToLayer(int index)
        {
            var newY = (index * 10) + 2;
            var position = _camera.position;
            position.Set(position.x, newY, position.z);
            _camera.position = position;
        }

        private void ChangeTeam(int value)
        {
            teamIndex = value;
        }
        
         public void SelectTransform()
         {
             var rayCast = _profile.RayCast.Value.RayCastReturn();
             if (rayCast == null)
             {
                 Debug.Log($"RayCast == null");
                 return;
             }
             if (rayCast.transform.GetComponent<SquareView>())
             {
                 positionField = rayCast.transform;
                 Debug.LogWarning($"Мы изменили трансформ перемещения {rayCast}");
             }
             
             Debug.LogError($"Мы ничего не меняли");
         }
         
         public void SelectFlyer(int buttonIndex)
        {
            if (manager.SelectedFlyer.Value != null)
            {
                // _moveController.UnSelectFlyer(manager.SelectedFlyer.Value);
            }
            
            manager.SelectedFlyer.Value = manager.FlyersDic[buttonIndex + teamIndex];
            // _moveController.SelectFlyer(manager.SelectedFlyer.Value);
             
              
            Debug.Log($"Мы изменили игрока! {manager.SelectedFlyer.Value.Type}");
        }
    
        public void PutInPosition()
        {
            if (manager.SelectedFlyer.Value != null)
            {
                // проверяем ещё, что флайер активный
                
                    if (positionField != null)
                    {
                        manager.SelectedFlyer.Value.Fly(positionField);     // я что-то упускаю очевидное
                    }

                    Debug.Log($"{positionField}");
                    return;
            }
            
            Debug.Log("PutInPosition // manager.SelectedFlyer.Value == null");
                
        }

        public void EndSpawn()
        {
            _profile.CurrentState.Value = GameState.Battle; 
        }

        private SpawnView LoadView()
        {
            var objView = Object.Instantiate(_descriptions.ButtonsConfig.UIForBattle, _canvas, false);
            AddGameObjects(objView);
            objView.gameObject.SetActive(true);

            return objView.GetComponent<SpawnView>();
        }

        protected override void OnDispose()
        {
            base.OnDispose();
            _input.OnClickMouseLeft -= SelectTransform;
            _input.OnClickMouseLeft -= PutInPosition;
            _input.OnClickMouseRight -= RightMouseInput;
            _input.OnClickButtonBack -= CameraDown;
            _input.OnClickButtonForward -= CameraUp;
        }
    }
}