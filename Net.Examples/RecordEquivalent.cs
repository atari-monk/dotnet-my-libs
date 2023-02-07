namespace Net.Examples;

public class RecordEquivalent
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
	public string EmailAddress { get; init; }
	public string Password { get; init; }

	public RecordEquivalent(
		string firstName
		, string lastName
		, string emailAddress
		, string password)
	{
		FirstName = firstName;
		LastName = lastName;
		EmailAddress = emailAddress;
		Password = password;
	}
}