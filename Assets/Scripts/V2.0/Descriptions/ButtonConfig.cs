using System;
using System.Collections.Generic;
using UnityEngine;
using V2._0.UI;

namespace V2._0
{
    [CreateAssetMenu(fileName = "Button", menuName = "Descriptions/ButtonConfig")]
    public class ButtonConfig : ScriptableObject
    {
        [SerializeField] private List<ButtonChange> buttonsChange;
        [SerializeField] private List<ButtonFlyer> buttonsFlyer;

        public List<ButtonChange> ButtonsChange => buttonsChange;
        public List<ButtonFlyer> ButtonsFlyer => buttonsFlyer;

    }

    /*[Serializable]
    public class SerializableButtonChange
    {
        
        [SerializeField] private List<ButtonChange> buttons;
        [SerializeField] private List<GameObject> transforms;

        private Dictionary<ButtonChange, GameObject> _dictionary = new Dictionary<ButtonChange, GameObject>();

        public Dictionary<ButtonChange, GameObject> GetDictionaryButtons()
        {
            for (int i = 0; i < buttons.Capacity; i++)
            {
                _dictionary.Add(buttons[i], transforms[i]);
            }

            return _dictionary;
        }
        
    }*/
    
    public enum Characteristic
    {
        Force,
        MagicForce,
        Agility
    }
    
    public enum Change
    {
        Minus,
        Plus
    }
}