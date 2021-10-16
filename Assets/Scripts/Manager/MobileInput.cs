using System;
using UnityEngine;


    public sealed class MobileInput : IUserInputProxy
    {
        public event Action<float> AxisOnChang = delegate(float f) { };
        public void GetAxis()
        {
            // Сейчас не отличается от PCUserInputRight!!!! Разобраться в разности платформ!
            AxisOnChang.Invoke(Input.GetAxis(AxisManager.MouseRight));
        }
    }