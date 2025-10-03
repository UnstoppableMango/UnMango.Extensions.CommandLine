using System.CommandLine;

namespace UnMango.Extensions.CommandLine.Tests;

public sealed class AcceptanceTests
{
	[Fact]
	public async Task HappyPath() {
		var cancellationToken = TestContext.Current.CancellationToken;
		var root = new RootCommand {
			new Command("testA"),
			new Command("testB"),
		};

		var builder = CliApplication.CreateBuilder();

		var app = builder.Build();

		var result = await app.RunAsync([], cancellationToken);

		Assert.Equal(0, result);
	}
}
