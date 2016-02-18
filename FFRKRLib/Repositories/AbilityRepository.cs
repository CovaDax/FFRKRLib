using System;
using System.Collections.Generic;
using System.Data;
using FFRKR.Interfaces;
using FFRKR.Repository;
using FFRKR.Core.Models;

namespace FFRKR.Repository {
    public class AbilityRepository : DB, IAbilityRepository<Ability> {
        public void AddNewAbility(Ability IAbility) {
            throw new NotImplementedException();
        }

        public Ability FindAbilityByName(string name) {
            throw new NotImplementedException();
        }

        public string FindEffectByName(string name) {
            throw new NotImplementedException();
        }

        public double FindMulitplierByName(string name) {
            throw new NotImplementedException();
        }

        public int FindRarityByName(string name) {
            throw new NotImplementedException();
        }

        public string FindSchoolByName(string name) {
            throw new NotImplementedException();
        }

        public string FindTypeByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<Ability> GetAbilitiesByElement(string element) {
            throw new NotImplementedException();
        }

        public IEnumerable<Ability> GetAbilitiesByRarity(string rarity) {
            throw new NotImplementedException();
        }

        public IEnumerable<Ability> GetAbilitiesBySchool(string school) {
            throw new NotImplementedException();
        }

        public IEnumerable<Ability> GetAbilitiesByType(string type) {
            throw new NotImplementedException();
        }

        public IEnumerable<Ability> GetAllAbilities() {
            throw new NotImplementedException();
        }

        public DataTable GetCostByAbilityName(string name) {
            throw new NotImplementedException();
        }
    }
}
