#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class PreferenceOverrideSourceEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.PreferenceOverrideSourceEnum?>
    {
        /// <inheritdoc />
        public override global::Novu.PreferenceOverrideSourceEnum? Read(
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
                        return global::Novu.PreferenceOverrideSourceEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.PreferenceOverrideSourceEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.PreferenceOverrideSourceEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.PreferenceOverrideSourceEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.PreferenceOverrideSourceEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
