using UnityEngine;


    internal sealed class InputInitialization : IInitialization
    {
        private IUserInputProxy _userInputLeft;
        private IUserInputProxy _userInputRight;

        /// <summary>
        /// Инициализируем мышь под устройство
        /// </summary>
        public void Initialization()
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                _userInputLeft = new MobileInput();             // выяснить как передавать управление с мобильного
                _userInputRight = new MobileInput();
                return;
            }

            _userInputLeft = new PCUserInputLeft();
            _userInputRight = new PCUserInputRight();
        }
        
        
        /// <summary>
        /// Передаем две мыши в GetInput
        /// </summary>
        /// <returns></returns>
        public (IUserInputProxy userInputLeft, IUserInputProxy userInputRight) GetInput()
        {
            (IUserInputProxy userInputLeft, IUserInputProxy userInputRight) result = (_userInputLeft, _userInputRight);
            return result;
        }
    }