using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class Team {
        public double deathTimer { get; set; }
        public List<int> dwellers { get; set; }
        public double expeditionStartTime { get; set; }
        public double realExpeditionStartTime { get; set; }
        public double returnTime { get; set; }
        public double returnedTime { get; set; }
        public double returnTripDuration { get; set; }
        public int teamIndex { get; set; }
        public string status { get; set; }
        public List<string> logs { get; set; }
        public int missedEncounters { get; set; }
        public int introMessages { get; set; }
        public int notificationID { get; set; }
    }
}