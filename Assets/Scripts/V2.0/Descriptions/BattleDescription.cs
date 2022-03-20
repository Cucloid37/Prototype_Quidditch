using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    [CreateAssetMenu(fileName = "BattleDescription", menuName = "Description/BattleDescription")]
    public class BattleDescription : ScriptableObject
    {
        // У нас есть разделение Spawn / Pool
        // Есть разделение на объекты FromThePeace / InsideTheBattle
        // И, кажется, они совпадают. Риали

        // [SerializeField] private FieldDescription _fieldDescription;
        // [SerializeField] private AssetReference _fieldReference;
        [SerializeField] private ObjectDescription _squareDescription;
                                                                                    //todo один из методов нужно будет убрать
        [SerializeField] private AssetReference _squareReference;
        

        // public FieldDescription GetFieldDescription => _fieldDescription;
        public ObjectDescription GetSquareDescription => _squareDescription;
        
        public async Task<GameObject> GetSquareView(IBattelDescriptioner reference)
        {
            if (reference is ISquare)
            {
                return await Addressables.InstantiateAsync(_squareReference).Task;
            }

            /*if (reference is IField)
            {
                return await Addressables.InstantiateAsync(_fieldReference).Task;
            }*/
            
            return null;

        }
        
        /*public async Task<GameObject> GetFieldView()
        {
            return await Addressables.InstantiateAsync(_fieldReference).Task;
        }*/
    }
}