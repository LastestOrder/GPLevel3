namespace FirstGame
{
    public interface IBonusesFactory
    {
        IBonuses CreateBonuses(BonusesType type);
    }
}