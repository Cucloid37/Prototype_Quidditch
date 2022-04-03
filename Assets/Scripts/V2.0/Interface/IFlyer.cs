using System.Collections.Generic;
using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    public interface IFlyer : ISpawn, IRelocatable
    {
        
        FlyerType Type { get; }
        FlyerTeam Team { get; }
        Coordinates coordinates { get; }
        List<IPredicate> allPredicates { get; }
        FlyerView View { get; }
        void SetTeam(FlyerTeam team);
        void SetCoor(Coordinates coor);
        void Fly(Transform target);
    }
}