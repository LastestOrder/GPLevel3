using UnityEngine;

namespace FirstGame
{
    public sealed class BonusesFactory : IBonusesFactory
    {
        private readonly BonusesData _bonusesData;
        //private readonly EnemyData _data;
        private readonly BonusesPoints _bonusesPoints;

        public BonusesFactory(BonusesData data)
        {
            _bonusesData = data;
        }

        // public IEnemy CreateEnemy(EnemyType type)
        // {
        //     var enemyProvider = _data.GetEnemy(type);
        //     return Object.Instantiate(enemyProvider);
        // }

        // public Transform CreateBonuses(BonusesType type)
        // {
        //     switch (type)
        //     {
        //         case BonusesType.Good: return new GameObject().AddMeshRenderer(_bonusesData._materialGood).transform;
        //         
        //         case BonusesType.Bad: return new GameObject().AddMeshRenderer(_bonusesData._materialBad).transform;
        //             
        //         default: return new GameObject().transform;
        //     }
        // }
        
        
        public IBonuses CreateBonuses(BonusesType type, Vector3 bonusesPoint)
        {
            
            var bonusesProvider = _bonusesData.GetBonuses(type);
           return Object.Instantiate(bonusesProvider, bonusesPoint, Quaternion.identity);
           var points = _bonusesPoints.BonusesSpawnPoints[0];
           //return Object.Instantiate(bonusesProvider, points, Quaternion.identity);
        }
        
        
    }
}