using System;
using UnityEngine;

namespace FirstGame
{
    public class EnemyProvider : MonoBehaviour, IEnemy
    {
        public event Action<int> OnTriggerEnterChange;
        [SerializeField] private float _speed;
        [SerializeField] private float _stopDistance;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(Vector3 point)
        {
            if ((transform.localPosition - point).sqrMagnitude >= _stopDistance * _stopDistance)
            {
                var dir = (point - transform.localPosition).normalized;
                _rigidbody.velocity = dir * _speed;
            }
            else
            {
                _rigidbody.velocity = Vector3.zero;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEnterChange?.Invoke(other.gameObject.GetInstanceID());
        }
    }
}