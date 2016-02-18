using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKR.Interfaces {
    public interface IRepository<T> {
        IEnumerable<T> GetAll();
        
        T FindByColumn(string column, string value);

        void AddNewItem(T model);

    }
}
