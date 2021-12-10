using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using V2._0.UI;

namespace V2._0
{
    [CreateAssetMenu(fileName = "UIDescription", menuName = "Description/UIDescription")]
    public class UIDescription : ScriptableObject
    {
        [SerializeField] private AssetReference canvasReference;
        
        [SerializeField] private Dictionary<Button, Action> buttonActions;

        [SerializeField] private IUserInterfaceModel GetModel => new UIModel(buttonActions);        // todo это костыль
        
        public async Task<GameObject> GetCanvasView()
        {
            return await Addressables.InstantiateAsync(canvasReference).Task;
        }
    }
}