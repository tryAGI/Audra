# Usage

Basic example showing how to inspect account usage and credit balance.

This example assumes `using Audra;` is in scope and `apiKey` contains your Audra API key.

```csharp
using var client = new AudraClient(apiKey);

var usage = await client.Billing.GetUsageAsync();
```