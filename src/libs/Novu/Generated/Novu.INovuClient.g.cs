
#nullable enable

namespace Novu
{
    /// <summary>
    /// Novu REST API. Please see https://docs.novu.co/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface INovuClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Novu.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ActivityClient Activity { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChannelConnectionsClient ChannelConnections { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsClient ChannelEndpoints { get; }

        /// <summary>
        /// 
        /// </summary>
        public ContextsClient Contexts { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariablesClient EnvironmentVariables { get; }

        /// <summary>
        /// Environments allow you to manage different stages of your application development lifecycle. Each environment has its own set of API keys and configurations, enabling you to separate development, staging, and production workflows.
        /// </summary>
        public EnvironmentsClient Environments { get; }

        /// <summary>
        /// Events represent a change in state of a subscriber. They are used to trigger workflows, and enable you to send notifications to subscribers based on their actions.
        /// </summary>
        public EventsClient Events { get; }

        /// <summary>
        /// With the help of the Integration Store, you can easily integrate your favorite delivery provider. During the runtime of the API, the Integrations Store is responsible for storing the configurations of all the providers.
        /// </summary>
        public IntegrationsClient Integrations { get; }

        /// <summary>
        /// Layouts are reusable wrappers for your email notifications.
        /// </summary>
        public LayoutsClient Layouts { get; }

        /// <summary>
        /// A message in Novu represents a notification delivered to a recipient on a particular channel. Messages contain information about the request that triggered its delivery, a view of the data sent to the recipient, and a timeline of its lifecycle events. Learn more about messages.
        /// </summary>
        public MessagesClient Messages { get; }

        /// <summary>
        /// 
        /// </summary>
        public NotificationsClient Notifications { get; }

        /// <summary>
        /// A subscriber in Novu represents someone who should receive a message. A subscriber's profile information contains important attributes about the subscriber that will be used in messages (name, email). The subscriber object can contain other key-value pairs that can be used to further personalize your messages.
        /// </summary>
        public SubscribersClient Subscribers { get; }

        /// <summary>
        /// Topics are a way to group subscribers together so that they can be notified of events at once. A topic is identified by a custom key. This can be helpful for things like sending out marketing emails or notifying users of new features. Topics can also be used to send notifications to the subscribers who have been grouped together based on their interests, location, activities and much more.
        /// </summary>
        public TopicsClient Topics { get; }

        /// <summary>
        /// Used to localize your notifications to different languages.
        /// </summary>
        public TranslationsClient Translations { get; }

        /// <summary>
        /// All notifications are sent via a workflow. Each workflow acts as a container for the logic and blueprint that are associated with a type of notification in your system.
        /// </summary>
        public WorkflowsClient Workflows { get; }

    }
}