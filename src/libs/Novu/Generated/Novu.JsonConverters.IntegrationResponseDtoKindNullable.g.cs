#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class IntegrationResponseDtoKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.IntegrationResponseDtoKind?>
    {
        /// <inheritdoc />
        public override global::Novu.IntegrationResponseDtoKind? Read(
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
                        return global::Novu.IntegrationResponseDtoKindExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.IntegrationResponseDtoKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.IntegrationResponseDtoKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.IntegrationResponseDtoKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.IntegrationResponseDtoKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
