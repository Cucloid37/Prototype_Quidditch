using System;

    public interface IUserInputProxy
    {
        event Action<float> AxisOnChang;

        void GetAxis();
    }