/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to create MEAI AIFunction tools from the Novu client for use with any IChatClient.
*/

namespace Novu.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        //// Create a Novu client and convert to AIFunction tools.
        using var client = new NovuClient(apiKey: "test-key");

        //// Create tools for use with any IChatClient.
        var triggerTool = client.AsTriggerEventTool();
        var subscribersTool = client.AsSearchSubscribersTool();
        var workflowsTool = client.AsListWorkflowsTool();
        var notificationsTool = client.AsListNotificationsTool();
        var getNotificationTool = client.AsGetNotificationTool();
        var topicsTool = client.AsListTopicsTool();

        //// Verify tool names and descriptions are set.
        triggerTool.Should().NotBeNull();
        triggerTool.Name.Should().Be("Novu_TriggerEvent");

        subscribersTool.Should().NotBeNull();
        subscribersTool.Name.Should().Be("Novu_SearchSubscribers");

        workflowsTool.Should().NotBeNull();
        workflowsTool.Name.Should().Be("Novu_ListWorkflows");

        notificationsTool.Should().NotBeNull();
        notificationsTool.Name.Should().Be("Novu_ListNotifications");

        getNotificationTool.Should().NotBeNull();
        getNotificationTool.Name.Should().Be("Novu_GetNotification");

        topicsTool.Should().NotBeNull();
        topicsTool.Name.Should().Be("Novu_ListTopics");
    }
}
