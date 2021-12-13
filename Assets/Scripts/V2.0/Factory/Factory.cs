using System;
using System.Threading.Tasks;
using UnityEngine;

namespace V2._0
{
    public class Factory : MonoBehaviour, IFactory
    {
        protected PeaceDescriptions _peaceDescriptions;
        protected UIDescription _uiDescription;
        protected BattleDescription _battleDescription;

        public void SetDescription(PeaceDescriptions peaceDescriptions, UIDescription uiDescription, BattleDescription battleDescription)
        {
            _peaceDescriptions = peaceDescriptions;
            _battleDescription = battleDescription;
            _uiDescription = uiDescription;
        }

        public virtual GameObject CreateWithTask(Task<GameObject> peacetimeDataTask)
        {
            return Instantiate(peacetimeDataTask.Result);
        }
        
        public virtual GameObject CreateWithPrefab(GameObject prefab, Vector3 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }
}