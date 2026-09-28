#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class BillingApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"billing", @"Billing endpoint commands.");
                         command.Subcommands.Add(BillingCreateBillingCheckoutCommandApiCommand.Create());
                         command.Subcommands.Add(BillingGetUsageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}