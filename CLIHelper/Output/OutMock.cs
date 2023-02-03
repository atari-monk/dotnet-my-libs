using System.Text;

namespace CLIHelper;

public abstract class OutMock
	: IOutMock
{
	protected readonly StringBuilder Buffer;

    public string OutText => Buffer.ToString();

    public string[] Lines => OutText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

    public OutMock() => 
        Buffer = new StringBuilder();
}