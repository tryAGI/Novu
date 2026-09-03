
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateIntegrationRequestDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// If the integration is active the validation on the credentials field will run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Novu.CredentialsDto? Credentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        public bool? Check { get; set; }

        /// <summary>
        /// Legacy StepFilter conditions. Ignored when `rules` is also set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? Conditions { get; set; }

        /// <summary>
        /// JSONLogic used at send time to select this integration. Takes precedence over `conditions`.<br/>
        /// Example: {"==":[{"var":"context.tenant.id"},"acme"]}
        /// </summary>
        /// <example>{"==":[{"var":"context.tenant.id"},"acme"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public object? Rules { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateIntegrationRequestDto" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="identifier"></param>
        /// <param name="environmentId"></param>
        /// <param name="active">
        /// If the integration is active the validation on the credentials field will run
        /// </param>
        /// <param name="credentials"></param>
        /// <param name="check"></param>
        /// <param name="rules">
        /// JSONLogic used at send time to select this integration. Takes precedence over `conditions`.<br/>
        /// Example: {"==":[{"var":"context.tenant.id"},"acme"]}
        /// </param>
        /// <param name="configurations">
        /// Configurations for the integration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIntegrationRequestDto(
            string? name,
            string? identifier,
            string? environmentId,
            bool? active,
            global::Novu.CredentialsDto? credentials,
            bool? check,
            object? rules,
            object? configurations)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.EnvironmentId = environmentId;
            this.Active = active;
            this.Credentials = credentials;
            this.Check = check;
            this.Rules = rules;
            this.Configurations = configurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIntegrationRequestDto" /> class.
        /// </summary>
        public UpdateIntegrationRequestDto()
        {
        }

    }
}