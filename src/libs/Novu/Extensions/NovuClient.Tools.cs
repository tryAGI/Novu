#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Novu;

public static class NovuClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that triggers a notification event to subscribers.
    /// </summary>
    public static AIFunction AsTriggerEventTool(this NovuClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The trigger identifier of the workflow to send (found on the workflow page)")] string workflowName,
                   [Description("The subscriber ID to send the notification to")] string subscriberId,
                   [Description("Optional JSON payload with custom data for the notification template (e.g. {\"name\":\"John\",\"message\":\"Hello\"})")] string? payloadJson = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Events.EventsControllerTriggerAsync(
                    name: workflowName,
                    to: subscriberId,
                    payload: payloadJson != null
                        ? System.Text.Json.JsonSerializer.Deserialize<object>(payloadJson)
                        : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Data?.Acknowledged,
                    response.Data?.TransactionId,
                    Status = response.Data?.Status,
                };
            },
            name: "Novu_TriggerEvent",
            description: "Trigger a Novu notification event to send notifications to a subscriber via the specified workflow. The workflow identifier determines which notification template and channels are used.");
    }

    /// <summary>
    /// Creates an AIFunction tool that searches for subscribers.
    /// </summary>
    public static AIFunction AsSearchSubscribersTool(this NovuClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional email to filter subscribers by")] string? email = null,
                   [Description("Optional name to filter subscribers by")] string? name = null,
                   [Description("Optional phone number to filter subscribers by")] string? phone = null,
                   [Description("Optional subscriber ID to search for")] string? subscriberId = null,
                   [Description("Maximum number of results to return")] double? limit = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Subscribers.SubscribersControllerSearchSubscribersAsync(
                    email: email,
                    name: name,
                    phone: phone,
                    subscriberId: subscriberId,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Novu_SearchSubscribers",
            description: "Search Novu subscribers by email, name, phone, or subscriber ID. Returns a paginated list of matching subscribers with their profile information.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists all workflows.
    /// </summary>
    public static AIFunction AsListWorkflowsTool(this NovuClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional search query to filter workflows by name")] string? query = null,
                   [Description("Maximum number of results to return")] double? limit = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Workflows.WorkflowControllerSearchWorkflowsAsync(
                    query: query,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Novu_ListWorkflows",
            description: "List all Novu notification workflows (templates) with optional filtering by name. Workflows define the notification channels and content for different event types.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists notification events.
    /// </summary>
    public static AIFunction AsListNotificationsTool(this NovuClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional transaction ID to filter notifications")] string? transactionId = null,
                   [Description("Optional page number (0-based)")] double? page = null,
                   [Description("Optional limit for results per page (default 10)")] double? limit = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Notifications.NotificationsControllerListNotificationsAsync(
                    transactionId: transactionId,
                    page: page,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Novu_ListNotifications",
            description: "List Novu notification events (triggered events) with optional filtering by transaction ID. Returns event details, status, and delivery information.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets a specific notification event by ID.
    /// </summary>
    public static AIFunction AsGetNotificationTool(this NovuClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The notification ID (MongoDB ObjectId) to retrieve")] string notificationId,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Notifications.NotificationsControllerGetNotificationAsync(
                    notificationId: notificationId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Novu_GetNotification",
            description: "Get detailed information about a specific Novu notification event including execution logs, status, and the actual notification content delivered to each channel.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists all topics.
    /// </summary>
    public static AIFunction AsListTopicsTool(this NovuClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional key to filter topics by")] string? key = null,
                   [Description("Optional name to filter topics by")] string? name = null,
                   [Description("Maximum number of results to return")] double? limit = null,
                   CancellationToken cancellationToken = default) =>
            {
                var response = await client.Topics.TopicsControllerListTopicsAsync(
                    key: key,
                    name: name,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Novu_ListTopics",
            description: "List all Novu topics with optional filtering by key or name. Topics group subscribers together for bulk notification delivery.");
    }
}
