using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKR.Interfaces;

namespace FFRKR.Repository {
    public class HeroRepository : IHeroRepository {
        public void AddNewHero(IHero hero) {
            throw new NotImplementedException();
        }

        public IDictionary<string, int> GetAbilitiesByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetAllHeroes() {
            throw new NotImplementedException();
        }

        public string GetAppearanceByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetEquipmentByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetHeroesByAbility(string ability) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetHeroesByEquipment(string equipment) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetHeroesByEvent(IEvent _event) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetHeroesByRealm(string realm) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetHeroesByStat(string stat) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetHeroesFromDungeons() {
            throw new NotImplementedException();
        }

        public IMemoryCrystal GetMC1ByName(string name) {
            throw new NotImplementedException();
        }

        public IMemoryCrystal GetMC2ByName(string name) {
            throw new NotImplementedException();
        }

        public string GetRealmByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<IRecordMateria> GetRecordMateriaByName(string name) {
            throw new NotImplementedException();
        }

        public IDictionary<string, int> GetStatsByName(string name) {
            throw new NotImplementedException();
        }

        public IEnumerable<IRelic> GetUniqueRelicsByName(string name) {
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
        // ~HeroRepository() {
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
        #endregion



    }
}
