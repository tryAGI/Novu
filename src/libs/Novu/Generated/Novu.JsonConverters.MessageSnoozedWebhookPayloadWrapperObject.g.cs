#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageSnoozedWebhookPayloadWrapperObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.MessageSnoozedWebhookPayloadWrapperObject>
    {
        /// <inheritdoc />
        public override global::Novu.MessageSnoozedWebhookPayloadWrapperObject Read(
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
                        return global::Novu.MessageSnoozedWebhookPayloadWrapperObjectExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.MessageSnoozedWebhookPayloadWrapperObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.MessageSnoozedWebhookPayloadWrapperObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.MessageSnoozedWebhookPayloadWrapperObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.MessageSnoozedWebhookPayloadWrapperObjectExtensions.ToValueString(value));
        }
    }
}
