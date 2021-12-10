using System;

namespace V2._0
{
    [Serializable]
    public class Agility : ISpecificCh
    {
        public int Count { get; private set; }
        
        public void SetCount(int current)
        {
            Count = current;
        }
    }
}