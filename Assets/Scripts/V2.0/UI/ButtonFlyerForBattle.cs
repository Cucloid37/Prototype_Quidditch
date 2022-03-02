using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class ButtonFlyerForBattle : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private int _flyerIndex;

        
        public void Init(UnityAction selectFlyer)
        {
            _button = gameObject.GetComponent<Button>();
            _button.onClick.AddListener(selectFlyer);
        }
    }
}