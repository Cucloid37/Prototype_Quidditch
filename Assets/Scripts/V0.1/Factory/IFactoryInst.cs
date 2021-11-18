
    using UnityEngine;

    public interface IFactoryInst : IFactory
    {
        GameObject CreateFactory(GameObject prefab, Vector3 position);
    }
