using System;
using UnityEngine;

namespace SaveData
{
    [Serializable]
    public sealed class SavedData
    {
        public GameObject flyerObject;
        // Заменить GameObject на путь к объекту? Как сохранить сам объект? Его позицию? О, боги!....
        public FlyerModelSerializable flyerModel;
        public bool isEnabled;
        public override string ToString() => 
            $"<color=red>Name</color> {flyerModel.name}, <color=green>Object</color> {flyerObject}, <color=yellow>IsVisible</color> {isEnabled}";
    }

    [Serializable]
    public struct FlyerModelSerializable
    {
        public string name;
        public float actionPoints;
        public int force;
        public int agility;
        public int magicForce;

        private FlyerModelSerializable(string name, float actionPoints, int force, int agility, int magicForce)
        {
            this.name = name;
            this.actionPoints = actionPoints;
            this.force = force;
            this.agility = agility;
            this.magicForce = magicForce;
        }

        /*public static implicit operator FlyerModel(FlyerModelSerializable value)
        {
            return new FlyerModel(value.name, value.actionPoints, value.force, value.agility, value.magicForce);
        }

        public static implicit operator FlyerModelSerializable(FlyerModel value)
        {
            return new FlyerModelSerializable(value.Name, value.ActionPoints, value.Force, value.Agility,
                value.MagicForce);
        }*/
    }
}