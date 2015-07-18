using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class Cycle {
        public string cycleType { get; set; }
        public List<TeamEncounter> teamEncounters { get; set; }
        public List<object> inProgress { get; set; }
        public List<object> pendingCycles { get; set; }
    }
}