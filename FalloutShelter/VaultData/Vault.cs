using System.Collections.Generic;
using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class Vault {
        public List<Rock> rocks { get; set; }
        public List<Room> rooms { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Storage storage { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Inventory inventory { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public EmergencyData emergencyData { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public RoomConsumption roomConsumption { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public DwellerWaterConsumption dwellerWaterConsumption { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public DwellerFoodConsumption dwellerFoodConsumption { get; set; }

        public int LunchBoxesCount { get; set; }
        public string VaultName { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Achievements Achievements { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Wasteland wasteland { get; set; }
    }
}