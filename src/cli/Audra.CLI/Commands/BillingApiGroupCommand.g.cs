#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class BillingApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"billing", @"Billing endpoint commands.");
                         command.Subcommands.Add(BillingCreateBillingCheckoutCommandApiCommand.Create());
                         command.Subcommands.Add(BillingGetUsageCommandApiCommand.Create());
        return command;
    }
}