using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    internal sealed class FieldFactory

    {
        private readonly IFactory _factory;              // Подходит ли эта фабрика для того, что в Pool? I think - yes, it is.
        private readonly SquareDescription _description;            // todo перевести Data в Description
        private List<GameObject> _squareList;
        private GameObject _square;
        private Vector3 _position;
        
        private const float xMax = 10;
        private const float yMax = 7;
        private const float zMax = 16;
        private const int Size = 1;

        public FieldFactory(SquareDescription description, IFactory factory)
        {
            _description = description;
            _factory = factory;
            _squareList = new List<GameObject>();
        }


        public void CreateField()
        {
            var parent = new GameObject("Field");
            for (int x = 0; x <= xMax; x++)
            {
                for (int y = 0; y <= yMax; y++)
                {
                    for (int z = 0; z <= zMax; z++)
                    {
                        _position.Set(x + Size, y + Size, z + Size);
                        _square = _factory.CreateGameObject(_description.GetView().Result, _position);
                        _square.name = $"{x}, {y}, {z}";
                        _square.transform.SetParent(parent.transform);
                        _squareList.Add(_square);
                    }
                }
            }
        }

    }
}