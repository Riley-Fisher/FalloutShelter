using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class ObjectiveMgr {
        public int taskID { get; set; }
        public bool canDiscard { get; set; }
        public List<List<string>> shuffleBags { get; set; }
        public List<SlotArray> slotArray { get; set; }
    }
}