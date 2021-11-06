using UnityEngine;

namespace FirstGame
{
    public interface IBonusesFactory
    {
        IBonuses CreateBonuses(BonusesType type, Vector3 bonusesPoint);
    }
}