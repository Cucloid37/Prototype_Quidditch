using System;
using System.Collections.Generic;

namespace V2._0
{
    public class MoveManager
    {
        public SubscriptionProperty<IFlyer> SelectedFlyer;
        public SubscriptionProperty<FlyerTeam> ActionTeam;
        public SubscriptionProperty<int> MoveCount;

        public Dictionary<int, IFlyer> FlyersDic;

        public MoveManager(ProfilePlayer profile)
        {
            FlyersDic = new Dictionary<int, IFlyer>()
            {
                {0, profile.TeamOne.Value[0]},
                {1, profile.TeamOne.Value[1]},
                {2, profile.TeamOne.Value[2]},
                {3, profile.TeamOne.Value[3]},
                {4, profile.TeamOne.Value[4]},
                {5, profile.TeamOne.Value[5]},
                {6, profile.TeamOne.Value[6]},
                {7, profile.TeamTwo.Value[0]},
                {8, profile.TeamTwo.Value[1]},
                {9, profile.TeamTwo.Value[2]},
                {10, profile.TeamTwo.Value[3]},
                {11, profile.TeamTwo.Value[4]},
                {12, profile.TeamTwo.Value[5]},
                {13, profile.TeamTwo.Value[6]}
            };
            
        }
    }
}