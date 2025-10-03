using System.CommandLine;

namespace UnMango.Extensions.CommandLine;

public sealed class CliApplicationBuilder(RootCommand? root = null)
{
	private readonly RootCommand _root = root ?? new();

    public CliApplication Build() {
	    var configuration = new InvocationConfiguration();

        return new(_root, configuration);
    }

    public CliApplicationBuilder With(Command command) {
		_root.Add(command);
		return new(_root);
    }
}
