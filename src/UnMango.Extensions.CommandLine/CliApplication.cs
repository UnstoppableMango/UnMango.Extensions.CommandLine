using System.CommandLine;

namespace UnMango.Extensions.CommandLine;

public sealed record CliApplication(RootCommand Command, InvocationConfiguration Configuration)
{
	private static readonly RootCommand DefaultRoot = new();

	public static CliApplicationBuilder CreateBuilder() => new(DefaultRoot);

	public Task<int> RunAsync(IReadOnlyList<string> args, CancellationToken cancellationToken = default) {
		var parseResult = Command.Parse(args);

		return parseResult.InvokeAsync(Configuration, cancellationToken);
	}
}
