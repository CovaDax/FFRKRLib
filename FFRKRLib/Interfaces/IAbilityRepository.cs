using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKRLib.Interfaces {
    public interface IAbilityRepository : IDisposable {
        IEnumerable<FFRKRLib.Models.Ability> GetAllAbilities();
        IEnumerable<FFRKRLib.Models.Ability> GetAbilitiesBySchool(string school);
        IEnumerable<FFRKRLib.Models.Ability> GetAbilitiesByType(string type);
        IEnumerable<FFRKRLib.Models.Ability> GetAbilitiesByRarity(string rarity);
        void AddNewAbility(FFRKRLib.Models.Ability ability);
        DataTable GetCostByAbilityName(string name);
    }
}
