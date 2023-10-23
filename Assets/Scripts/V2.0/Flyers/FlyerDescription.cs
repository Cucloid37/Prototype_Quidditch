using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{

    //todo выделить типы и энамы в отдельный скрипт
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
        [SerializeField] private GameObject icon;
        
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
        public FlyerModel GetModel => new FlyerModel(actionPoints, force, agility, magicForce, icon);

        public async Task<GameObject> GetView(AssetReference viewReference)
        {
            return await Addressables.LoadAssetAsync<GameObject>(viewReference).Task;
        }

        
    }

    namespace V2._0.NewDescription
    {

        [CreateAssetMenu(fileName = "Flyers", menuName = "Descriptions/Flyers")]
        public class FlyersDescription : ScriptableObject
        {
            [SerializeField] private FlyerDescript[] flyers;
            
            public Dictionary<FlyerType, AssetReference> GetFlyerDictionary()
            {
                return flyers.ToDictionary(flyer => flyer.Type, flyer => flyer.Reference);
            }
            
            public async Task<GameObject> GetView(AssetReference viewReference)
            {
                return await Addressables.LoadAssetAsync<GameObject>(viewReference).Task;
            }
        }
        
        [Serializable]
        public class FlyerDescript : Dictionary<FlyerType, AssetReference>
        {
            [SerializeField] private FlyerType type;
            [SerializeField] private AssetReference reference;
            
            [SerializeField] private ActionPoints actionPoints;
            [SerializeField] private Force force;
            [SerializeField] private Agility agility;
            [SerializeField] private MagicForce magicForce;
            [SerializeField] private GameObject icon;

            public FlyerType Type => type;
            public AssetReference Reference => reference;

            public FlyerModel GetModel => new FlyerModel(actionPoints, force, agility, magicForce, icon);
        }

    }
}