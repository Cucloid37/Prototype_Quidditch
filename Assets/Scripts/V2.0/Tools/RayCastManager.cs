using UnityEngine;
using UnityEngine.EventSystems;

namespace V2._0
{
    public class RayCastManager
    {
       public GameObject RayCastReturn()
        {
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 100))
            {
                return hitInfo.collider.gameObject;
            }
            return null;
        }

        
    }
}