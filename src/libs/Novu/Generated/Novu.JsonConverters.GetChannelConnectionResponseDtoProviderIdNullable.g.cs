#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetChannelConnectionResponseDtoProviderIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.GetChannelConnectionResponseDtoProviderId?>
    {
        /// <inheritdoc />
        public override global::Novu.GetChannelConnectionResponseDtoProviderId? Read(
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
                        return global::Novu.GetChannelConnectionResponseDtoProviderIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.GetChannelConnectionResponseDtoProviderId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.GetChannelConnectionResponseDtoProviderId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.GetChannelConnectionResponseDtoProviderId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.GetChannelConnectionResponseDtoProviderIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
