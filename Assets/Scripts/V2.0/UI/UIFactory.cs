using System.Collections.Generic;
using UnityEngine;

namespace V2._0.UI
{
    public class UIFactory : Factory, IUserInterfaceFactory
    {
        private List<GameObject> listObject;
        private List<ButtonModel> listModel;
        private GameObject _canvas;
        private UIController _controller;

        public List<GameObject> CreateUI()
        {
            listObject = _uiDescription.ButtonDescription.GetListView();
            listModel = _uiDescription.ButtonDescription.GetModels;
            _canvas = _uiDescription.GetCanvas().Result; 
            List<GameObject> buttonList = new List<GameObject>(listObject.Capacity - 1);
            for(int i = 0; i < listObject.Capacity; i++)
            {
                buttonList[i] = CreateWithPrefab(listObject[i], listModel[i].position);
                buttonList[i].transform.SetParent(_canvas.transform);
                listModel[i].SetButton(buttonList[i]);
            }

            _controller = new UIController(listModel);
            
            return null;
        }
    }
}