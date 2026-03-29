# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Novu SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Novu's notification triggering, subscriber management, workflow listing, and topic management.

## Installation

```bash
dotnet add package tryAGI.Novu
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTriggerEventTool()` | `Novu_TriggerEvent` | Trigger a notification event |
| `AsSearchSubscribersTool()` | `Novu_SearchSubscribers` | Search subscribers by email/name/phone |
| `AsListWorkflowsTool()` | `Novu_ListWorkflows` | List notification workflows |
| `AsListNotificationsTool()` | `Novu_ListNotifications` | List notification events |
| `AsGetNotificationTool()` | `Novu_GetNotification` | Get notification details and logs |
| `AsListTopicsTool()` | `Novu_ListTopics` | List notification topics |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Novu;

var client = new NovuClient(
    apiKey: Environment.GetEnvironmentVariable("NOVU_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsTriggerEventTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Send a welcome notification to subscriber user-123"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
