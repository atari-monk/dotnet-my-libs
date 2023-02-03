using DIHelper.MicrosoftDI;
using Microsoft.Extensions.DependencyInjection;

namespace CLIHelper.MDI;

public class CliIOSet 
	: MDIDependencySet
{
	public CliIOSet(
		IServiceCollection container)
		: base(container)
	{
	}

	public override void Register()
	{
		Container
			.AddSingleton<IInput, Input>()
			.AddSingleton<IOutput, ConsoleOut>();
	}
}