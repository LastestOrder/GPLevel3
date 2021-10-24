using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FirstGame
{
    [CreateAssetMenu(fileName = "BonusesSettings", menuName = "Data/Bonuses/BobusesSettings")]
    public sealed class BonusesData : ScriptableObject
    {
        [Serializable]
        
        private struct BonusesInfo
        {
            public BonusesType Type;
            public BonusesProvider BonusesPrefab;
        }

        [SerializeField] private List<BonusesInfo> _bonusesInfos;

        public BonusesProvider GetBonuses(BonusesType type)
        {
            var bonusesInfo = _bonusesInfos.FirstOrDefault(info => info.Type == type);
            if (bonusesInfo.BonusesPrefab == null)
            {
                throw new InvalidOperationException($"Bonuses type {type} note found");
            }

            return bonusesInfo.BonusesPrefab;
        }
    }
}