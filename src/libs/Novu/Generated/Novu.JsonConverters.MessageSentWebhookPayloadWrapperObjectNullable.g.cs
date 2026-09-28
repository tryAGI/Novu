#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageSentWebhookPayloadWrapperObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.MessageSentWebhookPayloadWrapperObject?>
    {
        /// <inheritdoc />
        public override global::Novu.MessageSentWebhookPayloadWrapperObject? Read(
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
                        return global::Novu.MessageSentWebhookPayloadWrapperObjectExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.MessageSentWebhookPayloadWrapperObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.MessageSentWebhookPayloadWrapperObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.MessageSentWebhookPayloadWrapperObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.MessageSentWebhookPayloadWrapperObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
