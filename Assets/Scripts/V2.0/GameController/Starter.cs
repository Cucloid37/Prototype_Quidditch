using UnityEngine;

namespace V2._0
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private BattleDescription battleDescript;
        [SerializeField] private PeaceDescriptions peaceDescriptions;
        [SerializeField] private UIDescription uiDescription;
        [SerializeField] private GameObject _canvas;
        private MonoControllers _controllers;
        
        private void Start()
        {
            _controllers = new MonoControllers();
            var initialization = new GameInitialization(battleDescript, peaceDescriptions, uiDescription, _controllers, _canvas);
            _controllers.Initialization();
        
        }
    
        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}