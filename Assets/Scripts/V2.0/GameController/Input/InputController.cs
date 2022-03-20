using System;
using UnityEngine;

namespace V2._0
{
    public class InputController : IExecute
    {
        //todo переименовать переменные, добавить мышку
        public event Action OnClickButtonForward;
        public event Action OnClickButtonBack;
        public event Action OnClickButtonRight;
        public event Action OnClickButtonLeft;

        public event Action OnClickMouseLeft;

        private readonly KeysManager _inputKeys;
        private readonly InputKeysData _inputKeysData;

        public InputController(InputKeysData inputDescription)
        {
            _inputKeys = new KeysManager();
            _inputKeysData = inputDescription;
        }
        
        public void Execute(float deltaTime)
        {
            if (Time.timeScale == Mathf.Round(0)) return;           //ToAsk 

            _inputKeys.GetKeyForward(_inputKeysData, OnClickButtonForward);
            _inputKeys.GetKeyBack(_inputKeysData, OnClickButtonBack);
            _inputKeys.GetKeyRight(_inputKeysData, OnClickButtonRight);
            _inputKeys.GetKeyLeft(_inputKeysData, OnClickButtonLeft);
            _inputKeys.GetMouseRight(OnClickMouseLeft);
        }
        
    }
}