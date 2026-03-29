#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPreferenceDtoWebhookPayloadWrapperTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType>
    {
        /// <inheritdoc />
        public override global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType Read(
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
                        return global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.WebhookPreferenceDtoWebhookPayloadWrapperTypeExtensions.ToValueString(value));
        }
    }
}
