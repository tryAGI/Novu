#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StepsItem3 : global::System.IEquatable<StepsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Novu.UpdateWorkflowDtoStepDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.InAppStepUpsertDto? InApp { get; init; }
#else
        public global::Novu.InAppStepUpsertDto? InApp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InApp))]
#endif
        public bool IsInApp => InApp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInApp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.InAppStepUpsertDto? value)
        {
            value = InApp;
            return IsInApp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.InAppStepUpsertDto PickInApp() => IsInApp
            ? InApp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InApp' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.EmailStepUpsertDto? Email { get; init; }
#else
        public global::Novu.EmailStepUpsertDto? Email { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Email))]
#endif
        public bool IsEmail => Email != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.EmailStepUpsertDto? value)
        {
            value = Email;
            return IsEmail;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.EmailStepUpsertDto PickEmail() => IsEmail
            ? Email!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Email' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.SmsStepUpsertDto? Sms { get; init; }
#else
        public global::Novu.SmsStepUpsertDto? Sms { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sms))]
#endif
        public bool IsSms => Sms != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSms(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.SmsStepUpsertDto? value)
        {
            value = Sms;
            return IsSms;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.SmsStepUpsertDto PickSms() => IsSms
            ? Sms!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sms' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.PushStepUpsertDto? Push { get; init; }
#else
        public global::Novu.PushStepUpsertDto? Push { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Push))]
#endif
        public bool IsPush => Push != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPush(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.PushStepUpsertDto? value)
        {
            value = Push;
            return IsPush;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.PushStepUpsertDto PickPush() => IsPush
            ? Push!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Push' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.ChatStepUpsertDto? Chat { get; init; }
#else
        public global::Novu.ChatStepUpsertDto? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickChat(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.ChatStepUpsertDto? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ChatStepUpsertDto PickChat() => IsChat
            ? Chat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.DelayStepUpsertDto? Delay { get; init; }
#else
        public global::Novu.DelayStepUpsertDto? Delay { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Delay))]
#endif
        public bool IsDelay => Delay != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDelay(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.DelayStepUpsertDto? value)
        {
            value = Delay;
            return IsDelay;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DelayStepUpsertDto PickDelay() => IsDelay
            ? Delay!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Delay' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.DigestStepUpsertDto? Digest { get; init; }
#else
        public global::Novu.DigestStepUpsertDto? Digest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Digest))]
#endif
        public bool IsDigest => Digest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDigest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.DigestStepUpsertDto? value)
        {
            value = Digest;
            return IsDigest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.DigestStepUpsertDto PickDigest() => IsDigest
            ? Digest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Digest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.ThrottleStepUpsertDto? Throttle { get; init; }
#else
        public global::Novu.ThrottleStepUpsertDto? Throttle { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Throttle))]
#endif
        public bool IsThrottle => Throttle != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThrottle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.ThrottleStepUpsertDto? value)
        {
            value = Throttle;
            return IsThrottle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ThrottleStepUpsertDto PickThrottle() => IsThrottle
            ? Throttle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Throttle' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.ToolStepUpsertDto? Tool { get; init; }
#else
        public global::Novu.ToolStepUpsertDto? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.ToolStepUpsertDto? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.ToolStepUpsertDto PickTool() => IsTool
            ? Tool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CustomStepUpsertDto? Custom { get; init; }
#else
        public global::Novu.CustomStepUpsertDto? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.CustomStepUpsertDto? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.CustomStepUpsertDto PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.HttpRequestStepUpsertDto? HttpRequest { get; init; }
#else
        public global::Novu.HttpRequestStepUpsertDto? HttpRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HttpRequest))]
