using UnityEditor.SceneManagement;
using UnityEngine;

namespace FirstGame
{
    [CreateAssetMenu(fileName = "UnitSettings", menuName = "Data/Unit/UnitSettings")]
    public sealed class PlayerData: ScriptableObject, IUnit
    {
        
        public Mesh Mesh;
        public Material _material;
        [SerializeField] private string _name;
        [SerializeField, Range(0, 100)] private float _speed;

        [SerializeField] private float _mass;
        //private LocationData _spawnlocation;
        [SerializeField] private GameObject _spawnLocation;
        //private Transform _transform = null;
        

        public float Speed => _speed;
        public string Name => _name;
        public float Mass => _mass;
        public Material Material => _material;

        public Vector3 ExtractPosition()
        {
            var Posiotion = _spawnLocation.transform.position;
            return Posiotion;
        }
        //public Vector3 Position => _spawnlocation.Position;

        // public void SpawnLocation(Transform _spawnLocation)
        // {
        //     this._transform = _spawnLocation;
        // }
        //
        // public Vector3 Position => _transform.transform.position;
//public Vector3 Position => _transform.position;
        //public Vector3 Position => _spawnLocation.transform.position;
    }
}