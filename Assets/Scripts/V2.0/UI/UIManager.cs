using System.Collections.Generic;

namespace V2._0.UI
{
    public class UIManager
    {
        public List<IButtonModel> _models { get; private set; }
        private List<IButtonToMain> _buttonToMains;

        public UIManager(List<IButtonModel> models)
        {
            _buttonToMains = new List<IButtonToMain>();
            _models = models;
            Initialization();
        }


        public UIManager Add(IButtonModel models)
        {
            if (models is IButtonToMain buttonMain)
            {
                _buttonToMains.Add(buttonMain);
            }

            return this;
        }

        public void Initialization()
        {
            foreach (var button in _models)
            {
                this.Add(button);
            }
        }
    }
}