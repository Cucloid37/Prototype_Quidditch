
    using UnityEngine;
    using UnityEngine.UI;

    internal sealed class UITypeModel : IInitialization, ICleanup
    {
        #region Properties

        private Transform _canvas;
        private readonly UICreateController _controller;
        private readonly Button _keeper;
        private readonly Button _seeker;
        private readonly Button _hunterOne;
        private readonly Button _hunterTwo;
        private readonly Button _hunterThree;
        private readonly Button _beaterOne;
        private readonly Button _beaterTwo;

        /*public Button Keeper => _keeper;

        public Button Seeker => _seeker;

        public Button HunterOne => _hunterOne;

        public Button HunterTwo => _hunterTwo;

        public Button HunterThree => _hunterThree;

        public Button BeaterOne => _beaterOne;

        public Button BeaterTwo => _beaterTwo;*/

        #endregion

        #region ConstIndex

        private const int IndexPanel = 1;
        private const int IndexKeeper = 0;
        private const int IndexSeeker = 1;
        private const int IndexHunterOne = 2;
        private const int IndexHunterTwo = 3;
        private const int IndexHunterThree = 4;
        private const int IndexBeaterOne = 5;
        private const int IndexBeaterTwo = 6;

        #endregion

        public UITypeModel(Transform canvas, UICreateController controller)
        {
            _canvas = canvas;
            _controller = controller;

            _keeper = canvas.GetChild(IndexPanel).transform.GetChild(IndexKeeper).gameObject.GetComponent<Button>();
            _seeker = canvas.GetChild(IndexPanel).transform.GetChild(IndexSeeker).gameObject.GetComponent<Button>();
            _hunterOne = canvas.GetChild(IndexPanel).transform.GetChild(IndexHunterOne).gameObject.GetComponent<Button>();
            _hunterTwo = canvas.GetChild(IndexPanel).transform.GetChild(IndexHunterTwo).gameObject.GetComponent<Button>();
            _hunterThree = canvas.GetChild(IndexPanel).transform.GetChild(IndexHunterThree).gameObject.GetComponent<Button>();
            _beaterOne = canvas.GetChild(IndexPanel).transform.GetChild(IndexBeaterOne).gameObject.GetComponent<Button>();
            _beaterTwo = canvas.GetChild(IndexPanel).transform.GetChild(IndexBeaterTwo).gameObject.GetComponent<Button>();
            
        }

        public void Initialization()
        {
            _keeper.onClick.AddListener(delegate { _controller.SetType(FlyerType.Keeper); });
            _seeker.onClick.AddListener(delegate { _controller.SetType(FlyerType.Seeker); });
            _hunterOne.onClick.AddListener(delegate { _controller.SetType(FlyerType.Hunter); });
            _hunterTwo.onClick.AddListener(delegate { _controller.SetType(FlyerType.Hunter); });
        }

        public void Cleanup()
        {
            _keeper.onClick.RemoveAllListeners();
            _seeker.onClick.RemoveAllListeners();
            _hunterOne.onClick.RemoveAllListeners();
            _hunterTwo.onClick.RemoveAllListeners();
        }
    }