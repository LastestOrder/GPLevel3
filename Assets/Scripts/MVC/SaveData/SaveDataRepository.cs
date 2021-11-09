using System.IO;
using UnityEngine;

namespace FirstGame
{
    public sealed class SaveDataRepository
    {
        private readonly IData<SaveData> _data;

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
                _data = new XMLData();
            }

            _path = Path.Combine(Application.dataPath, _folderName);
        }

        public void Save(PlayerData player)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }

            var savePlayer = new SaveData
            {
                Position = player.ExtractPosition(),
                Name = "Roman",
                IsEnabled = true
            };
            
            _data.Save(savePlayer, Path.Combine(_path, _fileName));
        }

        public void Load(PlayerData player)
        {
            var file = Path.Combine(_path, _fileName);
            if(!File.Exists(file)) return;
            var newPlayer = _data.Load(file);
            player.LoadPosition(newPlayer.Position);
            player.name = newPlayer.Name;
            //player.gameObject.SetActive(newPlayer.IsEnabled);
            
            Debug.Log(newPlayer);
        }
    }
}