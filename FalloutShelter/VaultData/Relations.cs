using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class Relations {
        public List<object> relations { get; set; }
        public int partner { get; set; }
        public int lastPartner { get; set; }
        public List<int> ascendants { get; set; }
    }
}