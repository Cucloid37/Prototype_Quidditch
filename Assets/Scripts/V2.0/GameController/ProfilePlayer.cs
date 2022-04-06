using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class ProfilePlayer
    {
        public SubscriptionProperty<GameState> CurrentState { get; }
        public SubscriptionProperty<List<IFlyer>> TeamOne { get; }
        public SubscriptionProperty<List<IFlyer>> TeamTwo { get; }
        public SubscriptionProperty<RayCastManager> RayCast { get; }

        public ProfilePlayer()
        {
            CurrentState = new SubscriptionProperty<GameState>()
            {
                Value = GameState.MainMenu
            };
            
            TeamOne = new SubscriptionProperty<List<IFlyer>>()
            {
                Value = new List<IFlyer>()
            };
            TeamTwo = new SubscriptionProperty<List<IFlyer>>()
            {
                Value = new List<IFlyer>()
            };
            
            RayCast = new SubscriptionProperty<RayCastManager>()
            {
                Value = new RayCastManager()
            };
        }
    }

    //todo вынести в отдельное место все enum и прочие определения
    public enum GameState
    {
        None,
        MainMenu,
        ChangeTeam,
        Spawn,
        Battle
    }
}