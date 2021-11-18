using System.Collections.Generic;
using UnityEngine;
internal sealed class FieldFactory

    {
        private readonly IFactoryInst _factory;
        private readonly SquareData _squareData;
        private List<GameObject> _squareList;
        private GameObject _square;
        private Vector3 _position;
        private const float xMax = 10;
        private const float yMax = 7;
        private const float zMax = 16;
        private const int Size = 1;
        private const int Capacity = 1496;
        
        public FieldFactory (SquareData squareDataData, IFactoryInst factory)
        {
            _squareData = squareDataData;
            _factory = factory;
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
                        _square = _factory.CreateFactory(_squareData.Squar, _position);
                        _square.name = $"{x}, {y}, {z}";
                        _square.transform.SetParent(parent.transform);

                    }
                }
            }
        }
        
    }