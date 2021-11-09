using UnityEngine;

namespace FirstGame
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerData _playerData;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }

        public Transform CreatePlayer()
        {
            return new GameObject(_playerData.Name).AddMeshFilter(_playerData.Mesh).AddMeshRenderer(_playerData.Material)
                .AddSphereCollider().AddRigidBody(_playerData.Mass).transform;
            //return new GameObject(_playerData.Name).AddMeshRenderer().AddMeshFilter(_playerData.Mesh);
            //AddMeshRenderer().AddSphereCollider();
        }
    }
}