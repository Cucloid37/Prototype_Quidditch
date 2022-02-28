using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    
    public class Flyer : IFlyer
    {
        protected FlyerModel _model;
        protected FlyerView _view;
        
        //todo инкапсулировать
        public IPredicate[] СanIFly { get; set; }
        
        public FlyerType Type { get; }
        public FlyerTeam Team { get; private set; }
        public Coordinates coordinates { get; private set; }

        public void SetTeam(FlyerTeam team)
        {
            Team = team;
        }

        public void SetCoor(Coordinates coor)
        {
            coordinates = coor;
        }

        public Flyer(FlyerModel model, FlyerView view, FlyerType type)
        {
            _model = model;
            _view = view;
            Type = type;
        }
        
        public Flyer() { }

        public virtual void Fly(IContext target, SquareModel squareTarget)
        {
            foreach (var Is in СanIFly)
            {
                if (!Is.IsReady(target))
                {
                    Debug.LogWarning($"{_model.myName}, {_model.myType} не может лететь");
                    return;
                }

                _model.SetTransform(squareTarget.Transform);
            }
        }

        public virtual void BallAction()
        {
            
        }

        public virtual void MagicAction()
        {
            
        }

    }
}