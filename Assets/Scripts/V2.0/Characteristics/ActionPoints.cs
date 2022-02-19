using System;
using UnityEngine;

namespace V2._0
{
    [Serializable]
    public class ActionPoints : IActionPoints
    {
        [SerializeField] public float actionPoints { get; private set; }

        public void SetAP(float action)
        {
            actionPoints = action;
        }

        
    }
}