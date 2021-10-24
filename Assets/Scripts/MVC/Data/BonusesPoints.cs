using System.Collections.Generic;
using UnityEngine;

namespace FirstGame
{
    public sealed class BonusesPoints : ScriptableObject
    {
        [SerializeField] private GameObject _bonusesPoints;

        private List<Vector3> ExtractBonusesPoints()
        {
            var _vectorListBonusesPoints = new List<Vector3>();

            foreach (Transform child in _bonusesPoints.transform)
            {
                _vectorListBonusesPoints.Add(child.transform.position);
            }

            return _vectorListBonusesPoints;
        }

        public List<Vector3> _bonusesSpawnPoints
        {
            get
            {
                return ExtractBonusesPoints();
            }
        }
    }
}


