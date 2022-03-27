namespace V2._0
{
    public interface IRelocatable
    {
        ReactiveValue<int> axisY { get; }
        
        

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