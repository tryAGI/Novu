#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkflowCreatedWebhookPayloadWrapperTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.WorkflowCreatedWebhookPayloadWrapperType>
    {
        /// <inheritdoc />
        public override global::Novu.WorkflowCreatedWebhookPayloadWrapperType Read(
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
                        return global::Novu.WorkflowCreatedWebhookPayloadWrapperTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.WorkflowCreatedWebhookPayloadWrapperType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.WorkflowCreatedWebhookPayloadWrapperType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.WorkflowCreatedWebhookPayloadWrapperType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.WorkflowCreatedWebhookPayloadWrapperTypeExtensions.ToValueString(value));
        }
    }
}
