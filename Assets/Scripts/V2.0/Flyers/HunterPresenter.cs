namespace V2._0
{
    public sealed class HunterPresenter : Flyer
    {
        public HunterPresenter(FlyerModel model, FlyerView view, Broom broom, MagicWand magicWand) : base(model, view, broom, magicWand)
        {
        }

        public override void Fly()
        {
            throw new System.NotImplementedException();
        }

        public override void BallAction()
        {
            throw new System.NotImplementedException();
        }

        public override void MagicAction()
        {
            throw new System.NotImplementedException();
        }
    }
}