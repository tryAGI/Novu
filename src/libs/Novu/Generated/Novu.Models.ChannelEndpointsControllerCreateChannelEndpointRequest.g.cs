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
        public ChannelEndpointsControllerCreateChannelEndpointRequest(
            global::Novu.ChannelEndpointsControllerCreateChannelEndpointRequestDiscriminatorType? type,
            global::Novu.CreateSlackChannelEndpointDto? slackChannel,
            global::Novu.CreateSlackUserEndpointDto? slackUser,
            global::Novu.CreateWebhookEndpointDto? webhook,
            global::Novu.CreatePhoneEndpointDto? phone,
            global::Novu.CreateMsTeamsChannelEndpointDto? msTeamsChannel,
            global::Novu.CreateMsTeamsUserEndpointDto? msTeamsUser
            )
        {
            Type = type;

            SlackChannel = slackChannel;
            SlackUser = slackUser;
            Webhook = webhook;
            Phone = phone;
            MsTeamsChannel = msTeamsChannel;
            MsTeamsUser = msTeamsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            MsTeamsUser?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser || !IsSlackChannel && IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser || !IsSlackChannel && !IsSlackUser && IsWebhook && !IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser || !IsSlackChannel && !IsSlackUser && !IsWebhook && IsPhone && !IsMsTeamsChannel && !IsMsTeamsUser || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && IsMsTeamsChannel && !IsMsTeamsUser || !IsSlackChannel && !IsSlackUser && !IsWebhook && !IsPhone && !IsMsTeamsChannel && IsMsTeamsUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Novu.CreateSlackChannelEndpointDto?, TResult>? slackChannel = null,
            global::System.Func<global::Novu.CreateSlackUserEndpointDto?, TResult>? slackUser = null,
            global::System.Func<global::Novu.CreateWebhookEndpointDto?, TResult>? webhook = null,
            global::System.Func<global::Novu.CreatePhoneEndpointDto?, TResult>? phone = null,
            global::System.Func<global::Novu.CreateMsTeamsChannelEndpointDto?, TResult>? msTeamsChannel = null,
            global::System.Func<global::Novu.CreateMsTeamsUserEndpointDto?, TResult>? msTeamsUser = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Novu.CreateSlackChannelEndpointDto?>? slackChannel = null,
            global::System.Action<global::Novu.CreateSlackUserEndpointDto?>? slackUser = null,
            global::System.Action<global::Novu.CreateWebhookEndpointDto?>? webhook = null,
            global::System.Action<global::Novu.CreatePhoneEndpointDto?>? phone = null,
            global::System.Action<global::Novu.CreateMsTeamsChannelEndpointDto?>? msTeamsChannel = null,
            global::System.Action<global::Novu.CreateMsTeamsUserEndpointDto?>? msTeamsUser = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Novu.CreateMsTeamsUserEndpointDto?>.Default.Equals(MsTeamsUser, other.MsTeamsUser) 
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
