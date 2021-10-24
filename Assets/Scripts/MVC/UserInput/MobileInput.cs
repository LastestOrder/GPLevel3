using System;
using UnityEngine;

namespace FirstGame
{
    internal sealed class MobileInput : IUserInputProxy
    {
        public event Action<float> AxisOnChange;

        public void GetAxis()
        {
            Debug.Log("Нажали кнопку!");
        }
    }
}