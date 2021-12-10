using UnityEngine;
using V2._0.Input;

namespace V2._0
{
    public class GameInitialization
    {

        public GameInitialization(BattleDescription battleDescription, PeaceDescriptions peaceDescriptions, UIDescription uiDescription,
            MonoControllers controllers, GameObject canvas)
        {
        
            var inputInitialization = new InputInitialization();    // todo разобраться с импутом

            IFactory factory = new GameObject("Factory in GI").AddComponent<Factory>();
            
            



        }
    }
}