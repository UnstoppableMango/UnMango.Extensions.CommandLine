using System.CommandLine;

namespace UnMango.Extensions.CommandLine;

public sealed class CliApplication(
	RootCommand command,
	InvocationConfiguration configuration,
	IServiceProvider services)
{
	private static readonly RootCommand DefaultRoot = new();

	public static CliApplicationBuilder CreateBuilder() => new(DefaultRoot);

	public Task<int> RunAsync(IReadOnlyList<string> args, CancellationToken cancellationToken = default) {
		var parseResult = command.Parse(args);

		return parseResult.InvokeAsync(configuration, cancellationToken);
	}
}
