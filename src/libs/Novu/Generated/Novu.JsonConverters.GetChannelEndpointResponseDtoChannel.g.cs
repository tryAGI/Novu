#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetChannelEndpointResponseDtoChannelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.GetChannelEndpointResponseDtoChannel>
    {
        /// <inheritdoc />
        public override global::Novu.GetChannelEndpointResponseDtoChannel Read(
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
                        return global::Novu.GetChannelEndpointResponseDtoChannelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.GetChannelEndpointResponseDtoChannel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.GetChannelEndpointResponseDtoChannel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.GetChannelEndpointResponseDtoChannel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.GetChannelEndpointResponseDtoChannelExtensions.ToValueString(value));
        }
    }
}
