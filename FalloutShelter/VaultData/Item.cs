using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FalloutShelter.VaultData {
    public class Item {
        public enum ItemTypes {
            Weapon,
            Outfit
        }

        public string id { get; set; }

        [JsonConverter(typeof (StringEnumConverter))]
        public ItemTypes type { get; set; }

        public bool hasBeenAssigned { get; set; }
    }
}