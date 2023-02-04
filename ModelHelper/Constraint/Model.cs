namespace ModelHelper;

public abstract class Model
{
    public const int NameMax = 70;
    public const int DescriptionMax = 280;
    public const int PathMax = 260;

    public const int IdMin = 1;
    public const int IdMax = int.MaxValue;
    public const int CountMin = 0;
    public const int CountMax = int.MaxValue;
	public const double LengthMin = 0;
    public const double LengthMax = double.MaxValue;
	
    public const string Datetime2Name = "datetime2";
    public const string DateTimeFormat = "dd.MM.yyyy HH:mm";
    public const string DateOnlyFormat = "dd.MM.yyyy";
    public const string MoneyFormat = "C";
    public const string DecimalFormat = "D";
    public const string PolishCulture = "pl-PL";

    public const string IdError = "Id must be greater than zero";
    public const string CountError = "Count is positive or zero";
	public const string LengthError = "Length must be equal or greater than zero";

    public static readonly IDictionary<Field, MaxLength> MaxLength;

    static Model()
    {
        MaxLength = new Dictionary<Field, MaxLength>();
        SetMaxLengthData();
    }

    private static void SetMaxLengthData()
    {
        MaxLength.Add(
            Field.Name
            , new MaxLength(
                Field.Name.ToString()
                , "UK Government Data Standards Catalogue suggests 70 characters for a single field to hold the Full Name"
                , NameMax));
        MaxLength.Add(
            Field.Description
            , new MaxLength(
                Field.Description.ToString()
                , "2017 Twitter character limit of 280 characters"
                , DescriptionMax));
        MaxLength.Add(
            Field.Path
            , new MaxLength(
                Field.Path.ToString()
                , "Windows file system imposes a default restriction on the maximum path length of 260 characters for folder/filename"
                , PathMax));
    }
}