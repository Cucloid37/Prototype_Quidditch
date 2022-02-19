using UnityEngine;

namespace V2._0
{
    [CreateAssetMenu(fileName = "InputKey", menuName = "Description/Input")]
    public class InputKeysData : ScriptableObject
    {
        [SerializeField] private KeyCode _forward;
        [SerializeField] private KeyCode _back;
        [SerializeField] private KeyCode _right;
        [SerializeField] private KeyCode _left;

        public KeyCode Forward => _forward;
        public KeyCode Back => _back;
        public KeyCode Right => _right;
        public KeyCode Left => _left;
    }
}