namespace GitPath.Lib;

public class DriveConverter
    : IConvert<string>
{
    public string Convert(string input)
    {
        var driveChar = input[0];
        var colonChar = input[1];

        if (char.IsLetter(driveChar) && 
            colonChar == ':')
        {
            var removedColon = input.Remove(1,1);
            return $"/{removedColon}";
        }

        throw new ArgumentException(
            "Bad input. It dosent have drive in it.");
    }
}