using System;
using UnityEngine;


    public sealed class PCUserInputLeft : IUserInputProxy
    {
        public event Action<float> AxisOnChang = delegate(float f) { };
    
        public void GetAxis()
        {
            AxisOnChang.Invoke(Input.GetAxis(AxisManager.MouseLeft));
        }
    }
