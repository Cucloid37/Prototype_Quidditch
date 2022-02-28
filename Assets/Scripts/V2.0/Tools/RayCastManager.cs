using UnityEngine;
using UnityEngine.EventSystems;

namespace V2._0
{
    public class RayCastManager : IExecute
    {
        private GameObject hitInfoObject;

        public GameObject HitInfoObject => hitInfoObject;

        public static GameObject RayCastReturn()
        {
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 50))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return null;
                return hitInfo.collider.gameObject;
            }
            return null;
        }

        public void Execute(float deltaTime)
        {
            //todo вынести обозначение кнопки мыши в статический класс
            if (Input.GetMouseButtonDown(0))
                hitInfoObject = RayCastReturn();
            if (Input.GetMouseButtonDown(1))
                hitInfoObject = RayCastReturn();
        }
    }
}