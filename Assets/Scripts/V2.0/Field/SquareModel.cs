using UnityEngine;

namespace V2._0
{
    public class SquareModel
    {
        private SquareView _view;
        public Coordinates MyCoordinates { get; private set; }
        public Vector3 MyPosition { get; private set; }
        public Transform Transform { get; private set; }

        public SquareModel(SquareView view)
        {
            _view = view;
            Transform = _view.transform;
            MyPosition = Transform.position;
            MyCoordinates = _view.ViewCoor;
        }
        
    }
}