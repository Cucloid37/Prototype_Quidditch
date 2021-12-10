
    namespace SaveData
    {
        public interface ISaveLoadData<T>
        {
            void Save(T data, string path = null);
            T Load(string path = null);
        }
    }
