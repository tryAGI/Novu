#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class ThrottleControlDtoUnitJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.ThrottleControlDtoUnit>
    {
        /// <inheritdoc />
        public override global::Novu.ThrottleControlDtoUnit Read(
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
                        return global::Novu.ThrottleControlDtoUnitExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.ThrottleControlDtoUnit)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.ThrottleControlDtoUnit);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.ThrottleControlDtoUnit value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.ThrottleControlDtoUnitExtensions.ToValueString(value));
        }
    }
}
