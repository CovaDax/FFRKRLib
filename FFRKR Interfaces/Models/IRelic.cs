using System.Collections.Generic;

namespace FFRKR.Interfaces {
    public interface IRelic {
        string Name { get; }
        string Realm { get; }
        string Type { get; }

        int Rarity { get; }
        int Rank { get; }

        int ATK { get; }
        int MAG { get; }
        int MND { get; }
        int DEF { get; }
        int RES { get; }
        int ACC { get; }

        ISoulbreak Soulbreak { get; }

        string BurstEffect { get; }
        IDictionary<string, int> MasteryBonus { get; }
    }
}