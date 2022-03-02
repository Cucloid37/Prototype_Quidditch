using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    public interface IFlyer : ISpawn
    {
        
        FlyerType Type { get; }
        FlyerTeam Team { get; }
        Coordinates coordinates { get; }
        ICanMove IsCanMove { get; }
        void SetTeam(FlyerTeam team);
        void SetCoor(Coordinates coor);
        void Fly(Transform target);
    }
}