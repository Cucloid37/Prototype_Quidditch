using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class RingFactory
    {
        private readonly Transform[] _positionRings;
        private readonly GameObject _prefab;

        private List<GameObject> goRing;
        private List<RingView> rings;

        public RingFactory(Transform[] positions, GameObject prefab)
        {
            _positionRings = positions;
            _prefab = prefab;
            goRing = new List<GameObject>(6);
            rings = new List<RingView>(6);
            CreateRing();
        }

        public void CreateRing()
        {
            for (int i = 0; i < _positionRings.Length; i++)
            {
                var go = Object.Instantiate(_prefab, _positionRings[i].position, Quaternion.identity);
                var view = go.AddComponent<RingView>();
                if(i < 3)
                {
                    view.SetTeam(FlyerTeam.One);
                } else
                {
                    view.SetTeam(FlyerTeam.Two);
                }
                
                goRing.Add(go);
                rings.Add(view);
            }

            
        }
    }
}