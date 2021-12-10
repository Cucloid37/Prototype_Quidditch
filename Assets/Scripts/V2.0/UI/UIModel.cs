using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class UIModel : IUserInterfaceModel
    {
        private Dictionary<Button, Action> _actions;
        private Button _button;
        
        public UIModel(Dictionary<Button, Action> actions)
        {
            _actions = actions;
        }
        
        
    }
}