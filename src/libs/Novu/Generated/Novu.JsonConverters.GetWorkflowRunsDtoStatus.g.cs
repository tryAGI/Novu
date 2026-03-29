#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetWorkflowRunsDtoStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.GetWorkflowRunsDtoStatus>
    {
        /// <inheritdoc />
        public override global::Novu.GetWorkflowRunsDtoStatus Read(
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
                        return global::Novu.GetWorkflowRunsDtoStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.GetWorkflowRunsDtoStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.GetWorkflowRunsDtoStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.GetWorkflowRunsDtoStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.GetWorkflowRunsDtoStatusExtensions.ToValueString(value));
        }
    }
}
