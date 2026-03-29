
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetaDto
    {
        /// <summary>
        /// The total count of subscriber IDs provided<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// The count of successfully created subscriptions<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Successful { get; set; }

        /// <summary>
        /// The count of failed subscription attempts<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaDto" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The total count of subscriber IDs provided<br/>
        /// Example: 3
        /// </param>
        /// <param name="successful">
        /// The count of successfully created subscriptions<br/>
        /// Example: 2
        /// </param>
        /// <param name="failed">
        /// The count of failed subscription attempts<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetaDto(
            double totalCount,
            double successful,
            double failed)
        {
            this.TotalCount = totalCount;
            this.Successful = successful;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaDto" /> class.
        /// </summary>
        public MetaDto()
        {
        }
    }
}