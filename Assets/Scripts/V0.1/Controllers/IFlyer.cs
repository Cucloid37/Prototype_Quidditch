
    using System;

    public interface IFlyer : IFly
    {
        void SetModel(string name, float actionPoints, int force, int agility, int magicForce);
    }
