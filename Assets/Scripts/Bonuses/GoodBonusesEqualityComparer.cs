using System.Collections.Generic;

namespace FirstGame
{
    public sealed class GoodBonusesEqualityComparer : IEqualityComparer<GoodBonus>
    {
        public bool Equals(GoodBonus x, GoodBonus y) => x.Point == y.Point;

        public int GetHashCode(GoodBonus obj) => obj.Point.GetHashCode();
    }
}
