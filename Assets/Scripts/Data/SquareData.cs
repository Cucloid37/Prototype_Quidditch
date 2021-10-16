using System.Data;
using System.IO;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "FieldData", menuName = "Data/Setting")]
public class SquareData : ScriptableObject
{
    [SerializeField] private string _prefabString;
    private GameObject _prefabSquare;

    public GameObject Squar
    {
        get
        {
            if (_prefabSquare == null)
            {
                _prefabSquare = Load<GameObject>("Prefabs/" + _prefabString);
                Debug.Log($"Мы загрузили следующее что-то {_prefabSquare.GetType()}");
                if (_prefabSquare == null)
                {
                    throw new DataException($"{_prefabSquare}");
                }
            }

            return _prefabSquare;
        }
    }
    
    
    private static T Load<T>(string resourcesPath) where T : Object =>
        Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
   
}