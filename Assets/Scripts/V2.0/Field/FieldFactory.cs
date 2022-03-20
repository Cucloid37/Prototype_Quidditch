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

        //todo вынести в статический класс
        private const float xMax = 11;
        private const float yMax = 8;
        private const float zMax = 17;
        private const int Size = 2;
        private const int SizeY = 10;

        public void InitFactory(GameObject prefab)
        {
            prefabSquare = prefab;
            _viewList = new List<SquareView>();
            _modelList = new List<SquareModel>();
            _position = new Vector3();
        }
   
        public FieldPresenter CreateField()
        {
           //todo вероятно, следует сделать так, чтобы каждая клетка поля знала, кто её соседи? Или, во всяком случае,
           //знала направления движения (прямо, наискосок, верх-вниз...). Хотя логичнее звучит, если это знает не клетка
            
            var parent = new GameObject("Field");
            
            for (int x = 0; x < xMax; x++)
            {
                for (int y = 0; y < yMax; y++)
                {
                    for (int z = 0; z < zMax; z++)
                    {
                        _position.Set(x + Size, y*10 + Size, z + Size);
                        GameObject _square = CreateWithPosition(prefabSquare, _position);
                        SquareView view = _square.GetComponentInChildren<BoxCollider>().gameObject.AddComponent<SquareView>();
                        _square.name = $"{x}, {y}, {z} :: index {_count}";
                        _square.transform.SetParent(parent.transform);
                        view.SetCoordinates(x, y, z);
                        _modelList.Add(new SquareModel(view));
                        _viewList.Add(view);
                        view.gameObject.SetActive(true);
                        _count++;
                        if (_count % 2 == 0)
                        {
                            view.SetColor(Color.cyan);
                        }
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