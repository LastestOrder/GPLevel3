using UnityEngine;

namespace FirstGame
{
    public sealed class LocationData : MonoBehaviour
    {
        [SerializeField] private Transform _spawnLocation;
        [SerializeField] private PlayerData _playerData;

        //public Vector3 Position => _spawnLocation.position;
        // public LocationData()
        // {
        //     
        //    _playerData.SpawnLocation(_spawnLocation);
        // }

    }
}