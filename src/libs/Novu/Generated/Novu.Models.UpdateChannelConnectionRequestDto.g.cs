
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChannelConnectionRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkspaceDto Workspace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.AuthDto Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelConnectionRequestDto" /> class.
        /// </summary>
        /// <param name="workspace"></param>
        /// <param name="auth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelConnectionRequestDto(
            global::Novu.WorkspaceDto workspace,
            global::Novu.AuthDto auth)
        {
            this.Workspace = workspace ?? throw new global::System.ArgumentNullException(nameof(workspace));
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelConnectionRequestDto" /> class.
        /// </summary>
        public UpdateChannelConnectionRequestDto()
        {
        }
    }
}