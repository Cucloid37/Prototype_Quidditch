using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class FlyersInitialization
    {
        private FlyerFactory _factory;
        private List<IFlyer> _teamOne;
        private List<IFlyer> _teamTwo;

        public List<IFlyer> TeamOne => _teamOne;
        public List<IFlyer> TeamTwo => _teamTwo;

        private const int FLYERSCOUNT = 7;
        public FlyersInitialization(FlyerFactory factory)
        {
            _factory = factory;
            _teamOne = CreateTeam(FlyerTeam.One);
            _teamTwo = CreateTeam(FlyerTeam.Two);
        }

        public List<IFlyer> CreateTeam(FlyerTeam teamEnum)
        {
            List<IFlyer> team = new List<IFlyer>()
            {
                _factory.CreateFlyer(FlyerType.Keeper),
                _factory.CreateFlyer(FlyerType.Seeker),
                _factory.CreateFlyer(FlyerType.Beater),
                _factory.CreateFlyer(FlyerType.Beater),
                _factory.CreateFlyer(FlyerType.Hunter),
                _factory.CreateFlyer(FlyerType.Hunter),
                _factory.CreateFlyer(FlyerType.Hunter)
            };
            
            Debug.Log($"{team.Count}, {team.Capacity}");

            for (int i = 0; i < team.Count; i++)
            {
                team[i]?.SetTeam(teamEnum);
                Debug.Log($"Создан флайер {team[i]?.Type}, хэшкод {team.GetHashCode()}, {team[i].GetType()}");
            }
            
            return team;
        }
        
    }
}