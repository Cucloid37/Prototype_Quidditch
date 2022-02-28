using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using V2._0.UI;

namespace V2._0
{
    public class ChangedMenuView : MonoBehaviour
    {
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _oneTeam;
        [SerializeField] private Button _twoTeam;
        
        //todo вынести кнопки в конфиги
        private List<ButtonFlyer> _buttonsFlyers = new List<ButtonFlyer>();
        private List<ButtonChange> _buttonChanges = new List<ButtonChange>();

        public void Init(UnityAction startBattle, UnityAction<FlyerTeam> changeTeam, UnityAction<IFlyer> changeFlyer,
            UnityAction<ButtonChange> changeCharacteristic)
        {
            _startButton.onClick.AddListener(startBattle);
            _oneTeam.onClick.AddListener(delegate { changeTeam(FlyerTeam.One); });
            _twoTeam.onClick.AddListener(delegate { changeTeam(FlyerTeam.Two); });

            foreach (var button in _buttonsFlyers)
            {
                button.InitButton();
                button.button.onClick.AddListener(delegate { changeFlyer(button.flyerByButton.Value); });
            }

            foreach (var button in _buttonChanges)
            {
                button.InitButton();
                button.button.onClick.AddListener(delegate { changeCharacteristic(button); });
            }
        }

        public void InitButtons(List<ButtonFlyer> buttonFlyers, List<ButtonChange> buttonChanges)
        {
            _buttonsFlyers = buttonFlyers;
            _buttonChanges = buttonChanges;

        }

        public void ChangeValueUI(IFlyer flyer)
        {
            
        }

        protected void OnDestroy()
        {
            _startButton.onClick.RemoveAllListeners();
            _oneTeam.onClick.RemoveAllListeners();
            _twoTeam.onClick.RemoveAllListeners();
            
            foreach (var button in _buttonsFlyers)
            {
                button.button.onClick.RemoveAllListeners();
            }

            foreach (var button in _buttonChanges)
            {
                button.button.onClick.RemoveAllListeners();
                    
            }
        }
    }
}