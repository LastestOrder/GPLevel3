using System;
using UnityEngine;

namespace FirstGame
{
    public sealed class BonusesProvider : MonoBehaviour, IBonuses
    {
        public event Action<int> OnTriggerEnterChange;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterChange?.Invoke(other.gameObject.GetInstanceID());
        }
    }
}