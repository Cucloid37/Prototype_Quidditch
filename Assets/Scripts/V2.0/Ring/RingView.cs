using UnityEngine;

namespace V2._0
{
    public class RingView : MonoBehaviour
    {
        private Transform position;
        private Renderer render;
        private FlyerTeam _team;

        public void SetTeam(FlyerTeam team)
        {
            _team = team;
            position = gameObject.transform;
            render = gameObject.GetComponent<Renderer>();
        }
    }
}