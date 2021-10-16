
using System.Data;
using System.IO;
using UnityEngine;

    [CreateAssetMenu(fileName = "UIStart", menuName = "Data/UI/Start")]
    public class UIStartData : ScriptableObject
    {
        [SerializeField] private string _prefabString;
        private GameObject _canvas;
        
        public GameObject CreateCanvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Load<GameObject>("Prefabs/UI/" + _prefabString);

                    if (_canvas == null)
                    {
                        throw new DataException($"Не загрузили {_canvas}");
                    }
                }

                return _canvas;
            }
        }

        private static T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }