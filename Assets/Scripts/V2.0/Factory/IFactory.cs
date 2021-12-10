using UnityEngine;

namespace V2._0
{
    public interface IFactory
    {
        GameObject CreateGameObject(GameObject prefab, Vector3 position);
    }
}