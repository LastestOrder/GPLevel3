using UnityEngine;

namespace FirstGame
{
    public sealed class BonusesFactory : IBonusesFactory
    {
        private readonly BonusesData _data;
        //private readonly EnemyData _data;
        private readonly BonusesPoints _points;

        public BonusesFactory(BonusesData data)
        {
            _data = data;
        }

        // public IEnemy CreateEnemy(EnemyType type)
        // {
        //     var enemyProvider = _data.GetEnemy(type);
        //     return Object.Instantiate(enemyProvider);
        // }
        
        public IBonuses CreateBonuses(BonusesType type)
        {
            var bonusesProvider = _data.GetBonuses(type);
           return Object.Instantiate(bonusesProvider);
           var points = _points.BonusesSpawnPoints[0];
           //return Object.Instantiate(bonusesProvider, points, Quaternion.identity);
        }
        
    }
}