#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChannelConnectionsControllerListChannelConnectionsChannelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?>
    {
        /// <inheritdoc />
        public override global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? Read(
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
                        return global::Novu.ChannelConnectionsControllerListChannelConnectionsChannelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.ChannelConnectionsControllerListChannelConnectionsChannel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.ChannelConnectionsControllerListChannelConnectionsChannelExtensions.ToValueString(value.Value));
            }
        }
    }
}
