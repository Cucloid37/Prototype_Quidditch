using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    
    public class Flyer : IFlyer 
    {
        protected FlyerModel _model;
        protected FlyerView _view;

        public ICanMove IsCanMove { get; private set; }
        public FlyerType Type { get; }
        public FlyerTeam Team { get; private set; }
        public Coordinates coordinates { get; private set; }


        public void SetCanMoveTeam(bool target)
        {
            IsCanMove.IsActiveTeam = target;
        }

        public void SetSelectedFlyer(bool target)
        {
            IsCanMove.IsSelectedFlyer = target;
        }
        
        public void SetTeam(FlyerTeam team)
        {
            Team = team;
        }

        public void SetCoor(Coordinates coor)
        {
            coordinates = coor;
            _model.SetTransform((Vector3)coordinates);
        }

        public Flyer(FlyerModel model, FlyerView view, FlyerType type)
        {
            _model = model;
            _view = view;
            Type = type;
        }
        
        public Flyer() { }

        
        
        public virtual void Fly(Transform target)
        {
            _view.transform.position = target.position;
        }

        public virtual void BallAction()
        {
            
        }

        public virtual void MagicAction()
        {
            
        }

    }
}