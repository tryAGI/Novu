#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetChannelEndpointResponseDtoProviderIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.GetChannelEndpointResponseDtoProviderId?>
    {
        /// <inheritdoc />
        public override global::Novu.GetChannelEndpointResponseDtoProviderId? Read(
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
                        return global::Novu.GetChannelEndpointResponseDtoProviderIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.GetChannelEndpointResponseDtoProviderId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.GetChannelEndpointResponseDtoProviderId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.GetChannelEndpointResponseDtoProviderId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.GetChannelEndpointResponseDtoProviderIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
