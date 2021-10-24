using UnityEditor.SceneManagement;
using UnityEngine;

namespace FirstGame
{
    public static partial class BuilderExtension
    {

        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddRigidBody(this GameObject gameObject, float mass)
        {
            var component = gameObject.GetOrAddComponent<Rigidbody>();
            component.mass = mass;
            return gameObject;
        }

        public static GameObject AddBoxCollider(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<BoxCollider>();
            return gameObject;
        }

        public static GameObject AddSphereCollider(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<SphereCollider>();
            return gameObject;
        }

        public static GameObject AddMeshFilter(this GameObject gameObject, Mesh mesh)
        {
            var component = gameObject.GetOrAddComponent<MeshFilter>();
            component.mesh = mesh;
            return gameObject;
        }

        // public static GameObject AddMaterial(this GameObject gameObject, Material material)
        // {
        //     var component = gameObject.GetOrAddComponent<>().mate;
        //     component.mater
        //     return gameObject;
        // }

        // public static GameObject AddMesh(this GameObject gameObject, Mesh mesh)
        // {
        //     var component = gameObject.GetOrAddComponent<Mesh>();
        //     component.Mes
        //     return gameObject;
        // }

        public static GameObject AddMeshRenderer(this GameObject gameObject, Material material)
        {
            var component = gameObject.GetOrAddComponent<MeshRenderer>();
            component.sharedMaterial = material;
            return gameObject;
        }

    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }

            return result;
        }
    }
}