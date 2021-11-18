using UnityEngine;

    public class Factory : MonoBehaviour, IFactoryInst
    {
        public GameObject CreateFactory(GameObject prefab, Vector3 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }