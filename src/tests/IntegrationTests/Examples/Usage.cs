/*
order: 20
title: Usage
slug: usage

Basic example showing how to inspect account usage and credit balance.
Commercial or unlimited accounts can return `null` for `CreditsChars`; check
`Unlimited` before treating credits as a finite balance.
*/

namespace Audra.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Usage()
    {
        using var client = GetAuthenticatedClient();

        var usage = await client.Billing.GetUsageAsync();

        var finiteCredits = usage.Unlimited is true ? null : usage.CreditsChars;

        finiteCredits.Should().Be(usage.CreditsChars);
        (usage.Unlimited is true || finiteCredits is not null).Should().BeTrue();
        (finiteCredits is null || finiteCredits >= 0).Should().BeTrue();
        usage.MonthlyChars.Should().BeGreaterThanOrEqualTo(0);
    }
}
