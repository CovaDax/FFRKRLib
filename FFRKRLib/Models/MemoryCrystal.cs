using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKR.Core.Models;

namespace FFRKR.Core.Models {
    public class MemoryCrystal {

        private Hero _hero;
        private Event _event;
        private int _levelCap;
        private bool _available;
        

        public Hero Hero { get { return _hero; } }
        public Event EventReward { get { return _event; } }
        public int LevelCap { get { return _levelCap; } }
        public bool Available { get { return _available; } }

        public MemoryCrystal(Hero hero, int levelcap = 50, bool available = false) {
            _hero = hero;
            _levelCap = levelcap;
            _available = available;
        }
    }
}