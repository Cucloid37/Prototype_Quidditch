using UnityEngine;

namespace V2._0
{
    [CreateAssetMenu(fileName = "AllDescriptions", menuName = "Descriptions/AllDescriptions")]
    public class Descriptions : ScriptableObject
    {
        [SerializeField] private FlyerDescription flyerDescription;
        [SerializeField] private SquareDescription SquareDescription;
        [SerializeField] private InputKeysData keysData;
        public FlyerDescription GetFlyerDescription => flyerDescription;
        public SquareDescription GetSquareDescription => SquareDescription;
        public InputKeysData InputDescription => keysData;
    }
}