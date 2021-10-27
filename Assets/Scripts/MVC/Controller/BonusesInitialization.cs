using System.Collections.Generic;

namespace FirstGame
{
    public class BonusesInitialization : IInitialization
    {
        private readonly IBonusesFactory _bonusesFactory;
        //private Spawn _bonus;
        private List<IBonuses> _bonuses;

        public BonusesInitialization(IBonusesFactory bonusesFactory)
        {
            _bonusesFactory = bonusesFactory;
               var bonuses = _bonusesFactory.CreateBonuses(BonusesType.Good);
            _bonuses = new List<IBonuses>
            {
                //bonuses
                //_bonusesFactory.CreateBonuses(BonusesType.Good)
                //_bonusesFactory.CreateBonuses(BonusesType.Bad),
                //_bonusesFactory.CreateBonuses(BonusesType.None)
            };
        }

        public void Initialization()
        {
            
        }

        public IEnumerable<IBonuses> GetBonuses()
        {
            foreach (var bonuses in _bonuses)
            {
                yield return bonuses;
            }
        }
    }
}