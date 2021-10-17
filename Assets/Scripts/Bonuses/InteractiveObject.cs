using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FirstGame
{
    public abstract class InteractiveObject: MonoBehaviour, IInteractable, IComparable<InteractiveObject>
    {
        protected Color _color;
        public bool IsInteractable { get; } = true;
        protected abstract void Interaction();
                
        private void Start()
        {
            ((IAction)this).Action();
            ((IInitialization)this).Action();
        }

        void IAction.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }

        void IInitialization.Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }

        //protected abstract void Interaction();
        //public virtual string DisplayFirstWay() => $"I am a {nameof(InteractiveObject)} class method";

        public int CompareTo(InteractiveObject other) => name.CompareTo(other.name);



    }
}
