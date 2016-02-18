using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FFRKR.Interfaces;

namespace FFRKR.Interfaces {
    public interface IHeroRepository<T> {
        IEnumerable<T> GetAllHeroes();
        IEnumerable<T> GetHeroesByStat(string stat);
        IEnumerable<T> GetHeroesByRealm(string realm);
        IEnumerable<T> GetHeroesByEquipment(string equipment);
        IEnumerable<T> GetHeroesByAbility(string ability);
        IEnumerable<T> GetHeroesByEvent(IEvent _event);
        IEnumerable<T> GetHeroesFromDungeons();

        IEnumerable<IRelic> GetUniqueRelicsByHeroName(string heroName);
        IEnumerable<IRecordMateria> GetRecordMateriaByHeroName(string heroName);

        IMemoryCrystal GetMC1ByHeroName(string heroName);
        IMemoryCrystal GetMC2ByHeroName(string heroName);

        IEnumerable<string> GetEquipmentByHeroName(string heroName);
        IDictionary<string, int> GetAbilitiesByHeroName(string heroName);
        IDictionary<string, int> GetStatsByHeroName(string heroName);

        string GetRealmByHeroName(string heroName);
        string GetAppearanceByHeroName(string heroName);        

        void AddNewHero(T hero);
        
    }
}
