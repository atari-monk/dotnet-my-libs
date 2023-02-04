namespace ModelHelper;

public interface IUpdatable<TModel>
{
    void Update(TModel model);
}