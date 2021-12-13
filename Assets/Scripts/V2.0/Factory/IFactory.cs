using UnityEngine;

namespace V2._0
{
    public interface IFactory
    {
        GameObject CreateWithPrefab(GameObject prefab, Vector3 position);
    }
}