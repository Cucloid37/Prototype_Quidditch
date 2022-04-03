using System.Collections.Generic;
using UnityEngine;
using V2._0.Predicates;

namespace V2._0
{
    
    public class Flyer : IFlyer, IContext 
    {
        protected FlyerModel _model;
        protected FlyerView _view;

       public FlyerType Type { get; }
        public FlyerTeam Team { get; private set; }
        public Coordinates coordinates { get; private set; }
        public FlyerView View => _view;
        
        public GameObject icon { get; private set; }
        public List<IPredicate> allPredicates { get; private set; }

        private const float MoveSize = 0.6f;



        #region Constructor

        public Flyer(FlyerModel model, FlyerView view, FlyerType type)
        {
            _model = model;
            _view = view;
            Type = type;

            allPredicates = new List<IPredicate>();
            
        }
        public Flyer() { }

        #endregion

        #region Set/Get

        public void SetTeam(FlyerTeam team)
        {
            Team = team;
        }

        public void SetCoor(Coordinates coor)
        {
            coordinates = coor;
        }

        #endregion

      
        public virtual void Fly(Transform target)
        {
            var position = target.position;
            position.Set(position.x, position.y + MoveSize, position.z);
            _view.transform.position = position;
            // SetCoor((Coordinates)position);
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