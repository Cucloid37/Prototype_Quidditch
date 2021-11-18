    using UnityEngine;

    internal sealed class UIFactory
    {
        private GameObject _canvas;
        private readonly IFactory _factory;

        public UIFactory(IFactory factory, GameObject canvas)
        {
            _factory = factory;
            _canvas = canvas;
        }

        public Transform CreateUIObject(GameObject prefab)
        {
            
            var canvas = _factory.CreateFactory(prefab, _canvas.transform.position);
            canvas.transform.SetParent(_canvas.transform);  
            return canvas.transform;
            
        }
        
    }
