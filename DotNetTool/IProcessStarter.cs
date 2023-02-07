namespace DotNetTool;

public interface IProcessStarter
{
	void StartProcess(
		string executeableName
		, params string[] arguments);
}