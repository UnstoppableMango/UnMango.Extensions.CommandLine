using System.CommandLine;
using System.CommandLine.Invocation;

namespace UnMango.Extensions.CommandLine;

internal sealed class AsynchronousCliAction(
	IServiceProvider services,
	Func<IServiceProvider, ParseResult, CancellationToken, Task<int>> action
) : AsynchronousCommandLineAction
{
	public override Task<int> InvokeAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
		=> action(services, parseResult, cancellationToken);
}
