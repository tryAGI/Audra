#nullable enable

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static class AuthApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"auth", @"Auth endpoint commands.");
                         command.Subcommands.Add(AuthCreateAccountsCommandApiCommand.Create());
                         command.Subcommands.Add(AuthCreateAccountsVerifyResendCommandApiCommand.Create());
                         command.Subcommands.Add(AuthGetAccountsVerifyCommandApiCommand.Create());
        return command;
    }
}