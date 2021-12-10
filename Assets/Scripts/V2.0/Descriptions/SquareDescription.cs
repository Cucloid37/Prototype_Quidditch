using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    [CreateAssetMenu(fileName = "SquareDescription", menuName = "Descriptions/Square")]
    public class SquareDescription : ScriptableObject
    {
        [SerializeField] private AssetReference _reference;

        public async Task<GameObject> GetView()
        {
            return await Addressables.InstantiateAsync(_reference).Task;
        }
        
    }
}