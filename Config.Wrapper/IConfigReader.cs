namespace Config.Wrapper;

public interface IConfigReader
{
  TData? GetConfigSection<TData>(string sectionName);

  TData GetConfigSection<TData>(string sectionName, TData defaultConfig);
}