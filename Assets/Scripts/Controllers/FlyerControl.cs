
    using UnityEngine;

    public class FlyerControl : MonoBehaviour, IFlyer
    {
        private FlyerModel _model;

        public void SetModel(string name, float actionPoints, int force, int agility, int magicForce)
        {
            _model = new FlyerModel(name, actionPoints, force, agility, magicForce);
        }

        public void Fly()
        {
            
        }
    }
