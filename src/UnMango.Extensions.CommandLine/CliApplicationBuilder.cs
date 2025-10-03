using System.CommandLine;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;

namespace UnMango.Extensions.CommandLine;

[PublicAPI]
public sealed class CliApplicationBuilder(RootCommand? root = null)
{
	private readonly RootCommand _root = root ?? new();

	public IServiceCollection Services { get; } = new ServiceCollection();

	public CliApplication Build() {
		var configuration = new InvocationConfiguration();

		return new(_root, configuration, Services.BuildServiceProvider());
	}

	public CliApplicationBuilder With(Command command) {
		_root.Add(command);
		return new(_root);
	}
}
