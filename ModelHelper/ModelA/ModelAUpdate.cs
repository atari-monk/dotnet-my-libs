namespace ModelHelper;

public abstract class ModelAUpdate
    : IUpdatable<IModelA>
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public void Update(IModelA model)
    {
        if (string.IsNullOrWhiteSpace(Name) == false
            && Name.Trim() != model.Name?.Trim())
            {
                model.Name = Name;
            }
        if (string.IsNullOrWhiteSpace(Description) == false
            && Description.Trim() != model.Description?.Trim())
            {
                model.Description = Description;
            }
    }
}