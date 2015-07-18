using System.Collections.Generic;
using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class Room {
        public bool emergencyDone { get; set; }
        public string type { get; set; }
        public string @class { get; set; }
        public int mergeLevel { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public bool power { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public RoomHealth roomHealth { get; set; }

        public int rushTask { get; set; }
        public int level { get; set; }
        public List<object> dwellers { get; set; }
        public List<object> deadDwellers { get; set; }
        public string currentStateName { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public CurrentState currentState { get; set; }

        public int deserializeID { get; set; }
        public bool broken { get; set; }
        public List<object> children { get; set; }
        public List<object> partners { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Storage storage { get; set; }

        public double? numberOfProductionCycle { get; set; }
        public bool? ExperienceRewardIsDirty { get; set; }
        public bool? newDwellerReady { get; set; }
    }
}