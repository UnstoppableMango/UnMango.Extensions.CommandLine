using System.CommandLine;

namespace UnMango.Extensions.CommandLine;

public sealed class CommandBuilder(Command command)
{
	public Command Build() {
		return command;
	}

	public CommandBuilder With(Action<IServiceProvider, ParseResult> action) {
		return this;
	}

	public CommandBuilder With(Func<IServiceProvider, ParseResult, int> action) {
		return this;
	}

	public CommandBuilder With(Func<IServiceProvider, ParseResult, Task> action) {
		return this;
	}

	public CommandBuilder With(Func<IServiceProvider, ParseResult, Task<int>> action)
		=> With((services, parseResult, _) => action(services, parseResult));

	public CommandBuilder With(Func<IServiceProvider, ParseResult, CancellationToken, Task> action) {
		return this;
	}

	public CommandBuilder With(Func<IServiceProvider, ParseResult, CancellationToken, Task<int>> action) {
		return this;
	}
}
