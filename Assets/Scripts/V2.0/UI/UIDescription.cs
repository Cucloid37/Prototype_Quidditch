using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using V2._0.UI;

namespace V2._0
{
    
    
    [CreateAssetMenu(fileName = "UIDescription", menuName = "Description/UIDescription")]
    public class UIDescription : ScriptableObject
    {
        [SerializeField] private ButtonDescription buttonDescription;

        [SerializeField] private AssetReference _canvasReference;

        public ButtonDescription ButtonDescription => buttonDescription;

        public async Task<GameObject> GetCanvas()
        {
            return await Addressables.InstantiateAsync(_canvasReference).Task;
        }
        
        
    }
}