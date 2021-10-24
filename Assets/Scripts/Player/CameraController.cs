using UnityEngine;

namespace FirstGame
{
    public sealed class CameraController2 : MonoBehaviour
    {
        public Player Player;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - Player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = Player.transform.position + _offset;
        }
    }
}
