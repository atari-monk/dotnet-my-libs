using Net.Examples;

namespace Net.Tests;

public class RecordExampleTests
{
	public void Test_RecordEquivalent_Immutablility()
	{
		var record = new RecordEquivalent("name", "lastName", "email", "test");

		//compile time error so yes immutable
		//record.FirstName = "changed name";
	}

	public void Test_Record_Immutablility()
	{
		var record = new RecordExample("name", "lastName", "email", "test");

		//compile time error so yes immutable
		//record.FirstName = "changed name";
	}
}