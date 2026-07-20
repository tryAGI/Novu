#nullable enable

namespace Novu.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpsgenieIntegrationEndpointDtoRegionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Novu.OpsgenieIntegrationEndpointDtoRegion?>
    {
        /// <inheritdoc />
        public override global::Novu.OpsgenieIntegrationEndpointDtoRegion? Read(
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
                        return global::Novu.OpsgenieIntegrationEndpointDtoRegionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Novu.OpsgenieIntegrationEndpointDtoRegion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Novu.OpsgenieIntegrationEndpointDtoRegion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Novu.OpsgenieIntegrationEndpointDtoRegion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Novu.OpsgenieIntegrationEndpointDtoRegionExtensions.ToValueString(value.Value));
            }
        }
    }
}
