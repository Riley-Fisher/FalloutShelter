using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class Equipment {
        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Storage storage { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Inventory inventory { get; set; }
    }
}