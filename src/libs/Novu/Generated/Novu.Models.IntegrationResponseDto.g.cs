
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IntegrationResponseDto
    {
        /// <summary>
        /// The unique identifier of the integration record in the database. This is automatically generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier for the environment associated with this integration. This links to the Environment collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// The unique identifier for the organization that owns this integration. This links to the Organization collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The name of the integration, which is used to identify it in the user interface.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A unique string identifier for the integration, often used for API calls or internal references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// The identifier for the provider of the integration (e.g., "mailgun", "twilio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderId { get; set; }

        /// <summary>
        /// The channel type for the integration, which defines how it communicates (e.g., email, SMS). Not set for agent-kind integrations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.IntegrationResponseDtoChannelJsonConverter))]
        public global::Novu.IntegrationResponseDtoChannel? Channel { get; set; }

        /// <summary>
        /// Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not have a channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.IntegrationResponseDtoKindJsonConverter))]
        public global::Novu.IntegrationResponseDtoKind? Kind { get; set; }

        /// <summary>
        /// The decrypted credentials required for the integration to function (e.g. provider API keys, signing secrets). Only returned to dashboard/session-token callers; API-key authenticated callers receive the integration metadata without this field to avoid amplifying API-key leaks into provider-credential leaks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Novu.CredentialsDto? Credentials { get; set; }

        /// <summary>
        /// The configurations required for enabling the additional configurations of the integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        public global::Novu.ConfigurationsDto? Configurations { get; set; }

        /// <summary>
        /// Indicates whether the integration is currently active. An active integration will process events and messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Indicates whether the integration has been marked as deleted (soft delete).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The timestamp indicating when the integration was deleted. This is set when the integration is soft deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public string? DeletedAt { get; set; }

        /// <summary>
        /// The identifier of the user who performed the deletion of this integration. Useful for audit trails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedBy")]
        public string? DeletedBy { get; set; }

        /// <summary>
        /// Indicates whether this integration is marked as primary. A primary integration is often the default choice for processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Primary { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationResponseDto" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// The unique identifier for the environment associated with this integration. This links to the Environment collection.
        /// </param>
        /// <param name="organizationId">
        /// The unique identifier for the organization that owns this integration. This links to the Organization collection.
        /// </param>
        /// <param name="name">
        /// The name of the integration, which is used to identify it in the user interface.
        /// </param>
        /// <param name="identifier">
        /// A unique string identifier for the integration, often used for API calls or internal references.
        /// </param>
        /// <param name="providerId">
        /// The identifier for the provider of the integration (e.g., "mailgun", "twilio").
        /// </param>
        /// <param name="active">
        /// Indicates whether the integration is currently active. An active integration will process events and messages.
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the integration has been marked as deleted (soft delete).
        /// </param>
        /// <param name="primary">
        /// Indicates whether this integration is marked as primary. A primary integration is often the default choice for processing.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the integration record in the database. This is automatically generated.
        /// </param>
        /// <param name="channel">
        /// The channel type for the integration, which defines how it communicates (e.g., email, SMS). Not set for agent-kind integrations.
        /// </param>
        /// <param name="kind">
        /// Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not have a channel.
        /// </param>
        /// <param name="credentials">
        /// The decrypted credentials required for the integration to function (e.g. provider API keys, signing secrets). Only returned to dashboard/session-token callers; API-key authenticated callers receive the integration metadata without this field to avoid amplifying API-key leaks into provider-credential leaks.
        /// </param>
        /// <param name="configurations">
        /// The configurations required for enabling the additional configurations of the integration.
        /// </param>
        /// <param name="deletedAt">
        /// The timestamp indicating when the integration was deleted. This is set when the integration is soft deleted.
        /// </param>
        /// <param name="deletedBy">
        /// The identifier of the user who performed the deletion of this integration. Useful for audit trails.
        /// </param>
        /// <param name="rules">
        /// JSONLogic used at send time to select this integration. Takes precedence over `conditions`.<br/>
        /// Example: {"==":[{"var":"context.tenant.id"},"acme"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationResponseDto(
            string environmentId,
            string organizationId,
            string name,
            string identifier,
            string providerId,
            bool active,
            bool deleted,
            bool primary,
            string? id,
            global::Novu.IntegrationResponseDtoChannel? channel,
            global::Novu.IntegrationResponseDtoKind? kind,
            global::Novu.CredentialsDto? credentials,
            global::Novu.ConfigurationsDto? configurations,
            string? deletedAt,
            string? deletedBy,
            object? rules)
        {
            this.Id = id;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
            this.Channel = channel;
            this.Kind = kind;
            this.Credentials = credentials;
            this.Configurations = configurations;
            this.Active = active;
            this.Deleted = deleted;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
            this.Primary = primary;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationResponseDto" /> class.
        /// </summary>
        public IntegrationResponseDto()
        {
        }

    }
}