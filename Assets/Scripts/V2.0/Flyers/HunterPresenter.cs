using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    public sealed class HunterPresenter : Flyer
    {
        public HunterPresenter(FlyerModel model, FlyerView view, FlyerType type) : base(model, view, type)
        {
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