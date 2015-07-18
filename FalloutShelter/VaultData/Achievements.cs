using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class Achievements {
        public List<ObjectivesInProgress> objectivesInProgress { get; set; }
        public List<string> completed { get; set; }
    }
}