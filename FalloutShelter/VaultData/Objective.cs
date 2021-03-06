using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class Objective {
        public string objectiveID { get; set; }
        public List<Requirement> requirements { get; set; }
        public bool completed { get; set; }
        public int incrementLevel { get; set; }
    }
}