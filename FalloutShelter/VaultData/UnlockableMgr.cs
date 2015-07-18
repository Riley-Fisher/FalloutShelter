using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class UnlockableMgr {
        public List<ObjectivesInProgress> objectivesInProgress { get; set; }
        public List<object> completed { get; set; }
        public List<object> claimed { get; set; }
    }
}