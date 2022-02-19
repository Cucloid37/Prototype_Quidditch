using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace V2._0
{
    public sealed class FieldFactory : Factory, ICleanup

    {
        private Descriptions _description;
        private FieldPresenter _presenter;
        private List<SquareView> _viewList;
        private List<SquareModel> _modelList;
        private Vector3 _position;

        private GameObject prefabSquare;
        
        private int _count = 0;

        public GameObject PrefabSquare => prefabSquare;

        private const float xMax = 10;
        private const float yMax = 7;
        private const float zMax = 16;
        private const int Size = 1;

        public FieldFactory()
        {
            _viewList = new List<SquareView>();
            _position = new Vector3();
        }

        private async void Start()
        {
            prefabSquare = await _description.GetSquareDescription.GetView();
            
            _viewList = new List<SquareView>();
            _modelList = new List<SquareModel>();
            _position = new Vector3();
            
            if (prefabSquare != null)
            {
                //todo это можно сделать через SubscriptionProperty
                _presenter = CreateField();
            }
        }

        public void SetDescription(Descriptions description)
        {
            _description = description;
        }
        
        public FieldPresenter GetPresenter()
        {
            return _presenter;
        }
        
        
        public FieldPresenter CreateField()
        {
            if (prefabSquare == null)
            {
                new NullReferenceException("Prefab of Field is null");
            }
            
            var parent = new GameObject("Field");
            
            for (int x = 0; x < zMax; x++)
            {
                for (int y = 0; y < xMax; y++)
                {
                    for (int z = 0; z < yMax; z++)
                    {
                        _position.Set(x + Size, y + Size, z + Size);
                        GameObject _square = CreateWithPosition(prefabSquare, _position);
                        SquareView view = _square.AddComponent<SquareView>();
                        _square.name = $"{x}, {y}, {z}";
                        _square.transform.SetParent(parent.transform);
                        view.SetCoordinates(x, y, z);
                        _modelList.Add(new SquareModel(view));
                        _viewList.Add(view);
                        _count++;
                        Debug.Log($"{_square.GetHashCode()}, {_square.GetInstanceID()}");
                    }
                }
            }

                _presenter = new FieldPresenter(_viewList, _modelList);

                Debug.Log($"Количество клеток поля: {_count}");

                return _presenter;

        }

        public void Cleanup()
        {
            Addressables.ReleaseInstance(prefabSquare);
            Destroy(gameObject);
        }
    }
}