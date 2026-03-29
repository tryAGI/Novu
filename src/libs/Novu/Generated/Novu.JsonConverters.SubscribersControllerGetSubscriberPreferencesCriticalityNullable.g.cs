#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class SubscribersControllerGetSubscriberPreferencesCriticalityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality?>
    {
        /// <inheritdoc />
        public override global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? Read(
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
                        return global::Novu.SubscribersControllerGetSubscriberPreferencesCriticalityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.SubscribersControllerGetSubscriberPreferencesCriticality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.SubscribersControllerGetSubscriberPreferencesCriticalityExtensions.ToValueString(value.Value));
            }
        }
    }
}
