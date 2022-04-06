using System;
using UnityEngine;

namespace V2._0
{
    public class KeysManager
    {
        //todo много дублирования кода, it is not good
        public void GetKeyForward(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKeyDown(_inputKeysData.Forward)) action?.Invoke();
        }

        public void GetKeyBack(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKeyDown(_inputKeysData.Back)) action?.Invoke();
        }
        public void GetKeyRight(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKeyDown(_inputKeysData.Right)) action?.Invoke();
        }
        
        
        public void GetMouseRight(Action action)
        {
            if (Input.GetMouseButtonDown(1))
            {
                action?.Invoke();
            }
        }

        public void GetMouseLeft(Action action)
        {
            if (Input.GetMouseButtonDown(0))
            {
                action?.Invoke();
            }
        }
    }
}