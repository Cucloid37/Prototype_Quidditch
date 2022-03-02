using System;
using UnityEngine;

namespace V2._0
{
    public class FlyerView : MonoBehaviour, ICleanup
    {
        private Transform _transform;

        private void Start()
        {
            _transform = gameObject.transform;
        }

        public void Move(Vector3 target, float speed)
        {
            // todo вспомнить Translate или как там его
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