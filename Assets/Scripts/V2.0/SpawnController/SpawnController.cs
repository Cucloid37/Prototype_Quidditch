using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    public class SpawnController : BaseController
    {
        private readonly MoveManager manager;
        private readonly SpawnView _view;
        private readonly Transform _camera;
        private readonly ProfilePlayer _profile;
        private readonly MoveController _moveController;
        private readonly Descriptions _descriptions;
        private readonly InputController _input;
        private readonly Transform _canvas;

        public SubscriptionProperty<IFlyer> SelectedFlyer { get; }
        private Transform positionField;
        private int teamIndex = 0;

        public SpawnController(MoveManager manager, MoveController moveController, ProfilePlayer profile, Descriptions descriptions, 
            InputController input, Transform canvas, GameObject camera)
        {
            this.manager = manager;
            _profile = profile;
            _moveController = moveController;
            _descriptions = descriptions;
            _input = input;
            _canvas = canvas;
            _camera = camera.transform;
            _view = LoadView();
            _view.Init(SelectFlyer, TransformToLayer, ChangeTeam);

            SelectedFlyer = new SubscriptionProperty<IFlyer>
            {
                Value = manager.SelectedFlyer.Value
            };
            
             SelectedFlyer.SubscribeOnChange(SetManager);
            
            _input.OnClickMouseLeft += SelectTransform;
            _input.OnClickMouseLeft += PutInPosition;
            _input.OnClickButtonBack += CameraDown;
            _input.OnClickButtonForward += CameraUp;
        }

        private void SetManager(IFlyer flyer)
        {
            manager.SelectedFlyer.Value = flyer;
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
            Debug.LogWarning($"{_camera.position.y}");
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
             var x = _profile.RayCast.Value.RayCastReturn();
             if (x == null)
             {
                 Debug.Log($"RayCast == null");
                 return;
             }
             if (x.transform.GetComponent<SquareView>())
             {
                 positionField = x.transform;
                 Debug.LogWarning($"Мы изменили трансформ перемещения {x}");
             }
             
             Debug.LogError($"Мы ничего не меняли");
         }
         
         public void SelectFlyer(int buttonIndex)
        {
            if (manager.SelectedFlyer.Value != null)
            {
                _moveController.UnSelectFlyer(manager.SelectedFlyer.Value);
            }
            
            manager.SelectedFlyer.Value = manager.FlyersDic[buttonIndex + teamIndex];
            _moveController.SelectFlyer(manager.SelectedFlyer.Value);
             
              
            Debug.Log($"Мы изменили игрока! {manager.SelectedFlyer.Value.Type}");
        }
    
        public void PutInPosition()
        {
            if (manager.SelectedFlyer.Value != null)
            {
                if (manager.SelectedFlyer.Value.IsCanMove.IsReady(manager.SelectedFlyer.Value.IsCanMove))
                {
                    if (positionField != null)
                    {
                        manager.SelectedFlyer.Value.Fly(positionField);     // я что-то упускаю очевидное
                    }

                    Debug.Log($"{positionField}");
                    return;
                } 
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
            _input.OnClickButtonBack -= CameraDown;
            _input.OnClickButtonForward -= CameraUp;
        }
    }
}