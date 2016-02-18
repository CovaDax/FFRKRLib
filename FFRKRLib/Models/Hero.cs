using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKR.Core.Models;
using FFRKR.Interfaces;
using FFRKR.Repository;

namespace FFRKR.Core.Models {
    public class Hero : IHero {

        private string _name;
        private string _appearance;
        private string _realm;
        private IMemoryCrystal _mc1, _mc2;
        private int _level, _hp, _atk, _mag, _mnd, _def, _res, _acc, _eva, _spd, _tot;
        private int _maxLevel;
        private IEnumerable<IRecordMateria> _rm;
        private IEnumerable<IRelic> _uniqueRelics;
        private IEnumerable<string> _equipment;
        private IDictionary<string, int> _abilities;
        private HeroRepository _repo;

        #region Properties
        public string Name { get { return this._name; } }
        public string Realm { get { return this._realm; } }
        public int HP { get { return this._hp; } }
        public int ATK { get { return this._atk; } }
        public int MAG { get { return this._mag; } }
        public int MND { get { return this._mnd; } }
        public int DEF { get { return this._def; } }
        public int RES { get { return this._res; } }
        public int ACC { get { return this._acc; } }
        public int EVA { get { return this._eva; } }
        public int SPD { get { return this._spd; } }
        public int TOT { get { return this._tot; } }

        public string Appearance { get { return this._appearance; } }
        public IMemoryCrystal MC1 { get { return this._mc1; } }
        public IMemoryCrystal MC2 { get { return this._mc2; } }
        public int Level { get { return this._level; } }

        public IEnumerable<IRecordMateria> RecordMateria { get { return this._rm; } }
        public IEnumerable<IRelic> UniqueRelics { get { return this._uniqueRelics; } }
        public IDictionary<string, int> Abilities { get { return this._abilities; } }
        public IEnumerable<string> Equipment { get { return this._equipment; } }
        #endregion

        public Hero(string name) {
            _name = name;
            _level = 1;
            _maxLevel = 50;
            _repo = new HeroRepository();
            Initialize();
        }

        public Hero(string name, int level, int maxLevel) {
            _name = name;
            _level = level;
            _maxLevel = maxLevel;
            _repo = new HeroRepository();
            Initialize();
        }

        private void Initialize() {
            _realm = _repo.GetRealmByHeroName(Name);
            _mc1 = _repo.GetMC1ByHeroName(Name);
            _mc2 = _repo.GetMC2ByHeroName(Name);
            _equipment = _repo.GetEquipmentByHeroName(Name);
            _abilities = _repo.GetAbilitiesByHeroName(Name);
            _uniqueRelics = _repo.GetUniqueRelicsByHeroName(Name);
            _rm = _repo.GetRecordMateriaByHeroName(Name);
            _appearance = _repo.GetAppearanceByHeroName(Name);
            setStats();
        }

        private void setStats() {
            IDictionary<string, int> stats = _repo.GetStatsByHeroName(Name);
            _hp = stats["HP"];
            _atk = stats["ATK"];
            _mag = stats["MAG"];
            _mnd = stats["MND"];
            _def = stats["DEF"];
            _res = stats["RES"];
            _spd = stats["SPD"];
            _acc = stats["ACC"];
            _eva = stats["EVA"];
            _tot = stats["TOT"];
        }
    }
}
