using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace V2._0
{
    public class ChangedMenuView : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _oneTeam;
        [SerializeField] private Button _twoTeam;
        
        //todo вынести кнопки в конфиги
        [SerializeField] private List<Button> _buttonsChanged;

        // возможно, окажется эффективным словарь
        public Dictionary<Chang, Action<IFlyer>> buttons = new Dictionary<Chang, Action<IFlyer>>()
        {

        };

        public void Init(UnityAction startBattle, UnityAction<FlyerTeam> changeTeam)
        {
            _startButton.onClick.AddListener(startBattle);
            _oneTeam.onClick.AddListener(delegate { changeTeam(FlyerTeam.One); });
            _twoTeam.onClick.AddListener(delegate { changeTeam(FlyerTeam.Two); });

            foreach (var button in _buttonsChanged)
            {
                button.onClick.AddListener(startBattle);
            }
        }

        protected void OnDestroy()
        {
            _startButton.onClick.RemoveAllListeners();
            _oneTeam.onClick.RemoveAllListeners();
            _twoTeam.onClick.RemoveAllListeners();
        }
    }

    public enum Chang
    {
        Minus,
        Plus
    }
}