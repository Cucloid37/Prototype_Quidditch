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
        
        [SerializeField] private AssetReference prefabHunter;
        [SerializeField] private AssetReference prefabSeeker;
        [SerializeField] private AssetReference prefabBeater;
        [SerializeField] private AssetReference prefabKeeper;

        #region public properties

        public AssetReference PrefabHunter => prefabHunter;

        public AssetReference PrefabSeeker => prefabSeeker;

        public AssetReference PrefabBeater => prefabBeater;

        public AssetReference PrefabKeeper => prefabKeeper;        

        #endregion
        
        
        //todo перевести в интерфейс GetModel
        public FlyerModel GetModel => new FlyerModel(this.actionPoints, this.force, this.agility, this.magicForce);

        public async Task<GameObject> GetView(AssetReference viewReference)
        {
            return await Addressables.LoadAssetAsync<GameObject>(viewReference).Task;
        }
        
    }
}