using System.Data;
using System.IO;
using UnityEngine;

namespace SaveData
{
    internal class SaveDataRepository : ISaveDataRepository
    {
        private readonly ISaveLoadData<SavedData> _data;

        private const string _folderName = "dataSave";
        private const string _fileName = "data.bat";
        private readonly string _path;

        public SaveDataRepository()
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                _data = new PlayerPrefsData();
            }
            else
            {
                _data = new StreamData();
            }
            _path = Path.Combine(Application.dataPath, _folderName);
        }
        /*public void Save(FlyerModel flayer)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }
            
            _data.Save((FlyerModelSerializable)flayer, Path.Combine(_path, _fileName));         // Разобраться с передачей данных, хы
            Debug.Log("Save");
        }

        public void Load(FlyerModel flayer)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file))
            {
                throw new DataException($"File {file} not found");
            }
            var newPlayer = _data.Load(file);                       // Здесь разобраться с инициализацией загруженных
            // данных
        }*/
    }
}
