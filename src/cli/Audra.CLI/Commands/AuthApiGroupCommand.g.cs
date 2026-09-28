#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class AuthApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"auth", @"Auth endpoint commands.");
                         command.Subcommands.Add(AuthCreateAccountsCommandApiCommand.Create());
                         command.Subcommands.Add(AuthCreateAccountsVerifyResendCommandApiCommand.Create());
                         command.Subcommands.Add(AuthGetAccountsVerifyCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}