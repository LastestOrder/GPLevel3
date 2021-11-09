using System;
using System.Collections.Generic;
using UnityEngine;

namespace FirstGame
{
    internal sealed class BonusesController: IInitialization, ICleanup
    {
        private readonly IEnumerable<IBonuses> _getBonuses;
        private readonly int _playerID;
        private readonly BonusesType _bonusesType;
        private int _point = 2;
        private DisplayBonuses _displayBonuses;

        public BonusesController(IEnumerable<IBonuses> getBonuses, int playerID)
        {
            _getBonuses = getBonuses;
            _playerID = playerID;
        }

        public void Initialization()
        {
            foreach (var bonuses in _getBonuses)
            {
                bonuses.OnTriggerEnterChange += BonusesOnOnTriggerEnterChange;
            }
        }

        private void BonusesOnOnTriggerEnterChange(int value, int bonuses)
        {
            
            switch (_bonusesType)
            {
                case BonusesType.Good: _displayBonuses.Display(_point);
                    break;
                case BonusesType.Bad: _displayBonuses.Display(-_point);
                    break;
                case BonusesType.None:
                    _displayBonuses.Display(0);
                    break;
            }
            
            if (value == _playerID)
            {
                Debug.Log(22);
            }
        }
        public void Cleanup()
        {
            foreach (var bonuses in _getBonuses)
            {
                bonuses.OnTriggerEnterChange -= BonusesOnOnTriggerEnterChange;
            }
        }
    }
}