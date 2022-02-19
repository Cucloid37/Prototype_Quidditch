using System;
using UnityEngine;

namespace V2._0
{
    public enum FlyerTeam
    {
        One,
        Two
    }

    [Serializable]
    public class FlyerModel : IFlyerModel
    {
        private FlyerView _view;
        private Transform _transform;
        
        public ActionPoints actionPoints { get; private set; }
        public Force force { get; private set; }
        public Agility agility { get; private set; }
        public MagicForce magicForce { get; private set; }

        public string myName { get; private set; }

        public Broom myBroom { get; private set; }
        public MagicWand myWand { get; private set; }
        public FlyerType myType { get; private set; }
        public FlyerTeam myTeam { get; private set; }
        
        

        public FlyerModel(ActionPoints actionPoints, Force force, Agility agility, MagicForce magicForce)
        {
            this.actionPoints = actionPoints;
            this.force = force;
            this.agility = agility;
            this.magicForce = magicForce;
        }

        #region region public void Get/Set : Broom, MagicWand, FlyerType, FlyerTeam, FlyerView, Name

        public void GetView(FlyerView view)
        {
            _view = view;
        }
        
        public void SetBroom(Broom broom)
        {
            myBroom = broom;
        }
        public void SetWand(MagicWand wand)
        {
            myWand = wand;
        }

        public void SetType(FlyerType type)
        {
            myType = type;
        }

        public void SetTeam(FlyerTeam team)
        {
            myTeam = team;
        }

        public void SetName(string name)
        {
            myName = name;
        }

        public void SetTransform(Transform transform)
        {
            _transform = transform;
            _view.SetTransform(_transform);
        }

        #endregion

        
    }
}