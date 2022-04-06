using UnityEngine;

namespace V2._0
{
    public static class UIFactory<T>
    {
        private static Transform _canvas;

        public static void SetCanvas(Transform canvas)
        {
            _canvas = canvas;
        }
        
        public static T LoadUI(string path, Transform canvas)
        {
            var objView = Object.Instantiate(ResourceLoader.LoadPrefab(path), canvas, false);
            
            return objView.GetComponent<T>();
        }
    }
}