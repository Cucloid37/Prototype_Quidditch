using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace V2._0.UI

{
    
    [Serializable]
    public class ButtonModel : IButtonModel
    {

        public AssetReference reference { get; private set; }
        public TaskOfButtons buttonsTask { get; private set; }

        [field: NonSerialized]
        public Vector3 position { get; private set; }
        
        public GameObject myObject { get; private set; }

        public Button myButton { get; private set; }

        public void SetButton(GameObject button)
        {
            myObject = button;
            myButton = myObject.GetComponent<Button>();
            position = myObject.transform.position;
        }
        
    }
}