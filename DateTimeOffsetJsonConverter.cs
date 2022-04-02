using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
    {
        public override DateTimeOffset Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
                DateTimeOffset.ParseExact(reader.GetString()!,
                    "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    //2022-04-02 13:08:27

        public override void Write(
            Utf8JsonWriter writer,
            DateTimeOffset dateTimeValue,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(dateTimeValue.ToString());
    }
