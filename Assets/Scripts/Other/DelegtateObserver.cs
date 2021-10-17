using System;
using UnityEngine;

namespace FirstGame
{

    public sealed class DelegtateObserver
    {
        public delegate void MyDelegate(object o);
        public sealed class Source
        {
            private event MyDelegate _functions;

            public void Add(MyDelegate f)
            {
                _functions += f;
            }

            public void Remove(MyDelegate f)
            {
                _functions -=f;
            }
        }
        public sealed class Observer1 //Наблюдатель 1
        {
            public void Do(object o)
            {
                Debug.Log($"Первый. Принял, что объект {o} побежал");
            }
        }

        public sealed class Observer2 //Наблюдатель 2
        {
            public void Do(object o)
            {
                Debug.Log($"Второй. Принял, что объект {o} побежал");
            }
        }
    }
}
