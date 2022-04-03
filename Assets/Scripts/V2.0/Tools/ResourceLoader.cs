using UnityEngine;

namespace V2._0
{
    public static class ResourceLoader
    {
        public static GameObject LoadPrefab(string path)
        {
            return Resources.Load<GameObject>(path);
        }
    }
}