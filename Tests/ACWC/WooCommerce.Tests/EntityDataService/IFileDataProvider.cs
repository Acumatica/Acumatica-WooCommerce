namespace ACSC.Tests.EntityDataService
{
    public interface IFileDataProvider
    {
        string FilePath { get; set; }

        T Get<T>();
    }
}