
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;

    [CreateAssetMenu(fileName = "FlyerData", menuName = "Data/FlyerData/Prefab")]
    public class FlyerData : ScriptableObject
    {
        [Serializable]
        private struct FlyerInfo
        {
            public FlyerType Type;
            public FlyerControl FlyerPrefab;
        }

        [SerializeField] private List<FlyerInfo> _flyerInfos;

        public FlyerControl GetFlyer(FlyerType type)
        {
            var flyerInfo = _flyerInfos.FirstOrDefault(info => info.Type == type);
            if (flyerInfo.FlyerPrefab == null)
            {
                throw new InvalidOperationException($"Prefabs {type} not found");
            }

            return flyerInfo.FlyerPrefab;
        }
        
    }
