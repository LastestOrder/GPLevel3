﻿namespace FirstGame
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}