#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChannelEndpointsControllerCreateChannelEndpointRequest : global::System.IEquatable<ChannelEndpointsControllerCreateChannelEndpointRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateSlackChannelEndpointDto? SlackChannel { get; init; }
#else
        public global::Novu.CreateSlackChannelEndpointDto? SlackChannel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackChannel))]
#endif
        public bool IsSlackChannel => SlackChannel != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlackChannel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateSlackChannelEndpointDto? value)
        {
            value = SlackChannel;
            return IsSlackChannel;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackChannelEndpointDto PickSlackChannel() => IsSlackChannel
            ? SlackChannel!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackChannel' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateSlackUserEndpointDto? SlackUser { get; init; }
#else
        public global::Novu.CreateSlackUserEndpointDto? SlackUser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackUser))]
#endif
        public bool IsSlackUser => SlackUser != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSlackUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateSlackUserEndpointDto? value)
        {
            value = SlackUser;
            return IsSlackUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateSlackUserEndpointDto PickSlackUser() => IsSlackUser
            ? SlackUser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackUser' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateWebhookEndpointDto? Webhook { get; init; }
#else
        public global::Novu.CreateWebhookEndpointDto? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateWebhookEndpointDto? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebhookEndpointDto PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreatePhoneEndpointDto? Phone { get; init; }
#else
        public global::Novu.CreatePhoneEndpointDto? Phone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Phone))]
#endif
        public bool IsPhone => Phone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPhone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreatePhoneEndpointDto? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePhoneEndpointDto PickPhone() => IsPhone
            ? Phone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateMsTeamsChannelEndpointDto? MsTeamsChannel { get; init; }
#else
        public global::Novu.CreateMsTeamsChannelEndpointDto? MsTeamsChannel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MsTeamsChannel))]
#endif
        public bool IsMsTeamsChannel => MsTeamsChannel != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMsTeamsChannel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateMsTeamsChannelEndpointDto? value)
        {
            value = MsTeamsChannel;
            return IsMsTeamsChannel;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsChannelEndpointDto PickMsTeamsChannel() => IsMsTeamsChannel
            ? MsTeamsChannel!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MsTeamsChannel' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateMsTeamsUserEndpointDto? MsTeamsUser { get; init; }
#else
        public global::Novu.CreateMsTeamsUserEndpointDto? MsTeamsUser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MsTeamsUser))]
#endif
        public bool IsMsTeamsUser => MsTeamsUser != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMsTeamsUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateMsTeamsUserEndpointDto? value)
        {
            value = MsTeamsUser;
            return IsMsTeamsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateMsTeamsUserEndpointDto PickMsTeamsUser() => IsMsTeamsUser
            ? MsTeamsUser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MsTeamsUser' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateTelegramChatEndpointDto? TelegramChat { get; init; }
#else
        public global::Novu.CreateTelegramChatEndpointDto? TelegramChat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TelegramChat))]
#endif
        public bool IsTelegramChat => TelegramChat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTelegramChat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateTelegramChatEndpointDto? value)
        {
            value = TelegramChat;
            return IsTelegramChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateTelegramChatEndpointDto PickTelegramChat() => IsTelegramChat
            ? TelegramChat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TelegramChat' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateWebexRoomEndpointDto? WebexRoom { get; init; }
#else
        public global::Novu.CreateWebexRoomEndpointDto? WebexRoom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebexRoom))]
#endif
        public bool IsWebexRoom => WebexRoom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebexRoom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateWebexRoomEndpointDto? value)
        {
            value = WebexRoom;
            return IsWebexRoom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebexRoomEndpointDto PickWebexRoom() => IsWebexRoom
            ? WebexRoom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebexRoom' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateWebexPersonEndpointDto? WebexPerson { get; init; }
#else
        public global::Novu.CreateWebexPersonEndpointDto? WebexPerson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebexPerson))]
#endif
        public bool IsWebexPerson => WebexPerson != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebexPerson(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateWebexPersonEndpointDto? value)
        {
            value = WebexPerson;
            return IsWebexPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateWebexPersonEndpointDto PickWebexPerson() => IsWebexPerson
            ? WebexPerson!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebexPerson' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateLineUserEndpointDto? LineUser { get; init; }
#else
        public global::Novu.CreateLineUserEndpointDto? LineUser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LineUser))]
