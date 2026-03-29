/*
order: 10
title: Notifications
slug: notifications

Basic example showing how to create a Novu client and list notification events.
*/

namespace Novu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListNotifications()
    {
        //// Create a Novu client with your API key.
        using var client = GetAuthenticatedClient();

        //// List recent notification events.
        var response = await client.Notifications.NotificationsControllerListNotificationsAsync(
            limit: 5);

        response.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_ListWorkflows()
    {
        //// List all workflows (notification templates).
        using var client = GetAuthenticatedClient();

        var response = await client.Workflows.WorkflowControllerSearchWorkflowsAsync(
            limit: 10);

        response.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_SearchSubscribers()
    {
        //// Search for subscribers by name or email.
        using var client = GetAuthenticatedClient();

        var response = await client.Subscribers.SubscribersControllerSearchSubscribersAsync(
            limit: 10);

        response.Should().NotBeNull();
    }
}
