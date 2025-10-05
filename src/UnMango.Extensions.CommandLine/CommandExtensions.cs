using System.CommandLine;
using JetBrains.Annotations;

namespace UnMango.Extensions.CommandLine;

[PublicAPI]
public static class CommandExtensions
{
	public static void SetAction(this Command command, Action<IServiceProvider, ParseResult> action) {
	}

	public static void SetAction(this Command command, Func<IServiceProvider, ParseResult, int> action) {
	}

	public static void SetAction(this Command command, Func<IServiceProvider, ParseResult, Task> action) {
	}

	public static void SetAction(
		this Command command,
		Func<IServiceProvider, ParseResult, Task<int>> action
	) => command.SetAction((services, parseResult, _) => action(services, parseResult));

	public static void SetAction(
		this Command command,
		IServiceProvider services,
		Func<IServiceProvider, ParseResult, CancellationToken, Task> action
	) => command.SetAction(services, (s, p, c) => action(s, p, c));

	public static void SetAction(
		this Command command,
		IServiceProvider services,
		Func<IServiceProvider, ParseResult, CancellationToken, Task<int>> action
	) => command.Action = new AsynchronousCliAction(services, action);
}
