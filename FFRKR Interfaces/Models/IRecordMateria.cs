using FFRKR.Interfaces;

namespace FFRKR.Interfaces {
    public interface IRecordMateria {
        string Name { get; }
        string UnlockCriteria { get; }
        int MaxLevel { get; }
        IHero Hero { get; }
    }
}