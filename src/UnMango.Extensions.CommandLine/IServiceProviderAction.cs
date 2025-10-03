namespace UnMango.Extensions.CommandLine;

internal interface IServiceProviderAction
{
	void Receive(IServiceProvider services);
}
