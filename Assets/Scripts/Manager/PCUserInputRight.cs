using System;
using UnityEngine;


    public sealed class PCUserInputRight : IUserInputProxy
    {
        public event Action<float> AxisOnChang = delegate (float f) { };
        public void GetAxis()
        {
            AxisOnChang.Invoke(Input.GetAxis(AxisManager.MouseRight));
        }
    }