using System;
using UnityEngine;
using UnityEngine.UI;

namespace V2._0.UI
{
    [Serializable]
    public class ButtonFlyer : MonoBehaviour
    {
        //[SerializeField] private Transform _displayOnUI;
        [SerializeField] private FlyerType _type;
        private Button _button;
        
        
        public SubscriptionProperty<IFlyer> flyerByButton { get; }
        //public Transform DisplayOnUI => _displayOnUI;
        public Button button => _button;
        public FlyerType type => _type;

        public void InitButton()
        {
            _button = gameObject.GetComponent<Button>();
            if (_button == null)
            {
                new Exception("Блаблаблаблаблабла");
            }
        }
    }
}