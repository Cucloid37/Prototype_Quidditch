using UnityEngine;
using UnityEngine.UI;

    internal sealed class UIStartModel : IInitialization, ICleanup
    {
        // private Transform _canvas;
        private readonly UIController _controller;
        private readonly Button _createFirstTeam;
        private readonly Button _createSecondTeam;

        private const int IndexPanelFirst = 1;
        private const int IndexPanelSecond = 2;

        public UIStartModel(Transform canvas, UIController controller)
        {
            //_canvas = canvas;
            _controller = controller;
            _createFirstTeam = canvas.GetChild(IndexPanelFirst).gameObject.GetComponent<Button>();
            _createSecondTeam = canvas.GetChild(IndexPanelSecond).gameObject.GetComponent<Button>();
        }

        public void Initialization()
        {
            _createFirstTeam.onClick.AddListener(_controller.CreateTeam);
            _createSecondTeam.onClick.AddListener(_controller.CreateTeam);
        }

        public void Cleanup()
        {
            _createFirstTeam.onClick.RemoveAllListeners();
            _createSecondTeam.onClick.RemoveAllListeners();
        }
    }