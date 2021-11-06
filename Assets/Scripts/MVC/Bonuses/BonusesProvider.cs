using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace FirstGame
{
    public sealed class BonusesProvider : MonoBehaviour, IBonuses
    {
       public event Action<int,int> OnTriggerEnterChange;

        private Rigidbody _rigidbody;

        private void Start()
        {
            //_rigidbody = GetComponent<Rigidbody>();
        }

        public void SpawnPoint(Vector3 position)
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterChange?.Invoke(other.gameObject.GetInstanceID(), gameObject.GetInstanceID());
        }
    }
}