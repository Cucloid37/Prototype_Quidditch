using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    [CreateAssetMenu(fileName = "PeaceTimeDescription", menuName = "Descriptions/Data")]
    public class PeaceDescriptions : ScriptableObject
    {
        [SerializeField] private FlyerDescription flyerDescription;

        public FlyerDescription FlyerDescription => flyerDescription;
        
        
        
    }
}