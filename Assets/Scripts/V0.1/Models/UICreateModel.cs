    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;
    internal sealed class UICreateModel : IInitialization, ICleanup
    {
        private UICreateController _controller;
        private Transform _canvas;
        private UICreateData _data;
        private TMP_InputField _inputName;
        private Button _forceMinus;
        private Button _forcePlus;
        private Text _forceCount;
        private Button _agilityMinus;
        private Button _agilityPlus;
        private Text _agilityCount;
        private Button _magicMinus;
        private Button _magicPlus;
        private Text _magicCount;
        private Text _cpCount;
        private Text _apCount;
        private Button _createButton;

        public TMP_InputField InputName => _inputName;

        public Text ForceCount => _forceCount;

        public Text AgilityCount => _agilityCount;

        public Text MagicCount => _magicCount;

        public Text CpCount => _cpCount;

        public Text APCount => _apCount;

        #region ConstIndex

        private const int IndexCreatePanel = 2;
        private const int IndexCreateButton = 1;
        private const int IndexNamePanel = 2;
        private const int IndexForcePanel = 3;
        private const int IndexAgilityPanel = 4;
        private const int IndexMagicPanel = 5;
        private const int IndexCpPanel = 6;
        private const int IndexApPanel = 7;

        #endregion
        
        public UICreateModel(Transform canvas, UICreateController controller)
        {
            _canvas = canvas;
            _controller = controller;
            
            _inputName = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexNamePanel).transform.GetChild(1)
                .gameObject.GetComponent<TMP_InputField>();
            _createButton = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexCreateButton).transform.GetChild(0)
                .gameObject.GetComponent<Button>();
            _forceMinus = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexForcePanel).transform.GetChild(1)
                .transform.GetChild(0).gameObject.GetComponent<Button>();
            _forcePlus = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexForcePanel).transform.GetChild(1)
                .transform.GetChild(1).gameObject.GetComponent<Button>();
            _forceCount = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexForcePanel).transform.GetChild(1)
                .transform.GetChild(2).gameObject.GetComponent<Text>();
            _agilityMinus = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexAgilityPanel).transform.GetChild(1)
                .transform.GetChild(0).gameObject.GetComponent<Button>();
            _agilityPlus = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexAgilityPanel).transform.GetChild(1)
                .transform.GetChild(1).gameObject.GetComponent<Button>();
            _agilityCount = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexAgilityPanel).transform.GetChild(1)
                .transform.GetChild(2).gameObject.GetComponent<Text>();
            _magicMinus = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexMagicPanel).transform.GetChild(1)
                .transform.GetChild(0).gameObject.GetComponent<Button>();
            _magicPlus = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexMagicPanel).transform.GetChild(1)
                .transform.GetChild(1).gameObject.GetComponent<Button>();
            _magicCount = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexMagicPanel).transform.GetChild(1)
                .transform.GetChild(2).gameObject.GetComponent<Text>();
            _cpCount = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexCpPanel).transform.GetChild(1)
                .gameObject.GetComponent<Text>();
            _apCount = _cpCount = _canvas.GetChild(IndexCreatePanel).transform.GetChild(IndexApPanel).transform.GetChild(1)
                .gameObject.GetComponent<Text>();

        }

        public void Initialization()
        {
            _forceMinus.onClick.AddListener(delegate { _controller.MinusCount(_forceCount); } );
            _forcePlus.onClick.AddListener(delegate { _controller.PlusCount(_forceCount); });
            _agilityMinus.onClick.AddListener(delegate { _controller.MinusCount(_agilityCount); } );
            _agilityPlus.onClick.AddListener(delegate { _controller.PlusCount(_agilityCount); });
            _magicMinus.onClick.AddListener(delegate { _controller.MinusCount(_magicCount); });
            _magicPlus.onClick.AddListener(delegate { _controller.PlusCount(_magicCount); });
            _createButton.onClick.AddListener(_controller.CreateFlyer);
        }

        public void Cleanup()
        {
            _forceMinus.onClick.RemoveAllListeners();
            _forcePlus.onClick.RemoveAllListeners();
            _agilityMinus.onClick.RemoveAllListeners();
            _agilityPlus.onClick.RemoveAllListeners();
            _magicMinus.onClick.RemoveAllListeners();
            _magicPlus.onClick.RemoveAllListeners();
            _createButton.onClick.RemoveAllListeners();
        }
    }
