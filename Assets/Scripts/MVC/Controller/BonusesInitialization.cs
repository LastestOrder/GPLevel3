using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FirstGame
{
    public class BonusesInitialization : IInitialization
    {
        private readonly IBonusesFactory _bonusesFactory;
        private Spawn _bonus;
        private List<IBonuses> _bonuses;
        private List<Vector3> _bonusesPoints;

        public BonusesInitialization(IBonusesFactory bonusesFactory, List<Vector3> bonusesPoints)
        {

            _bonusesPoints = bonusesPoints;
            _bonusesFactory = bonusesFactory;
            _bonus = new Spawn();
               //var bonuses = _bonusesFactory.CreateBonuses(BonusesType.Good);
            _bonuses = new List<IBonuses>
            {
                //bonuses
                _bonusesFactory.CreateBonuses(BonusesType.Good,_bonusesPoints[Random.Range(0,_bonusesPoints.Count)]),
                _bonusesFactory.CreateBonuses(BonusesType.Bad,_bonusesPoints[Random.Range(0,_bonusesPoints.Count)]),
                _bonusesFactory.CreateBonuses(BonusesType.None,_bonusesPoints[Random.Range(0,_bonusesPoints.Count)])
            };
            for (int i = 0; i < _bonuses.Count; i++)
            {
                _bonus.AddUnit(_bonuses[i]);
            }

            
            
        }

        public void Initialization()
        {
            
        }

        public ISpawn GetBonusesSpawn()
        {
            return _bonus;
        }

        public IEnumerable<IBonuses> GetBonuses()
        {
            foreach (var bonuses in _bonuses)
            {
                yield return bonuses;
            }
        }
    }
}