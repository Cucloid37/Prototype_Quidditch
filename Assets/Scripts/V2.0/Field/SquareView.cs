using System;
using UnityEngine;

namespace V2._0
{
    public class SquareView : MonoBehaviour, ICleanup
    {
        private Transform _position;
        private Collider _colider;

        private Coordinates _myCoordinates;
        private Color _color;

        public Coordinates ViewCoor => _myCoordinates;

        private void Start()
        {
            _position = gameObject.GetComponent<Transform>();
        }

        public Transform GetPosition()
        {
            return _position;
        }

        public void SetColor(Color color)
        {
            _color = gameObject.GetComponentInChildren<Renderer>().material.color;
            Debug.Log(_color);
            _color = color;
            Debug.LogWarning(_color);
        }

        public Coordinates SetCoordinates(int x, int y, int z)
        {
            _myCoordinates = new Coordinates(x, y, z);
            return _myCoordinates;
        }

        private void OnCollisionEnter(Collision other)
        {
            
        }

        public void Cleanup()
        {
            Destroy(gameObject);
        }
    }
}