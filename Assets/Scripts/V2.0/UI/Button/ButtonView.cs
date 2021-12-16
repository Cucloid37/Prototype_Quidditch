using System;
using UnityEngine;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class ButtonView : MonoBehaviour
    {
        public event Action<int> Click;
        
        private Button _button;
        
    }
}