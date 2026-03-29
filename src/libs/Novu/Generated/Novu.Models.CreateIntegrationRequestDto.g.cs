
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationRequestDto
    {
        /// <summary>
        /// The name of the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The unique identifier for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The ID of the associated environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        public global::System.Guid? EnvironmentId { get; set; }

        /// <summary>
        /// The provider ID for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// The channel type for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.CreateIntegrationRequestDtoChannelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.CreateIntegrationRequestDtoChannel Channel { get; set; }

        /// <summary>
        /// The credentials for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Novu.CredentialsDto? Credentials { get; set; }

        /// <summary>
        /// If the integration is active, the validation on the credentials field will run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Flag to check the integration status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        public bool? Check { get; set; }

        /// <summary>
        /// Conditions for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? Conditions { get; set; }

        /// <summary>
        /// Configurations for the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        public object? Configurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationRequestDto" /> class.
        /// </summary>
        /// <param name="providerId">
        /// The provider ID for the integration
        /// </param>
        /// <param name="channel">
        /// The channel type for the integration
        /// </param>
        /// <param name="name">
        /// The name of the integration
        /// </param>
        /// <param name="identifier">
        /// The unique identifier for the integration
        /// </param>
        /// <param name="environmentId">
        /// The ID of the associated environment
        /// </param>
        /// <param name="credentials">
        /// The credentials for the integration
        /// </param>
        /// <param name="active">
        /// If the integration is active, the validation on the credentials field will run
        /// </param>
        /// <param name="check">
        /// Flag to check the integration status
        /// </param>
        /// <param name="conditions">
        /// Conditions for the integration
        /// </param>
        /// <param name="configurations">
        /// Configurations for the integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationRequestDto(
            string providerId,
            global::Novu.CreateIntegrationRequestDtoChannel channel,
            string? name,
            string? identifier,
            global::System.Guid? environmentId,
            global::Novu.CredentialsDto? credentials,
            bool? active,
            bool? check,
            global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? conditions,
            object? configurations)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.EnvironmentId = environmentId;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Channel = channel;
            this.Credentials = credentials;
            this.Active = active;
            this.Check = check;
            this.Conditions = conditions;
            this.Configurations = configurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationRequestDto" /> class.
        /// </summary>
        public CreateIntegrationRequestDto()
        {
        }
    }
}