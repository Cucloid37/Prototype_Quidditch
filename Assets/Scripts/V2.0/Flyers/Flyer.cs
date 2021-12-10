using UnityEngine;

namespace V2._0
{
    
    public class Flyer : IFlyer
    {
        protected FlyerModel _model;
        protected FlyerView _view;
        protected Broom _broom;
        protected MagicWand _magicWand;

        public Flyer(FlyerModel model, FlyerView view, Broom broom, MagicWand magicWand)
        {
            _model = model;
            _view = view;
            _broom = broom;
            _magicWand = magicWand;
        }
        
        public Flyer() { }

        public virtual void Fly()
        {
            
        }

        public virtual void BallAction()
        {
            
        }

        public virtual void MagicAction()
        {
            
        }
    }
}