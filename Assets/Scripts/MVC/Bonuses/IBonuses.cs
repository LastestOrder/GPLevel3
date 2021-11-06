using System;

namespace FirstGame
{
    public interface IBonuses : ISpawn
    {
        event Action<int,int> OnTriggerEnterChange;
    }
}