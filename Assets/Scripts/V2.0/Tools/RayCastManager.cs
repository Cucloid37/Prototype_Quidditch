using UnityEngine;
using UnityEngine.EventSystems;

namespace V2._0
{
    public class RayCastManager
    {
        
        private GameObject hitInfoObject;

        public GameObject HitInfoObject => hitInfoObject;


        public void SetHitInfo()
        {
            hitInfoObject = RayCastReturn();
        }
        
        public GameObject RayCastReturn()
        {
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 100))
            {
                return hitInfo.collider.gameObject;
            }
            return null;
        }

        public void Execute(float deltaTime)
        {
            //todo вынести обозначение кнопки мыши в статический класс
            //todo вынести импут в отдельный класс
            if (Input.GetMouseButtonDown(0))
                hitInfoObject = RayCastReturn();
            if (Input.GetMouseButtonDown(1))
                hitInfoObject = RayCastReturn();
        }
    }
}