namespace V2._0
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}