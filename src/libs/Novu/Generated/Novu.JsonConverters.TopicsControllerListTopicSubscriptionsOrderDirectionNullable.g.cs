#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopicsControllerListTopicSubscriptionsOrderDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?>
    {
        /// <inheritdoc />
        public override global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? Read(
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
                        return global::Novu.TopicsControllerListTopicSubscriptionsOrderDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.TopicsControllerListTopicSubscriptionsOrderDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.TopicsControllerListTopicSubscriptionsOrderDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
