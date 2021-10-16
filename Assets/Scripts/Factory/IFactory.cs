using UnityEngine;

    public interface IFactory
    {
        GameObject CreateFactory(GameObject prefab, Vector3 position);
    }