using System;

namespace V2._0
{
    [Serializable]
    public class ActionPoints : IActionPoints
    {
        public float actionPoints { get; private set; }

        public void SetAP(float action)
        {
            actionPoints = action;
        }

        
    }
}