#endif
        public bool IsHttpRequest => HttpRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHttpRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Novu.HttpRequestStepUpsertDto? value)
        {
            value = HttpRequest;
            return IsHttpRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Novu.HttpRequestStepUpsertDto PickHttpRequest() => IsHttpRequest
            ? HttpRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HttpRequest' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.InAppStepUpsertDto value) => new StepsItem3((global::Novu.InAppStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.InAppStepUpsertDto?(StepsItem3 @this) => @this.InApp;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.InAppStepUpsertDto? value)
        {
            InApp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromInApp(global::Novu.InAppStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.EmailStepUpsertDto value) => new StepsItem3((global::Novu.EmailStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.EmailStepUpsertDto?(StepsItem3 @this) => @this.Email;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.EmailStepUpsertDto? value)
        {
            Email = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromEmail(global::Novu.EmailStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.SmsStepUpsertDto value) => new StepsItem3((global::Novu.SmsStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.SmsStepUpsertDto?(StepsItem3 @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.SmsStepUpsertDto? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromSms(global::Novu.SmsStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.PushStepUpsertDto value) => new StepsItem3((global::Novu.PushStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.PushStepUpsertDto?(StepsItem3 @this) => @this.Push;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.PushStepUpsertDto? value)
        {
            Push = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromPush(global::Novu.PushStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.ChatStepUpsertDto value) => new StepsItem3((global::Novu.ChatStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.ChatStepUpsertDto?(StepsItem3 @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.ChatStepUpsertDto? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromChat(global::Novu.ChatStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.DelayStepUpsertDto value) => new StepsItem3((global::Novu.DelayStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.DelayStepUpsertDto?(StepsItem3 @this) => @this.Delay;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.DelayStepUpsertDto? value)
        {
            Delay = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromDelay(global::Novu.DelayStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.DigestStepUpsertDto value) => new StepsItem3((global::Novu.DigestStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.DigestStepUpsertDto?(StepsItem3 @this) => @this.Digest;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.DigestStepUpsertDto? value)
        {
            Digest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromDigest(global::Novu.DigestStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.ThrottleStepUpsertDto value) => new StepsItem3((global::Novu.ThrottleStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.ThrottleStepUpsertDto?(StepsItem3 @this) => @this.Throttle;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.ThrottleStepUpsertDto? value)
        {
            Throttle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromThrottle(global::Novu.ThrottleStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.ToolStepUpsertDto value) => new StepsItem3((global::Novu.ToolStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.ToolStepUpsertDto?(StepsItem3 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.ToolStepUpsertDto? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromTool(global::Novu.ToolStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.CustomStepUpsertDto value) => new StepsItem3((global::Novu.CustomStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.CustomStepUpsertDto?(StepsItem3 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.CustomStepUpsertDto? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromCustom(global::Novu.CustomStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepsItem3(global::Novu.HttpRequestStepUpsertDto value) => new StepsItem3((global::Novu.HttpRequestStepUpsertDto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Novu.HttpRequestStepUpsertDto?(StepsItem3 @this) => @this.HttpRequest;

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(global::Novu.HttpRequestStepUpsertDto? value)
        {
            HttpRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StepsItem3 FromHttpRequest(global::Novu.HttpRequestStepUpsertDto? value) => new StepsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public StepsItem3(
            global::Novu.UpdateWorkflowDtoStepDiscriminatorType? type,
            global::Novu.InAppStepUpsertDto? inApp,
            global::Novu.EmailStepUpsertDto? email,
            global::Novu.SmsStepUpsertDto? sms,
            global::Novu.PushStepUpsertDto? push,
            global::Novu.ChatStepUpsertDto? chat,
            global::Novu.DelayStepUpsertDto? delay,
            global::Novu.DigestStepUpsertDto? digest,
            global::Novu.ThrottleStepUpsertDto? throttle,
            global::Novu.ToolStepUpsertDto? tool,
            global::Novu.CustomStepUpsertDto? custom,
            global::Novu.HttpRequestStepUpsertDto? httpRequest
            )
        {
            Type = type;

            InApp = inApp;
            Email = email;
            Sms = sms;
            Push = push;
            Chat = chat;
            Delay = delay;
            Digest = digest;
            Throttle = throttle;
            Tool = tool;
            Custom = custom;
            HttpRequest = httpRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            HttpRequest as object ??
            Custom as object ??
            Tool as object ??
            Throttle as object ??
            Digest as object ??
            Delay as object ??
            Chat as object ??
            Push as object ??
            Sms as object ??
            Email as object ??
            InApp as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InApp?.ToString() ??
            Email?.ToString() ??
            Sms?.ToString() ??
            Push?.ToString() ??
            Chat?.ToString() ??
            Delay?.ToString() ??
            Digest?.ToString() ??
            Throttle?.ToString() ??
            Tool?.ToString() ??
            Custom?.ToString() ??
            HttpRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && IsDigest && !IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && IsThrottle && !IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && IsTool && !IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && IsCustom && !IsHttpRequest || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsThrottle && !IsTool && !IsCustom && IsHttpRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Novu.InAppStepUpsertDto, TResult>? inApp = null,
            global::System.Func<global::Novu.EmailStepUpsertDto, TResult>? email = null,
            global::System.Func<global::Novu.SmsStepUpsertDto, TResult>? sms = null,
            global::System.Func<global::Novu.PushStepUpsertDto, TResult>? push = null,
            global::System.Func<global::Novu.ChatStepUpsertDto, TResult>? chat = null,
            global::System.Func<global::Novu.DelayStepUpsertDto, TResult>? delay = null,
            global::System.Func<global::Novu.DigestStepUpsertDto, TResult>? digest = null,
            global::System.Func<global::Novu.ThrottleStepUpsertDto, TResult>? throttle = null,
            global::System.Func<global::Novu.ToolStepUpsertDto, TResult>? tool = null,
            global::System.Func<global::Novu.CustomStepUpsertDto, TResult>? custom = null,
            global::System.Func<global::Novu.HttpRequestStepUpsertDto, TResult>? httpRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInApp && inApp != null)
            {
                return inApp(InApp!);
            }
            else if (IsEmail && email != null)
            {
                return email(Email!);
            }
            else if (IsSms && sms != null)
            {
                return sms(Sms!);
            }
            else if (IsPush && push != null)
            {
                return push(Push!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsDelay && delay != null)
            {
                return delay(Delay!);
            }
            else if (IsDigest && digest != null)
            {
                return digest(Digest!);
            }
            else if (IsThrottle && throttle != null)
            {
                return throttle(Throttle!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsHttpRequest && httpRequest != null)
            {
                return httpRequest(HttpRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Novu.InAppStepUpsertDto>? inApp = null,

            global::System.Action<global::Novu.EmailStepUpsertDto>? email = null,

            global::System.Action<global::Novu.SmsStepUpsertDto>? sms = null,

            global::System.Action<global::Novu.PushStepUpsertDto>? push = null,

            global::System.Action<global::Novu.ChatStepUpsertDto>? chat = null,

            global::System.Action<global::Novu.DelayStepUpsertDto>? delay = null,

            global::System.Action<global::Novu.DigestStepUpsertDto>? digest = null,

            global::System.Action<global::Novu.ThrottleStepUpsertDto>? throttle = null,

            global::System.Action<global::Novu.ToolStepUpsertDto>? tool = null,

            global::System.Action<global::Novu.CustomStepUpsertDto>? custom = null,

            global::System.Action<global::Novu.HttpRequestStepUpsertDto>? httpRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInApp)
            {
                inApp?.Invoke(InApp!);
            }
            else if (IsEmail)
            {
                email?.Invoke(Email!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
            else if (IsPush)
            {
                push?.Invoke(Push!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsDelay)
            {
                delay?.Invoke(Delay!);
            }
            else if (IsDigest)
            {
                digest?.Invoke(Digest!);
            }
            else if (IsThrottle)
            {
                throttle?.Invoke(Throttle!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsHttpRequest)
            {
                httpRequest?.Invoke(HttpRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Novu.InAppStepUpsertDto>? inApp = null,
            global::System.Action<global::Novu.EmailStepUpsertDto>? email = null,
            global::System.Action<global::Novu.SmsStepUpsertDto>? sms = null,
            global::System.Action<global::Novu.PushStepUpsertDto>? push = null,
            global::System.Action<global::Novu.ChatStepUpsertDto>? chat = null,
            global::System.Action<global::Novu.DelayStepUpsertDto>? delay = null,
            global::System.Action<global::Novu.DigestStepUpsertDto>? digest = null,
            global::System.Action<global::Novu.ThrottleStepUpsertDto>? throttle = null,
            global::System.Action<global::Novu.ToolStepUpsertDto>? tool = null,
            global::System.Action<global::Novu.CustomStepUpsertDto>? custom = null,
            global::System.Action<global::Novu.HttpRequestStepUpsertDto>? httpRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInApp)
            {
                inApp?.Invoke(InApp!);
            }
            else if (IsEmail)
            {
                email?.Invoke(Email!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
            else if (IsPush)
            {
                push?.Invoke(Push!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsDelay)
            {
                delay?.Invoke(Delay!);
            }
            else if (IsDigest)
            {
                digest?.Invoke(Digest!);
            }
            else if (IsThrottle)
            {
                throttle?.Invoke(Throttle!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsHttpRequest)
            {
                httpRequest?.Invoke(HttpRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InApp,
                typeof(global::Novu.InAppStepUpsertDto),
                Email,
                typeof(global::Novu.EmailStepUpsertDto),
                Sms,
                typeof(global::Novu.SmsStepUpsertDto),
                Push,
                typeof(global::Novu.PushStepUpsertDto),
                Chat,
                typeof(global::Novu.ChatStepUpsertDto),
                Delay,
                typeof(global::Novu.DelayStepUpsertDto),
                Digest,
                typeof(global::Novu.DigestStepUpsertDto),
                Throttle,
                typeof(global::Novu.ThrottleStepUpsertDto),
                Tool,
                typeof(global::Novu.ToolStepUpsertDto),
                Custom,
                typeof(global::Novu.CustomStepUpsertDto),
                HttpRequest,
                typeof(global::Novu.HttpRequestStepUpsertDto),
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
        public bool Equals(StepsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Novu.InAppStepUpsertDto?>.Default.Equals(InApp, other.InApp) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.EmailStepUpsertDto?>.Default.Equals(Email, other.Email) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.SmsStepUpsertDto?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.PushStepUpsertDto?>.Default.Equals(Push, other.Push) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.ChatStepUpsertDto?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.DelayStepUpsertDto?>.Default.Equals(Delay, other.Delay) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.DigestStepUpsertDto?>.Default.Equals(Digest, other.Digest) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.ThrottleStepUpsertDto?>.Default.Equals(Throttle, other.Throttle) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.ToolStepUpsertDto?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CustomStepUpsertDto?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.HttpRequestStepUpsertDto?>.Default.Equals(HttpRequest, other.HttpRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepsItem3 obj1, StepsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepsItem3 obj1, StepsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepsItem3 o && Equals(o);
        }
    }
}
