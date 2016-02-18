using FFRKR.Interfaces;
using System.Collections.Generic;

namespace FFRKR.Interfaces {
    public interface IMemoryCrystal {
        IEnumerable<IMemoryCrystal> GetAllMemoryCrystals();
        IEnumerable<IMemoryCrystal> GetMemoryCrystalsByHero(string heroName);
    }
}