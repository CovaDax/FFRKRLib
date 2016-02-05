using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FFRKR.Interfaces;

namespace FFRKR.Interfaces {
    public interface IHeroRepository : IDisposable {
        IEnumerable<IHero> GetAllHeroes();
        IEnumerable<IHero> GetHeroesByStat(string stat);
        IEnumerable<IHero> GetHeroesByRealm(string realm);
        IEnumerable<IHero> GetHeroesByEquipment(string equipment);
        IEnumerable<IHero> GetHeroesByAbility(string ability);
        IEnumerable<IHero> GetHeroesByEvent(IEvent _event);
        IEnumerable<IHero> GetHeroesFromDungeons();

        IEnumerable<IRelic> GetUniqueRelicsByName(string name);
        IEnumerable<IRecordMateria> GetRecordMateriaByName(string name);

        IMemoryCrystal GetMC1ByName(string name);
        IMemoryCrystal GetMC2ByName(string name);

        IEnumerable<string> GetEquipmentByName(string name);
        IDictionary<string, int> GetAbilitiesByName(string name);
        IDictionary<string, int> GetStatsByName(string name);

        string GetRealmByName(string name);
        string GetAppearanceByName(string name);        

        void AddNewHero(IHero hero);
        
    }
}
