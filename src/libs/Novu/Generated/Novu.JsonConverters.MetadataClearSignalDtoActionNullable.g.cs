#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class MetadataClearSignalDtoActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.MetadataClearSignalDtoAction?>
    {
        /// <inheritdoc />
        public override global::Novu.MetadataClearSignalDtoAction? Read(
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
                        return global::Novu.MetadataClearSignalDtoActionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.MetadataClearSignalDtoAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.MetadataClearSignalDtoAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.MetadataClearSignalDtoAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.MetadataClearSignalDtoActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
