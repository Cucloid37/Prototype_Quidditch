using UnityEngine;
using UnityEngine.AddressableAssets;
using V2._0.UI;

namespace V2._0
{
    [CreateAssetMenu(fileName = "AllDescriptions", menuName = "Descriptions/AllDescriptions")]
    public class Descriptions : ScriptableObject
    {
        [SerializeField] private FlyerDescription flyerDescription;
        [SerializeField] private ObjectDescription squareDescription;
        [SerializeField] private ObjectDescription ringDescription; 
        [SerializeField] private InputKeysData keysData;
        [SerializeField] private ButtonConfig buttonsConfig;
        [SerializeField] private GameObject _canvas;
        
        
        public FlyerDescription GetFlyerDescription => flyerDescription;
        public ObjectDescription SquareDescription => squareDescription;
        public ObjectDescription RingDescription => ringDescription;
        public InputKeysData InputDescription => keysData;
        public ButtonConfig ButtonsConfig => buttonsConfig;
        public GameObject canvas => _canvas;
    }
}