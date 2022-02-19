using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{

    [CreateAssetMenu(fileName = "FielDescription", menuName = "Description/Field")]
    [Serializable]
    public class FieldDescription : ScriptableObject
    {
        [SerializeField] private AssetReference _prefabReference;

        public async Task<GameObject> GetSquareView()
        {
            return await Addressables.InstantiateAsync(_prefabReference).Task;
        }
        
    }
}