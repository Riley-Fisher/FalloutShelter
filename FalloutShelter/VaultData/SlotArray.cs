using System.Collections.Generic;
using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class SlotArray {
        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Objective objective { get; set; }

        public int incLevel { get; set; }
        public List<bool> lottery { get; set; }
    }
}