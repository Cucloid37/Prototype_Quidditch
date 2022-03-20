using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace V2._0.UI
{
    public class ButtonLayerForBattle : MonoBehaviour, IDisposable
    {
        [SerializeField] private Button _button;
        [SerializeField] private int _layerIndex;

        public Button button => _button; 
        public int LayerIndex => _layerIndex;

        public void Init(UnityAction<int> transformToLayer)
        {
            _button.onClick.AddListener(delegate { transformToLayer(_layerIndex); });
        }

        public void Dispose()
        {
            _button.onClick.RemoveAllListeners();
        }
    }
}