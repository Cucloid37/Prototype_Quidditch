using UnityEngine;

namespace V2._0
{
    public class TeamController : BaseController
    {
        private readonly FlyerUIView _view;
        public TeamController(Transform canvas)
        {
            _view = UIFactory<FlyerUIView>.LoadUI(PathUI.PathFlyerUI, canvas);
            AddGameObjects(_view.gameObject);
        }
    }
}