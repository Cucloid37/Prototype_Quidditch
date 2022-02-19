using V2._0.Predicates;

namespace V2._0
{
    public interface IFlyer : ISpawn
    {
        IPredicate[] СanIFly { get; set; }
        FlyerType Type { get; }
        FlyerTeam Team { get; }
        void SetTeam(FlyerTeam team);
    }
}