using System;
using Newtonsoft.Json;

namespace FalloutShelter.Converters {
    public class BoolConverter : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue(((bool) value) ? "true" : "false");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer) {
            return bool.Parse(reader.Value.ToString());
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof (bool);
        }
    }
}