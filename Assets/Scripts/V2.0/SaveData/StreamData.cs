using System.IO;

namespace SaveData
{
    internal sealed class StreamData : ISaveLoadData<SavedData>
    {
        public void Save(SavedData data, string path = null)
        {
            /*if (path == null) return;
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.flyerObject);
                sw.WriteLine(data.flyerModel.name);
                sw.WriteLine(data.flyerModel.force);
                sw.WriteLine(data.flyerModel.agility);
                sw.WriteLine(data.flyerModel.magicForce);
                sw.WriteLine(data.flyerModel.actionPoints);
                sw.WriteLine(data.isEnabled);
            }*/
        }

        public SavedData Load(string path = null)
        {
            var result = new SavedData();

            /*using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.flyerObject = sr.ReadLine();
                    result.flyerModel.name = sr.ReadLine();
                    result.flyerModel.force = sr.ReadLine().TrySingle();
                    result.flyerModel.agility = sr.ReadLine().TrySingle();
                    result.flyerModel.magicForce = sr.ReadLine().TrySingle();
                    result.flyerModel.actionPoints = sr.ReadLine().TrySingle();
                }
            }*/

            return result;
        }
    }
}