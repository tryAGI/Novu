#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageUnarchivedWebhookPayloadWrapperObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.MessageUnarchivedWebhookPayloadWrapperObject>
    {
        /// <inheritdoc />
        public override global::Novu.MessageUnarchivedWebhookPayloadWrapperObject Read(
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
                        return global::Novu.MessageUnarchivedWebhookPayloadWrapperObjectExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.MessageUnarchivedWebhookPayloadWrapperObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.MessageUnarchivedWebhookPayloadWrapperObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.MessageUnarchivedWebhookPayloadWrapperObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.MessageUnarchivedWebhookPayloadWrapperObjectExtensions.ToValueString(value));
        }
    }
}
