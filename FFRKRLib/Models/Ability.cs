using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKRLib.Models {
    public class Ability {

        #region Private Members
        private string _name;
        private int _rank; //0 means not crafted. 5 means complete.
        private int _level;
        private string _type;
        private string _school;
        private DataTable _cost;
        private bool _maxed;
        private bool _crafted;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int Rank
        {
            get { return _rank; }
        }

        public int Level
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
        #endregion

    }
}
