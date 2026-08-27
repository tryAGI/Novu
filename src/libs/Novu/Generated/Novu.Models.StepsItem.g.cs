#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct StepsItem : global::System.IEquatable<StepsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Novu.WorkflowResponseDtoStepDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.InAppStepResponseDto? InApp { get; init; }
#else
        public global::Novu.InAppStepResponseDto? InApp { get; }
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
            out global::Novu.InAppStepResponseDto? value)
        {
            value = InApp;
            return IsInApp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.InAppStepResponseDto PickInApp() => IsInApp
            ? InApp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InApp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.EmailStepResponseDto? Email { get; init; }
#else
        public global::Novu.EmailStepResponseDto? Email { get; }
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
            out global::Novu.EmailStepResponseDto? value)
        {
            value = Email;
            return IsEmail;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.EmailStepResponseDto PickEmail() => IsEmail
            ? Email!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Email' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.SmsStepResponseDto? Sms { get; init; }
#else
        public global::Novu.SmsStepResponseDto? Sms { get; }
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
            out global::Novu.SmsStepResponseDto? value)
        {
            value = Sms;
            return IsSms;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.SmsStepResponseDto PickSms() => IsSms
            ? Sms!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sms' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.PushStepResponseDto? Push { get; init; }
#else
        public global::Novu.PushStepResponseDto? Push { get; }
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
            out global::Novu.PushStepResponseDto? value)
        {
            value = Push;
            return IsPush;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.PushStepResponseDto PickPush() => IsPush
            ? Push!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Push' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.ChatStepResponseDto? Chat { get; init; }
#else
        public global::Novu.ChatStepResponseDto? Chat { get; }
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
            out global::Novu.ChatStepResponseDto? value)
        {
            value = Chat;
            return IsChat;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.ChatStepResponseDto PickChat() => IsChat
            ? Chat!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Chat' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.DelayStepResponseDto? Delay { get; init; }
#else
        public global::Novu.DelayStepResponseDto? Delay { get; }
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
            out global::Novu.DelayStepResponseDto? value)
        {
            value = Delay;
            return IsDelay;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.DelayStepResponseDto PickDelay() => IsDelay
            ? Delay!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Delay' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.DigestStepResponseDto? Digest { get; init; }
#else
        public global::Novu.DigestStepResponseDto? Digest { get; }
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
            out global::Novu.DigestStepResponseDto? value)
        {
            value = Digest;
            return IsDigest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.DigestStepResponseDto PickDigest() => IsDigest
            ? Digest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Digest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.CustomStepResponseDto? Custom { get; init; }
#else
        public global::Novu.CustomStepResponseDto? Custom { get; }
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
            out global::Novu.CustomStepResponseDto? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.CustomStepResponseDto PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.ThrottleStepResponseDto? Throttle { get; init; }
#else
        public global::Novu.ThrottleStepResponseDto? Throttle { get; }
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
            out global::Novu.ThrottleStepResponseDto? value)
        {
            value = Throttle;
            return IsThrottle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.ThrottleStepResponseDto PickThrottle() => IsThrottle
            ? Throttle!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Throttle' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.HttpRequestStepResponseDto? HttpRequest { get; init; }
#else
        public global::Novu.HttpRequestStepResponseDto? HttpRequest { get; }
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
            out global::Novu.HttpRequestStepResponseDto? value)
        {
            value = HttpRequest;
            return IsHttpRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.HttpRequestStepResponseDto PickHttpRequest() => IsHttpRequest
            ? HttpRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HttpRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Novu.ToolStepResponseDto? Tool { get; init; }
#else
        public global::Novu.ToolStepResponseDto? Tool { get; }
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
            out global::Novu.ToolStepResponseDto? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Novu.ToolStepResponseDto PickTool() => IsTool
            ? Tool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.InAppStepResponseDto value) => new StepsItem((global::Novu.InAppStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.InAppStepResponseDto?(StepsItem @this) => @this.InApp;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.InAppStepResponseDto? value)
        {
            InApp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromInApp(global::Novu.InAppStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.EmailStepResponseDto value) => new StepsItem((global::Novu.EmailStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.EmailStepResponseDto?(StepsItem @this) => @this.Email;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.EmailStepResponseDto? value)
        {
            Email = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromEmail(global::Novu.EmailStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.SmsStepResponseDto value) => new StepsItem((global::Novu.SmsStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.SmsStepResponseDto?(StepsItem @this) => @this.Sms;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.SmsStepResponseDto? value)
        {
            Sms = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromSms(global::Novu.SmsStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.PushStepResponseDto value) => new StepsItem((global::Novu.PushStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.PushStepResponseDto?(StepsItem @this) => @this.Push;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.PushStepResponseDto? value)
        {
            Push = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromPush(global::Novu.PushStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.ChatStepResponseDto value) => new StepsItem((global::Novu.ChatStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.ChatStepResponseDto?(StepsItem @this) => @this.Chat;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.ChatStepResponseDto? value)
        {
            Chat = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromChat(global::Novu.ChatStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.DelayStepResponseDto value) => new StepsItem((global::Novu.DelayStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.DelayStepResponseDto?(StepsItem @this) => @this.Delay;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.DelayStepResponseDto? value)
        {
            Delay = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromDelay(global::Novu.DelayStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.DigestStepResponseDto value) => new StepsItem((global::Novu.DigestStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.DigestStepResponseDto?(StepsItem @this) => @this.Digest;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.DigestStepResponseDto? value)
        {
            Digest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromDigest(global::Novu.DigestStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.CustomStepResponseDto value) => new StepsItem((global::Novu.CustomStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.CustomStepResponseDto?(StepsItem @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.CustomStepResponseDto? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromCustom(global::Novu.CustomStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.ThrottleStepResponseDto value) => new StepsItem((global::Novu.ThrottleStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.ThrottleStepResponseDto?(StepsItem @this) => @this.Throttle;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.ThrottleStepResponseDto? value)
        {
            Throttle = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromThrottle(global::Novu.ThrottleStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.HttpRequestStepResponseDto value) => new StepsItem((global::Novu.HttpRequestStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.HttpRequestStepResponseDto?(StepsItem @this) => @this.HttpRequest;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.HttpRequestStepResponseDto? value)
        {
            HttpRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromHttpRequest(global::Novu.HttpRequestStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepsItem(global::Novu.ToolStepResponseDto value) => new StepsItem((global::Novu.ToolStepResponseDto?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Novu.ToolStepResponseDto?(StepsItem @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public StepsItem(global::Novu.ToolStepResponseDto? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepsItem FromTool(global::Novu.ToolStepResponseDto? value) => new StepsItem(value);

        /// <summary>
        ///
        /// </summary>
        public StepsItem(
            global::Novu.WorkflowResponseDtoStepDiscriminatorType? type,
            global::Novu.InAppStepResponseDto? inApp,
            global::Novu.EmailStepResponseDto? email,
            global::Novu.SmsStepResponseDto? sms,
            global::Novu.PushStepResponseDto? push,
            global::Novu.ChatStepResponseDto? chat,
            global::Novu.DelayStepResponseDto? delay,
            global::Novu.DigestStepResponseDto? digest,
            global::Novu.CustomStepResponseDto? custom,
            global::Novu.ThrottleStepResponseDto? throttle,
            global::Novu.HttpRequestStepResponseDto? httpRequest,
            global::Novu.ToolStepResponseDto? tool
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
            Custom = custom;
            Throttle = throttle;
            HttpRequest = httpRequest;
            Tool = tool;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Tool as object ??
            HttpRequest as object ??
            Throttle as object ??
            Custom as object ??
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
            Custom?.ToString() ??
            Throttle?.ToString() ??
            HttpRequest?.ToString() ??
            Tool?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && IsCustom && !IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && IsThrottle && !IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && IsHttpRequest && !IsTool || !IsInApp && !IsEmail && !IsSms && !IsPush && !IsChat && !IsDelay && !IsDigest && !IsCustom && !IsThrottle && !IsHttpRequest && IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Novu.InAppStepResponseDto, TResult>? inApp = null,
            global::System.Func<global::Novu.EmailStepResponseDto, TResult>? email = null,
            global::System.Func<global::Novu.SmsStepResponseDto, TResult>? sms = null,
            global::System.Func<global::Novu.PushStepResponseDto, TResult>? push = null,
            global::System.Func<global::Novu.ChatStepResponseDto, TResult>? chat = null,
            global::System.Func<global::Novu.DelayStepResponseDto, TResult>? delay = null,
            global::System.Func<global::Novu.DigestStepResponseDto, TResult>? digest = null,
            global::System.Func<global::Novu.CustomStepResponseDto, TResult>? custom = null,
            global::System.Func<global::Novu.ThrottleStepResponseDto, TResult>? throttle = null,
            global::System.Func<global::Novu.HttpRequestStepResponseDto, TResult>? httpRequest = null,
            global::System.Func<global::Novu.ToolStepResponseDto, TResult>? tool = null,
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
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsThrottle && throttle != null)
            {
                return throttle(Throttle!);
            }
            else if (IsHttpRequest && httpRequest != null)
            {
                return httpRequest(HttpRequest!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Novu.InAppStepResponseDto>? inApp = null,

            global::System.Action<global::Novu.EmailStepResponseDto>? email = null,

            global::System.Action<global::Novu.SmsStepResponseDto>? sms = null,

            global::System.Action<global::Novu.PushStepResponseDto>? push = null,

            global::System.Action<global::Novu.ChatStepResponseDto>? chat = null,

            global::System.Action<global::Novu.DelayStepResponseDto>? delay = null,

            global::System.Action<global::Novu.DigestStepResponseDto>? digest = null,

            global::System.Action<global::Novu.CustomStepResponseDto>? custom = null,

            global::System.Action<global::Novu.ThrottleStepResponseDto>? throttle = null,

            global::System.Action<global::Novu.HttpRequestStepResponseDto>? httpRequest = null,

            global::System.Action<global::Novu.ToolStepResponseDto>? tool = null,
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
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsThrottle)
            {
                throttle?.Invoke(Throttle!);
            }
            else if (IsHttpRequest)
            {
                httpRequest?.Invoke(HttpRequest!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Novu.InAppStepResponseDto>? inApp = null,
            global::System.Action<global::Novu.EmailStepResponseDto>? email = null,
            global::System.Action<global::Novu.SmsStepResponseDto>? sms = null,
            global::System.Action<global::Novu.PushStepResponseDto>? push = null,
            global::System.Action<global::Novu.ChatStepResponseDto>? chat = null,
            global::System.Action<global::Novu.DelayStepResponseDto>? delay = null,
            global::System.Action<global::Novu.DigestStepResponseDto>? digest = null,
            global::System.Action<global::Novu.CustomStepResponseDto>? custom = null,
            global::System.Action<global::Novu.ThrottleStepResponseDto>? throttle = null,
            global::System.Action<global::Novu.HttpRequestStepResponseDto>? httpRequest = null,
            global::System.Action<global::Novu.ToolStepResponseDto>? tool = null,
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
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsThrottle)
            {
                throttle?.Invoke(Throttle!);
            }
            else if (IsHttpRequest)
            {
                httpRequest?.Invoke(HttpRequest!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
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
                typeof(global::Novu.InAppStepResponseDto),
                Email,
                typeof(global::Novu.EmailStepResponseDto),
                Sms,
                typeof(global::Novu.SmsStepResponseDto),
                Push,
                typeof(global::Novu.PushStepResponseDto),
                Chat,
                typeof(global::Novu.ChatStepResponseDto),
                Delay,
                typeof(global::Novu.DelayStepResponseDto),
                Digest,
                typeof(global::Novu.DigestStepResponseDto),
                Custom,
                typeof(global::Novu.CustomStepResponseDto),
                Throttle,
                typeof(global::Novu.ThrottleStepResponseDto),
                HttpRequest,
                typeof(global::Novu.HttpRequestStepResponseDto),
                Tool,
                typeof(global::Novu.ToolStepResponseDto),
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
        public bool Equals(StepsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Novu.InAppStepResponseDto?>.Default.Equals(InApp, other.InApp) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.EmailStepResponseDto?>.Default.Equals(Email, other.Email) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.SmsStepResponseDto?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.PushStepResponseDto?>.Default.Equals(Push, other.Push) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.ChatStepResponseDto?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.DelayStepResponseDto?>.Default.Equals(Delay, other.Delay) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.DigestStepResponseDto?>.Default.Equals(Digest, other.Digest) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.CustomStepResponseDto?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.ThrottleStepResponseDto?>.Default.Equals(Throttle, other.Throttle) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.HttpRequestStepResponseDto?>.Default.Equals(HttpRequest, other.HttpRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Novu.ToolStepResponseDto?>.Default.Equals(Tool, other.Tool)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepsItem obj1, StepsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepsItem obj1, StepsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepsItem o && Equals(o);
        }
    }
}
