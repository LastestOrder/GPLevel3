using UnityEngine;

namespace FirstGame
{
    public class Player : MonoBehaviour
    {
        public float Speed = 3.0f;
        private Rigidbody _rigidbody;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            //GoodBonus _goodBonus = new GoodBonus();
            //Speed += _goodBonus.Speed;
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            
            _rigidbody.AddForce(movement * Speed);
        }



        //public float speed;
        //private float _speed;
        //public float Speed
        //{
        //    get => _speed;
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            _speed = value;
        //        }
        //    }
        //}
        //public float GetSpeed()
        //{
        //    return _speed;
        //}

        //public float GetSpeed() => _speed;

        //public void SetSpeed(float speed)
        //{
        //    if (speed > 0)
        //        _speed = speed;
        //}
        //public Player()
        //{
        //    speed = 3.0f;
        //}

        //public Player(float speed)
        //{
        //    Speed = speed;
        //}
        //public Player(float speed) : this()
        //{
        //    this.speed = speed;
        //}
    }
}
