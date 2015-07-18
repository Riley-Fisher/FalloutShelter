using System;
using System.Drawing;
using Newtonsoft.Json;

namespace FalloutShelter.Converters {
    public class UColorConverter : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            var n = (Color) value;
            var val = (uint) ((n.A << 24) | (n.R << 16) |
                              (n.G << 8) | (n.B << 0));
            writer.WriteValue(val);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer) {
            uint number = Convert.ToUInt32(reader.Value);
            var a = (byte) (number >> 24);
            var r = (byte) (number >> 16);
            var g = (byte) (number >> 8);
            var b = (byte) (number >> 0);
            return Color.FromArgb(a, r, g, b);
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof (Color);
        }
    }
}