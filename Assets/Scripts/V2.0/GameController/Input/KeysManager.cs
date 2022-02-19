using System;
using UnityEngine;

namespace V2._0
{
    public class KeysManager
    {
        //todo много дублирования кода, it is not good
        public void GetKeyForward(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKey(_inputKeysData.Forward)) action?.Invoke();
        }

        public void GetKeyBack(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKeyDown(_inputKeysData.Back)) action?.Invoke();
        }
        public void GetKeyRight(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKeyDown(_inputKeysData.Right)) action?.Invoke();
        }

        public void GetKeyLeft(InputKeysData _inputKeysData, Action action)
        {
            if (Input.GetKeyDown(_inputKeysData.Left)) action?.Invoke();
        }

        public void GetMouseRight(Action action)
        {
            if(Input.GetMouseButtonDown(0)) action?.Invoke();
        }
    }
}