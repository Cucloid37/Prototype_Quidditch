using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace V2._0.UI

{
    
    
    [Serializable]
    public class ButtonModel
    {
        // скорее всего наследуется от кого-нибудь

        public AssetReference reference;
        public Vector3 position;
        public ButtonType buttonType;

        public Button myButton { get; private set; }

        public void SetButton(GameObject button)
        {
            myButton = button.GetComponent<Button>();
        }
    }
}