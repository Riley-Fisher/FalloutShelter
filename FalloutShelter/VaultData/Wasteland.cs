using System.Collections.Generic;
using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class Wasteland {
        [TypeConverter(typeof (ExpandableObjectConverter))]
        public State state { get; set; }

        public List<Team> teams { get; set; }
        public List<Cycle> cycles { get; set; }
        public int allTimeTeamsCounter { get; set; }
    }
}