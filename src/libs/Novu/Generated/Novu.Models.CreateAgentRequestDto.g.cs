
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentRequestDto
    {
        /// <summary>
        /// Required when not adopting an existing managed agent (i.e. when managedRuntime.externalAgentId is absent). Optional in adopt mode where the name is resolved from the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Required when not adopting an existing managed agent. Auto-generated from the provider agent name when omitted in adopt mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.CreateAgentRequestDtoRuntimeJsonConverter))]
        public global::Novu.CreateAgentRequestDtoRuntime? Runtime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managedRuntime")]
        public global::Novu.ManagedRuntimeDto? ManagedRuntime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Required when not adopting an existing managed agent (i.e. when managedRuntime.externalAgentId is absent). Optional in adopt mode where the name is resolved from the provider.
        /// </param>
        /// <param name="identifier">
        /// Required when not adopting an existing managed agent. Auto-generated from the provider agent name when omitted in adopt mode.
        /// </param>
        /// <param name="description"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="runtime"></param>
        /// <param name="managedRuntime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequestDto(
            string name,
            string identifier,
            string? description,
            bool? active,
            global::Novu.CreateAgentRequestDtoRuntime? runtime,
            global::Novu.ManagedRuntimeDto? managedRuntime)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Description = description;
            this.Active = active;
            this.Runtime = runtime;
            this.ManagedRuntime = managedRuntime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestDto" /> class.
        /// </summary>
        public CreateAgentRequestDto()
        {
        }

    }
}