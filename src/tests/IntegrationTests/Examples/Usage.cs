/*
order: 20
title: Usage
slug: usage

Basic example showing how to inspect account usage and credit balance.
*/

namespace Audra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Usage()
    {
        using var client = GetAuthenticatedClient();

        var usage = await client.Billing.GetUsageAsync();

        var isUnlimited =
            usage.AdditionalProperties.TryGetValue("unlimited", out var unlimited) &&
            unlimited is System.Text.Json.JsonElement { ValueKind: System.Text.Json.JsonValueKind.True };

        if (isUnlimited)
        {
            usage.CreditsChars.Should().BeNull();
        }
        else
        {
            usage.CreditsChars.Should().BeGreaterThanOrEqualTo(0);
        }

        usage.MonthlyChars.Should().BeGreaterThanOrEqualTo(0);
    }
}
