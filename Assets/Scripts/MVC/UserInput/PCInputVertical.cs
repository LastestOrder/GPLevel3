﻿using System;
using UnityEngine;

namespace FirstGame
{
    public class PCInputVertical : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate(float f) {  };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisManager.VERTICAL));
        }
        

    }
}