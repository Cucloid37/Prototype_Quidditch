using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0.UI
{
    public enum ButtonType
    {
        Plus,
        Minus,
        Create,
        ChangePage
    }
    
    [CreateAssetMenu(fileName = "ButtonDescription", menuName = "Description/UI/Buttons")]
    public class ButtonDescription : ScriptableObject
    {
        [SerializeField] private List<ButtonModel> _buttonModels;

        public List<ButtonModel> GetModels => _buttonModels;

        public async Task<GameObject> GetView(AssetReference buttonReference)
        {
            return await Addressables.InstantiateAsync(buttonReference).Task;
        }

        public List<GameObject> GetListView()
        {
            List<GameObject> listGameObject = new List<GameObject>(_buttonModels.Capacity - 1);
            for (int i = 0; i < _buttonModels.Capacity; i++)
            {
                listGameObject[i] = GetView(_buttonModels[i].reference).Result;
            }

            return listGameObject;
        }
    }
}