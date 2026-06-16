#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AuthApiGroupCommand.Create());
                         command.Subcommands.Add(BillingApiGroupCommand.Create());
                         command.Subcommands.Add(LexiconApiGroupCommand.Create());
                         command.Subcommands.Add(MetaApiGroupCommand.Create());
                         command.Subcommands.Add(SpeechApiGroupCommand.Create());
                         command.Subcommands.Add(VoicesApiGroupCommand.Create());
        return command;
    }
}