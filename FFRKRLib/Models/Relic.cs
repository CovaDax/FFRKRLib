using System.Collections.Generic;
using FFRKR.Interfaces;

namespace FFRKR.Core.Models {
    public class Relic : IRelic {

        #region Private Variables
        private string _name;
        private string _realm;
        private string _type;

        private int _rarity, _rank;
        private int _atk, _mag, _mnd, _def, _res, _acc;
        private ISoulbreak _soulbreak;
        private string _burstEffect;
        private Dictionary<string, int> _masteryBonus;

        private RelicRepository _repo;
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Realm
        {
            get
            {
                return _realm;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
        }

        public int Rarity
        {
            get
            {
                return _rarity;
            }
        }

        public int Rank
        {
            get
            {
                return _rank;
            }
        }


        public string BurstEffect
        {
            get
            {
                return _burstEffect;
            }
        }

        public IDictionary<string, int> MasteryBonus
        {
            get
            {
                return _masteryBonus;
            }
        }

        public int ATK
        {
            get
            {
                return _atk;
            }
        }

        public int MAG
        {
            get
            {
                return _mag;
            }
        }

        public int MND
        {
            get
            {
                return _mnd;
            }
        }

        public int DEF
        {
            get
            {
                return _def;
            }
        }

        public int RES
        {
            get
            {
                return _res;
            }
        }

        public int ACC
        {
            get
            {
                return _acc;
            }
        }

        public ISoulbreak Soulbreak
        {
            get
            {
                return _soulbreak;
            }
        }

        #endregion

        public Relic(string name) {
            _name = name;
            _repo = new RelicRepository();
            Initialize();
        }

        public void Initialize() {
            
        }
    }
}
