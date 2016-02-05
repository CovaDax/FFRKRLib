using System;
using System.Collections.Generic;
using System.Data;
using FFRKR.Interfaces;

namespace FFRKR.Repository {
    public class AbilityRepository : IAbilityRepository {

        #region Private Variables
        private DB _connection;
        #endregion

        public IAbility FindAbilityByName(string name) {
            throw new NotImplementedException();
        }

        public IAbility FindByName<IAbility>(string name) {
            throw new NotImplementedException();
        }

        public IAbility FindColumnByName<IAbility>(string name, string column) {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAbilitiesByElement(string element) {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAbilitiesByRarity(string rarity) {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAbilitiesBySchool(string school) {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAbilitiesByType(string type) {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAll<IAbility>() {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAllAbilities() {
            throw new NotImplementedException();
        }

        public IEnumerable<IAbility> GetAllByColumn<IAbility>(string column) {
            throw new NotImplementedException();
        }

        public DataTable GetCostByAbilityName(string name) {
            throw new NotImplementedException();
        }

        public void AddNewAbility(IAbility IAbility) {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~AbilityRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose() {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        public string FindTypeByName(string name) {
            throw new NotImplementedException();
        }

        public string FindSchoolByName(string name) {
            throw new NotImplementedException();
        }

        public int FindRarityByName(string name) {
            throw new NotImplementedException();
        }

        public double FindMulitplierByName(string name) {
            throw new NotImplementedException();
        }

        public string FindEffectByName(string name) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
