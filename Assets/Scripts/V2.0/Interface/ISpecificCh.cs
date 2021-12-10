namespace V2._0
{
    public interface ISpecificCh : ICharacteristic
    {
        int Count { get; }

        void SetCount(int current);
    }
}