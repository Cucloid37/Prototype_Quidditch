using System.Collections.Generic;
using UnityEngine;

namespace V2._0.UI
{
    public class UIFactory : Factory, IUserInterfaceFactory
    {
        private List<GameObject> listObject;
        private List<IButtonModel> listModels;
        private GameObject _canvas;
        private UIController _controller;
        private UIManager _manager;

        public UIManager CreateUI()
        {
            listObject = DescriptManager.UI.ButtonDescription.GetListView();
            listModels = DescriptManager.UI.ButtonDescription.GetModels();
            
            _canvas = _uiDescription.GetCanvas().Result; 
            List<GameObject> buttonList = new List<GameObject>(listObject.Capacity - 1);
            for(int i = 0; i < listObject.Capacity; i++)
            {
                buttonList[i] = CreateWithPrefab(listObject[i], listModels[i].position);
                buttonList[i].transform.SetParent(_canvas.transform);
                listModels[i].SetButton(buttonList[i]);
            }

            _manager = new UIManager(listModels);
           
            
            
            
            return _manager;   
        }
    }
}