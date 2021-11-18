using UnityEngine;
using UnityEngine.UI;

    internal sealed class UIStartModel : IInitialization, ICleanup
    {
        // private Transform _canvas;
        private readonly UIController _controller;
        private readonly Button _createFirstTeam;
        private readonly Button _createSecondTeam;
        private readonly Button _start;

        private const int IndexPanelFirst = 1;
        private const int IndexPanelSecond = 2;
        private const int IndexPanelStart = 3;

        public UIStartModel(Transform canvas, UIController controller)
        {
            //_canvas = canvas;
            _controller = controller;
            _createFirstTeam = canvas.GetChild(IndexPanelFirst).gameObject.GetComponent<Button>();
            _createSecondTeam = canvas.GetChild(IndexPanelSecond).gameObject.GetComponent<Button>();
            _start = canvas.GetChild(IndexPanelStart).gameObject.GetComponent<Button>();
        }

        public void Initialization()
        {
            _createFirstTeam.onClick.AddListener(_controller.CreateUITeam);
            _createSecondTeam.onClick.AddListener(_controller.CreateUITeam);
            _start.onClick.AddListener(_controller.StartBattle);
        }

        public void Cleanup()
        {
            _createFirstTeam.onClick.RemoveAllListeners();
            _createSecondTeam.onClick.RemoveAllListeners();
        }
    }