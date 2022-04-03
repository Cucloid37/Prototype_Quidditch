using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace V2._0
{
    public class MainMenuView : MonoBehaviour, IuiView
    {
        [SerializeField] private Button _buttonStart;

        public void Init(UnityAction startGame)
        {
            _buttonStart.onClick.AddListener(startGame);
        }

        protected void OnDestroy()
        {
            _buttonStart.onClick.RemoveAllListeners();
        }
    }
}