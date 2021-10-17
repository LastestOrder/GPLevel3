using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FirstGame
{
    public sealed class GoodBonus : InteractiveObject, IFlay, IFlicker, IEquatable<GoodBonus>
    {
        public int Point;
        private Material _material;
        private float _lengthFlay;
        private DisplayBonuses _displayBonuses;
        public float Speed = 0.0f;


        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _displayBonuses = new DisplayBonuses();
        }

        protected override void Interaction()
        {
            Player _player = new Player();
            _player.Speed += 3.0f;
            //Speed += 3.0f;
            _displayBonuses.Display(5);
            Debug.Log(_player.Speed);
        }

        public bool Equals(GoodBonus other) => Point == other.Point;

        #region Interface
        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFlay), transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }
        #endregion

    }
}
