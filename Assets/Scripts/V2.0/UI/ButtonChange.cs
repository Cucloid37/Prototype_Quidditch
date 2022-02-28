using System;
using UnityEngine;
using UnityEngine.UI;

namespace V2._0.UI
{
    [Serializable]
    public class ButtonChange : MonoBehaviour
    {
        [SerializeField] private Transform _displayOnUI;
        [SerializeField] private Change _action;
        [SerializeField] private Characteristic _characteristic;

        public Transform DisplayOnUI => _displayOnUI;
        public Change action => _action;
        public Characteristic characteristic => _characteristic;
        public Button button { get; private set; }

        public void InitButton()
        {
            button = gameObject.GetComponent<Button>();
        }
    }
}