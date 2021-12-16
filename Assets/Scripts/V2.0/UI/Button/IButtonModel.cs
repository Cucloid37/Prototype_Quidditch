using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace V2._0.UI
{
    
    public interface IButtonModel
    {
        AssetReference reference { get; }
        TaskOfButtons buttonsTask { get; }
        
        Vector3 position { get; }
        GameObject myObject { get; }
        Button myButton { get; }

        void SetButton(GameObject button);
    }

    public interface IButtonMath : IButtonModel
    {
        
    }
}