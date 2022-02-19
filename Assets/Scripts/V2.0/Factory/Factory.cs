using System;
using System.Threading.Tasks;
using UnityEngine;

namespace V2._0
{
    public class Factory : MonoBehaviour, IFactory
    {
        private int count = 0;

        public virtual GameObject CreateWithGo(GameObject peacetimeDataTask)
        {
            var x = Instantiate(peacetimeDataTask);
            x.name = count.ToString();
            count++;
            return x;
        }
        
        public virtual GameObject CreateWithPosition(GameObject prefab, Vector3 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }
}