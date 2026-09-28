#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkflowUpdatedWebhookPayloadWrapperTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.WorkflowUpdatedWebhookPayloadWrapperType?>
    {
        /// <inheritdoc />
        public override global::Novu.WorkflowUpdatedWebhookPayloadWrapperType? Read(
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
                        return global::Novu.WorkflowUpdatedWebhookPayloadWrapperTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.WorkflowUpdatedWebhookPayloadWrapperType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.WorkflowUpdatedWebhookPayloadWrapperType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.WorkflowUpdatedWebhookPayloadWrapperType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.WorkflowUpdatedWebhookPayloadWrapperTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
