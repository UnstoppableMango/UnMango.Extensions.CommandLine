namespace UnMango.Extensions.CommandLine;

public sealed record CliApplication()
{
    public static CliApplicationBuilder CreateBuilder() => new();
}
