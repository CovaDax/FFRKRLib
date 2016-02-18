using System;
using System.Collections.Generic;
using System.Data;
using FFRKR.Interfaces;

namespace FFRKR.Core.Models {
    public class RelicRepository : IRelicRepository {
        public void AddNewRelic(IRelic relic) {
            throw new NotImplementedException();
        }

        public IRelic FindRelicByName(string name) {
            throw new NotImplementedException();
        }

        public IRelic FindRelicBySoulbreak(string soulBreak) {
            throw new NotImplementedException();
        }

        public IEnumerable<IHero> GetAllHeroes(IRelic relic) {
            throw new NotImplementedException();
        }

        public IEnumerable<IRelic> GetAllRelics() {
            throw new NotImplementedException();
        }

        public IEnumerable<IRelic> GetAllRelicsByRarity(int rarity) {
            throw new NotImplementedException();
        }

        public IEnumerable<IRelic> GetAllRelicsByType(string type) {
            throw new NotImplementedException();
        }

        public IEnumerable<IRelic> GetAllSharedRelics() {
            throw new NotImplementedException();
        }

        public IEnumerable<IRelic> GetAllUniqueRelics(string heroName) {
            throw new NotImplementedException();
        }
    }
}