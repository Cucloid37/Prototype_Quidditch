using System.Collections.Generic;
using UnityEngine;

namespace V2._0
{
    public class RingFactory
    {
        private readonly Transform[] _positionRings;
        private readonly GameObject _prefab;

        private List<GameObject> goRing;
        private List<Ring> rings;

        public RingFactory(Transform[] positions, GameObject prefab)
        {
            _positionRings = positions;
            _prefab = prefab;
            goRing = new List<GameObject>();
            CreateRing();
        }

        public void CreateRing()
        {
            for (int i = 0; i < _positionRings.Length; i++)
            {
                goRing[i] = Object.Instantiate(_prefab, _positionRings[i].position, Quaternion.identity);
                var view = goRing[i].AddComponent<RingView>();
                
                if (i < 3)                                      // а почему бы и нет? ))) Наверное, потому что очень легко по ошибке наруить порядок и псда
                {
                    rings[i] = new Ring(FlyerTeam.One, view);
                }
                else
                {
                    rings[i] = new Ring(FlyerTeam.Two, view);
                }
            }

            
        }
    }
}