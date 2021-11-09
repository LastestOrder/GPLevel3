using System.Collections.Generic;
using UnityEngine;

namespace FirstGame
{
    [CreateAssetMenu(fileName = "BonusesSettings", menuName = "Data/Bonuses/BobusesPoints")]
    public sealed class BonusesPoints : ScriptableObject
    {
        [SerializeField] private GameObject _bonusesPoints;

        public List<Vector3> ExtractBonusesPoints()
        {
            var _vectorListBonusesPoints = new List<Vector3>();

            foreach (Transform child in _bonusesPoints.transform)
            {
                _vectorListBonusesPoints.Add(child.transform.position);
            }

            return _vectorListBonusesPoints;
        }

        public List<Vector3> BonusesSpawnPoints
        {
            get
            {
                return ExtractBonusesPoints();
            }
        }
    }
}


