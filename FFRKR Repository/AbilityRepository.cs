using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKRLib.Interfaces;

namespace FFRKRLib.Repositories {
    public class AbilityRepository : IModelRepository {

        #region Private Variables
        private Database _connection;
        #endregion

        public T FindByName<T>(string name) {
            throw new NotImplementedException();
        }

        public T FindColumnByName<T>(string name, string column) {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllByColumn<T>(string column) {
            throw new NotImplementedException();
        }
    }
}
