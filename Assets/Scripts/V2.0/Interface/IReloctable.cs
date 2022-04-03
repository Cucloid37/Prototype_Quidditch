using UnityEngine;

namespace V2._0
{
    public interface IRelocatable
    {
        Coordinates coordinates { get; }

        GameObject icon { get; }
        
    }

    public class AxisY
    {
        public ReactiveValue<int> axisValue;

        public AxisY()
        {
            axisValue = new ReactiveValue<int>();
        }
    }
    
}