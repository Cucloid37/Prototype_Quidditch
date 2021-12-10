using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class UIModel : IUserInterfaceModel
    {
        private Dictionary<Button, Action> _actions;
        
        public UIModel(Dictionary<Button, Action> actions)
        {
            _actions = actions;
        }
    }
}