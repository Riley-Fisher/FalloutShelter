using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class DwellerSpawner {
        public List<DwellersWaiting> dwellersWaiting { get; set; }
        public List<object> dwellersOrderNodes { get; set; }
    }
}