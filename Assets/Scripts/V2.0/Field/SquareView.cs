using System;
using UnityEngine;

namespace V2._0
{
    public class SquareView : MonoBehaviour
    {
        private Transform _position;

        private Coordinates _myCoordinates;

        public Coordinates ViewCoor => _myCoordinates;

        public Transform GetPosition()
        {
            return _position;
        }

        public Coordinates SetCoordinates(int x, int y, int z)
        {
            _myCoordinates = new Coordinates(x, y, z);
            return _myCoordinates;
        }

        private void OnCollisionEnter(Collision other)
        {
            
        }
    }
}