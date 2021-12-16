
using System;
using System.Collections.Generic;

namespace V2._0.UI
{
    public class UIController
    {
        // нет, что-то я не так делаю с делегатами... Почему это для меня так сложно???...
        
        private Action plus;
        private Dictionary<TaskOfButtons, Action> buttonActions;
        private UIManager _manager;

        public Dictionary<TaskOfButtons, Action> ButtonActions => buttonActions;

        public UIController(UIManager manager)
        {
            _manager = manager;
                                        // todo понять, где лучше инициализировать словари (отдельный класс?)
                                        // будем смотреть на функционал и писать под него методы
            plus += Plus;
            buttonActions = new Dictionary<TaskOfButtons, Action>()
            {
                {TaskOfButtons.Plus, plus}
            };
        }

        public void Plus()
        {
            
        }

        public void Minus()
        {
            
        }
    }
}