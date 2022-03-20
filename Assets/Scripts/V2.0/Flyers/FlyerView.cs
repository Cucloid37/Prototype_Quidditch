using System;
using UnityEngine;

namespace V2._0
{
    public class FlyerView : MonoBehaviour, ICleanup
    {
        private Transform _transform;
        private Renderer _render;

        private void Start()
        {
            _transform = gameObject.transform;
            _render = gameObject.GetComponentInChildren<Renderer>();
        }

        /*public void Move(Vector3 target, float speed)
        {
            // todo вспомнить Translate или как там его
        }*/

        public void SetColor(Color color)
        {
            if (_render == null)
            {
                _render = gameObject.GetComponentInChildren<Renderer>();
            }

            _render.material.color = color;
        }

        public void SetTransform(Transform transform)
        {
            _transform = transform;
        }

        public void Cleanup()
        {
            Destroy(gameObject);
        }
    }
}