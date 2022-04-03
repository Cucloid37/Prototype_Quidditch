namespace V2._0
{
    public class UIController : BaseController
    {
        private readonly ProfilePlayer profile;
        private readonly InputController input;
        private readonly MoveManager manager;

        private MoveUIView _view;
        
        
        public UIController(ProfilePlayer profile, InputController input, MoveManager manager)
        {
            this.profile = profile;
            this.input = input;
            this.manager = manager;
            
            manager.SelectedFlyer.SubscribeOnChange(PanelDisplay);
        }

        private void PanelDisplay(IFlyer flyer)
        {
            
        }
    }
}