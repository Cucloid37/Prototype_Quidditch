namespace V2._0
{
    public sealed class BeaterPresenter : Flyer
    {
        public BeaterPresenter(FlyerModel model, FlyerView view, FlyerType type) : base(model, view, type)
        {
            _model = model;
            _view = view;
        }

        public override void BallAction()
        {
            
        }

        public override void MagicAction()
        {
            
        }
    }
}