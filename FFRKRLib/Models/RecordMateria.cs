using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKR.Interfaces;

namespace FFRKR.Core.Models {
    public class RecordMateria : IRecordMateria {

        #region Private Variables
        private Hero _hero;
        private int _maxLevel;
        private string _name;
        private string _unlockCriteria;

        public IHero Hero
        {
            get
            {
                return _hero;
            }
        }

        public int MaxLevel
        {
            get
            {
                return _maxLevel;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string UnlockCriteria
        {
            get
            {
                return _unlockCriteria;
            }
        }
        #endregion


    }
}
