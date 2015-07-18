using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class TaskMgr {
        public int id { get; set; }
        public double time { get; set; }
        public List<Task> tasks { get; set; }
        public List<object> pausedTasks { get; set; }
    }
}