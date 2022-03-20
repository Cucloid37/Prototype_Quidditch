using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class ButtonFlyerForBattle : MonoBehaviour, IDisposable
    {
        [SerializeField] private Button _button;
        [SerializeField] private int _flyerIndex;

        public Button button => _button; 
        public int FlyerIndex => _flyerIndex;

        public void Init(UnityAction<int> selectFlyer)
        {
            _button.onClick.AddListener(delegate { selectFlyer(_flyerIndex); });
        }

        public void Dispose()
        { 
            _button.onClick.RemoveAllListeners();
        }
    }
}