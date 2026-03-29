
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewPayloadDto
    {
        /// <summary>
        /// Partial subscriber information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.SubscriberResponseDtoOptional? Subscriber { get; set; }

        /// <summary>
        /// Payload data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Steps data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public object? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// Environment variables data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public object? Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewPayloadDto" /> class.
        /// </summary>
        /// <param name="subscriber">
        /// Partial subscriber information
        /// </param>
        /// <param name="payload">
        /// Payload data
        /// </param>
        /// <param name="steps">
        /// Steps data
        /// </param>
        /// <param name="context"></param>
        /// <param name="env">
        /// Environment variables data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewPayloadDto(
            global::Novu.SubscriberResponseDtoOptional? subscriber,
            object? payload,
            object? steps,
            object? context,
            object? env)
        {
            this.Subscriber = subscriber;
            this.Payload = payload;
            this.Steps = steps;
            this.Context = context;
            this.Env = env;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewPayloadDto" /> class.
        /// </summary>
        public PreviewPayloadDto()
        {
        }
    }
}