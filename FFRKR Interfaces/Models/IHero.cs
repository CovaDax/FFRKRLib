using System.Collections.Generic;

namespace FFRKR.Interfaces {
    public interface IHero {
        string Name { get; }
        string Realm { get; }
        string Appearance { get; }

        int Level { get; }
        int HP { get; }
        int ATK { get; }
        int MAG { get; }
        int MND { get; }
        int DEF { get; }
        int RES { get; }
        int ACC { get; }
        int EVA { get; }
        int TOT { get; }

        IMemoryCrystal MC1 { get; }
        IMemoryCrystal MC2 { get; }

        IEnumerable<string> Equipment { get; }
        IDictionary<string, int> Abilities { get; }
        IEnumerable<IRecordMateria> RecordMateria { get; }
        IEnumerable<IRelic> UniqueRelics { get; }
    }
}