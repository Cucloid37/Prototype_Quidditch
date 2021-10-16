    using System.Data;
    using System.IO;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    [CreateAssetMenu(fileName = "UICreateData", menuName = "Data/UICreate")]
    public class UICreateData : ScriptableObject
    {
        [SerializeField] private string _prefabString;
        private GameObject _createCanvas;

        public GameObject CreateCanvas
        {
            get
            {
                if (_createCanvas == null)
                {
                    _createCanvas = Load<GameObject>("Prefabs/UI/" + _prefabString);

                    if (_createCanvas == null)
                    {
                        throw new DataException($"Не загрузили {_createCanvas}");
                    }
                }

                return _createCanvas;
            }
        }

        private static T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }