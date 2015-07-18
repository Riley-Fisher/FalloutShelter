using System.Collections.Generic;
using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class Requirement {
        public string requirementID { get; set; }
        public bool satisfied { get; set; }
        public int rushCount { get; set; }
        public int? higherMergeLevelFound { get; set; }
        public int? currentBabies { get; set; }
        public int? acceptedRoom { get; set; }
        public int? dweller { get; set; }
        public int? currentInvasions { get; set; }
        public int? numberOfObjectivesCompleted { get; set; }
        public int? currentLegendaryDwellers { get; set; }
        public int? currentLegendaryOutfits { get; set; }
        public int? currentLegendaryWeapons { get; set; }
        public double? nukaCount { get; set; }
        public bool? isAchievement { get; set; }
        public int? currentDwellers { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public GainedRes gainedRes { get; set; }

        public List<int?> dwellersIds { get; set; }
        public int? dwellerCount { get; set; }
    }
}