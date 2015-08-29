using System.ComponentModel;
using System.Drawing;
using FalloutShelter.Converters;
using Newtonsoft.Json;

namespace FalloutShelter.VaultData {
    public class Dweller {
        public int serializeId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Happiness happiness { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Health health { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Experience experience { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Relations relations { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Equipment equipment { get; set; }

        public int gender { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public Stats stats { get; set; }

        public bool pregnant { get; set; }
        public bool babyReady { get; set; }
        public bool assigned { get; set; }
        public bool sawIncident { get; set; }
        public bool WillGoToWasteland { get; set; }

        [JsonConverter(typeof (UColorConverter))]
        public Color skinColor { get; set; }

        [JsonConverter(typeof (UColorConverter))]
        public Color hairColor { get; set; }

        [JsonConverter(typeof (UColorConverter))]
        public Color outfitColor { get; set; }

        public int pendingExperienceReward { get; set; }
        public string hair { get; set; }
        public string faceMask { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public EquipedOutfit equipedOutfit { get; set; }

        [TypeConverter(typeof (ExpandableObjectConverter))]
        public EquipedWeapon equipedWeapon { get; set; }

        public int savedRoom { get; set; }
        public double lastChildBorn { get; set; }
        public string rarity { get; set; }
        public int deathTime { get; set; }
        public string uniqueData { get; set; }
        public int? daysOnWasteland { get; set; }
        public int? hoursOnWasteland { get; set; }
    }
}