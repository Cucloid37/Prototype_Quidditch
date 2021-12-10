using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    public enum FlyerType
    {
        Hunter,
        Seeker,
        Beater,
        Keeper
    }

    [CreateAssetMenu(fileName = "Flyer", menuName = "Descriptions/Flyer")]
    public sealed class FlyerDescription : ScriptableObject
    {
        [SerializeField] private ActionPoints actionPoints;
        [SerializeField] private Force force;
        [SerializeField] private Agility agility;
        [SerializeField] private MagicForce magicForce;


        private static AssetReference PrefabHunter { get; }       
        private static AssetReference PrefabSeeker { get; }
        private static AssetReference PrefabBeater { get; }
        private static AssetReference PrefabKeeper { get; }

        private Dictionary<FlyerType, AssetReference> _dictAsset = new Dictionary<FlyerType, AssetReference>
        {
            {FlyerType.Hunter, PrefabHunter},
            {FlyerType.Seeker, PrefabSeeker},
            {FlyerType.Beater, PrefabBeater},
            {FlyerType.Keeper, PrefabKeeper}
        };

        public Dictionary<FlyerType, AssetReference> DictAsset => _dictAsset;
        
        
        //todo перевести в интерфейс передачу данных
        public FlyerModel GetModel => new FlyerModel(this.actionPoints, this.force, this.agility, this.magicForce);

        public async Task<GameObject> GetView(AssetReference viewReference)
        {
            return await Addressables.InstantiateAsync(viewReference).Task;
        }
    }
}