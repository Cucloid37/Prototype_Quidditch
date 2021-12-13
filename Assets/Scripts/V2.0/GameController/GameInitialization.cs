using UnityEngine;
using V2._0.Input;
using V2._0.UI;

namespace V2._0
{
    public class GameInitialization
    {

        public GameInitialization(BattleDescription battleDescription, PeaceDescriptions peaceDescriptions, UIDescription uiDescription,
            MonoControllers controllers, GameObject canvas)
        {
        
            var inputInitialization = new InputInitialization();    // todo разобраться с импутом

            IUserInterfaceFactory factory = new GameObject("Factory in GI").AddComponent<UIFactory>();
            // мы запускаем PeaceInitialization
            var peaceInitialization = new PeaceInitialization(factory);



        }
    }
}