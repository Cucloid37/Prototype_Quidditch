
    using UnityEngine;

    namespace SaveData
    {
        internal class PlayerPrefsData : ISaveLoadData<SavedData>
        {
            public void Save(SavedData data, string path = null)
            {
                PlayerPrefs.SetString("Name", data.flyerModel.name);
            
                PlayerPrefs.SetFloat("ActionPoints", data.flyerModel.actionPoints);
                PlayerPrefs.SetInt("Force", data.flyerModel.force);
                PlayerPrefs.SetInt("Agility", data.flyerModel.agility);
                PlayerPrefs.SetInt("MagicForce", data.flyerModel.magicForce);
                PlayerPrefs.SetString("Object", data.flyerObject.ToString());
                PlayerPrefs.SetString("IsEnable", data.isEnabled.ToString());
            
                PlayerPrefs.Save();
            }

            public SavedData Load(string path = null)
            {
                var result = new SavedData();

                var key = "Name";
                if (PlayerPrefs.HasKey(key))
                {
                    result.flyerModel.name = PlayerPrefs.GetString(key);
                }

                key = "ActionPoints";
                if (PlayerPrefs.HasKey(key))
                {
                    result.flyerModel.actionPoints = PlayerPrefs.GetFloat(key);
                }

                key = "Force";
                if (PlayerPrefs.HasKey(key))
                {
                    result.flyerModel.force = PlayerPrefs.GetInt(key);
                }

                key = "Agility";
                if (PlayerPrefs.HasKey(key))
                {
                    result.flyerModel.agility = PlayerPrefs.GetInt(key);
                }

                key = "MagicForce";
                if(PlayerPrefs.HasKey(key))
                {
                    result.flyerModel.magicForce = PlayerPrefs.GetInt(key);
                }

                key = "IsEnable";
                if (PlayerPrefs.HasKey(key))
                {
                   // result.isEnabled = PlayerPrefs.GetString(key).TryBool();
                }
                return result;
            }

            public void Clear()
            {
                PlayerPrefs.DeleteAll();
                PlayerPrefs.DeleteKey("IsEnable");
            }
        }
    }
