using System;
using UnityEngine;

namespace V2._0
{
    public class SquareView : MonoBehaviour, ICleanup
    {
        private Transform _position;
        private Collider _colider;

        private Coordinates _myCoordinates;
        private Renderer _render;

        public Coordinates ViewCoor => _myCoordinates;
        public Transform Position => _position;

        private void Start()
        {
            if (_position == null)
            {
                _position = gameObject.GetComponent<Transform>();
            }
            
        }

        public Transform GetPosition()
        {
            return _position;
        }

        public void SetColor(Color color)
        {
            _render = gameObject.GetComponentInChildren<Renderer>();
            _render.material.color = color;
            Debug.LogWarning(_render.material.color);
        }

        public void SetCoordinates(int x, int y, int z)
        {
            _myCoordinates = new Coordinates(x, y, z);
            _position = gameObject.GetComponent<Transform>();
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