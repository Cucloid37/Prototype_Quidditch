namespace V2._0
{
    public sealed class PeaceInitialization
    {
        // сюда передаются фабрики
        private readonly IUserInterfaceFactory _factory; 

        public PeaceInitialization(IUserInterfaceFactory factory)
        {
            _factory = factory;
        }
        
        
    }
}