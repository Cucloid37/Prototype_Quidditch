using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    
    public class Flyer : IFlyer, IContext 
    {
        protected FlyerModel _model;
        protected FlyerView _view;

        public CanMove IsCanMove { get; private set; }
        public FlyerType Type { get; }
        public FlyerTeam Team { get; private set; }
        public Coordinates coordinates { get; private set; }
        public FlyerView View => _view;

        private const float MoveSize = 0.6f;
        
        public Flyer(FlyerModel model, FlyerView view, FlyerType type)
        {
            _model = model;
            _view = view;
            Type = type;
            
            IsCanMove = new CanMove();
            
            // заглушка
            IsCanMove.IsActiveTeam = true;
            IsCanMove.IsActiveFlyer = true;
            //
            
            // IsCanMove.IsSelectedFlyer.SubscribeOnChange(SelectFlyer);
        }

        private void SelectFlyer(bool desklimate)
        {
            
        }
        
        public void SetCanMoveTeam(bool target)
        {
            IsCanMove.IsActiveTeam = target;
        }

        public void SetSelectedFlyer(bool target)
        {
            IsCanMove.IsSelectedFlyer.Value = target;
        }
        
        public void SetTeam(FlyerTeam team)
        {
            Team = team;
        }

        public void SetCoor(Coordinates coor)
        {
            coordinates = coor;
        }

        public Flyer() { }

        
        
        public virtual void Fly(Transform target)
        {
            var position = target.position;
            position.Set(position.x, position.y + MoveSize, position.z);
            _view.transform.position = position;
            SetCoor((Coordinates)position);
            _model.SetTransform(position);
        }

        public virtual void BallAction()
        {
            
        }

        public virtual void MagicAction()
        {
            
        }

    }
}