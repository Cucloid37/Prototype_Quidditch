
    public class InputController : IExecute
    {
        private readonly IUserInputProxy _mouseRight;
        private readonly IUserInputProxy _mouseLeft;


        public InputController((IUserInputProxy imputRight, IUserInputProxy inputLeft) input)
        {
            _mouseRight = input.imputRight;
            _mouseLeft = input.inputLeft;
            
        }

        public void Execute(float deltaTime)
        {
            _mouseRight.GetAxis();
            _mouseLeft.GetAxis();
        }
    }
