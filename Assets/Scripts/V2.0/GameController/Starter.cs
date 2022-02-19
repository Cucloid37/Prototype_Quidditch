using UnityEngine;

namespace V2._0
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private Descriptions _descriptions;
        [SerializeField] private GameObject _canvas;
        private ProfilePlayer _profile;
        private UpdateControllers _controllers;
        private FlyersInitialization _loadReference;
        private MainController _mainController;
        
        private void Start()
        {
            _profile = new ProfilePlayer();
            _controllers = new UpdateControllers();
            _mainController = new MainController(_profile, _descriptions, _controllers, _canvas);
            _controllers.Initialization();
        
        }
    
        private void Update()
        {
            var deltaTime = Time.deltaTime;
            //_controllers.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            //_controllers.LateExecute(deltaTime);
        }

        private void OnDestroy()
        {
           _controllers?.Cleanup();
        }
    }
}