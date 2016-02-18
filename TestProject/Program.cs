using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFRKR.Repository;
using FFRKR.Interfaces;

namespace TestProject {
    class Program {
        static void Main(string[] args) {
            FFRKR.Repository.HeroRepository repo = new FFRKR.Repository.HeroRepository();
            IEnumerable<FFRKR.Core.Models.Hero> heroes = repo.GetAllHeroes();
            string stop = "";
            //new CreateRelicDB();
        }
    }
}
