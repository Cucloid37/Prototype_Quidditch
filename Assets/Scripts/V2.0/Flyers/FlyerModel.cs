using System;
using UnityEngine;

namespace V2._0
{
    public enum MyTeam
    {
        One,
        Two
    }
    
    [Serializable]
    public class FlyerModel : IFlyerModel
    {
        public ActionPoints actionPoints { get; private set; }
        public Force force { get; private set; }
        public Agility agility { get; private set; }
        public MagicForce magicForce { get; private set; }

        public string name { get; private set; }

        public Broom myBroom { get; private set; }
        public MagicWand myWand { get; private set; }
        public MyTeam myTeam { get; private set; }
        
        private Transform _transform;

        public FlyerModel(ActionPoints actionPoints, Force force, Agility agility, MagicForce magicForce)
        {
            this.actionPoints = actionPoints;
            this.force = force;
            this.agility = agility;
            this.magicForce = magicForce;
        }

        public void SetBroom(Broom broom)
        {
            myBroom = broom;
        }
        public void SetWand(MagicWand wand)
        {
            myWand = wand;
        }

        public void SetTransform(Transform transform)
        {
            _transform = transform;
        }
    }
}