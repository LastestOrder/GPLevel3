using System;

namespace FirstGame
{
    public interface IEnemy : IMove
    {
        event Action<int> OnTriggerEnterChange;
    }
}