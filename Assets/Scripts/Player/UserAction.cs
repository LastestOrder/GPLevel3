using System;
using System.Collections.Generic;
using UnityEngine;


namespace FirstGame
{
    public enum UserAction : byte
    {
        None = 0,
        Up   = 1,
        Down = 2
    }
    public sealed class ActionDelegateExample
    {
        private readonly Dictionary<UserAction, Action> _actrion;

        public ActionDelegateExample()
        {
            _actrion = new Dictionary<UserAction, Action>
            {
                [UserAction.Up] = UpMethod,
                [UserAction.Down] = DownMethod
            };
        }

        
        public Action this[UserAction index]=> _actrion[index];

        private void UpMethod()
        {
            Debug.Log(nameof(UpMethod));
        }

        private void DownMethod()
        {
            Debug.Log(nameof(DownMethod));
        }
    }
}
