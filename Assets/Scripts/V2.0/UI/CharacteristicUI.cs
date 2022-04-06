using System;
using UnityEngine;
using UnityEngine.UI;

namespace V2._0
{
    public class CharacteristicUI : MonoBehaviour
    {
        [SerializeField] private Text _seconds;
        [SerializeField] private Text _points;

        public Text Seconds => _seconds;
        public Text Points => _points;
    }
}