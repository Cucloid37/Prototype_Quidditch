using UnityEngine;

    public class Factory : MonoBehaviour, IFactory
    {
        public GameObject CreateFactory(GameObject prefab, Vector3 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }