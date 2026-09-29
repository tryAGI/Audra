#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Audra.CLI.Commands;

internal static partial class AuthGetAccountsVerifyCommandApiCommand
{
    private static Option<string> Token { get; } = new(
        name: @"--token")
    {
        Description = @"",
        Required = true,
    };

    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-accounts-verify", @"Verify email from signup link");
                        command.Options.Add(Token);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var token = parseResult.GetRequiredValue(Token);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                await client.Auth.GetAccountsVerifyAsync(
                                    token: token,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}