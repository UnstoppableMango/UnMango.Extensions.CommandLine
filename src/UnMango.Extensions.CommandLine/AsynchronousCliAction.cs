using System.CommandLine;
using System.CommandLine.Invocation;

namespace UnMango.Extensions.CommandLine;

internal sealed class AsynchronousCliAction(IServiceProvider services) : AsynchronousCommandLineAction
{
	public override Task<int> InvokeAsync(ParseResult parseResult, CancellationToken cancellationToken = default) {
		throw new NotImplementedException();
	}
}
