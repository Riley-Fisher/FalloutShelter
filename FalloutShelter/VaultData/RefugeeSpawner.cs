using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class RefugeeSpawner {
        public int newGameTask { get; set; }
        public int succeed { get; set; }
        public string currentPool { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public CurrentPoolData currentPoolData { get; set; }

        public double globalTimerGPTime { get; set; }
        public bool collectedAllRefugees { get; set; }
    }
}