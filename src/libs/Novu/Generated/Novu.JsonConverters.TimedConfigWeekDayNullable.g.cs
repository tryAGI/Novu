#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class TimedConfigWeekDayNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.TimedConfigWeekDay?>
    {
        /// <inheritdoc />
        public override global::Novu.TimedConfigWeekDay? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Novu.TimedConfigWeekDayExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.TimedConfigWeekDay)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.TimedConfigWeekDay?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.TimedConfigWeekDay? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.TimedConfigWeekDayExtensions.ToValueString(value.Value));
            }
        }
    }
}
