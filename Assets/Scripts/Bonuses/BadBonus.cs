using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FirstGame
{
    public sealed class BadBonus: InteractiveObject, IFlay, IRotation, ICloneable
    {
        private float _lengthPlay;
        private float _speedRotation;

        //public delegate void CaughtPlayerChange(object value);
        //private event CaughtPlayerChange _caughtPlayer;
        //public event CaughtPlayerChange CaughtPlayer
        private event EventHandler<CaughtPlayerEventArgs> _caughtPlayer;
        public event EventHandler<CaughtPlayerEventArgs> CaughtPlayer
        {
            add { _caughtPlayer += value; }
            remove { _caughtPlayer -= value; }
        }

        private void Awake()
        {
            _lengthPlay = Random.Range(1.0f, 5.0f);
            _speedRotation = Random.Range(10f, 50.0f);
        }

        protected override void Interaction()
        {
            _caughtPlayer?.Invoke(this, new CaughtPlayerEventArgs(_color));
        }

        #region Interface 
        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthPlay), transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
        #endregion

        public object Clone()
        {
            var result = Instantiate(gameObject, transform.position, transform.rotation, transform.parent);
            return result;
        }

    }
}
