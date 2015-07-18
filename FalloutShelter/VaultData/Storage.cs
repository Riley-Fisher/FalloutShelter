using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class Storage {
        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Resources resources { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Bonus bonus { get; set; }
    }
}