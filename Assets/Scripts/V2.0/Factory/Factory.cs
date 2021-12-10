using System;
using System.Threading.Tasks;
using UnityEngine;

namespace V2._0
{
    public class Factory : MonoBehaviour, IFactory
    {
        protected PeaceDescriptions descriptions;

        public void SetDescription(PeaceDescriptions descriptions)
        {
            this.descriptions = descriptions;
        }

        public virtual GameObject Create(Task<GameObject> peacetimeDataTask)
        {
            return Instantiate(peacetimeDataTask.Result);
        }
        
        public GameObject CreateGameObject(GameObject prefab, Vector3 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }
}