using System.Collections.Generic;

namespace V2._0
{
    public class ProfilePlayer
    {
        public SubscriptionProperty<GameState> CurrentState { get; }
        public SubscriptionProperty<List<IFlyer>> TeamOne { get; }
        public SubscriptionProperty<List<IFlyer>> TeamTwo { get; }

        public ProfilePlayer()
        {
            CurrentState = new SubscriptionProperty<GameState>();
            TeamOne = new SubscriptionProperty<List<IFlyer>>()
            {
                Value = new List<IFlyer>()
            };
            TeamTwo = new SubscriptionProperty<List<IFlyer>>()
            {
                Value = new List<IFlyer>()
            };
            CurrentState.Value = GameState.MainMenu;
        }
    }

    public enum GameState
    {
        None,
        MainMenu,
        ChangeTeam,
        Spawn,
        Battle
    }
}