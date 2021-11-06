using System.IO;
using UnityEngine;

namespace FirstGame
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data: ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _enemyDataPath;
        [SerializeField] private string _bonusesDataPath;
        [SerializeField] private string _bonusesPointDataPath;

        private PlayerData _player;
        private EnemyData _enemy;
        private BonusesData _bonuses;
        private BonusesPoints _bonusesPoints;

        public PlayerData Player
        {
            get
            {
                if (_player==null)
                {
                    _player = Load<PlayerData>("Data/" + _playerDataPath);
                }

                return _player;
            }
        }

        public EnemyData Enemy
        {
            get
            {
                if (_enemy == null)
                {
                    _enemy = Load<EnemyData>("Data/" + _enemyDataPath);
                }
                return _enemy;
            }
        }

        public BonusesData Bonuses
        {
            get
            {
                if (_bonuses==null)
                {
                    _bonuses = Load<BonusesData>("Data/" + _bonusesDataPath);
                }
                return _bonuses;
            }
        }

        public BonusesPoints BonusesPoints
        {
            get
            {
                if (_bonusesPoints == null)
                {
                    _bonusesPoints = Load<BonusesPoints>("Data/" + _bonusesPointDataPath);
                }

                return _bonusesPoints;
            }
        }



        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}