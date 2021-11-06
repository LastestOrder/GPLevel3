using System.Collections.Generic;
using UnityEngine;

namespace FirstGame
{
    public class Spawn : ISpawn
    {
        private List<ISpawn> _spawns = new List<ISpawn>();

        public void AddUnit(ISpawn unit)
        {
            _spawns.Add(unit);
        }

        public void RemoveUnit(ISpawn unit)
        {
            _spawns.Remove(unit);
        }

        public void SpawnPoint(Vector3 point)
        {
            for (int i = 0; i < _spawns.Count; i++)
            {
                _spawns[i].SpawnPoint(point);
            }
        }
        
    }
}