#endif
        public bool IsLineUser => LineUser != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLineUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateLineUserEndpointDto? value)
        {
            value = LineUser;
            return IsLineUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateLineUserEndpointDto PickLineUser() => IsLineUser
            ? LineUser!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LineUser' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreatePagerDutyServiceEndpointDto? PagerdutyService { get; init; }
#else
        public global::Novu.CreatePagerDutyServiceEndpointDto? PagerdutyService { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PagerdutyService))]
#endif
        public bool IsPagerdutyService => PagerdutyService != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPagerdutyService(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreatePagerDutyServiceEndpointDto? value)
        {
            value = PagerdutyService;
            return IsPagerdutyService;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreatePagerDutyServiceEndpointDto PickPagerdutyService() => IsPagerdutyService
            ? PagerdutyService!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PagerdutyService' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CreateOpsgenieIntegrationEndpointDto? OpsgenieIntegration { get; init; }
#else
        public global::Novu.CreateOpsgenieIntegrationEndpointDto? OpsgenieIntegration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpsgenieIntegration))]
#endif
        public bool IsOpsgenieIntegration => OpsgenieIntegration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpsgenieIntegration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CreateOpsgenieIntegrationEndpointDto? value)
        {
            value = OpsgenieIntegration;
            return IsOpsgenieIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CreateOpsgenieIntegrationEndpointDto PickOpsgenieIntegration() => IsOpsgenieIntegration
            ? OpsgenieIntegration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpsgenieIntegration' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateSlackChannelEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateSlackChannelEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateSlackChannelEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.SlackChannel;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateSlackChannelEndpointDto? value)
        {
            SlackChannel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromSlackChannel(global::Novu.CreateSlackChannelEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateSlackUserEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateSlackUserEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateSlackUserEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.SlackUser;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateSlackUserEndpointDto? value)
        {
            SlackUser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromSlackUser(global::Novu.CreateSlackUserEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateWebhookEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateWebhookEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateWebhookEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateWebhookEndpointDto? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromWebhook(global::Novu.CreateWebhookEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreatePhoneEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreatePhoneEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreatePhoneEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.Phone;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreatePhoneEndpointDto? value)
        {
            Phone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromPhone(global::Novu.CreatePhoneEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateMsTeamsChannelEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateMsTeamsChannelEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateMsTeamsChannelEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.MsTeamsChannel;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateMsTeamsChannelEndpointDto? value)
        {
            MsTeamsChannel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromMsTeamsChannel(global::Novu.CreateMsTeamsChannelEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateMsTeamsUserEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateMsTeamsUserEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateMsTeamsUserEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.MsTeamsUser;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateMsTeamsUserEndpointDto? value)
        {
            MsTeamsUser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromMsTeamsUser(global::Novu.CreateMsTeamsUserEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateTelegramChatEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateTelegramChatEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateTelegramChatEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.TelegramChat;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateTelegramChatEndpointDto? value)
        {
            TelegramChat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromTelegramChat(global::Novu.CreateTelegramChatEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateWebexRoomEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateWebexRoomEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateWebexRoomEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.WebexRoom;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateWebexRoomEndpointDto? value)
        {
            WebexRoom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromWebexRoom(global::Novu.CreateWebexRoomEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateWebexPersonEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateWebexPersonEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateWebexPersonEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.WebexPerson;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateWebexPersonEndpointDto? value)
        {
            WebexPerson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromWebexPerson(global::Novu.CreateWebexPersonEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateLineUserEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateLineUserEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateLineUserEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.LineUser;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateLineUserEndpointDto? value)
        {
            LineUser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromLineUser(global::Novu.CreateLineUserEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreatePagerDutyServiceEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreatePagerDutyServiceEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreatePagerDutyServiceEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.PagerdutyService;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreatePagerDutyServiceEndpointDto? value)
        {
            PagerdutyService = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromPagerdutyService(global::Novu.CreatePagerDutyServiceEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateOpsgenieIntegrationEndpointDto value) => new ChannelEndpointsControllerCreateChannelEndpointRequest((global::Novu.CreateOpsgenieIntegrationEndpointDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CreateOpsgenieIntegrationEndpointDto?(ChannelEndpointsControllerCreateChannelEndpointRequest @this) => @this.OpsgenieIntegration;

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(global::Novu.CreateOpsgenieIntegrationEndpointDto? value)
        {
            OpsgenieIntegration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChannelEndpointsControllerCreateChannelEndpointRequest FromOpsgenieIntegration(global::Novu.CreateOpsgenieIntegrationEndpointDto? value) => new ChannelEndpointsControllerCreateChannelEndpointRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public ChannelEndpointsControllerCreateChannelEndpointRequest(
            global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? type,
            global::Novu.CreateSlackChannelEndpointDto? slackChannel,
            global::Novu.CreateSlackUserEndpointDto? slackUser,
            global::Novu.CreateWebhookEndpointDto? webhook,
            global::Novu.CreatePhoneEndpointDto? phone,
            global::Novu.CreateMsTeamsChannelEndpointDto? msTeamsChannel,
            global::Novu.CreateMsTeamsUserEndpointDto? msTeamsUser,
            global::Novu.CreateTelegramChatEndpointDto? telegramChat,
            global::Novu.CreateWebexRoomEndpointDto? webexRoom,
            global::Novu.CreateWebexPersonEndpointDto? webexPerson,
            global::Novu.CreateLineUserEndpointDto? lineUser,
            global::Novu.CreatePagerDutyServiceEndpointDto? pagerdutyService,
            global::Novu.CreateOpsgenieIntegrationEndpointDto? opsgenieIntegration
            )
        {
            Type = type;

            SlackChannel = slackChannel;
            SlackUser = slackUser;
            Webhook = webhook;
            Phone = phone;
            MsTeamsChannel = msTeamsChannel;
            MsTeamsUser = msTeamsUser;
            TelegramChat = telegramChat;
            WebexRoom = webexRoom;
            WebexPerson = webexPerson;
            LineUser = lineUser;
            PagerdutyService = pagerdutyService;
            OpsgenieIntegration = opsgenieIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpsgenieIntegration as object ??
            PagerdutyService as object ??
            LineUser as object ??
            WebexPerson as object ??
            WebexRoom as object ??
            TelegramChat as object ??
            MsTeamsUser as object ??
            MsTeamsChannel as object ??
            Phone as object ??
            Webhook as object ??
            SlackUser as object ??
            SlackChannel as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SlackChannel?.ToString() ??
            SlackUser?.ToString() ??
            Webhook?.ToString() ??
            Phone?.ToString() ??
            MsTeamsChannel?.ToString() ??
            MsTeamsUser?.ToString() ??
            TelegramChat?.ToString() ??
            WebexRoom?.ToString() ??
            WebexPerson?.ToString() ??
            LineUser?.ToString() ??
            PagerdutyService?.ToString() ??
            OpsgenieIntegration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && IsWebexPerson && !IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && IsLineUser && !IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && IsPagerdutyService && !IsOpsgenieIntegration || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser && !IsTelegramChat && !IsWebexRoom && !IsWebexPerson && !IsLineUser && !IsPagerdutyService && IsOpsgenieIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Novu.CreateSlackChannelEndpointDto, TResult>? slackChannel = null,
            global::System.Func<global::Novu.CreateSlackUserEndpointDto, TResult>? slackUser = null,
            global::System.Func<global::Novu.CreateWebhookEndpointDto, TResult>? webhook = null,
            global::System.Func<global::Novu.CreatePhoneEndpointDto, TResult>? phone = null,
            global::System.Func<global::Novu.CreateMsTeamsChannelEndpointDto, TResult>? msTeamsChannel = null,
            global::System.Func<global::Novu.CreateMsTeamsUserEndpointDto, TResult>? msTeamsUser = null,
            global::System.Func<global::Novu.CreateTelegramChatEndpointDto, TResult>? telegramChat = null,
            global::System.Func<global::Novu.CreateWebexRoomEndpointDto, TResult>? webexRoom = null,
            global::System.Func<global::Novu.CreateWebexPersonEndpointDto, TResult>? webexPerson = null,
            global::System.Func<global::Novu.CreateLineUserEndpointDto, TResult>? lineUser = null,
            global::System.Func<global::Novu.CreatePagerDutyServiceEndpointDto, TResult>? pagerdutyService = null,
            global::System.Func<global::Novu.CreateOpsgenieIntegrationEndpointDto, TResult>? opsgenieIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannel && slackChannel != null)
            {
                return slackChannel(SlackChannel!);
            }
            else if (IsSlackUser && slackUser != null)
            {
                return slackUser(SlackUser!);
            }
            else if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsPhone && phone != null)
            {
                return phone(Phone!);
            }
            else if (IsMsTeamsChannel && msTeamsChannel != null)
            {
                return msTeamsChannel(MsTeamsChannel!);
            }
            else if (IsMsTeamsUser && msTeamsUser != null)
            {
                return msTeamsUser(MsTeamsUser!);
            }
            else if (IsTelegramChat && telegramChat != null)
            {
                return telegramChat(TelegramChat!);
            }
            else if (IsWebexRoom && webexRoom != null)
            {
                return webexRoom(WebexRoom!);
            }
            else if (IsWebexPerson && webexPerson != null)
            {
                return webexPerson(WebexPerson!);
            }
            else if (IsLineUser && lineUser != null)
            {
                return lineUser(LineUser!);
            }
            else if (IsPagerdutyService && pagerdutyService != null)
            {
                return pagerdutyService(PagerdutyService!);
            }
            else if (IsOpsgenieIntegration && opsgenieIntegration != null)
            {
                return opsgenieIntegration(OpsgenieIntegration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Novu.CreateSlackChannelEndpointDto>? slackChannel = null,

            global::System.Action<global::Novu.CreateSlackUserEndpointDto>? slackUser = null,

            global::System.Action<global::Novu.CreateWebhookEndpointDto>? webhook = null,

            global::System.Action<global::Novu.CreatePhoneEndpointDto>? phone = null,

            global::System.Action<global::Novu.CreateMsTeamsChannelEndpointDto>? msTeamsChannel = null,

            global::System.Action<global::Novu.CreateMsTeamsUserEndpointDto>? msTeamsUser = null,

            global::System.Action<global::Novu.CreateTelegramChatEndpointDto>? telegramChat = null,

            global::System.Action<global::Novu.CreateWebexRoomEndpointDto>? webexRoom = null,

            global::System.Action<global::Novu.CreateWebexPersonEndpointDto>? webexPerson = null,

            global::System.Action<global::Novu.CreateLineUserEndpointDto>? lineUser = null,

            global::System.Action<global::Novu.CreatePagerDutyServiceEndpointDto>? pagerdutyService = null,

            global::System.Action<global::Novu.CreateOpsgenieIntegrationEndpointDto>? opsgenieIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannel)
            {
                slackChannel?.Invoke(SlackChannel!);
            }
            else if (IsSlackUser)
            {
                slackUser?.Invoke(SlackUser!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
            else if (IsMsTeamsChannel)
            {
                msTeamsChannel?.Invoke(MsTeamsChannel!);
            }
            else if (IsMsTeamsUser)
            {
                msTeamsUser?.Invoke(MsTeamsUser!);
            }
            else if (IsTelegramChat)
            {
                telegramChat?.Invoke(TelegramChat!);
            }
            else if (IsWebexRoom)
            {
                webexRoom?.Invoke(WebexRoom!);
            }
            else if (IsWebexPerson)
            {
                webexPerson?.Invoke(WebexPerson!);
            }
            else if (IsLineUser)
            {
                lineUser?.Invoke(LineUser!);
            }
            else if (IsPagerdutyService)
            {
                pagerdutyService?.Invoke(PagerdutyService!);
            }
            else if (IsOpsgenieIntegration)
            {
                opsgenieIntegration?.Invoke(OpsgenieIntegration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Novu.CreateSlackChannelEndpointDto>? slackChannel = null,
            global::System.Action<global::Novu.CreateSlackUserEndpointDto>? slackUser = null,
            global::System.Action<global::Novu.CreateWebhookEndpointDto>? webhook = null,
            global::System.Action<global::Novu.CreatePhoneEndpointDto>? phone = null,
            global::System.Action<global::Novu.CreateMsTeamsChannelEndpointDto>? msTeamsChannel = null,
            global::System.Action<global::Novu.CreateMsTeamsUserEndpointDto>? msTeamsUser = null,
            global::System.Action<global::Novu.CreateTelegramChatEndpointDto>? telegramChat = null,
            global::System.Action<global::Novu.CreateWebexRoomEndpointDto>? webexRoom = null,
            global::System.Action<global::Novu.CreateWebexPersonEndpointDto>? webexPerson = null,
            global::System.Action<global::Novu.CreateLineUserEndpointDto>? lineUser = null,
            global::System.Action<global::Novu.CreatePagerDutyServiceEndpointDto>? pagerdutyService = null,
            global::System.Action<global::Novu.CreateOpsgenieIntegrationEndpointDto>? opsgenieIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannel)
            {
                slackChannel?.Invoke(SlackChannel!);
            }
            else if (IsSlackUser)
            {
                slackUser?.Invoke(SlackUser!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
            else if (IsMsTeamsChannel)
            {
                msTeamsChannel?.Invoke(MsTeamsChannel!);
            }
            else if (IsMsTeamsUser)
            {
                msTeamsUser?.Invoke(MsTeamsUser!);
            }
            else if (IsTelegramChat)
            {
                telegramChat?.Invoke(TelegramChat!);
            }
            else if (IsWebexRoom)
            {
                webexRoom?.Invoke(WebexRoom!);
            }
            else if (IsWebexPerson)
            {
                webexPerson?.Invoke(WebexPerson!);
            }
            else if (IsLineUser)
            {
                lineUser?.Invoke(LineUser!);
            }
            else if (IsPagerdutyService)
            {
                pagerdutyService?.Invoke(PagerdutyService!);
            }
            else if (IsOpsgenieIntegration)
            {
                opsgenieIntegration?.Invoke(OpsgenieIntegration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SlackChannel,
                typeof(global::Novu.CreateSlackChannelEndpointDto),
                SlackUser,
                typeof(global::Novu.CreateSlackUserEndpointDto),
                Webhook,
                typeof(global::Novu.CreateWebhookEndpointDto),
                Phone,
                typeof(global::Novu.CreatePhoneEndpointDto),
                MsTeamsChannel,
                typeof(global::Novu.CreateMsTeamsChannelEndpointDto),
                MsTeamsUser,
                typeof(global::Novu.CreateMsTeamsUserEndpointDto),
                TelegramChat,
                typeof(global::Novu.CreateTelegramChatEndpointDto),
                WebexRoom,
                typeof(global::Novu.CreateWebexRoomEndpointDto),
                WebexPerson,
                typeof(global::Novu.CreateWebexPersonEndpointDto),
                LineUser,
                typeof(global::Novu.CreateLineUserEndpointDto),
                PagerdutyService,
                typeof(global::Novu.CreatePagerDutyServiceEndpointDto),
                OpsgenieIntegration,
                typeof(global::Novu.CreateOpsgenieIntegrationEndpointDto),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ChannelEndpointsControllerCreateChannelEndpointRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateSlackChannelEndpointDto?>.Default.Equals(SlackChannel, other.SlackChannel) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateSlackUserEndpointDto?>.Default.Equals(SlackUser, other.SlackUser) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateWebhookEndpointDto?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreatePhoneEndpointDto?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateMsTeamsChannelEndpointDto?>.Default.Equals(MsTeamsChannel, other.MsTeamsChannel) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateMsTeamsUserEndpointDto?>.Default.Equals(MsTeamsUser, other.MsTeamsUser) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateTelegramChatEndpointDto?>.Default.Equals(TelegramChat, other.TelegramChat) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateWebexRoomEndpointDto?>.Default.Equals(WebexRoom, other.WebexRoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateWebexPersonEndpointDto?>.Default.Equals(WebexPerson, other.WebexPerson) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateLineUserEndpointDto?>.Default.Equals(LineUser, other.LineUser) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreatePagerDutyServiceEndpointDto?>.Default.Equals(PagerdutyService, other.PagerdutyService) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateOpsgenieIntegrationEndpointDto?>.Default.Equals(OpsgenieIntegration, other.OpsgenieIntegration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChannelEndpointsControllerCreateChannelEndpointRequest obj1, ChannelEndpointsControllerCreateChannelEndpointRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelEndpointsControllerCreateChannelEndpointRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChannelEndpointsControllerCreateChannelEndpointRequest obj1, ChannelEndpointsControllerCreateChannelEndpointRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelEndpointsControllerCreateChannelEndpointRequest o && Equals(o);
        }
    }
}
