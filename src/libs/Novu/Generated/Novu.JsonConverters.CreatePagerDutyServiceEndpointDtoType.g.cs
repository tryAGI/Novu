#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreatePagerDutyServiceEndpointDtoTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.CreatePagerDutyServiceEndpointDtoType>
    {
        /// <inheritdoc />
        public override global::Novu.CreatePagerDutyServiceEndpointDtoType Read(
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
                        return global::Novu.CreatePagerDutyServiceEndpointDtoTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.CreatePagerDutyServiceEndpointDtoType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.CreatePagerDutyServiceEndpointDtoType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.CreatePagerDutyServiceEndpointDtoType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Novu.CreatePagerDutyServiceEndpointDtoTypeExtensions.ToValueString(value));
        }
    }
}
