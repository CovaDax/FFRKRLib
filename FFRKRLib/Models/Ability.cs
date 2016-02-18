using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKR.Interfaces;
using FFRKR.Repository;

namespace FFRKR.Core.Models {
    public class Ability : IAbility {

        #region Private Members
        private string _name;
        private int _rank; //0 means not crafted. 5 means complete.
        private int _level;
        private string _type;
        private string _school;
        private string _effect;
        private DataTable _cost;
        private double _multiplier;
        private bool _maxed;
        private bool _crafted;
        AbilityRepository _repo;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Rank
        {
            get { return _rank; }
            set {   if (value < 1) value = 1;
                    else if (value > 5) value = 5;
                    _rank = value; }
        }

        public int Rarity
        {
            get { return _level; }
        }

        public string Type
        {
            get { return _type; }
        }

        public string School
        {
            get { return _school; }
        }

        public DataTable Cost
        {
            get { return _cost; }
        }

        public double Multiplier
        {
            get { return _multiplier; }
        }

        public string Effect
        {
            get { return _effect; }
        }
        
        public bool AtMax
        {
            get { return _maxed; }
            set
            {
                if (value == true && _level == 5) _maxed = value;
                else if (value == false && _level < 5) _maxed = value;
            }

        }
        #endregion

        public Ability(string name) {
            _name = name;
            _repo = new Repository.AbilityRepository();
            _cost = _repo.GetCostByAbilityName(Name);
            _level = _repo.FindRarityByName(Name);
            _school = _repo.FindSchoolByName(Name);
            _type = _repo.FindTypeByName(Name);
            _effect = _repo.FindEffectByName(Name);
        }
    }
}
