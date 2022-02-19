using UnityEngine;

namespace V2._0
{
    public class BattleController : BaseController
    {
        private GameObject factory = new GameObject("Factory");
        
        public BattleController(ProfilePlayer profilePlayer, Descriptions descriptions, UpdateControllers controllers, GameObject canvas)
        {
            var inputInitialization = new InputController(descriptions.InputDescription);

            FieldFactory fieldFactory = factory.AddComponent<FieldFactory>();
            fieldFactory.SetDescription(descriptions);

            controllers.Add(inputInitialization);
        }
    }
}