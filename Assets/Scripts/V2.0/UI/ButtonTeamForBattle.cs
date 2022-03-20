using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class ButtonTeamForBattle : MonoBehaviour, IDisposable
    {
        [SerializeField] private Button _button;
        [SerializeField] private int _teamIndex;

        public Button button => _button; 
        public int TeamIndex => _teamIndex;

        public void Init(UnityAction<int> changeTeam)
        {
            _button.onClick.AddListener(delegate { changeTeam(_teamIndex); });
        }

        public void Dispose()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}