#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookMessageFailedDtoWebhookPayloadWrapperObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject?>
    {
        /// <inheritdoc />
        public override global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject? Read(
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
                        return global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.WebhookMessageFailedDtoWebhookPayloadWrapperObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
