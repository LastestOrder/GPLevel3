using System.IO;

namespace FirstGame
{
    public sealed class StreamData : IData<SaveData>
    {
        public void Save(SaveData data, string path = null)
        {
            if (path == null) return;;
            using(var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.Name);
                sw.WriteLine(data.Position.X);
                sw.WriteLine(data.Position.Y);
                sw.WriteLine(data.Position.Z);
                sw.WriteLine(data.IsEnabled);
            }
        }

        public SaveData Load(string path = null)
        {
            var result = new SaveData();

            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.Name = sr.ReadLine();
                    result.Position.X = sr.ReadLine().TrySingle();
                    result.Position.Y = sr.ReadLine().TrySingle();
                    result.Position.Z = sr.ReadLine().TrySingle();
                    result.IsEnabled = sr.ReadLine().TryBool();
                }
            }

            return result;
        }
    }
}