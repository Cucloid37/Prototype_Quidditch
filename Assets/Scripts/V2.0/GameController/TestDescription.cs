using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    [CreateAssetMenu(fileName = "Descriptoin", menuName = "Descriptions")]
    public class TestDescription : ScriptableObject
    {
        [SerializeField] private Flyer _flyer;
        [SerializeField] private AssetReference _testDescription;
    }
}