using System;

namespace FirstGame
{
    public interface IBonuses
    {
        event Action<int> OnTriggerEnterChange;
    }
}