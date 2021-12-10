using UnityEngine;

namespace V2._0
{
    public interface IFlyerFactory : ISpawnFactory
    {
        IFlyer CreateFlyer(FlyerType type);
        
    }
}