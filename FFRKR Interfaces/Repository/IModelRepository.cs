using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKR.Interfaces {
    public interface IModelRepository {
        IEnumerable<T> GetAll<T>();
        IEnumerable<T> GetAllByColumn<T>(string column);
        T FindByName<T>(string name);
        T FindColumnByName<T>(string name, string column);
    }
}
