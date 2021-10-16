    using System.Collections.Generic;

    internal sealed class UIController : IUIcontroller
    {
        private readonly Data _data;
        private readonly UIFactory _factory;
        private List<IFlyer> _listTeam;

        private const int CapacityList = 6;
        public UIController(Data data, UIFactory factory)
        {
            _data = data;
            _factory = factory;
        }
        
        public void CreateTeam()
        {
            _listTeam = new List<IFlyer>(CapacityList);

            var controller = new UICreateController(_data, _listTeam);
            var canvas = _factory.CreateUIObject(_data.UICreate.CreateCanvas);
            var createUI = new UICreateModel(canvas, controller);
            var typeUI = new UITypeModel(canvas, controller);
            createUI.Initialization();
            typeUI.Initialization();
            controller.Initialization(createUI);
        }


    }
