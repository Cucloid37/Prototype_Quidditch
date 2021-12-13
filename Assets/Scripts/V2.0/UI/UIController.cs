
using System;
using System.Collections.Generic;

namespace V2._0.UI
{
    public class UIController
    {
        // нет, что-то я не так делаю с делегатами... Почему это для меня так сложно???...
        
        private Action plus;
        private Dictionary<ButtonType, Action> buttonActions;
        private List<ButtonModel> _models;

        public Dictionary<ButtonType, Action> ButtonActions => buttonActions;

        public UIController(List<ButtonModel> models)
        {
            _models = models;
                                        // todo понять, где лучше инициализировать словари (отдельный класс?)
                                        // будем смотреть на функционал и писать под него методы
            plus += Plus;
            buttonActions = new Dictionary<ButtonType, Action>()
            {
                {ButtonType.Plus, plus}
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