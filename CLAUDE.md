# CLAUDE.md -- Novu SDK

## Overview

Auto-generated C# SDK for [Novu](https://novu.co/) -- notification infrastructure platform for email, SMS, push, in-app, and chat notifications.
OpenAPI spec from `https://api.novu.co/openapi.json` (3.0.0).

## Build & Test

```bash
dotnet build Novu.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key via `Authorization: ApiKey <key>` header. Constructor uses Bearer internally, converted via `Authorized` hook:

```csharp
var client = new NovuClient(apiKey); // NOVU_API_KEY env var
```

**Important:** Novu uses `Authorization: ApiKey <key>`, not `Authorization: Bearer <key>`. The `Authorized` partial hook in `NovuClient.Auth.cs` rewrites the scheme from `Bearer` to `ApiKey`.

## Key Files

- `src/libs/Novu/openapi.yaml` -- Source OpenAPI spec
- `src/libs/Novu/generate.sh` -- Regeneration script (jq fix for auth + autosdk)
- `src/libs/Novu/Generated/` -- **Never edit** -- auto-generated code (1931 files)
- `src/libs/Novu/Extensions/NovuClient.Auth.cs` -- Auth hook (Bearer -> ApiKey)
- `src/libs/Novu/Extensions/NovuClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new NovuClient(apiKey);

// Events -- trigger notifications
client.Events.EventsControllerTriggerAsync(request)           // Trigger notification
client.Events.EventsControllerTriggerBulkAsync(request)       // Bulk trigger
client.Events.EventsControllerBroadcastEventToAllAsync(...)   // Broadcast to all
client.Events.EventsControllerCancelAsync(transactionId)      // Cancel triggered event

// Subscribers -- manage notification recipients
client.Subscribers.SubscribersControllerSearchSubscribersAsync(...)  // Search subscribers
client.Subscribers.SubscribersControllerCreateSubscriberAsync(...)   // Create subscriber
client.Subscribers.SubscribersControllerGetSubscriberAsync(id)       // Get subscriber
client.Subscribers.SubscribersControllerPatchSubscriberAsync(...)    // Update subscriber

// Workflows -- notification templates
client.Workflows.WorkflowControllerSearchWorkflowsAsync(...)  // List workflows
client.Workflows.WorkflowControllerGetWorkflowAsync(id)        // Get workflow
client.Workflows.WorkflowControllerCreate(...)                 // Create workflow

// Notifications -- event logs
client.Notifications.NotificationsControllerListNotificationsAsync(...)  // List events
client.Notifications.NotificationsControllerGetNotificationAsync(id)     // Get event details

// Topics -- subscriber groups
client.Topics.TopicsControllerListTopicsAsync(...)             // List topics
client.Topics.TopicsControllerUpsertTopicAsync(...)            // Create/update topic

// Integrations -- channel providers
client.Integrations.IntegrationsControllerListIntegrationsAsync()  // List integrations

// Environments -- dev/staging/prod
client.Environments.EnvironmentsControllerV1ListMyEnvironmentsAsync()  // List environments

// Layouts -- email wrappers
client.Layouts.LayoutsControllerListAsync(...)  // List layouts

// Messages -- delivered notifications
client.Messages.MessagesControllerGetMessagesAsync(...)  // List messages

// Translations -- localization
client.Translations.TranslationControllerGetTranslationGroupEndpointAsync(...)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsTriggerEventTool()` -- Trigger a notification event to a subscriber via a workflow
- `AsSearchSubscribersTool()` -- Search subscribers by email, name, phone, or ID
- `AsListWorkflowsTool()` -- List notification workflows/templates
- `AsListNotificationsTool()` -- List notification events with optional filtering
- `AsGetNotificationTool()` -- Get detailed notification event by ID
- `AsListTopicsTool()` -- List topics (subscriber groups)

## Spec Notes

- Base URL: `https://api.novu.co`
- Auth: `ApiKey` scheme (not Bearer) -- `generate.sh` converts apiKey to http/bearer for code generation; `Authorized` hook rewrites Bearer -> ApiKey at runtime
- 110 operations across 15 sub-clients: Activity, ChannelConnections, ChannelEndpoints, Contexts, EnvironmentVariables, Environments, Events, Integrations, Layouts, Messages, Notifications, Subscribers, Topics, Translations, Workflows
