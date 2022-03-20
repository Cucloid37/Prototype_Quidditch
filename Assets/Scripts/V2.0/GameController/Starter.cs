using System.Linq;
using UnityEngine;
using V2._0._2_ProgrammData.Code.Scripts._GameController.Descriptions;

namespace V2._0
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private Descriptions _descriptions;
        [SerializeField] private GameObject _canvas;
        [SerializeField] private GameObject _mainCamera;
        private ProfilePlayer _profile;
        private SubscriptionProperty<UpdateControllers> _controllers;
        private FlyersInitialization _loadReference;
        private MainController _mainController;

        private int TestCount;
        [SerializeField] private CarDescription _carDescription;
        
        private void Start()
        {
            TestVoid();
            _profile = new ProfilePlayer();
            _controllers = new SubscriptionProperty<UpdateControllers>()
            {
                Value = new UpdateControllers()
            };
            
            _mainController = new MainController(_profile, _descriptions, _controllers.Value, _canvas, _mainCamera);
            _controllers.Value.Initialization();
        
        }

        public void TestVoid()
        {

            var x = new ReactiveValue<int>()
            {
                CurrentValue = 3
            };

            x.OnChange += TestInt;

            x.CurrentValue = 5;
            x.CurrentValue = 3;
            x.CurrentValue = 3;
            x.CurrentValue = 6;
        }

        public void TestInt(int x)
        {
            Debug.Log($"{TestCount += x}");
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllers?.Value.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            _controllers?.Value.LateExecute(deltaTime);
        }

        private void OnDestroy()
        {
           _controllers?.Value.Cleanup();
        }
    }
}