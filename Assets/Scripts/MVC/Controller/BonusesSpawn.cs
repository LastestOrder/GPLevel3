using System.Collections.Generic;
using UnityEngine;

namespace FirstGame
{
    public sealed class BonusesSpawn : MonoBehaviour, IInitialization
    {
        private readonly BonusesPoints _bonusesPoints;
        private readonly ISpawn _bonus;

        public BonusesSpawn(ISpawn bonus, BonusesPoints bonusesPoints)
        {
            _bonusesPoints = bonusesPoints;
            _bonus = bonus;

            
        }

        public void Initialization()
        {
            
        }
    }
}