using System;
using System.Collections.Generic;

namespace V2._0.UI
{
    public class UIManager
    {
        private Dictionary<IButton, Action> buttonAction;

        public void SubscribeToEvent()
        {
            foreach (var action in buttonAction)
            {
                action.Key
            }
        }
    }
}